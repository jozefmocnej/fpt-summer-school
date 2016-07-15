using BasicWpfMVVM.Base;
using BasicWpfMVVM.Commands;
using BasicWpfMVVM.Model;
using BasicWpfMVVM.Sevices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Services.Client;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWpfMVVM.ViewModel
{
    public class RoomViewModel : ViewModelBase
    {
           private readonly IViewService _viewService;

           private string _RoomView;
           public string RoomView
           {
               get { return _RoomView; }
               set
               {
                   SetProperty(ref _RoomView, value, "RoomView");
               }
           }

           
           public RoomViewModel (IViewService viewService)
           {
               _viewService = viewService;
               InitializeCommands();


               RoomView = Resources.Strings.Resource.Building + ": " + Globals.IdBuilding + " | " + Resources.Strings.Resource.Floor + ": " + Globals.SelectedFloor + " | " + Resources.Strings.Resource.Room + ": " + Globals.IdRoom;
               UpdatePersonsCollection();      
           }

           private ObservableCollection<ZSUMMER_SRV.Person> personsCollection;
           public ObservableCollection<ZSUMMER_SRV.Person> PersonsCollection
           {
               get { return personsCollection; }
               set
               {

                   SetProperty(ref personsCollection, value, "PersonsCollection");
               }
           }

           private void InitializeCommands()
           {
               BackToHome = new DelegateCommand(OnBackToHomeCommandExecute);
               GoBack = new DelegateCommand(OnGoBackCommandExecute);
               SearchToHome = new DelegateCommand(OnSearchToHomeCommandExecute);
               // commands that are used in the view FirstView and its functions
           }

           public DelegateCommand BackToHome { get; private set; }
           public DelegateCommand GoBack { get; set; }
           public DelegateCommand SearchToHome { get; set; }


           private void OnSearchToHomeCommandExecute()
           {
               _viewService.ShowView(Globals.ViewNameSearchView);
           }

           private void OnBackToHomeCommandExecute()
           {
               _viewService.ShowView(Globals.ViewNameHomeView);
           }

           private void OnGoBackCommandExecute()
           {

               _viewService.ShowView(Globals.LastSelectedView);
           }

           private void UpdatePersonsCollection()
           {
               var query = RestCallsService<ZSUMMER_SRV.Person>.GetItemsAsync(x => x.IdBuilding == Globals.IdBuilding && x.IdRoom == Globals.IdRoom);
               query.BeginExecute(onUpdatePersonsCollectionCompleted, query);
           }

           private void onUpdatePersonsCollectionCompleted(IAsyncResult result)
           {
               DataServiceQuery<ZSUMMER_SRV.Person> query =
               result.AsyncState as DataServiceQuery<ZSUMMER_SRV.Person>;

               PersonsCollection = new ObservableCollection<ZSUMMER_SRV.Person>(
                           query.EndExecute(result));
           }

    }
}
