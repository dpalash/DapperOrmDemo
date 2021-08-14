using System;
using Hangfire;
using Hangfire.SqlServer;

namespace HangFireConsoleApp
{
    static class Program
    {
        static void Main(string[] args)
        {
            JobStorage.Current = new SqlServerStorage(@"data source=PALASH-PC\PD_MSSQLSERVER;initial catalog=neptune;persist security info=True;user id=sa;password=cefalo023");
            var options = new BackgroundJobServerOptions
            {
                ServerName = $"{Environment.MachineName}:54596",
                SchedulePollingInterval = TimeSpan.FromMinutes(1)
            };

            using (var server = new BackgroundJobServer(options))
            {
                //BackgroundJob.Schedule(() => Console.WriteLine("Hello, world!"), TimeSpan.FromMinutes(1));
                RecurringJob.AddOrUpdate(() => Console.Write("Powerful!"), Cron.Minutely);
                Console.ReadKey();
            }

            //GlobalConfiguration.Configuration.UseSqlServerStorage(@"data source=PALASH-PC\PD_MSSQLSERVER;initial catalog=neptune;persist security info=True;user id=sa;password=cefalo023");

            //using (var server = new BackgroundJobServer())
            //{
            //    Console.WriteLine("Hangfire Server started. Press any key to exit...");
            //    Console.ReadKey();
            //}

        }
    }
}
