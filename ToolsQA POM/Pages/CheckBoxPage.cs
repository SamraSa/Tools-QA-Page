using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace ToolsQA_POM.Pages
{
    public class CheckBoxPage
    {
        public CheckBoxPage()
        {
        PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#tree-node > ol > li > span > label > span.rct-checkbox > svg")]
        public IWebElement CheckBoxButton { get; set; }
    }
}
