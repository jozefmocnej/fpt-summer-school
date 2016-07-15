using BasicWpfMVVM.Base;
using BasicWpfMVVM.Commands;
using BasicWpfMVVM.Model;
using BasicWpfMVVM.View;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace BasicWpfMVVM.ViewModel
{
    public class SecondViewModel : ViewModelBase
    {
        private readonly IViewService _viewService;
        private string _textSecondView;
        public string TextSecondView
        {
            get { return _textSecondView; }
            set
            {

                SetProperty(ref _textSecondView, value, "TextSecondView");
            }
        }

        public SecondViewModel(IViewService viewService)
        {
            _viewService = viewService;
            InitializeCommands();
        }
        private void InitializeCommands()
        {
            BackToHome = new DelegateCommand(OnBackToHomeCommandExecute, OnBackToHomeCommandCanExecute);

            NavigateHome = new DelegateCommand(OnNavigateCommandExecute, OnNavigateCommandCanExecute);
            OpenMouseClickCommand = new DelegateCommand(OpenMouseClickCommandExecute);      
        }

        private void OpenMouseClickCommandExecute()
        {
            TextSecondView = "Stalcil som prave tlacidlo";
        }
 

        private bool OnBackToHomeCommandCanExecute()
        {
            return true;
        }

        private void OnBackToHomeCommandExecute()
        {
            _viewService.ShowView("FirstView");
        }

        private bool OnNavigateCommandCanExecute()
        {
            return true;
        }

        private void OnNavigateCommandExecute()
        {

            TextSecondView = " som v druhom view";
            _viewService.ShowView(Globals.ViewNameBuildingsView);
        }
        public DelegateCommand BackToHome { get; private set; }
        public DelegateCommand NavigateHome { get; private set; }
        public DelegateCommand OpenMouseClickCommand { get; private set; }


      
    }

}
