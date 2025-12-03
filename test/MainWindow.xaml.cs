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

namespace ComparerNombres
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Gestionnaire d'événement pour comparer deux nombres
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Variables
            int premierNombre = 0;
            int deuxiemeNombre = 0;

            try
            {
                //Convertir les deux valeurs du textbox en entiers
                premierNombre =  int.Parse(PremiereValeur.Text);
                deuxiemeNombre = int.Parse(DeuxiemeValeur.Text);

                if (premierNombre > deuxiemeNombre)
                {
                    MonLabel.Content = deuxiemeNombre;
                    //MessageBox.Show(deuxiemeNombre.ToString());
                }
                else if (premierNombre < deuxiemeNombre)
                {
                    MonLabel.Content = premierNombre;
                    //MessageBox.Show(premierNombre.ToString());
                }
                else
                {
                    MonLabel.Content = "Les deux nombres sont égaux";
                }

            }
            catch(Exception ex)
            {
                MonLabel.Content = "Les deux valeurs doivent être entières";
            }

            



        }
    }
}
