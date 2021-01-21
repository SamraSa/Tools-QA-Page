

using NUnit.Framework;

namespace ToolsQA_POM.Scenarios
{
    public class SearchInputFieldScenario
    {
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
            
            Functions.FillSearchField(Config.SearchField.TwoCharacters);

            Assert.AreEqual(Functions.TitleOfBook(), Config.BookTitle.BookTitleText);

            //Filter

            Functions.ChangeAuthorNameOrder();
            Assert.AreEqual(Functions.AuthorName1(), Config.AuthorName.FirstRowAuthorName);
         

        }


        [Test]
        public void SerachFieldFourCharacters()
        {
            //Search Field

            Functions.FillSearchField(Config.SearchField.FourCharacters);

            Assert.IsTrue(Functions.TitleOfBook().Contains(Config.BookTitle.BookTitleText));
        }


        //Test cleanup

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
