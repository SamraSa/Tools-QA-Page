using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace ToolsQA_POM.Pages
{
    public class LoginPage
    {
        public LoginPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        //Using FindBy for locating elements

        //Login Scenarios

        [FindsBy(How = How.Id, Using = "userName")]
        public IWebElement UsernameField { get; set; }


        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement PasswordField { get; set; }


        [FindsBy(How = How.Id, Using = "login")]
        public IWebElement LoginButton { get; set; }


        [FindsBy(How = How.Id, Using = "name")]
        public IWebElement ErrorMessage { get; set; }

        
        [FindsBy(How = How.XPath, Using = "//div[text()='Login']")]
        public IWebElement Title { get; set; }

        
    }
}
