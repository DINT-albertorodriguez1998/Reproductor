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

namespace Reproductor
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Trailer_Checked(object sender, RoutedEventArgs e)
        {
            if((sender as RadioButton).Name == RadioButton_Trailer1.Name)
            {
                MediaElement.Source = new Uri(@"C:\Users\alumno\Desktop\trailer1.mp4");
                MediaElement.Play();
            }
            else
            {
                MediaElement.Source = new Uri(@"C:\Users\alumno\Desktop\trailer2.mp4");
                MediaElement.Play();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((sender as Button).Name == Button_Play.Name)
                MediaElement.Play();
            else if ((sender as Button).Name == Button_Stop.Name)
                MediaElement.Stop();
            else
                MediaElement.Pause();
        }

        private void RadioButton_Sileciar_Checked(object sender, RoutedEventArgs e)
        {
            MediaElement.IsMuted = true;
        }

        private void RadioButton_Sileciar_Unchecked(object sender, RoutedEventArgs e)
        {
            MediaElement.IsMuted = false;
        }
    }
}
