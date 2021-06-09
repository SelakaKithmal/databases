using bulkexp.Models;
using CsvHelper;
using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            var db = _context.CreateDbContext();
            _logger.LogInformation("App is running");

            var users = db.Users.ToList();

            foreach (var item in users)
            {
                Console.WriteLine(item.UserName);
            }
        }

        public void ReadFromCsv()
        {
            using (var reader = new StreamReader(_config.GetSection("ProvisionData:Locations:Small").Value))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    
                };
            }
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
