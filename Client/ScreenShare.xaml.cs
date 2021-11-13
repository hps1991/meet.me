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

namespace Client
{
    /// <summary>
    /// Interaction logic for ScreenShare.xaml
    /// </summary>
    public partial class ScreenShare : UserControl
    {
        ScreenVM obj;
        public ScreenShare()
        {
            InitializeComponent();
            obj = new ScreenVM();
            DataContext = obj;
        }
        public void OnClick(object sender, RoutedEventArgs e)
        {
            if (obj.Trial("i"))
                t2.Visibility = System.Windows.Visibility.Visible;
            else
                t2.Visibility = System.Windows.Visibility.Collapsed;
        }
    }
}
