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

namespace UrbexProject
{
    /// <summary>
    /// Logique d'interaction pour Galerie.xaml
    /// </summary>
    public partial class Galerie : Window
    {
        public string UrlChoisie { get; set; }
        public Galerie()
        {
            InitializeComponent();

            Image1.Source = new BitmapImage(new Uri("Image/ImageGalerie/champ.jpeg", UriKind.Relative));
            Image2.Source = new BitmapImage(new Uri("Image/ImageGalerie/cityByNight.jpg", UriKind.Relative));
            Image3.Source = new BitmapImage(new Uri("Image/ImageGalerie/PontSeul.jpg", UriKind.Relative));
            Image4.Source = new BitmapImage(new Uri("Image/ImageGalerie/tourEffeil.jpg", UriKind.Relative));
        }

        private void Image_1(object sender, RoutedEventArgs e)
        {
            UrlChoisie = "Image/ImageGalerie/champ.jpeg";
            Close();
        }

        private void Image_2(object sender, RoutedEventArgs e)
        {
            UrlChoisie = "Image/ImageGalerie/cityByNight.jpg";
            Close();
        }

        private void Image_3(object sender, RoutedEventArgs e)
        {
            UrlChoisie = "Image/ImageGalerie/PontSeul.jpg";
            Close();
        }

        private void Image_4(object sender, RoutedEventArgs e)
        {
            UrlChoisie = "Image/ImageGalerie/tourEffeil.jpg";
            Close();
        }
    }
}
