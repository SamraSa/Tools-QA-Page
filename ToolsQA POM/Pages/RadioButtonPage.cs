using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace ToolsQA_POM.Pages
{
    public class RadioButtonPage
    {
        public RadioButtonPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }


        [FindsBy(How = How.Id, Using = "yesRadio")]
        public IWebElement RadioButton1 { get; set; }

        /*
        [FindsBy(How = How.CssSelector, Using = "#app > div > div > div.row > div.col-12.mt-4.col-md-6 > div:nth-child(1) > div:nth-child(2) > label")]
        public IWebElement RadioButton1Label { get; set; }
        */

        
        [FindsBy(How = How.XPath, Using = "(//div[contains(@class,'custom-control')]/label)[1]")]
        public IWebElement RadioButton1Label { get; set; }
        

        [FindsBy(How = How.Id, Using = "impressiveRadio")]
        public IWebElement RadioButton2 { get; set; }

       
        [FindsBy(How = How.CssSelector, Using = "#app > div > div > div.row > div.col-12.mt-4.col-md-6 > div:nth-child(1) > div:nth-child(3) > label")]
        public IWebElement RadioButton2Label { get; set; }


        [FindsBy(How = How.Id, Using = "noRadio")]
        public IWebElement RadioButton3 { get; set; }

       
        [FindsBy(How = How.CssSelector, Using = "#app > div > div > div.row > div.col-12.mt-4.col-md-6 > div:nth-child(1) > div.custom-control.disabled.custom-radio.custom-control-inline > label")]
        public IWebElement RadioButton3Label { get; set; }

       
        [FindsBy(How = How.CssSelector, Using = "#app > div > div > div.row > div.col-12.mt-4.col-md-6 > div:nth-child(1) > p")]
        public IWebElement CheckedRadioButtonMessage { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#app > div > div > div.row > div.col-12.mt-4.col-md-6 > div:nth-child(1)")]
        public IWebElement ParentElementRadioButtons { get; set; }



       


        
    }
}
