using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace ToolsQA_POM.Pages
{
    public class DashboardPage
    {
        public DashboardPage()
        {
         PageFactory.InitElements(Driver.driver, this);
        }
       
        //Login Scenarios

        [FindsBy(How = How.CssSelector, Using = "#userName-value")]
        public IWebElement ProfileUser { get; set; }

        [FindsBy(How = How.Id, Using = "submit")]
        public IWebElement LogoutButton { get; set; }
    }
}
