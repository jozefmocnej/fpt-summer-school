using BasicWpfMVVM.Base;
using BasicWpfMVVM.ViewModel;
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

namespace BasicWpfMVVM.View
{
    /// <summary>
    /// Interaction logic for BuildingsView.xaml
    /// </summary>
    public partial class BuildingsView : UserControlBase
    {
        public BuildingsView()
        {
            InitializeComponent();
        }

        public BuildingsViewModel ViewModel
        {
            get
            {
                return (BuildingsViewModel)DataContext;
            }
        }

        private void Building1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
