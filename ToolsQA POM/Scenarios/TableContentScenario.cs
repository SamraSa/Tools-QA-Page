using AventStack.ExtentReports;
using NUnit.Framework;
using System;
using System.Diagnostics;
using System.Threading;

namespace ToolsQA_POM.Scenarios
{
    [TestFixture]
    public class TableContentScenario
    {
        ExtentReports rep = ExtentManager.getInstance();
        ExtentTest test;
        public TableContentScenario()
        {
        }


        [OneTimeSetUp]
        public void Initialize()
        {
            Functions.InitializerDriver();
     
        }

        [Test]
        public void ClickingOnTabeleContent()
        {

            try
            {
                test = rep.CreateTest("Tabele Content");
                test.Log(Status.Info, "Starting the Table Content Test");

                Functions.SelectFirstDropDownElement();
                test.Log(Status.Info, "Selecting first dropdown element");

                Functions.RowTableCount();
                test.Log(Status.Info, "Counting number of books in the table");

                Assert.AreEqual(Functions.RowTableCount(), Config.TableRows.TabeleRowsOfFirstElement);

                Functions.ClickingOnThePenultimatTableResult();
                test.Log(Status.Info, "This is the penultimate result");
                Thread.Sleep(3000);
                
                Functions.passTakeScreenshot("Table_Content_Scenario_Schreenshot_Result");


                Assert.AreEqual(Functions.ISBNOfBook(), Config.TableBookISBN.penultimateBookISBN);

                test.Log(Status.Pass, "Test passed");
                rep.Flush();
            }

            catch (Exception e)
            {
                Trace.WriteLine("Error: " + e);
                Functions.passTakeScreenshot("Table_Content_Scenario_Error_Screenshot");
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
