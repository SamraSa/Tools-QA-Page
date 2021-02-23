using AventStack.ExtentReports;
using NUnit.Framework;
using System;
using System.Diagnostics;
using System.Threading;

namespace ToolsQA_POM.Scenarios
{
    [TestFixture]
    public class EmptyFields
    {

        ExtentReports rep = ExtentManager.getInstance();
        ExtentTest test;
        public EmptyFields()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Functions.InitializerDriver();
        }

        [Test]
        public void LeaveFieldsEmpty()
        {
            try
            {
                test = rep.CreateTest("Empty Fields Test");
                test.Log(Status.Info, "Starting the Empty Fields Login Test");

                Functions.EmptyLoginForm();

                Functions.ScrollToTitle();
                Thread.Sleep(1000);

                Functions.passTakeScreenshot("EmptyFields_Scenario_Schreenshot_Result");
                test.Log(Status.Info, "Empty Fields Login Test in the process");

                Assert.AreEqual(Functions.EmptyUserNameFieldErrorClassText(), Config.EmptyInputFields.InvalidClassText);
                Assert.AreEqual(Functions.EmptyPasswordFieldErrorClassText(), Config.EmptyInputFields.InvalidClassText);

                test.Log(Status.Pass, "Test passed");
                rep.Flush();
            }

            catch (Exception e)

            {
                Trace.WriteLine("error: " + e);
                Functions.passTakeScreenshot("EmptyFields_Error_Screenshot");
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
