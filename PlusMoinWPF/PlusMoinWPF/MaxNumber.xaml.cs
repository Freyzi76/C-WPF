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
using System.Windows.Shapes;

namespace PlusMoinWPF
{
    /// <summary>
    /// Logique d'interaction pour MaxNumber.xaml
    /// </summary>
    public partial class MaxNumber : Window
    {

        string ErrorVal = "";


        public MaxNumber()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            MainWindow main = Application.Current.Windows.OfType<MainWindow>().First();

            if (UserValMax.Text != null) {

                if (int.TryParse(UserValMax.Text, out int userValueEnter))
                {

                    main.randomNumberMax = userValueEnter;

                    main.SetValue();

                    Close();

                }
                else
                {

                    ErrorVal = "format";

                    Error();

                }

            } else {

                ErrorVal = "null";

                Error();
            
            }

            

        }



        public void Error()
        {

            Error errorForm = new Error();

            errorForm.Show();

            Error error = Application.Current.Windows.OfType<Error>().First();

            if(ErrorVal == "null")
            {

                error.ErrorLabel.Content = "Vous devez entrer une valeur";

            } else if (ErrorVal == "format") {

                error.ErrorLabel.Content = "Vous devez entrer uniquement des chiffres";

            }

            

        }






    }
}
