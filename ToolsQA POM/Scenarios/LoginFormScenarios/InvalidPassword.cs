using AventStack.ExtentReports;
using NUnit.Framework;
using System;
using System.Diagnostics;
using System.Threading;


namespace ToolsQA_POM.Scenarios
{
    [TestFixture]
    public class InvalidPassword
    {
        ExtentReports rep = ExtentManager.getInstance();
        ExtentTest test;
        public InvalidPassword()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Functions.InitializerDriver();
        }

        [Test]
        public void LessThan5Chars()
        {
            try
            {
                test = rep.CreateTest("Invalid Password Login Test");
                test.Log(Status.Info, "Starting the Invalid Password Login Test");

                Functions.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Invalid.Password.FourCharacters);
                
                Functions.ScrollToTitle();
                Thread.Sleep(1000);

                Functions.passTakeScreenshot("InvalidPassword_LessThan5Chars_Scenario_Schreenshot_Result");
                test.Log(Status.Info, "Invalid Password Login Test in the process");

                Assert.AreEqual(Functions.ErrorMessageText(), Config.Messages.ErrorMessage);

                test.Log(Status.Pass, "Test passed");
                rep.Flush();
            }

            catch (Exception e)

            {
                Trace.WriteLine("error: " + e);
                Functions.passTakeScreenshot("InvalidPassword_LessThan5Chars_Error_Screenshot");
                test.Log(Status.Fail, "Test failed");
                rep.Flush();
            }
        }

        [Test]
        public void OnlyLetters()
        {
            try
            {
                test = rep.CreateTest("Invalid Password Login Test");
                test.Log(Status.Info, "Starting the Invalid Password Login Test");

                Functions.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Invalid.Password.OnlyLetters);

                Functions.ScrollToTitle();
                Thread.Sleep(1000);
                Functions.passTakeScreenshot("InvalidPassword_OnlyLetters_Scenario_Schreenshot_Result");
                test.Log(Status.Info, "Invalid Password Login Test in the process");

                Assert.AreEqual(Functions.ErrorMessageText(), Config.Messages.ErrorMessage);

                test.Log(Status.Pass, "Test passed");
                rep.Flush();
            }
            
            catch (Exception e)

            {
                Trace.WriteLine("error: " + e);
                Functions.passTakeScreenshot("InvalidPassword__OnlyLetters_Error_Screenshot");
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

