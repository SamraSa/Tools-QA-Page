using AventStack.ExtentReports;
using NUnit.Framework;
using System;
using System.Diagnostics;
using System.Threading;

namespace ToolsQA_POM.Scenarios
{
    [TestFixture]
    public class DropDownMenuScenario
    {
        ExtentReports rep = ExtentManager.getInstance();
        ExtentTest test;
        public DropDownMenuScenario()
        {
        }


        [OneTimeSetUp]
        public void Initialize()
        {
            Functions.InitializerDriver();
        }

        [Test]
        public void DropDownMenuList()
        {
            try
            {
                test = rep.CreateTest("Drop Down Menu");
                test.Log(Status.Info, "Starting the Drop Down Menu Test");

                Functions.DropDownMenuValueChange();
                test.Log(Status.Info, "Second Drop Down Option is selected");

                Functions.ScrollToDropDownElement();
                Thread.Sleep(3000);

                Functions.passTakeScreenshot("DropDownSecondOption_Scenario_Schreenshot_Result");
                Thread.Sleep(3000);

                Assert.AreEqual(Functions.RowTableCount(), Config.TableRows.TabeleRowsOfSecondElement);
                test.Log(Status.Info, "Table rows are counted and compared to number in the Drop Down second option");
                
                test.Log(Status.Pass, "Test passed");
                rep.Flush();
            }

            catch (Exception e)
            {
                Trace.WriteLine("Error: " + e);
                Functions.passTakeScreenshot("Drop_Down_Scenario_Error_Screenshot");
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
