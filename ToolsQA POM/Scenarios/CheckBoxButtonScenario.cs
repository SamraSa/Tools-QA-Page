using AventStack.ExtentReports;
using NUnit.Framework;
using System;
using System.Diagnostics;
using System.Threading;

namespace ToolsQA_POM.Scenarios
{
    [TestFixture]
    public class CheckBoxButtonScenario
    {
        ExtentReports rep = ExtentManager.getInstance();
        ExtentTest test;
        public CheckBoxButtonScenario()
        {
        }
            [OneTimeSetUp]
            public void Initialize()
            {
                Functions.InitializerDriver();
                NavigateTo.CheckBoxButton();
            }

        [Test]
        public void CheckBoxCase()

        {
            try
            {
                test = rep.CreateTest("Check Box");
                test.Log(Status.Info, "Starting the Check Box Test");

                Functions.CheckBoxFunction();

                Thread.Sleep(3000);

                Functions.CheckBoxFunction();
                
                Functions.passTakeScreenshot("CheckBoxChecked_Scenario_Schreenshot_Result");
                Thread.Sleep(3000);
                test.Log(Status.Info, "Check Box is checked");

                test.Log(Status.Pass, "Test passed");
                rep.Flush();
            }

            catch (Exception e)
            {
                Trace.WriteLine("Error: " + e);
                Functions.passTakeScreenshot("CheckBox_Scenario_Error_Screenshot");
                test.Log(Status.Fail, "Test failed");
                rep.Flush();
            }
        }

       [OneTimeTearDown]
       public void CleanUp()
       {
            Driver.driver.Quit();
       }
        
    }
}
