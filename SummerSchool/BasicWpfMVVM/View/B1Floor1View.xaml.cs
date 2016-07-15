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
    /// Interaction logic for B1Floor1View.xaml
    /// </summary>
    public partial class B1Floor1View : UserControlBase
    {
        public B1Floor1View()
        {
            InitializeComponent();
        }


        public B1Floor1ViewModel ViewModel
        {
            get
            {
                return (B1Floor1ViewModel)DataContext;
            }
        }
    }
}