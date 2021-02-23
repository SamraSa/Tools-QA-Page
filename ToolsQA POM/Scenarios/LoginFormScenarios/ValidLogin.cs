using AventStack.ExtentReports;
using NUnit.Framework;
using System;
using System.Diagnostics;
using System.Threading;

namespace ToolsQA_POM
{
    [TestFixture]
    public class ValidLogin

    {
        ExtentReports rep = ExtentManager.getInstance();
        ExtentTest test;
        public ValidLogin()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Functions.InitializerDriver();
        }

        [Test]
        public void PositiveTestCase()
        {


            try
            {
                test = rep.CreateTest("Valid Login Test");
                test.Log(Status.Info, "Starting the Valid Login Test");

                Functions.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Valid.Password);
                Thread.Sleep(5000);
                Functions.passTakeScreenshot("Valid_Login_Scenario_Schreenshot_Result");
                test.Log(Status.Info, "In the Valid Login Test");

                Assert.AreEqual(Functions.ProfleUser(), "Samra");
                Functions.LogoutFunction();
                Thread.Sleep(5000);

                test.Log(Status.Pass, "Test passed");
                rep.Flush();

            }
            catch (Exception e)
            {
                Trace.WriteLine("error: " + e);
                Functions.passTakeScreenshot("Valid_Login_Error_Screenshot");
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

    

        

       
        