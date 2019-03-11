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
using System.IO;

namespace lab_106_game_increase_score_01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Initialize();
        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //File.WriteAllText("fileUser.txt", user.Text + Environment.NewLine + lvl.Text + Environment.NewLine + score.Text);
        }

        //void Initialize()
        //{
        //    string[] data01 = File.ReadAllLines("fileUser.txt");
        //    user.Text = data01[0];
        //    lvl.Text = data01[1];
        //    score.Text = data01[2];
        //}
        //Up Button
        private int hscore = 100;
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            hscore++;
            score.Text = hscore.ToString();
        }
        // Down Button
        
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            hscore--;
            score.Text = hscore.ToString();
        }
        // Create a GAMING HOME PAGE
        // name of gamer (saved to text file)
        // level reached (saved to that file)
        // Top score
        // Prize for best presented interface

        // Next iteration - add an up/down button to increase the score
    }
}
