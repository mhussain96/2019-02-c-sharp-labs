using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HangmanGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Random rand = new Random();

        static string[] word = { "alabama", "alaska", "arizona", "arkansas", "california", "colorado", "connecticut", "delaware", "florida", "georgia", "hawaii", "idaho", "illinois", "indiana", "iowa", "kansas", "kentucky", "louisiana", "maine", "maryland", "massachusetts", "michigan", "minnesota", "mississippi", "missouri", "montana", "nebraska", "nevada", "ohio", "oklahoma", "oregon", "pennsylvania", "tennessee", "texas", "utah", "vermont", "virginia", "washington", "wisconsin", "wyoming" };

        static string randUsaStates = word[rand.Next(word.Length)];

        static char[] wordChar = randUsaStates.ToCharArray();

        static char[] dashes = new char[randUsaStates.Length];
                
        List<int> lettersGuessedCorrectly = new List<int>();
        List<Button> usedButton = new List<Button>();

        int lives = 5;
        
        int lettersFound = 0;
        
        public MainWindow()
        {
            InitializeComponent();
        }
               
        // start button
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {                       
            //wordDisplayed.Text = new String(dashToHide, randUsaStates.Length);
            // Changes length of word into dashes upon clicking the start button and displays it in textbox
            for (int i = 0; i < dashes.Length; i++)
            {
                dashes[i] = '-';
            }
            string myDash = new string(dashes);

            wordDisplayed.Text = myDash;           
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button pressed = (Button)sender;
            usedButton.Add(pressed);
            string letterClicked = pressed.Content.ToString();
            pressed.IsEnabled = false;
            string myDash = new string(dashes);
            Console.WriteLine(randUsaStates);
            Console.WriteLine(randUsaStates.Contains(Convert.ToChar(letterClicked)));
                           
            foreach (var character in wordChar)
            {
                //Console.WriteLine(character);
                // button clicked is equal to the character in the word display in the textbox
                if (Convert.ToChar(letterClicked) == character)   
                {
                    lettersFound++;
                    for (int i = randUsaStates.IndexOf(letterClicked); i > -1; i = randUsaStates.IndexOf(letterClicked, i+1))
                    {
                        lettersGuessedCorrectly.Add(i);                       
                        //Console.WriteLine(i);
                    }
                    
                    foreach (var item in lettersGuessedCorrectly)
                    {
                        dashes[item] = Convert.ToChar(letterClicked);
                        string myDash1 = new string(dashes);
                        wordDisplayed.Text = myDash1;                                              
                    }
                    if (lettersGuessedCorrectly.Count > 0)
                    {
                        lettersGuessedCorrectly.Clear();
                    }
                    //Console.WriteLine("Found");
                }
                
                // once letters found is equal to length of the word, user wins.
                if (randUsaStates.Length == lettersFound)
                {
                    MessageBox.Show("Congratulations You Win!");
                }
                else if (lives < 2)
                {
                    MessageBox.Show("You Lose!");
                }
            }
            // lives decrease for every incorrect answer
            if (!randUsaStates.Contains(Convert.ToChar(letterClicked)))
            {
                lives--;
                score.Text = lives.ToString();               
            }
        }
    }
}
