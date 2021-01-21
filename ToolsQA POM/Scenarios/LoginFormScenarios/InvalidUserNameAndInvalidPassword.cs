using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsQA_POM.Scenarios
{
    public class InvalidUserNameAndInvalidPassword
    {

        public InvalidUserNameAndInvalidPassword()
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
            Functions.FillLoginForm(Config.Credentials.Invalid.Username.FourCharacters, Config.Credentials.Invalid.Password.FourCharacters);

            Assert.AreEqual(Functions.ErrorMessageText(), Config.Messages.ErrorMessage);

        }


        [Test]
        public void OnlyNummbers()
        {
            Functions.FillLoginForm(Config.Credentials.Invalid.Username.OnlyNumbers, Config.Credentials.Invalid.Password.OnlyNumbers);

            Assert.AreEqual(Functions.ErrorMessageText(), Config.Messages.ErrorMessage);

        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }




}
