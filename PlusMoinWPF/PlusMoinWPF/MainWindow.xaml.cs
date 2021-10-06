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

        public int randomNumberMax = 10;

        int score;

        bool winner = false;


        public MainWindow()
        {
            InitializeComponent();

            SetValue();

        }


        public void SetValue()
        {

            life = 3;

            Random random = new Random();

            randomNumber = random.Next(0, randomNumberMax);


            lifeLabel.Content = "Vie restante : ";

            resultLifeLabel.Content = life;

            resultLabel.Content = "Tu dois trouver un chiffre random créé par le programme,  \r\n compris entre 0 et 10.  \r\n A toi de jouer :) " + randomNumberMax;

            scoreResult.Content = score;

        }


        private void buttonUserInput_Click(object sender, RoutedEventArgs e)
        {


            if(int.TryParse(UserInput.Text, out int userValueEnter))
            {


                if (userValueEnter == randomNumber && life > 0)
                {

                    resultLabel.Content = "Tu as trouver";

                    winner = true;

                    OpenReplay();

                } else if (userValueEnter < randomNumber && life > 0) {

                    resultLabel.Content = "C'est Plus";

                    life--;

                } else if (userValueEnter > randomNumber && life > 0) {

                    resultLabel.Content = "C'est Moins";

                    life--;

                } else if ( life == 0) {

                    resultLabel.Content = "Tu as perdu";

                    winner = false;

                    OpenReplay();

                }

                if (life == 0)
                {

                    resultLifeLabel.Content = "";
                    lifeLabel.Content = "Tu n'a plus de vie";

                    winner = false;

                    OpenReplay();

                } else {

                    resultLifeLabel.Content = life;

                }



            } else {

                ErrorFormat();

            }

        }



        private void buttonChangeValMax_Click(object sender, RoutedEventArgs e)
        {

            DefindRandomNumberMax();

        }



        public void DefindRandomNumberMax()
        {

            MaxNumber max = new MaxNumber();

            max.Show();

        }



        public void OpenReplay()
        {

            if(winner == true)
            {

                score = score + 10;

            }

            Replay ReplayForm = new Replay();

            ReplayForm.Show();

        }



        public void ErrorFormat()
        {

            Error errorForm = new Error();

            errorForm.Show();

            Error error = Application.Current.Windows.OfType<Error>().First();

            error.ErrorLabel.Content = "Vous devez entrer uniquement des chiffres";

        }

     
    }
}
