using System;

namespace StringManipulationChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userInputString;         //this will hold your users message
            int elementNum;                 //this will hold the element number within the messsage that your user indicates
            char char1;                     //this will hold the char value that your user wants to search for in the message.
            string fName;                   //this will hold the users first name
            string lName;                   //this will hold the users last name
            
            Console.WriteLine("Please enter your message and press enter.");
            string v = Console.ReadLine();
            userInputString = v;

            Console.WriteLine("Please enter a number less than the length of your string and press enter.");
            string u = Console.ReadLine();
            elementNum = int.Parse(u);

            StringToUpper(userInputString);

            StringToLower(userInputString);

            StringTrim(userInputString);

            StringSubstring(userInputString, elementNum);

            Console.WriteLine("For which character should I search for in your original message?");
            string search = Console.ReadLine();
            char1 = char.Parse(search);

            SearchChar(userInputString, char1);

            Console.WriteLine("Please enter your frist name.");
            string first = Console.ReadLine();
            fName = first;

            Console.WriteLine("Please enter your last name.");
            string last = Console.ReadLine();
            lName = last;

            ConcatNames(fName, lName);






        }

        // This method has one string parameter. 
        // It will:
        // 1) change the string to all upper case, 
        // 2) print the result to the console and 
        // 3) return the new string.
        public static string StringToUpper(string userInputString){
            string upperUserInputString = userInputString.ToUpper();
            Console.WriteLine(upperUserInputString);
            return upperUserInputString;
        }

        // This method has one string parameter. 
        // It will:
        // 1) change the string to all lower case, 
        // 2) print the result to the console and 
        // 3) return the new string.        
        public static string StringToLower(string userInputString){
            string lowerUserInputString = userInputString.ToLower();
            Console.WriteLine(lowerUserInputString);
            return lowerUserInputString;
        }
        
        // This method has one string parameter. 
        // It will:
        // 1) trim the whitespace from before and after the string, 
        // 2) print the result to the console and 
        // 3) return the new string.
        public static string StringTrim(string userInputString){
            string trimUserInputString = userInputString.Trim();
            Console.WriteLine(trimUserInputString);
            return trimUserInputString;
        }
        
        // This method has two parameters, one string and one integer. 
        // It will:
        // 1) get the substring based on the integer received, 
        // 2) print the result to the console and 
        // 3) return the new string.
        public static string StringSubstring(string userInputString, int elementNum){
            string selectUserInputString = userInputString.Substring(elementNum);
            Console.WriteLine(selectUserInputString);
            return selectUserInputString;
        }

        // This method has two parameters, one string and one char.
        // It will:
        // 1) search the string parameter for the char parameter
        // 2) return the index of the char.
        public static int SearchChar(string userInputString, char char1){
            bool searchUserInputString = userInputString.Contains(char1);
                if(searchUserInputString is true)
                {
                    Console.WriteLine("Your selected character is included in your original message.");
                
                }
                else
                {
                    Console.WriteLine("Your selected character is not included in your original message.");
                }

            int index = userInputString.IndexOf(char1);
            Console.WriteLine("The index of your selected char is: " +index);
            return index;
        }

        // This method has two string parameters.
        // It will:
        // 1) concatenate the two strings with a space between them.
        // 2) return the new string.
        public static string ConcatNames(string fName, string lName){
           string userFullName = fName + lName;
           Console.WriteLine(userFullName);
           return userFullName;
        }



    }//end of program
}
