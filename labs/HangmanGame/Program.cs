using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace HangmanGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();
            // selection of words stored in a string variable 
            string[] listOfStates = { "mississippi", "massachusetts", "oregon", "california", "ohio", "vermont", "virginia", "arizona", "connecticut", "montana" };
            // randomly selected states from wordBank
            string usaStatesGuessed = listOfStates[rand.Next(listOfStates.Length)];
            
          
            StringBuilder display = new StringBuilder(usaStatesGuessed.Length);

            //for (int i = 0; i < usaStatesGuessed.Length; i++)
            //{
            //    display.Append("_");
            //}

            Console.WriteLine(usaStatesGuessed);
            List<char> lettersGuessedCorrectly = new List<char>();
            List<char> lettersGuessedIncorrectly = new List<char>();

            Console.WriteLine(display);
          
            bool victory = true;
            int lives = 3;
            string input;
            char letterGuess;
            int lettersShown = 0;
            Console.WriteLine("Press enter to start: ");
            Console.ReadKey();
           
            Console.WriteLine("Welcome to Maiwand's Version of Hangman. Can you name the US state?");

            while (victory && lives > 0)
            {
                Console.Write("Enter a letter: ");
                input = Console.ReadLine();
                letterGuess = input[0];

                if (lettersGuessedCorrectly.Contains(letterGuess))
                {
                    Console.WriteLine($"\nYou have guessed correctly: \n{letterGuess}");
                    continue;
                }
                else if (lettersGuessedIncorrectly.Contains(letterGuess))
                {
                    Console.WriteLine($"\nYou have guessed incorrectly: \n{letterGuess}");
                    continue;
                }

               

                if (lettersShown == usaStatesGuessed.Length)
                {
                    victory = true;
                }
                else
                {
                    // Console.WriteLine("You have guessed incorrectly!");
                    lettersGuessedIncorrectly.Add(letterGuess);
                    //lives--;
                }
                //Console.WriteLine(display.ToString());
            }

            if (victory == true)
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }
            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}
