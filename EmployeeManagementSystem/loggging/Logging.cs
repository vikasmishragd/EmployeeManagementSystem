using log4net;
using log4net.Appender;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace EmployeeManagementSystem
{
	public static class Logging
    {
        public static ILog Logger;

        public static readonly string DefaultPattern = "%d{HH:mm:ss} %level: %C.%M - %m %n";

        static Logging()
        {
            ConfigureAppender();
            SetHeader();
        }

        public static void SetHeader()
        {
            var appender = GetAppender();

            if (appender == null) return;

            var myPattern = new ProductInfoPattern("%d{HH:mm:ss} %level: %C.%M - %m %n")
            {
                DebugLevel = GetLogLevel()
            };

            appender.Layout = myPattern;
            appender.ActivateOptions();
            log4net.Config.BasicConfigurator.Configure(appender);
        }

        private static RollingFileAppender GetAppender()
        {
            RollingFileAppender appender = null;
            var appenders = LogManager.GetRepository().GetAppenders();
            foreach (var app in appenders)
            {
                if (app.Name.Equals(GetAppenderName(@"EmployeeManagementSystem")))
                    appender = (RollingFileAppender)app;

            }
            return appender;
        }

        private static string GetAppenderName(string key)
        {
            var nodes = key.Split('\\');
            return nodes.GetValue(nodes.GetUpperBound(0)).ToString();
        }

        internal static void ConfigureAppender()
        {
            var appender = new RollingFileAppender
            {
                Name = @"EmployeeManagementSystem",
                Layout = new log4net.Layout.PatternLayout(DefaultPattern),
                File = GetLogFilePath(),
                MaxSizeRollBackups = 2,
                MaximumFileSize = "100MB",
                AppendToFile = true,
                LockingModel = new FileAppender.MinimalLock()
            };

            switch (GetLogLevel())
            {
                case 0:
                    appender.Threshold = log4net.Core.Level.Error;
                    break;
                case 1:
                    appender.Threshold = log4net.Core.Level.Warn;
                    break;
                case 2:
                    appender.Threshold = log4net.Core.Level.Info;
                    break;
                case 3:
                    appender.Threshold = log4net.Core.Level.Debug;
                    break;
                default:
                    appender.Threshold = log4net.Core.Level.Debug;
                    break;
            }

            appender.ActivateOptions();

            log4net.Config.BasicConfigurator.Configure(appender);

            Logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType?.FullName);
        }

        private static string GetLogFilePath()
        {
            var mainModuleFileName = Process.GetCurrentProcess().MainModule?.FileName;
            return mainModuleFileName?.Replace(Path.GetExtension(mainModuleFileName), ".log");
        }

        private static int GetLogLevel()
        {
            try
            {
                var appSettingsFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"appsettings.json");
                var appSettings = File.ReadAllText(appSettingsFile);
                var settings = JsonConvert.DeserializeObject<AppSettings>(appSettings);

                return settings.LogLevel;
            }
            catch
            {
                return 5;
            }

        }
    }

    public class AppSettings
    {
        public int LogLevel { get; set; } = 5;
    }
}
