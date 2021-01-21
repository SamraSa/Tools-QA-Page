using NUnit.Framework;
using System.Threading;

namespace ToolsQA_POM.Scenarios
{
    public class CheckBoxButtonScenario
    {
        public CheckBoxButtonScenario()
        {
        }
            [OneTimeSetUp]
            public void Initialize()
            {
                Functions.InitializerDriver();
                NavigateTo.CheckBoxButton();
            }

            [Test]
            public void CheckBoxCase()

            {

            Functions.CheckBoxFunction();

            Thread.Sleep(3000);

            Functions.CheckBoxFunction();

            Thread.Sleep(3000);
        }


            [OneTimeTearDown]
            public void CleanUp()
            {
                Driver.driver.Quit();
            }
        
    }
}
