using System;

namespace RockPaperScissors_NoDb
{
    class Program
    {
        static void Main(string[] args)
        {
            int userChoice;
            bool userResponseInt;
            string userResponse;
            string y;
            string n;

            Random randomNumber = new Random(10);
            int computerChoice = randomNumber.Next(1, 4);
            
            while(true)
            {        
                Console.WriteLine("\nWelcome to Rock-Paper-Scissors!\n\nPlease choose Rock, Paper, or Scissors by typing 1, 2, or 3. Press enter to confirm your choice.\n");
                Console.WriteLine("\t1. Rock\n\t2. Paper\n\t3. Scissors\n");
                userResponse = Console.ReadLine(); //Reads the users input
                userResponseInt = int.TryParse(userResponse, out userChoice);

                if(userResponseInt == false || userChoice <1 || userChoice >3)
                {
                    Console.WriteLine("Your choice was invalid.");
                }
                else
                {
                   break;
                }

            Console.WriteLine("Your choice was: " + userChoice);

            

            // compares the numbers to see who won
            if(userChoice == computerChoice)    // if the players tie
            {
                Console.WriteLine("This game is a tie.");
            }

            else if(userChoice == 1 && computerChoice == 3 ||   // if the user wins
                userChoice == 2 && computerChoice == 1
                 || userChoice == 3 && computerChoice == 2)
            {
                Console.WriteLine("Congrats! The user Wins!");
            }
            else    // if the computer wins
            {
                Console.WriteLine("We're sorry. The computer won :(");
            }
                        Console.WriteLine("Would you like to play again?\n\tPress y for yes, or press n for no.");
            string playAgain = Console.ReadLine();
            if(playAgain != (y || n))
            {
                Console.WriteLine("The user response was invalid. Goodbye.");
            }
            else if(playAgain == y)
            {
                continue;
            }
            else if(playAgain == n)
            {
                Console.WriteLine("Thank you for playing. Goodbye.");
                break;
            }

            }


        }
    }
}
