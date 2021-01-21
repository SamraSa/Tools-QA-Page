using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace ToolsQA_POM.Pages.PageElements
{
    public class Menu
    {
        public Menu()
        {       
            PageFactory.InitElements(Driver.driver, this);
        }

        /*[FindsBy(How = How.CssSelector, Using = "#app > div > div > div.row > div:nth-child(1) > div > div > div:nth-child(1) > span > div > div.header-text")]
        public IWebElement Elements { get; set; }*/


        [FindsBy(How = How.XPath, Using = "//div[text()='Elements']")]
        public IWebElement Elements { get; set; }


        /*[FindsBy(How = How.CssSelector, Using = "#app > div > div > div.row > div:nth-child(1) > div > div > div:nth-child(2) > span > div > div.header-text")]
        public IWebElement Forms { get; set; }*/

        [FindsBy(How = How.XPath, Using = "//div[text()='Forms']")]
        public IWebElement Forms { get; set; }


    }
}
