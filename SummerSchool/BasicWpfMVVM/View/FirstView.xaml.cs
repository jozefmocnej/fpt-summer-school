using BasicWpfMVVM.Base;
using BasicWpfMVVM.ViewModel;

namespace BasicWpfMVVM.View
{
    /// <summary>
    /// Interaction logic for FirstView.xaml
    /// </summary>
    public partial class FirstView : UserControlBase
    {
        public FirstView()
        {
            InitializeComponent();
        }
        public FirstViewModel ViewModel
        {
            get
            {
                return (FirstViewModel)DataContext;
            }
        }
  
    }
}
