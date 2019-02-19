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

        static string[] word = { "alabama", "alaska", "arizona", "arkansas", "california", "colorado", "connecticut", "delaware", "florida", "georgia", "hawaii", "idaho", "illinois", "indiana", "iowa", "kansas", "kentucky", "louisiana", "maine", "maryland", "massachusetts", "michigan", "minnesota", "mississippi", "missouri", "montana", "nebraska", "nevada", "north dakota", "ohio", "oklahoma", "oregon", "pennsylvania", "tennessee", "texas", "utah", "vermont", "virginia", "washington", "wisconsin", "wyoming" };

        static string randUsaStates = word[rand.Next(word.Length)];

        static char[] lettersGuessed = new char[randUsaStates.Length];

        List<char> lettersGuessedCorrectly = new List<char>();
        List<Button> usedButton = new List<Button>();

        int lives = 5;
        
        char dashToHide = '-';
        int lettersFound = 0;

        public MainWindow()
        {
            InitializeComponent();
        }
               
        // start button
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {                       
            wordDisplayed.Text = new String(dashToHide, lettersGuessed.Length);            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button pressed = (Button)sender;
            usedButton.Add(pressed);
            string letterClicked = pressed.Content.ToString();
            bool win = false;

            foreach (var character in randUsaStates)
            {
                if (letterClicked == randUsaStates)
                {
                    lettersFound++;

                    //wordDisplayed.Text = character.ToString();
                }
                else
                {
                    //wordDisplayed.Text = dashToHide.ToString();
                }
            }
        }
    }
}
