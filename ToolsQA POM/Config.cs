namespace ToolsQA_POM
{
    public static class Config
    {
        public static int ElementsWaitingTimeout = 5;
        public static string BaseURL = "https://www.demoqa.com/books";


        //Login Scenarios
        public static class Credentials
        {
            public static class Valid
            {
                public static string Username = "Samra";
                public static string Password = "Samra123!";
            }

            public static class Invalid
            {
                public static class Username
                {
                    public static string FourCharacters = "abcd";
                    public static string ThirteenCharacters = "abcdabcdabcda";
                    public static string OnlyLetters = "abcdabcd";
                    public static string OnlyNumbers = "123456789";
                    public static string OnlySpecialSymbols = "$#@%)(*$%#%?><";
                    public static string NoSpecialSymbol = "asd1234";
                }

                public static class Password
                {
                    public static string FourCharacters = "abcd";
                    public static string ThirteenCharacters = "abcdabcdabcda";
                    public static string OnlyLetters = "abcdabcd";
                    public static string OnlyNumbers = "123456789";
                    public static string OnlySpecialSymbols = "$#@%)(*$%#%?><";
                    public static string NoSpecialSymbol = "asd1234";
                }


            }
        }


        //Login scenarios - Invalid User Name or Password
        public static class Messages
        {
            public static string ErrorMessage = "Invalid username or password!";
        }


        //Login scenarios - Empty Fields
        public static class EmptyInputFields
        {
            public static string InvalidClassText = "mr-sm-2 is-invalid form-control";
        }


        //Search Input Field
        public static class SearchField
        {
            public static string TwoCharacters = "Ja";
            public static string FourCharacters = "Java";
            public static string LowerCase = "java";
            public static string UpperCase = "JAVA";
            public static string Numbers = "123";
        }

        public static class BookTitle
        {
            public static string BookTitleText = "Learning JavaScript Design Patterns";
        }


        //Search Input Field - Filter
        public static class AuthorName
        {
            public static string FirstRowAuthorName = "Marijn Haverbeke";
        }


        //Drop Down Menu

        public static class TableRows
        {
            public static int TabeleRowsOfFirstElement = 5;
            public static int TabeleRowsOfSecondElement = 10;
            public static int TabeleRowsOfThirdElement = 20;
        }


        //Table Content
        public static class TableBookISBN
        {
            public static string penultimateBookISBN = "9781449365035";
        }




        //Radio Button

        public static class SelectedButtonMessage
        {
            public static string SelectedButton1Message = "You have selected Yes";
            public static string SelectedButton2Message = "You have selected Impressive";

        }

        //Text Box
        public static class InputFieldText
        {
            public static class Valid
            {
                public static string FullName = "Samra";
                public static string Email = "samra@gmail.com";
                public static string CurrentAddress = "Street 1";
                public static string PermanentAddress = "Street 2";
            }

            public static class Invalid
            {
                public static class FullName
                {
                    public static string FourCharacters = "abcd";
                    public static string ThirteenCharacters = "abcdabcdabcda";
                    public static string OnlyLetters = "abcdabcd";
                    public static string OnlyNumbers = "123456789";
                    public static string OnlySpecialSymbols = "$#@%)(*$%#%?><";
                    public static string NoSpecialSymbol = "asd1234";
                }


                public static class Email
                {
                    public static string NoUser = "@example.com";
                    public static string NoAt = "exampleexample.com";
                    public static string OnlyUser = "example";
                    public static string NoExtension = "example@example";
                }


                public static class CurrentAddress
                {

                    public static string OnlyStreet = "Street";
                    public static string OnlyNummber = "12";
                }


                public static class PermanentAddress
                {

                    public static string OnlyStreet = "Street";
                    public static string OnlyNummber = "12";
                }

            }
        }

        public static class OutputValidFillFormText
        {
            public static string TextContentName = "Name:Samra\r\nEmail:samra@gmail.com\r\nCurrent Address :Street 1\r\nPermananet Address :Street 2";
            public static string TextContentEmail = "Email:samra @gmail.com";
            public static string TextContentCurrentAddress = "Current Address :Street 1";
            public static string TextContentPermanentAddress = "Permananet Address :Street 2";

            
        }
    }
}
