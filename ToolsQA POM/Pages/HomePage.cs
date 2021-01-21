using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace ToolsQA_POM.Pages
{
    public class HomePage
    {
        public HomePage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }


        //Login Scenarios

        [FindsBy(How = How.Id, Using = "login")]
        public IWebElement LoginButton { get; set; }

        
        //Search Input Field

        [FindsBy(How = How.Id, Using = "searchBox")]
        public IWebElement SearchFiledElement { get; set; }

        
        [FindsBy(How = How.CssSelector, Using = "div.rt-table > div.rt-tbody > div:nth-child(1) > div > div:nth-child(2)")]
        public IWebElement FirstTableRowTitle { get; set; }


        //Search InputField - Filter

        [FindsBy(How = How.CssSelector, Using = "#app > div > div > div.row > div.col-12.mt-4.col-md-6 > div.books-wrapper > div.ReactTable.-striped.-highlight > div.rt-table > div.rt-tbody > div:nth-child(1) > div > div:nth-child(3)")]
        public IWebElement FirstRowAuthorCursorPointer { get; set; }

       
        [FindsBy(How = How.CssSelector, Using = "div.rt-table > div.rt-tbody > div:nth-child(1) > div > div:nth-child(3)")]
        public IWebElement FirstTableRowAuthorName { get; set; }


        //Drop Down Menu

       /* [FindsBy(How = How.CssSelector, Using = "#app > div > div > div.row > div.col-12.mt-4.col-md-6 > div.books-wrapper > div.ReactTable.-striped.-highlight > div.pagination-bottom > div > div.-center > span.select-wrap.-pageSizeOptions > select > option:nth-child(1)")]
        public IWebElement FirstDropDownElement { get; set; }
       */

        [FindsBy(How = How.XPath, Using = "//span[contains(@class,'select-wrap -pageSizeOptions')]//child::option[1]")]
        public IWebElement FirstDropDownElement { get; set; }



        [FindsBy(How = How.XPath, Using = "//span[contains(@class,'select-wrap -pageSizeOptions')]//child::option[2]")]
        public IWebElement SecondDropDownElement { get; set; }

        /* [FindsBy(How = How.CssSelector, Using = "#app > div > div > div.row > div.col-12.mt-4.col-md-6 > div.books-wrapper > div.ReactTable.-striped.-highlight > div.pagination-bottom > div > div.-center > span.select-wrap.-pageSizeOptions > select > option:nth-child(2)")]
         public IWebElement SecondDropDownElement { get; set; }

         */

        [FindsBy(How = How.XPath, Using = "//span[contains(@class,'select-wrap -pageSizeOptions')]//child::option[3]")]
        public IWebElement ThirdDropDownElement { get; set; }

        /*[FindsBy(How = How.CssSelector, Using = "#app > div > div > div.row > div.col-12.mt-4.col-md-6 > div.books-wrapper > div.ReactTable.-striped.-highlight > div.pagination-bottom > div > div.-center > span.select-wrap.-pageSizeOptions > select > option:nth-child(3)")]
        public IWebElement ThirdDropDownElement { get; set; }
        */


        [FindsBy(How = How.XPath, Using = "//span[contains(@class,'select-wrap -pageSizeOptions')]/select")]
        public IWebElement DropDownMenu { get; set; }

        /*[FindsBy(How = How.CssSelector, Using = "#app > div > div > div.row > div.col-12.mt-4.col-md-6 > div.books-wrapper > div.ReactTable.-striped.-highlight > div.pagination-bottom > div > div.-center > span.select-wrap.-pageSizeOptions > select")]
        public IWebElement DropDownMenu { get; set; }
        */


        [FindsBy(How = How.ClassName, Using = "rt-table")]
        public IWebElement Table { get; set; }












    }
}
