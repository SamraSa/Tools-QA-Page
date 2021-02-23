using AventStack.ExtentReports;
using NUnit.Framework;
using System;
using System.Diagnostics;
using System.Threading;

namespace ToolsQA_POM.Scenarios
{
    [TestFixture]
    public class RadioButtonScenario
    {
        ExtentReports rep = ExtentManager.getInstance();
        ExtentTest test;
        public RadioButtonScenario()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Functions.InitializerDriver();
            NavigateTo.RadioButton();
        }

        [Test]
        public void RadioButtonCase()

        {
            try
            {
                test = rep.CreateTest("Radio Button");
                test.Log(Status.Info, "Starting the Radio Button Test");

                //Radio Button 'Yes'

                Functions.RadioButton1Function();
                Thread.Sleep(2000);

                test.Log(Status.Info, "Radio Button 'Yes' is selected");

                Functions.passTakeScreenshot("RadioButtonYes_Scenario_Schreenshot_Result");

                Assert.AreEqual(Functions.RadioButtonMessage(), Config.SelectedButtonMessage.SelectedButton1Message);
                test.Log(Status.Info, "Selected Radio Button 'Yes' Message is verified");


                //Radio Button 'Impressive'

                Functions.RadioButton2Function();
                Thread.Sleep(2000);

                test.Log(Status.Info, "Radio Button 'No' is selected");

                Functions.passTakeScreenshot("RadioButtonNo_Scenario_Schreenshot_Result");

                Assert.AreEqual(Functions.RadioButtonMessage(), Config.SelectedButtonMessage.SelectedButton2Message);
                test.Log(Status.Info, "Selected Radio Button 'Impressive' Message is verified");

                test.Log(Status.Pass, "Test passed");
                rep.Flush();
            }

            catch (Exception e)
            {
                Trace.WriteLine("Error: " + e);
                Functions.passTakeScreenshot("Radio_Button_Scenario_Error_Screenshot");
                test.Log(Status.Fail, "Test failed");
                rep.Flush();
            }
        }


        [Test]
        public void VerifyAllButtons()

        {
            try
            {
                test = rep.CreateTest("Checking the Radio Buttons");
                test.Log(Status.Info, "Starting the Radio Buttons Test");

                Functions.CheckingAllButtons();
                test.Log(Status.Info, "Radio Buttons are one by one checked");

                Functions.passTakeScreenshot("RadioButtons_Scenario_Schreenshot_Result");
                

                test.Log(Status.Pass, "Test passed");
                rep.Flush();
            }

            catch (Exception e)
            {
                Trace.WriteLine("Error: " + e);
                Functions.passTakeScreenshot("Radio_Buttons_Scenario_Error_Screenshot");
                test.Log(Status.Fail, "Test failed");
                rep.Flush();
            }
        }

            [Test]
        public void RadioButtonStatus()

        {
            try
            {
                test = rep.CreateTest("Radio Button Status");
                test.Log(Status.Info, "Starting the Radio Button Status Test");

                Functions.StartButtonsStatus();
                test.Log(Status.Info, "Radio Buttons are not checked");

                Functions.passTakeScreenshot("RadioButtons_ Status_Scenario_Schreenshot_Result");

                test.Log(Status.Pass, "Test passed");
                rep.Flush();
            }
            catch (Exception e)
            {
                Trace.WriteLine("Error: " + e);
                Functions.passTakeScreenshot("Radio_Button_Scenario_Error_Screenshot");
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
