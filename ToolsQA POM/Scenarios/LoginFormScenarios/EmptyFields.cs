using NUnit.Framework;


namespace ToolsQA_POM.Scenarios
{
    public class EmptyFields
    {

        public EmptyFields()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Functions.InitializerDriver();
        }

        [Test]
        public void LeaveFieldsEmpty()
        {
            Functions.EmptyLoginForm();

            Assert.AreEqual(Functions.EmptyUserNameFieldErrorClassText(), Config.EmptyInputFields.InvalidClassText);
            Assert.AreEqual(Functions.EmptyPasswordFieldErrorClassText(), Config.EmptyInputFields.InvalidClassText);

        }
      
        
        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }

    }
}
