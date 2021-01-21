using NUnit.Framework;
using System.Threading;


namespace ToolsQA_POM.Scenarios
{
    public class InvalidPassword
    {
        public InvalidPassword()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Functions.InitializerDriver();
        }

        [Test]
        public void LessThan5Chars()
        {
            Functions.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Invalid.Password.FourCharacters);

            Assert.AreEqual(Functions.ErrorMessageText(), Config.Messages.ErrorMessage);

        }


        [Test]
        public void OnlyLetters()
        {
            Functions.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Invalid.Password.OnlyLetters);

            Assert.AreEqual(Functions.ErrorMessageText(), Config.Messages.ErrorMessage);

        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}

