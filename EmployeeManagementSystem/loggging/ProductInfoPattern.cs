using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Management;
using System.Threading;

namespace EmployeeManagementSystem
{
    public class ProductInfoPattern : log4net.Layout.PatternLayout
    {
        private readonly string SepLine = "-----------------------------------------------------------------------------";
        public int DebugLevel;

        public ProductInfoPattern(string pattern) : base(pattern)
        {

        }

        public override string Header
        {
            get
            {
                var product = System.Reflection.Assembly.GetEntryAssembly();

                var fileVersion = FileVersionInfo.GetVersionInfo(product.Location);

                var osName = (from x in new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem")
                            .Get()
                            .OfType<ManagementObject>()
                              select x.GetPropertyValue("Caption")).FirstOrDefault()
                            ?.ToString();

                var osLevel = $"{Environment.OSVersion.ServicePack} ({Environment.OSVersion.Version.Build})";

                var processInfo =
                    $"{product?.Location} (Process Id: {Process.GetCurrentProcess().Id.ToString()}, Thread Id: {Environment.CurrentManagedThreadId.ToString()})";

                var productVersion = $"Version {fileVersion.FileVersion} Build {fileVersion.FileBuildPart}";

                var ci = CultureInfo.InstalledUICulture;

                var languages = $"User language: {ci.EnglishName}, System language: {Thread.CurrentThread.CurrentCulture}";

                var machineUser = $"Username: {Environment.UserName}, Workstation: {Environment.MachineName}";

                return string.Format("\n{9}: {0}\n{9}: {1}\n{9}: {2}\n\n{9}: {3}\n{9}: {4}\n{9}: {5}\n{9}: Report Level {6}\n{9}: {7}\n{9}: {8}\n{9}: {0}\n",
                    SepLine, osName, osLevel, processInfo, productVersion, languages, DebugLevel, machineUser, DateTime.Now.ToLongDateString(), DateTime.Now.ToString("HH:mm:ss"));
            }
        }
    }
}