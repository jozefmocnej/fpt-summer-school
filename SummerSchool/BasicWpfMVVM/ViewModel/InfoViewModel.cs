using BasicWpfMVVM.Base;
using BasicWpfMVVM.Commands;
using BasicWpfMVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWpfMVVM.ViewModel
{

    public class InfoViewModel : ViewModelBase
    {
        #region  Must Be

        private readonly IViewService _viewService;

        public InfoViewModel(IViewService viewService)
        {
            _viewService = viewService;
            InitializeCommands();

        }



        private void InitializeCommands()
        {
            // commands that are used in the view FirstView and its functions
            BackToHome = new DelegateCommand(OnBackToHomeCommandExecute);
            GoBack = new DelegateCommand(OnGoBackCommandExecute);
            //SearchRoom = new DelegateCommand(OnSearchRoomCommandExecute);
        }

        private void OnBackToHomeCommandExecute()
        {
            _viewService.ShowView(Globals.ViewNameHomeView);
        }

        private void OnGoBackCommandExecute()
        {

            _viewService.ShowView(Globals.ViewNameHomeView);
        }





        /// <summary>
        /// Define for the button BackToHome
        /// </summary>
        public DelegateCommand BackToHome { get; private set; }
        public DelegateCommand GoBack { get; private set; }
        //public DelegateCommand SearchRoom { get; private set; }


        #endregion
    }
}
