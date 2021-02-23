using AventStack.ExtentReports;
using NUnit.Framework;
using System;
using System.Diagnostics;
using System.Threading;

namespace ToolsQA_POM.Scenarios
{
    [TestFixture]
    public class TextBoxScenario
    {
        ExtentReports rep = ExtentManager.getInstance();
        ExtentTest test;
        public TextBoxScenario()
        {
        }


        [OneTimeSetUp]
        public void Initialize()
        {
            Functions.InitializerDriver();
            NavigateTo.TextBox();
        }

        [Test]
        public void TextBoxFillForm()

        {
            try
            {
                test = rep.CreateTest("Text Box Scenario");
                test.Log(Status.Info, "Starting the Text Box Test");

                Functions.FillTextBoxForm(Config.InputFieldText.Valid.FullName, Config.InputFieldText.Valid.Email, Config.InputFieldText.Valid.CurrentAddress, Config.InputFieldText.Valid.PermanentAddress);

                Thread.Sleep(3000);

                Functions.passTakeScreenshot("Filling_Text_Box_Scenario_Schreenshot_Result");
                test.Log(Status.Info, "Filled Text Box Form");

                Assert.AreEqual(Functions.OutputContentText(), Config.OutputValidFillFormText.TextContentName);
                test.Log(Status.Info, "Comparing entered datas with output text");

                test.Log(Status.Pass, "Test passed");
                rep.Flush();
            }

            catch (Exception e)
            {
                Trace.WriteLine("Error: " + e);
                Functions.passTakeScreenshot("Text_ Box_Scenario_Error_Screenshot");
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
