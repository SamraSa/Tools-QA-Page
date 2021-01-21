using NUnit.Framework;
using System.Threading;

namespace ToolsQA_POM.Scenarios
{
    public class RadioButtonScenario
    {
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

            Functions.RadioButton1Function();
            Assert.AreEqual(Functions.RadioButtonMessage(), Config.SelectedButtonMessage.SelectedButton1Message);

            Functions.RadioButton2Function();
            Assert.AreEqual(Functions.RadioButtonMessage(), Config.SelectedButtonMessage.SelectedButton2Message);
        }


        [Test]
        public void VerifyAllButtons()

        {
            Functions.CheckingAllButtons();
        }

        [Test]
        public void RadioButtonStatus()

        {
            Functions.StartButtonsStatus();
        }


        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }

    }
}
