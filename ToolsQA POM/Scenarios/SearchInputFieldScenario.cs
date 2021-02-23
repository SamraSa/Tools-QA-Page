using AventStack.ExtentReports;
using NUnit.Framework;
using System;
using System.Diagnostics;
using System.Threading;

namespace ToolsQA_POM.Scenarios
{
    [TestFixture]
    public class SearchInputFieldScenario
    {

        ExtentReports rep = ExtentManager.getInstance();
        ExtentTest test;
        public SearchInputFieldScenario()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Functions.InitializerDriver();
        }

        [Test]
        public void SerachFieldLessThanThreeCharacters()
        {
            //Search Field

            try
            {
                test = rep.CreateTest("Search Field");
                test.Log(Status.Info, "Starting the Search Field Test");

                Functions.FillSearchField(Config.SearchField.TwoCharacters);

                test.Log(Status.Info, "Entering two characters into Search Field");

                Assert.AreEqual(Functions.TitleOfBook(), Config.BookTitle.BookTitleText);
                Thread.Sleep(2000);

                test.Log(Status.Info, "Comparing entered characters with table results");

                Functions.passTakeScreenshot("Search_Field_Content_Scenario_Schreenshot_Result");

                //Filter

                Functions.ChangeAuthorNameOrderFirstClick();
                Thread.Sleep(3000);
                Functions.ChangeAuthorNameOrderSecondClick();
                Thread.Sleep(3000);
                test.Log(Status.Info, "Author Names Order is changed");

                Assert.AreEqual(Functions.AuthorName1(), Config.AuthorName.FirstRowAuthorName);
                Functions.passTakeScreenshot("Author_Names_Order_Scenario_Schreenshot_Result");

                test.Log(Status.Pass, "Test passed");
                rep.Flush();

            }

            catch (Exception e)
            {
                Trace.WriteLine("Error: " + e);
                Functions.passTakeScreenshot("Search_Field_Scenario_Error_Screenshot");
                test.Log(Status.Fail, "Test failed");
                rep.Flush();
            }
        }


        [Test]
        public void SerachFieldFourCharacters()
        {
            //Search Field

            try
            {
                test = rep.CreateTest("Search Field with fours entered chars");
                test.Log(Status.Info, "Starting the Search Field with four entered chars Test");

                Functions.FillSearchField(Config.SearchField.FourCharacters);
                test.Log(Status.Info, "Entering four characters into Search Field");

                Functions.passTakeScreenshot("FourCharacters_FillingSearchField_Scenario_Schreenshot_Result");

                Assert.IsTrue(Functions.TitleOfBook().Contains(Config.BookTitle.BookTitleText));
                test.Log(Status.Info, "Comparing entered characters with table results");

                test.Log(Status.Pass, "Test passed");
                rep.Flush();
            }
            catch (Exception e)
            {
                Trace.WriteLine("Error: " + e);
                Functions.passTakeScreenshot("Search_Field_FourChars_Scenario_Error_Screenshot");
                test.Log(Status.Fail, "Test failed");
                rep.Flush();
            }
        }


            //Test cleanup

            [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
