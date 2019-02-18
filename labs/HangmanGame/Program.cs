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
            string[] word = { "alabama", "alaska", "arizona", "arkansas", "california", "colorado", "connecticut", "delaware", "florida", "georgia", "hawaii", "idaho", "illinois", "indiana", "iowa", "kansas", "kentucky", "louisiana", "maine", "maryland", "massachusetts", "michigan", "minnesota", "mississippi", "missouri", "montana", "mebraska", "nevada", "new hampshire", "new jersey", "new mexico", "new york", "north carolina", "north dakota", "ohio", "oklahoma", "oregon", "pennsylvania", "rhode island", "south carolina", "south dakota", "tennessee", "texas", "utah", "vermont", "virgin island", "virginia", "washington", "west virginia", "wisconsin", "wyoming" };
            // randomly selected states from wordBank
            char[] randUsaStates = word[rand.Next(word.Length)].ToCharArray();
            
          
            
            //Console.WriteLine(usaStatesGuessed);
            List<char> lettersGuessedCorrectly = new List<char>();
            List<char> lettersGuessedIncorrectly = new List<char>();


            
            int lives = 3;
            bool win = true;
            char underscoreToHide = '_';
            Console.WriteLine("Press enter to start: ");
            Console.ReadKey();
           
            Console.WriteLine("Welcome to Maiwand's Version of Hangman. Can you name the US state?");

            while (win)
            {
                //Console.WriteLine(usaStatesGuessed);

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
                    win = true;
                    
                }
                else
                {
                    if (win && lives > 0)
                    {
                        lives--;
                        Console.WriteLine("Incorrect letter!");

                        if (lives == 0)
                        {
                            Console.WriteLine("Game Over!");
                            break;
                        }
                        
                        
                        //continue;
                        
                    }
                    else
                    {
                        Console.WriteLine("Correct letter!");
                        
                        //continue;
                    }
                }
                Console.WriteLine("Congratulations you win!");
                              
            }           
        }
    }
}
