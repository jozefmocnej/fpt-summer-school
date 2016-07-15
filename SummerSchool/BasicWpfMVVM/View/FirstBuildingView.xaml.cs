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
    /// Interaction logic for FirstBuildingView.xaml
    /// </summary>
    public partial class FirstBuildingView : UserControlBase
    {
        public FirstBuildingView()
        {
            InitializeComponent();
        }

        public FirstBuildingViewModel ViewModel
        {
            get
            {
                return (FirstBuildingViewModel)DataContext;
            }
        }
    }
}
