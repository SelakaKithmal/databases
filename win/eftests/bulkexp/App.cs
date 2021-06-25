using bulkexp.Mappings;
using bulkexp.Models;
using bulkexp.Types;
using CsvHelper;
using EFCore.BulkExtensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;

namespace bulkexp
{
    public class App
    {
        private readonly ILogger<App> _logger;
        private readonly IConfiguration _config;
        private readonly ABCContext _context;
        private Stopwatch timer;

        public App(ILogger<App> logger, IConfiguration config, ABCContext context)
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

        public List<UserDTO> GetLocationsDTO()
        {
            using (var reader = new StreamReader(_config.GetSection("ProvisionData:Locations:Small").Value))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    csv.Context.RegisterClassMap<UserMap>();
                    return csv.GetRecords<UserDTO>().ToList();
                };
            }
        }

        public void GetLocationEntities()
        {
          //  var context = _context.CreateDbContext();

            timer.Start();
            var usersList = GetLocationsDTO();
            timer.Stop();

            _logger.LogInformation($"CSV Reading time: {timer.ElapsedMilliseconds / 1000.000}");

            timer.Reset();

          

            timer.Start();

           
            timer.Stop();

            _logger.LogInformation($"Entity mapping time: {timer.ElapsedMilliseconds / 1000.000}");

            timer.Reset();
            timer.Start();
            List<AspNetUser> aspUserList = new List<AspNetUser>();

            foreach(var user in usersList)
            {
                var usr = new AspNetUser { Email = user.Email, NormalizedUserName = user.NormalizedUserName, UserName = user.UserName, Id = Guid.NewGuid().ToString() };
                aspUserList.Add(usr);
            }

            using (var transation = _context.Database.BeginTransaction())
            {

                var bulkConfig = new BulkConfig { UpdateByProperties = new List<string> { "NormalizedUserName", "Email", "UserName" }, PropertiesToExcludeOnUpdate = new List<string> { "Id"  } };
                _context.BulkInsertOrUpdate(aspUserList, bulkConfig);
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
