using NUnit.Framework;
using System.Threading;

namespace ToolsQA_POM
{
    public class ValidLogin
    {
        public ValidLogin()
        {
        }

            [OneTimeSetUp]
            public void Initialize()
            {
                Functions.InitializerDriver();
            }

            [Test]
            public void PositiveTestCase()
            {
                Functions.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Valid.Password);
                Thread.Sleep(5000);
                Assert.AreEqual(Functions.ProfleUser(), "Samra");
                Functions.LogoutFunction();
                Thread.Sleep(5000);
            }

            [OneTimeTearDown]
            public void CleanUp()
            {
                Driver.driver.Quit();
            }

    }
}

    

        

       
        