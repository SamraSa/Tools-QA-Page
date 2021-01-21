using System;
using OpenQA.Selenium;

namespace ToolsQA_POM
{

    public static class Driver
    {
        public static IWebDriver driver { get; set; }

        //Implicit wait
        public static void WaitForElementUpTo(int seconds = 5)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(seconds);
            
        }
    }
}