using NUnit.Framework;
using System.Threading;

namespace ToolsQA_POM.Scenarios
{
    public class TextBoxScenario
    {
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

            Functions.FillTextBoxForm(Config.InputFieldText.Valid.FullName, Config.InputFieldText.Valid.Email, Config.InputFieldText.Valid.CurrentAddress, Config.InputFieldText.Valid.PermanentAddress);

            Thread.Sleep(3000);

            Assert.AreEqual(Functions.OutputContentText(), Config.OutputValidFillFormText.TextContentName);
        }


        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }

    }
}
