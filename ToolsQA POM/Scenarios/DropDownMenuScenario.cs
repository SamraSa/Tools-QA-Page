

using NUnit.Framework;

namespace ToolsQA_POM.Scenarios
{
    public class DropDownMenuScenario
    {
        public DropDownMenuScenario()
        {
        }


        [OneTimeSetUp]
        public void Initialize()
        {
            Functions.InitializerDriver();
        }

        [Test]
        public void DropDownMenuList()
        {
            Functions.DropDownMenuValueChange();

            Assert.AreEqual(Functions.RowTableCount(), Config.TableRows.TabeleRowsOfSecondElement);
           
        }


        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
