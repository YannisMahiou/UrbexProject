using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using ClassLibrary;
using System.Collections.ObjectModel;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UrbexProject.UsersControl
{
    /// <summary>
    /// Logique d'interaction pour Histoire.xaml
    /// </summary>
    public partial class Histoire : UserControl
    {
        public static readonly DependencyProperty SujetHistoireProperty = DependencyProperty.Register("SujetHistoire", typeof(Topic), typeof(Histoire));
        public Topic SujetHistoire
        {
            get
            {
                return GetValue(SujetHistoireProperty) as Topic;
            }
            set
            {
                SetValue(SujetHistoireProperty, value);
            }
        }
        public Histoire()
        {
            InitializeComponent();
            rootHistoire.DataContext = this;
        }
    }
}
