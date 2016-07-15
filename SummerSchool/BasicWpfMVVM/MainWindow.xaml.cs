using BasicWpfMVVM.Base;
using BasicWpfMVVM.Model;
using Microsoft.Practices.Unity;
using System.Windows;

namespace BasicWpfMVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IViewService
    {
        private IUnityContainer _container;
        public MainWindow()
        {
            InitializeComponent();
            _container = ((UnityConfiguration)this.TryFindResource("container")).Container;

            // Register itself as service to switch views.
            _container.RegisterInstance<IViewService>(this);

            ShowView(Globals.ViewNameHomeView);
        }

        public void ShowView(string viewName)
        {
            var view = _container.Resolve<UserControlBase>(viewName);
            clientArea.Content = view;
        }


        public void ShowView(string viewName, object context)
        {
            var view = _container.Resolve<UserControlBase>(viewName);
            view.SetViewModelContext(context);
            clientArea.Content = view;
        }
    }

}
