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

namespace Inl3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int clicked = 1;
        int redGained = 0;
        int blackGained = 0;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (clicked > 10)
            { txtBlockLeft.Text = "You can only play 10 times!";
                btn.IsEnabled = false;
                txtResult.Text = $"{redGained} red wins; {blackGained} black wins";
            } 
            else
            {
                Random number = new Random();
                int i = number.Next(1, 3);

                txtBlockLeft.Text = $"The game played {clicked++} times";


                if (i == 1)
                { 
                    ellips.Fill = Brushes.Red; 
                    txtResult.Text = "Red color win";
                    redGained++;

                }
                else if (i == 2)
                { 
                    ellips.Fill = Brushes.Black;
                    txtResult.Text = "Black color win";
                    blackGained++;
                }
                
            }

        }
    }
}
