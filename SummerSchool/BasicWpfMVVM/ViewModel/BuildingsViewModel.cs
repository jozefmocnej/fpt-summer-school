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
    public class BuildingsViewModel : ViewModelBase
    {
           #region  Must Be

           private readonly IViewService _viewService;

           public BuildingsViewModel(IViewService viewService)
           {
               _viewService = viewService;
               InitializeCommands();
           }
           private void InitializeCommands()
           {
               // commands that are used in the view FirstView and its functions
               BackToHome = new DelegateCommand(OnBackToHomeCommandExecute);
               SearchToHome = new DelegateCommand(OnSearchToHomeCommandExecute);
               GoBack = new DelegateCommand(OnGoBackCommandExecute);
               OpenMouseClickCommand = new DelegateCommand(OpenMouseClickCommanExecuted, OpenMouseClickCommandCannExecute);
               GoToBuilding1 = new DelegateCommand<string>(OnGoToBuilding1CommanExecuted);
               GoToBuilding2 = new DelegateCommand<string>(OnGoToBuilding2CommanExecuted);
           }

           private void OpenMouseClickCommanExecuted()
           {
                
               //TODO: implemntovat vybratie poschodia
               _viewService.ShowView(Globals.ViewNameFirstBuildingsView);
           }

           private bool OpenMouseClickCommandCannExecute()
           {
               return true;
           }

           private void OnGoBackCommandExecute()
           {
               _viewService.ShowView(Globals.ViewNameHomeView);
           }

           private void OnSearchToHomeCommandExecute()
           {
               //TODO: este spravit a implemnetovat view pre search
               _viewService.ShowView(Globals.ViewNameSearchView);
           }

           private void OnGoToBuilding1CommanExecuted(string IdBuilding)
           {
            Globals.IdBuilding  = IdBuilding;
               //TODO: implemntovat vybratie poschodia
               _viewService.ShowView(Globals.ViewNameFirstBuildingsView);
           }

        private void OnGoToBuilding2CommanExecuted(string IdBuilding)
           {
               Globals.IdBuilding = IdBuilding;
               //TODO: implemntovat vybratie poschodia
               _viewService.ShowView(Globals.ViewNameSecondBuildingsView);
           }


           /// <summary>
           /// Define for the button BackToHome
           /// </summary>
           public DelegateCommand BackToHome { get; private set; }
           public DelegateCommand SearchToHome { get; private set; }
           public DelegateCommand GoBack { get; private set; }
           public DelegateCommand OpenMouseClickCommand { get; private set; }
           public DelegateCommand<string> GoToBuilding1 { get; private set; }
           public DelegateCommand<string> GoToBuilding2 { get; private set; }
        
        #endregion

        #region Commands
           private void OnBackToHomeCommandExecute()
           {
               _viewService.ShowView(Globals.ViewNameHomeView);
           }
        #endregion

    }
}
