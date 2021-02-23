using OpenQA.Selenium.Chrome;
using ToolsQA_POM.Pages;
using OpenQA.Selenium.Interactions;
using System;
using OpenQA.Selenium;
using System.Threading;
using System.Diagnostics;

namespace ToolsQA_POM
{
    public static class Functions
    {
        //Here we create an object of WebDriver, maximize browser, implementing waits, launching URL 
        public static void InitializerDriver()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Navigate().GoToUrl(Config.BaseURL);
            Driver.driver.Manage().Window.Maximize();
            Driver.WaitForElementUpTo(Config.ElementsWaitingTimeout);
        }

        //Report Screenshot

        public static void passTakeScreenshot(string screenshotName)
        {
            string ScreenshotTime = DateTime.Now.ToString("dd-MM-yyyy HH:mm").Replace(" / ", "_").Replace(":", "_").Replace(" ", "_");


            Trace.WriteLine("Time_: " + ScreenshotTime);


            ITakesScreenshot screenshotDriver = Driver.driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            screenshot.SaveAsFile(@"C:\Users\SiradS\Desktop\ToolsQA_POM\ToolsQA POM\Reports\Screenshots\" + screenshotName + " " + ScreenshotTime + ".jpeg");

        }



        // Defining all the user actions (Methods) that can be performed in the all Pages

        //Login Scenarios

        public static void FillLoginForm(string username, string password)
        {
            LoginPage loginPage = new LoginPage();
            HomePage homePage = new HomePage();
            Actions action = new Actions(Driver.driver);

            homePage.LoginButton.Click();

            loginPage.UsernameField.Clear();
            loginPage.UsernameField.SendKeys(username);

            loginPage.PasswordField.Clear();
            loginPage.PasswordField.SendKeys(password);

            action.MoveToElement(loginPage.LoginButton);
            action.Build().Perform();

            loginPage.LoginButton.Click();

        }


        //Login Scenarios - Valid Login

        public static string ProfleUser()
        {
            DashboardPage dashboardPage = new DashboardPage();

            var DashboardTitle = dashboardPage.ProfileUser.Text;
            return DashboardTitle;
        }


        public static void LogoutFunction()
        {
            DashboardPage dashboardPage = new DashboardPage();

            dashboardPage.LogoutButton.Click();
        }


        //Login Scenarios - Invalid UserName or Password

        public static string ErrorMessageText()
        {
            LoginPage loginPage = new LoginPage();
            Actions action = new Actions(Driver.driver);

            action.MoveToElement(loginPage.ErrorMessage);
            action.Build().Perform();

            var errorMessage = loginPage.ErrorMessage.Text;
            return errorMessage;
        }

        public static void ScrollToTitle()
        {
            LoginPage loginPage = new LoginPage();
            Actions action = new Actions(Driver.driver);


            ((IJavaScriptExecutor)Driver.driver).ExecuteScript("arguments[0].scrollIntoView(true);", loginPage.Title);

        }

            //Login scenarios - Empty Fields

            public static void EmptyLoginForm()
        {
            LoginPage loginPage = new LoginPage();
            HomePage homePage = new HomePage();
            Actions action = new Actions(Driver.driver);

            homePage.LoginButton.Click();

            loginPage.UsernameField.Clear();
            loginPage.PasswordField.Clear();

            action.MoveToElement(loginPage.LoginButton);
            action.Build().Perform();

            loginPage.LoginButton.Click();

        }

        public static string EmptyUserNameFieldErrorClassText()
        {
            LoginPage loginPage = new LoginPage();

            var EmptyUserNameFieldErrorText = loginPage.UsernameField.GetAttribute("class");
            Console.WriteLine("Test " + EmptyUserNameFieldErrorText);
            return EmptyUserNameFieldErrorText;

        }

        public static string EmptyPasswordFieldErrorClassText()
        {
            LoginPage loginPage = new LoginPage();

            var EmptyPasswordFieldErrorText = loginPage.PasswordField.GetAttribute("class");
            Console.WriteLine("Test " + EmptyPasswordFieldErrorText);
            return EmptyPasswordFieldErrorText;
        }


        //Search Input Field

        public static void FillSearchField(string searchword)
        {
            HomePage homePage = new HomePage();

            homePage.SearchFiledElement.Clear();
            homePage.SearchFiledElement.SendKeys(searchword);
        }

        public static string TitleOfBook()
        {
            HomePage homePage = new HomePage();

            var BookTitle = homePage.FirstTableRowTitle.Text;
            Console.WriteLine("Title " + BookTitle);
            return BookTitle;

        }


        //Search Input Field - Filter

        public static string AuthorName1()
        {
            HomePage homePage = new HomePage();

            var NameOfAuthor1 = homePage.FirstTableRowAuthorName.Text;
            Console.WriteLine("Title " + NameOfAuthor1);
            return NameOfAuthor1;
        }


        public static void ChangeAuthorNameOrderFirstClick()
        {
            HomePage homePage = new HomePage();

            homePage.RowAuthorCursorPointer.Click();
            
        }

        public static void ChangeAuthorNameOrderSecondClick()
        {
            HomePage homePage = new HomePage();

            homePage.RowAuthorCursorPointer.Click();

        }


        //Drop Down Menu

        public static void DropDownMenuValueChange()
        {
            HomePage homePage = new HomePage();
            Actions action = new Actions(Driver.driver);


            action.MoveToElement(homePage.DropDownMenu);
            action.Build().Perform();

            homePage.SecondDropDownElement.Click();

        }


        public static void SelectFirstDropDownElement()
        {
            HomePage homePage = new HomePage();
            Actions action = new Actions(Driver.driver);


            action.MoveToElement(homePage.DropDownMenu);
            action.Build().Perform();

            homePage.FirstDropDownElement.Click();

        }


        public static void ScrollToDropDownElement()
        {
            HomePage homePage = new HomePage();
            Actions action = new Actions(Driver.driver);

            ((IJavaScriptExecutor)Driver.driver).ExecuteScript("arguments[0].scrollIntoView(true);", homePage.DropDownMenu);

        }

        //Table

        public static int RowTableCount()
        {
            HomePage homePage = new HomePage();

            int NumberOfTableRows = homePage.Table.FindElements(By.ClassName("rt-tr")).Count;
            return NumberOfTableRows;
        }

        public static void ClickingOnThePenultimatTableResult()
        {
            HomePage homePage = new HomePage();
            Actions action = new Actions(Driver.driver);


            action.MoveToElement(homePage.DropDownMenu);
            action.Build().Perform();

            homePage.TablePenultimateResult.Click();
            
        }


        public static string ISBNOfBook()
        {
            HomePage homePage = new HomePage();

            var BookISBN = homePage.ISBNOfSelectedBook.Text;
            return BookISBN;

        }




        //Check Box

        public static void CheckBoxFunction()
        {
            CheckBoxPage checkBoxPage = new CheckBoxPage();

            var CheckBoxStatus = checkBoxPage.CheckBoxButton.GetAttribute("class");
            var substring1 = "rct-icon-check";


            if (CheckBoxStatus.Contains(substring1))
            {
                Console.WriteLine("The checkbox is checked!");

            }
            else
            {
                Console.WriteLine("The checkbox is NOT checked!");
                checkBoxPage.CheckBoxButton.Click();

                Thread.Sleep(3000);
            }
        }

        //Radio Button

        public static string RadioButton1Function()
        {
            RadioButtonPage radioButtonPage = new RadioButtonPage();

            radioButtonPage.RadioButton1Label.Click();

            var RadioChecked = radioButtonPage.RadioButton1.GetAttribute("checked");

            return RadioChecked;
        }

        public static string RadioButton2Function()
        {
            RadioButtonPage radioButtonPage = new RadioButtonPage();

            radioButtonPage.RadioButton2Label.Click();

            var RadioChecked = radioButtonPage.RadioButton2.GetAttribute("checked");

            return RadioChecked;
        }

        public static string RadioButtonMessage()
        {
            RadioButtonPage radioButtonPage = new RadioButtonPage();

            var CheckedButtonMessage = radioButtonPage.CheckedRadioButtonMessage.Text;
            return CheckedButtonMessage;
        }



        public static IWebElement RadioButtonLabel(string option1)
        {
            RadioButtonPage radioButtonPage = new RadioButtonPage();

            var RadioButton = radioButtonPage.ParentElementRadioButtons.FindElement(By.CssSelector("#app > div > div > div.row > div.col-12.mt-4.col-md-6 > div:nth-child(1) > div:nth-child(" + option1 + ") > label"));
            return RadioButton;
        }

        public static IWebElement RadioButtonInput(string option1)
        {
            RadioButtonPage radioButtonPage = new RadioButtonPage();

            var RadioButton = radioButtonPage.ParentElementRadioButtons.FindElement(By.CssSelector("#app > div > div > div.row > div.col-12.mt-4.col-md-6 > div:nth-child(1) > div:nth-child(" + option1 + ") > input"));
            return RadioButton;
        }



        public static void CheckingAllButtons()
        {
            string[] option = { "2", "3" };

            for (int i = 0; i < option.Length; i++)
            {
                var radioButtonInput = RadioButtonInput(option[i]);
                var radioButtonLabel = RadioButtonLabel(option[i]);



                if (radioButtonInput.GetAttribute("checked") == "true")
                {
                    Console.WriteLine("The " + (i + 1) + " radio button is checked");
                }

                else
                {
                    Console.WriteLine("This is one of the unchecked radio Buttons");
                    radioButtonLabel.Click();
                    Thread.Sleep(5000);
                }

            }
        }

        public static void StartButtonsStatus()
        {
            string[] option = { "2", "3" };

            for (int i = 0; i < option.Length; i++)
            {
                var radioButtonInput = RadioButtonInput(option[i]);
                var radioButtonLabel = RadioButtonLabel(option[i]);



                if (radioButtonInput.GetAttribute("checked") == null)
                {
                    Console.WriteLine("The " + (i + 1) + " radio button is not checked");

                }

                else
                {
                    Console.WriteLine("This Radio Button is checked");
                    Thread.Sleep(5000);
                }
            }
        }


        //Text Box
        public static void FillTextBoxForm(string fullname, string email, string current_address, string permanent_address)
        {
           
            TextBoxPage textBoxPage = new TextBoxPage();
            Actions action = new Actions(Driver.driver);


            textBoxPage.FullNameInputField.Clear();
            textBoxPage.FullNameInputField.SendKeys(fullname);

            textBoxPage.EmailInputField.Clear();
            textBoxPage.EmailInputField.SendKeys(email);

            textBoxPage.CurrentAdddressInputField.Clear();
            textBoxPage.CurrentAdddressInputField.SendKeys(current_address);

            textBoxPage.PermanentAdddressInputField.Clear();
            textBoxPage.PermanentAdddressInputField.SendKeys(permanent_address);

           
            ((IJavaScriptExecutor)Driver.driver).ExecuteScript("arguments[0].scrollIntoView(true);", textBoxPage.SubmitButton);
           
            //Ista metoda na dva nacina
            // ((IJavaScriptExecutor)Driver.driver).ExecuteScript("arguments[0].click();", textBoxPage.SubmitButton);
            textBoxPage.SubmitButton.Click();

        }


        public static string OutputContentText()
        {
            TextBoxPage textBoxPage = new TextBoxPage();

            var outputText = textBoxPage.OutputTextField.Text;
            return outputText;
        }
    }
}

