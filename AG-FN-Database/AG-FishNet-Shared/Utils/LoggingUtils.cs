using System;
using NLog;
using NLog.Layouts;

namespace AG_FishNet_Shared.Utils
{
    public static class LoggingUtils
    {
        public static readonly string FileName;

        static LoggingUtils()
        {
            FileName = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".txt";
        }

        public static void SetupLogging(LogLevel minLogLevel = null)
        {
            if (minLogLevel == null) minLogLevel = LogLevel.Debug;

            var config = new NLog.Config.LoggingConfiguration();

            var defaultLayout = Layout.FromString("${threadname:whenEmpty=${threadid}} ${time} (${level:uppercase=true}) ${logger:shortName=false}:${callsite-linenumber} : ${message}");

            // Log to file
            var logfile = new NLog.Targets.FileTarget("logfile") {FileName = "Log/" + FileName};
            config.AddRule(LogLevel.Debug, LogLevel.Fatal, logfile);
            logfile.Layout = defaultLayout;

            // Log to colored console
            var logColored = new NLog.Targets.ColoredConsoleTarget("console");
            config.AddRule(minLogLevel, LogLevel.Fatal, logColored);
            logColored.Layout = defaultLayout;

            // Log to trace (allows Azure's Log Stream to display errors)
            var logTrace = new NLog.Targets.TraceTarget("trace");
            config.AddRule(minLogLevel, LogLevel.Fatal, logTrace);
            logTrace.Layout = defaultLayout;

            // Set configuration and re-config
            LogManager.Configuration = config;
            LogManager.ReconfigExistingLoggers();
        }
    }
}