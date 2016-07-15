using BasicWpfMVVM.Base;
using BasicWpfMVVM.ViewModel;

namespace BasicWpfMVVM.View
{
    /// <summary>
    /// Interaction logic for B1Floor0View.xaml
    /// </summary>
    public partial class B1Floor0View : UserControlBase
    {
        public B1Floor0View()
        {
            InitializeComponent();
        }

        public B1Floor0ViewModel ViewModel
        {
            get
            {
                return (B1Floor0ViewModel)DataContext;
            }
        }
    }
}
