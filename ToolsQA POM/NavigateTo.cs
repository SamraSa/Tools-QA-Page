using ToolsQA_POM.Pages.PageElements;

namespace ToolsQA_POM
{
    public static class NavigateTo
    {
        public static void CheckBoxButton()
        {
            Menu menu = new Menu();
            Submenu submenu = new Submenu();

            menu.Elements.Click();
            submenu.CheckBox.Click();
           
        }

        public static void RadioButton()
        {

            Menu menu = new Menu();
            Submenu submenu = new Submenu();

            menu.Elements.Click();
            submenu.RadioButton.Click();
        }


        public static void TextBox()
        {

            Menu menu = new Menu();
            Submenu submenu = new Submenu();

            menu.Elements.Click();
            submenu.TextBox.Click();
        }
    }
}
