using bulkexp.Mappings;
using bulkexp.Models;
using bulkexp.Types;
using CsvHelper;
using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bulkexp
{
    public class App
    {
        private readonly ILogger<App> _logger;
        private readonly IConfiguration _config;
        private readonly IDbContextFactory<CC_Client_UKG_CloneContext> _context;
        private Stopwatch timer;

        public App(ILogger<App> logger, IConfiguration config, IDbContextFactory<CC_Client_UKG_CloneContext> context)
        {
            _logger = logger;
            _config = config;
            _context = context;
            timer = new Stopwatch();
        }

        public void Run()
        {
            //var db = _context.CreateDbContext();
            _logger.LogInformation("App is running");
            GetLocationEntities();
        }

        public IEnumerable<LocationsDTO> GetLocationsDTO()
        {
            using (var reader = new StreamReader(_config.GetSection("ProvisionData:Locations:Small").Value))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    csv.Context.RegisterClassMap<LocationMap>();
                    return csv.GetRecords<LocationsDTO>().ToList();
                };
            }
        }

        public void GetLocationEntities()
        {
            var context = _context.CreateDbContext();

            timer.Start();
            var locationDto = GetLocationsDTO();
            timer.Stop();

            _logger.LogInformation($"CSV Reading time: {timer.ElapsedMilliseconds / 1000.000}");

            timer.Reset();

            var locationEntities = new List<Location>();

            timer.Start();

            foreach (var loc in locationDto)
            {
                locationEntities.Add(
                    new Location
                    {
                        FkLocationTypeId = context.LocationTypes.Where(lt => lt.LocationTypeName.Trim().ToLower().Equals(loc.LocationType.Trim().ToLower())).Select(lt => lt.LocationTypeId).SingleOrDefault(),
                        AutoWrapupApptStatus = context.AppointmentStatuses.Where(apt => apt.AppointmentStatusName.Trim().ToLower().Equals(loc.AutoWrapUpApptStatus.Trim().ToLower())).Select(apt => apt.AppointmentStatusId).SingleOrDefault(),
                        ActiveStatus = (byte)(loc.ActiveStatus ? 1 : 0),
                        Address1 = loc.Address1.Trim(),
                        Address2 = loc.Address2.Trim(),
                        AppointmentCutOffDays = loc.AppointmentCutoffWindow,
                        AutoAssignFloatPriorityMode = Convert.ToByte(loc.FloatPriorityMode),
                        AutoWrapupTime = loc.AutoWrapUpTime,
                        AvailabilityWindowDays = loc.FutureAvailabilityWindow,
                        ChangeApptStatus = loc.ChangeApptStatus,
                        City = loc.City.Trim(),
                        Color = ColorTranslator.ToHtml(Color.FromArgb(Convert.ToInt32(loc.GetRGB()[0]), Convert.ToInt32(loc.GetRGB()[1]), Convert.ToInt32(loc.GetRGB()[2]))).Substring(1,6),
                        Country = loc.Country.Trim(),
                        CreatedBy = context.Users.Where(u => u.UserId == 1).Select(u => u.UserId).SingleOrDefault(),
                        CreatedDate = DateTime.Now,
                        DailySummaryEmailTime = loc.SummaryEmailNotificationTime,
                        DurationBeforeFirstApptHours = loc.LeadTimeAppointmentBooking,
                        Email = loc.Email.Trim(),
                        EnableStaffSelection = loc.AllowRequestStaff,
                        FkParentLocationId = context.Locations.Where(l => l.LocationCode.Trim().ToLower().Equals(loc.ParentLocationCode)).Select(l => l.LocationId).SingleOrDefault(),
                        FkTimeZoneId = context.TimeZones.Where(tz => tz.StandardName.Trim().ToLower().Equals(loc.Timezone.Trim().ToLower())).Select(t => t.TimeZoneId).SingleOrDefault(),
                        Latitude = loc.Latitude,
                        LocationCode = loc.LocationCode,
                        LocationDisplayName = loc.LocationDisplayName.Trim(),
                        LocationName = loc.LocationName.Trim(),
                        Longitude = loc.Longitude,
                        OnlineCheckInEnabled = loc.AllowRemoteCheckIn,
                        PhoneExtention = loc.PhoneExt.Trim(),
                        PhoneNumber = loc.PhoneNumber.Trim(),
                        ReminderBeforeApptEmailHours = loc.ReminderEmailNotificationTime,
                        ReminderBeforeApptSmsHours = loc.ReminderTextMessageNotificationTime,
                        ShowInWidget = loc.ShowInWidget,
                        State = loc.State.Trim(),
                        TimeBeforeBranchCloseForOnlineCheckIn = loc.CutOffBeforeClosing,
                        TimeInAdvanceForOnlineCheckIn = loc.CheckInLeadTime,
                        UseAppointments = loc.UseAppointment,
                        ZipCode = loc.ZipCode.Trim(),
                        GoogleReserveEnabled = false
                    }
                );
            }
            timer.Stop();

            _logger.LogInformation($"Entity mapping time: {timer.ElapsedMilliseconds / 1000.000}");

            timer.Reset();
            timer.Start();

            using (var transation = context.Database.BeginTransaction())
            {
                context.BulkInsert(locationEntities);
                transation.Commit();
            }

            timer.Stop();
            _logger.LogInformation($"Insertion time: {timer.ElapsedMilliseconds / 1000.000}");
        }

        /*
        public void BulkWriteTasksProjects(labratContext context, IEnumerable<TaskProject> records)
        {
            var projects = records.Select(r => r.ProjectName).Distinct();

            List<Project> rawProjectEntities = projects.Select(r => new Project { ProjectName = r }).ToList();

            timer.Start();

            context.BulkInsert(rawProjectEntities);

            List<Task> rawTaskEntities = records
                .Select(r => new Task
                {
                    TaskName = r.TaskName,
                    Project = context.Projects
                                .Where(p => p.ProjectName.Equals(r.ProjectName))
                                .Select(p => p.ProjectId)
                                .Single()
                }).ToList();

            context.BulkInsert(rawTaskEntities);

            timer.Stop();
            Console.WriteLine(timer.ElapsedMilliseconds / 1000.000);

            var projEntities = context.Projects;
        }
        */
    }
}
