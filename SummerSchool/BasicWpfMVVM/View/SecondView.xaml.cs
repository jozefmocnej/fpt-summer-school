using BasicWpfMVVM.Base;

namespace BasicWpfMVVM.View
{
    /// <summary>
    /// Interaction logic for s.xaml
    /// </summary>
    public partial class SecondView : UserControlBase
    {
        public SecondView()
        {
            InitializeComponent();
        }
        public SecondView ViewModel
        {
            get
            {
                return (SecondView)DataContext;
            }
        }
    }

}
