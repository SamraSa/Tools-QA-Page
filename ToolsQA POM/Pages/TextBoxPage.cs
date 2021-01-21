using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace ToolsQA_POM.Pages
{
    class TextBoxPage
    {
        public TextBoxPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }


        [FindsBy(How = How.Id, Using = "userName")]
        public IWebElement FullNameInputField { get; set; }


        [FindsBy(How = How.Id, Using = "userEmail")]
        public IWebElement EmailInputField { get; set; }


        [FindsBy(How = How.Id, Using = "currentAddress")]
        public IWebElement CurrentAdddressInputField { get; set; }


        [FindsBy(How = How.Id, Using = "permanentAddress")]
        public IWebElement PermanentAdddressInputField { get; set; }


        [FindsBy(How = How.Id, Using = "submit")]
        public IWebElement SubmitButton { get; set; }


        [FindsBy(How = How.Id, Using = "output")]
        public IWebElement OutputElement { get; set; }


        /* [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'justify-content-end row')]//button")]
         public IWebElement SubButton { get; set; }*/


        [FindsBy(How = How.XPath, Using = "//div[@id='output']")]
        public IWebElement OutputTextField { get; set; }




    }
}
