using NUnit.Framework;

namespace ToolsQA_POM.Scenarios
{
    public class InvalidUserName
    {
        public InvalidUserName()
        {
        }


        [OneTimeSetUp]
        public void Initialize()
        {
            Functions.InitializerDriver();
        }

        [Test]
        public void OnlySpecialSymbols()
        {
            Functions.FillLoginForm(Config.Credentials.Invalid.Username.OnlySpecialSymbols, Config.Credentials.Valid.Password);

            Assert.AreEqual(Functions.ErrorMessageText(), Config.Messages.ErrorMessage);

        }


        [Test]
        public void NoSpecialSymbol()
        {
            Functions.FillLoginForm(Config.Credentials.Invalid.Username.NoSpecialSymbol, Config.Credentials.Valid.Password);

            Assert.AreEqual(Functions.ErrorMessageText(), Config.Messages.ErrorMessage);

        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }

    }
}