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
            string[] word = { "alabama", "alaska", "arizona", "arkansas", "california", "colorado", "connecticut", "delaware", "florida", "georgia", "hawaii", "idaho", "illinois", "indiana", "iowa", "kansas", "kentucky", "louisiana", "maine", "maryland", "massachusetts", "michigan", "minnesota", "mississippi", "missouri", "montana", "nebraska", "nevada", "north dakota", "ohio", "oklahoma", "oregon", "pennsylvania", "tennessee", "texas", "utah", "vermont", "virginia", "washington", "wisconsin", "wyoming" };
                        
            // randomly selected states from wordBank
            string randUsaStates = word[rand.Next(word.Length)];

            //char[] lettersGuessed = new char[randUsaStates.Length];
            
            List<char> lettersGuessedCorrectly = new List<char>();
            
            //Console.WriteLine(randUsaStates);
            
            int lives = 5;
            bool win = false;
            char underscoreToHide = '_';
            int lettersFound = 0;
            Console.WriteLine("Press enter to start: ");
            Console.ReadKey();
           
            Console.WriteLine("Welcome to Maiwand's Version of Hangman. You have 5 lives to start with, if you guess wrong you lose a life. \nCan you name the US state?");

            while (!win)
            {
                foreach (var character in randUsaStates)
                {
                    if (lettersGuessedCorrectly.Contains(character))
                    {
                        Console.WriteLine(character);
                    }                  
                    else
                    {                                               
                        Console.WriteLine(underscoreToHide);
                    }
                }

                Console.WriteLine("Enter your letter: ");
                char letter = char.Parse(Console.ReadLine());

                if (randUsaStates.Contains(letter))
                {
                    Console.WriteLine("Correct letter!");                   
                    lettersGuessedCorrectly.Add(letter);

                    for (int i = 0; i < randUsaStates.Length; i++)
                    {
                        if (randUsaStates[i] == letter)
                        {
                            lettersFound++;
                        }
                    }  
                    if (lettersFound == randUsaStates.Length)
                    {
                        win = true;
                    }
                }
                else
                {
                    if (!win && lives > 0)
                    {
                        lives--;
                        Console.WriteLine("Incorrect letter!");
                        Console.WriteLine($"\nYou have {lives} lives remaining");
                        if (lives <= 0)
                        {
                            Console.WriteLine("\nUnlucky you're a loser!");
                            break;
                        }                       
                    }                   
                    else
                    {                        
                        Console.WriteLine("Correct letter!");                        
                    }
                }
                
                if (win)
                {
                    Console.WriteLine("\nCongratulations you win!");
                    break;
                }
            }           
        }
    }
}
