using AventStack.ExtentReports;
using NUnit.Framework;
using System;
using System.Diagnostics;
using System.Threading;

namespace ToolsQA_POM.Scenarios
{
    [TestFixture]
    public class InvalidUserNameAndInvalidPassword
    {
        ExtentReports rep = ExtentManager.getInstance();
        ExtentTest test;

        public InvalidUserNameAndInvalidPassword()
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
                test = rep.CreateTest("InvalidUserNameAndPassword Test");
                test.Log(Status.Info, "Starting the Invalid User Name And Password Login Test");

                Functions.FillLoginForm(Config.Credentials.Invalid.Username.FourCharacters, Config.Credentials.Invalid.Password.FourCharacters);

                Functions.ScrollToTitle();
                Thread.Sleep(1000);
                Functions.passTakeScreenshot("InvalidUserNamenAndPass_LessThan5Chars_Scenario_Schreenshot_Result");
                test.Log(Status.Info, "Invalid Login Test in the process");


                Assert.AreEqual(Functions.ErrorMessageText(), Config.Messages.ErrorMessage);

                test.Log(Status.Pass, "Test passed");
                rep.Flush();
            }

            catch (Exception e)

            {
                Trace.WriteLine("error: " + e);
                Functions.passTakeScreenshot("InvalidUNAndPass_LessThan5Chars_Login_Error_Screenshot");
                test.Log(Status.Fail, "Test failed");
                rep.Flush();
            }
        }


        [Test]
        public void OnlyNummbers()
        {
            try
            {
                test = rep.CreateTest("Invalid Login Test");
                test.Log(Status.Info, "Starting the Invalid User Name and Password Login Test");

                Functions.FillLoginForm(Config.Credentials.Invalid.Username.OnlyNumbers, Config.Credentials.Invalid.Password.OnlyNumbers);
                
                Functions.ScrollToTitle();
                Functions.passTakeScreenshot("InvalidUserNameAndPassword_OnlyNumbers_Scenario_Schreenshot_Result");
                test.Log(Status.Info, "Invalid Login Test in the process");

                Assert.AreEqual(Functions.ErrorMessageText(), Config.Messages.ErrorMessage);

                test.Log(Status.Pass, "Test passed");
                rep.Flush();
            }

            catch (Exception e)

            {
                Trace.WriteLine("error: " + e);
                Functions.passTakeScreenshot("Invalid_UNAndPass_Login_Error_Screenshot");
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
