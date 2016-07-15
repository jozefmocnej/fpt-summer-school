using BasicWpfMVVM.Base;
using BasicWpfMVVM.Commands;
using BasicWpfMVVM.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace BasicWpfMVVM.ViewModel
{
    public class HomeViewModel : ViewModelBase
    {
        #region  Must Be

        private readonly IViewService _viewService;

        #region timedisplay
      
        public HomeViewModel(IViewService viewService)
        {
            _viewService = viewService;
            InitializeCommands();
            GetCurrentDateTime();
        }
        private void InitializeCommands()
        {
            // commands that are used in the view FirstView and its functions
            GoToNavigation = new DelegateCommand(OnGoToNavigationCommandExecute, OnGoToNavigationCommandCanExecute);
            GoToSearch = new DelegateCommand(OnGoToSearchCommandExecute, OnGoToSearchCommandCanExecute);
            changeLanguage = new DelegateCommand<string>(LanguageCommandExecute);
            GoToStatistic = new DelegateCommand(GoToStatisticCommandExecute);
            GoToInfo = new DelegateCommand(GoToInfoCommandExecute);
        }



        private void LanguageCommandExecute(string language)
        {
            CultureInfo ci = new CultureInfo(language);
            Thread.CurrentThread.CurrentUICulture = ci;
            _viewService.ShowView(Globals.ViewNameHomeView);
        }

        private bool OnGoToNavigationCommandCanExecute()
        {
            return true;
        }


        /// <summary>
        /// Define for the button BackToHome
        /// </summary>
        public DelegateCommand GoToNavigation { get; private set; }
        /// <summary>
        /// Define for the button Navigate
        /// </summary>
        public DelegateCommand GoToSearch { get; private set; }
        public DelegateCommand<string> changeLanguage { get; private set; }
        public DelegateCommand GoToStatistic { get; private set; }
        public DelegateCommand GoToInfo { get; private set; }

        #endregion


        #region Commands

        private void GoToStatisticCommandExecute()
        {
            _viewService.ShowView(Globals.ViewNameStatisticView);
        }
        private void GoToInfoCommandExecute()
        {
            _viewService.ShowView(Globals.ViewNameInfoView);
        }

        private void OnGoToNavigationCommandExecute()
        {
            _viewService.ShowView(Globals.ViewNameBuildingsView);
        }

        private bool OnGoToSearchCommandCanExecute()
        {
            return true;
        }

        private void OnGoToSearchCommandExecute()
        {
            _viewService.ShowView(Globals.ViewNameSearchView);
        }

        //private void OnGoToHomeCommandExecute()
        //{
        //    //TODO: este spravit a implemnetovat view pre search
        //    _viewService.ShowView(Globals.ViewNameSearchView);
        //}

        //private bool OnGoToHomeCommandCanExecute()
        //{
        //    return true;
        //}



        //private void languageCommandExecute()
        //{

        //}
        #endregion

        public string GetCurrentDateTime()
        {
            try
            {
                DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
                dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
                dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
                dispatcherTimer.Start();

                return CurrentDateTime;

            }
            catch
            {
                return CurrentDateTime;
            }
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            // Updating the Label which displays the current second
            CurrentDateTime = DateTime.Now.ToString(" HH:mm:ss");

        }
        private string _currentDateTime;
        public string CurrentDateTime
        {
            get
            {
                return _currentDateTime;
            }
            set
            {
                if (value != _currentDateTime)
                {
                    _currentDateTime = value;
                    OnPropertyChanged("CurrentDateTime");
                }
            }
        }

        #endregion
    }
}
