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
    /// Logique d'interaction pour Replay.xaml
    /// </summary>
    public partial class Replay : Window
    {


        public Replay()
        {
            InitializeComponent();

        }


        private void buttonContinue_Click(object sender, RoutedEventArgs e)
        {

            MainWindow main = Application.Current.Windows.OfType<MainWindow>().First();

            main.SetValue();

            Close();

        }

        private void buttonExit_Click(object sender, RoutedEventArgs e)
        {

            MainWindow main = Application.Current.Windows.OfType<MainWindow>().First();

            main.Close();

            Close();

        }


    }
}
