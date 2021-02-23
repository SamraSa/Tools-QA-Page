using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsQA_POM
{
    class ExtentManager
    {
        public static ExtentHtmlReporter htmlReporter;

        private static ExtentReports extent;

        private ExtentManager()
        {

        }

        public static ExtentReports getInstance()
        {
            if(extent == null)
            {
                //string filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
                // filePath = Directory.GetParent(Directory.GetParent(filePath).FullName).FullName;
                string reportTime = DateTime.Now.ToString("dd-MM-yyyy").Replace("/", "_").Replace(":", "_").Replace(" ", "_").Replace("-", "_");
                string reportPath = @"C:\Users\SiradS\Desktop\ToolsQA_POM\ToolsQA POM\Reports\Report " + reportTime + ".html";
                
                htmlReporter = new ExtentHtmlReporter(reportPath);
                extent = new ExtentReports();
                extent.AttachReporter(htmlReporter);
                extent.AddSystemInfo("OS", "Windows");
                extent.AddSystemInfo("Host Name", "samra");
                extent.AddSystemInfo("Environment", "QA");
                extent.AddSystemInfo("UserName", "Samra");

                //Right click extent-config.xml, properties, copy a path

                string extentConfigPath = @"C:\Users\SiradS\Desktop\ToolsQA_POM\ToolsQA POM\extent-config.xml";
                //Console.Writeline(filePath);
                htmlReporter.LoadConfig(extentConfigPath);
            }
            return extent;
        }
    }
}
