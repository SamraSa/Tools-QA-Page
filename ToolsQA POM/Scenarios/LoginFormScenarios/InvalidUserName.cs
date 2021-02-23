using AventStack.ExtentReports;
using NUnit.Framework;
using System;
using System.Diagnostics;
using System.Threading;

namespace ToolsQA_POM.Scenarios
{
    [TestFixture]
    public class InvalidUserName
    {
        ExtentReports rep = ExtentManager.getInstance();
        ExtentTest test;
        public InvalidUserName()
        {
        }


        [OneTimeSetUp]
        public void Initialize()
        {
            Functions.InitializerDriver();
        }

        [Test]
        public void OnlySpecialSymbols()
        {
            try
            {
                test = rep.CreateTest("Invalid User Name Test");
                test.Log(Status.Info, "Starting the Invalid User Name Login Test");

                Functions.FillLoginForm(Config.Credentials.Invalid.Username.OnlySpecialSymbols, Config.Credentials.Valid.Password);

                Functions.ScrollToTitle();
                Thread.Sleep(1000);
                Functions.passTakeScreenshot("InvalidUserName_OnlySpecialSymbols_Scenario_Schreenshot_Result");
                test.Log(Status.Info, "Invalid User Name Login Test in the process");

                Assert.AreEqual(Functions.ErrorMessageText(), Config.Messages.ErrorMessage);

                test.Log(Status.Pass, "Test passed");
                rep.Flush();
            }

            catch (Exception e)

            {
                Trace.WriteLine("error: " + e);
                Functions.passTakeScreenshot("InvalidUserName_OnlySpecialSymbols_Error_Screenshot");
                test.Log(Status.Fail, "Test failed");
                rep.Flush();
            }
        }


        [Test]
        public void NoSpecialSymbol()
        {
            try
            {
                test = rep.CreateTest("Invalid User Name Login Test");
                test.Log(Status.Info, "Starting the Invalid User Name Login Test");

                Functions.FillLoginForm(Config.Credentials.Invalid.Username.NoSpecialSymbol, Config.Credentials.Valid.Password);

                Functions.ScrollToTitle();
                Thread.Sleep(1000);
                Functions.passTakeScreenshot("InvalidUserName_NoSpecialSymbol_Scenario_Schreenshot_Result");
                test.Log(Status.Info, "Invalid User Name Login Test in the process");

                Assert.AreEqual(Functions.ErrorMessageText(), Config.Messages.ErrorMessage);

                test.Log(Status.Pass, "Test passed");
                rep.Flush();
            }

            catch (Exception e)

            {
                Trace.WriteLine("error: " + e);
                Functions.passTakeScreenshot("InvalidUserName_NoSpecialSymbol_Error_Screenshot");
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