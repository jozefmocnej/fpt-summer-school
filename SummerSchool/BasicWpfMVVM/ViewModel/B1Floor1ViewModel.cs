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
    public class B1Floor1ViewModel : ViewModelBase
    {
        #region  Must Be

           private readonly IViewService _viewService;

           private string _B1Floor1View;
           public string B1Floor1View
           {
               get { return _B1Floor1View; }
               set
               {
                   SetProperty(ref _B1Floor1View, value, "B1Floor1View");
               }
           }

           public B1Floor1ViewModel(IViewService viewService)
           {
               _viewService = viewService;
               InitializeCommands();


               B1Floor1View = Resources.Strings.Resource.Building + ": " + Globals.IdBuilding + " | " + Resources.Strings.Resource.Floor + ": " + Globals.SelectedFloor;
           }
           private void InitializeCommands()
           {
               // commands that are used in the view FirstView and its functions
               BackToHome = new DelegateCommand(OnBackToHomeCommandExecute);
               GoBack = new DelegateCommand(OnGoBackCommandExecute);
               SearchToHome = new DelegateCommand(OnSearchToHomeCommandExecute);
               GoToRoom = new DelegateCommand<string>(OnGoToRoomCommandExecute);

          
           }

           /// <summary>
           /// Define for the button BackToHome
           /// </summary>
           public DelegateCommand BackToHome { get; private set; }
           public DelegateCommand GoBack { get; private set; }
           public DelegateCommand SearchToHome { get; private set; }
           public DelegateCommand<string> GoToRoom { get; set; }

        #endregion

        #region Commands
           private void OnBackToHomeCommandExecute()
           {
               _viewService.ShowView(Globals.ViewNameHomeView);
           }

           private void OnGoBackCommandExecute()
           {
               _viewService.ShowView(Globals.ViewNameSecondBuildingsView);
           }

           private void OnSearchToHomeCommandExecute()
           {
               _viewService.ShowView(Globals.ViewNameSearchView);
           }

           private void OnGoToRoomCommandExecute(string IdRoom)
           {
               Globals.IdRoom = IdRoom;
               _viewService.ShowView(Globals.RoomView);
           }

           #endregion
    }
}
