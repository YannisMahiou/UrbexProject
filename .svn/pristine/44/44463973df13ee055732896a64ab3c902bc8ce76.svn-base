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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UrbexProject.UsersControl
{
    /// <summary>
    /// Logique d'interaction pour Regles.xaml
    /// </summary>
    public partial class Regles : UserControl
    {
        public static readonly DependencyProperty ReglesPageProperty = DependencyProperty.Register("ReglesPage", typeof(Topic), typeof(Regles));
        public Topic ReglesPage
        {
            get
            {
                return GetValue(ReglesPageProperty) as Topic;
            }
            set
            {
                SetValue(ReglesPageProperty, value);
            }
        }
        public Regles()
        {
            InitializeComponent();
            rootRegle.DataContext = this;
        }
    }
}
