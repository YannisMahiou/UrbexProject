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
using ClassLibrary;
using System.Diagnostics;
using System.Windows.Navigation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UrbexProject.UsersControl
{
    /// <summary>
    /// Logique d'interaction pour EnSavoirPlus.xaml
    /// </summary>
    public partial class EnSavoirPlus : UserControl
    {
        public static readonly DependencyProperty ESPPageProperty = DependencyProperty.Register("ESPPage", typeof(Topic), typeof(EnSavoirPlus));
        public Topic ESPPage
        {
            get
            {
                return GetValue(ESPPageProperty) as Topic;
            }
            set
            {
                SetValue(ESPPageProperty, value);
            }
        }
        public EnSavoirPlus()
        {
            InitializeComponent();
            rootESP.DataContext = this;
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
        }
    }
}
