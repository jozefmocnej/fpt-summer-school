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
    public class SecondBuildingViewModel : ViewModelBase
    {
         #region  Must Be

           private readonly IViewService _viewService;
         
           public SecondBuildingViewModel(IViewService viewService)
           {
               _viewService = viewService;
               InitializeCommands();
           }
           private void InitializeCommands()
           {
               // commands that are used in the view FirstView and its functions
               BackToHome = new DelegateCommand(OnBackToHomeCommandExecute);
               GoBack = new DelegateCommand(OnGoBackCommandExecute);
               OpenMouseClickCommand = new DelegateCommand(OpenMouseClickCommandExecute);
               SearchToHome = new DelegateCommand(OnSearchToHomeCommandExecute);
               GoToFloor = new DelegateCommand<string>(OnGoToFloorCommandExecute);
           }

        
           /// <summary>
           /// Define for the button BackToHome
           /// </summary>
           public DelegateCommand BackToHome { get; private set; }
           public DelegateCommand GoBack { get; private set; }
           public DelegateCommand OpenMouseClickCommand { get; private set; }
           public DelegateCommand SearchToHome { get; private set; }
           public DelegateCommand<string> GoToFloor { get; private set; }

        #endregion

           #region Commands

           private void OnGoToFloorCommandExecute(string SelectedFloor)
           {
               Globals.LastSelectedView = Globals.ViewNameB1Floor1View;
               Globals.SelectedFloor = SelectedFloor;
               //TODO: toto treba zmenit 
               if (SelectedFloor != "4")
               {
                   var context = ViewContext.CreateContext(Globals.ViewNameSecondBuildingsView, true);
                   _viewService.ShowView(Globals.ViewNameFirstView, context);
               }
               else
               {
                   _viewService.ShowView(Globals.ViewNameB1Floor1View);
               }
             

           }
         

           private void OnBackToHomeCommandExecute()
           {
               _viewService.ShowView(Globals.ViewNameHomeView);
           }

           private void OnGoBackCommandExecute()
           {
               _viewService.ShowView(Globals.ViewNameBuildingsView);
           }
           
           private void OpenMouseClickCommandExecute()
           {
               _viewService.ShowView(Globals.ViewNameB1Floor1View);
           }

           private void OnSearchToHomeCommandExecute()
           {
               _viewService.ShowView(Globals.ViewNameSearchView);
           }
           #endregion
    }
}
