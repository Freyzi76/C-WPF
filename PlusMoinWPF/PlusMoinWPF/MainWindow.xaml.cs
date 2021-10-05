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

namespace PlusMoinWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int life;

        int randomNumber;

        public MainWindow()
        {
            InitializeComponent();

            SetValue();


        }


        public void SetValue()
        {

            life = 3;

            Random random = new Random();

            randomNumber = random.Next(0, 10);

            resultLifeLabel.Content = life;

        }


        private void buttonUserInput_Click(object sender, RoutedEventArgs e)
        {


            if(int.TryParse(userInput.Text, out int userValueEnter))
            {


                if (userValueEnter == randomNumber && life > 0)
                {

                    resultLabel.Content = "Tu as trouver";

                } else if (userValueEnter < randomNumber && life > 0) {

                    resultLabel.Content = "C'est Plus";

                    life--;

                } else if (userValueEnter > randomNumber && life > 0) {

                    resultLabel.Content = "C'est Moins";

                    life--;

                } else if ( life == 0) {

                    resultLabel.Content = "Tu as perdu";

                }

                resultLifeLabel.Content = life;


            }

        }
    }
}
