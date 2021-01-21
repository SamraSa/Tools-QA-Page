using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace ToolsQA_POM.Pages.PageElements
{
    public class Submenu
    {
        public Submenu()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#item-1 > span")]
        public IWebElement CheckBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#item-2 > span")]
        public IWebElement RadioButton { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#item-0 > span")]
        public IWebElement TextBox { get; set; }


    }
}
