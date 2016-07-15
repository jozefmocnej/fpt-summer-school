using BasicWpfMVVM.Authentication;
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
    public class SearchViewModel : ViewModelBase
    {
        #region  Must Be

        private readonly IViewService _viewService;

        public SearchViewModel(IViewService viewService)
        {
            _viewService = viewService;
            InitializeCommands();

            UpdateBuildingComoboBox();
        }



        private void InitializeCommands()
        {
            // commands that are used in the view FirstView and its functions
            BackToHome = new DelegateCommand(OnBackToHomeCommandExecute);
            GoBack = new DelegateCommand(OnGoBackCommandExecute);
            //SearchRoom = new DelegateCommand(OnSearchRoomCommandExecute);
            SearchPerson = new DelegateCommand(OnSearchPersonCommandExecute);
        }





        /// <summary>
        /// Define for the button BackToHome
        /// </summary>
        public DelegateCommand BackToHome { get; private set; }
        public DelegateCommand GoBack { get; private set; }
        //public DelegateCommand SearchRoom { get; private set; }
        public DelegateCommand SearchPerson { get; private set; }


        #endregion

        #region  Properties

        private ObservableCollection<ZSUMMER_SRV.Person> personsCollection;
        public ObservableCollection<ZSUMMER_SRV.Person> PersonsCollection
        {
            get { return personsCollection; }
            set
            {

                SetProperty(ref personsCollection, value, "PersonsCollection");
            }
        }

        private ObservableCollection<ZSUMMER_SRV.Building> buildingsComboBox;
        public ObservableCollection<ZSUMMER_SRV.Building> BuildingsComboBox
        {
            get { return buildingsComboBox; }
            set
            {

                SetProperty(ref buildingsComboBox, value, "BuildingsComboBox");
            }
        }

        private ObservableCollection<ZSUMMER_SRV.Floor> floorsComboBox;
        public ObservableCollection<ZSUMMER_SRV.Floor> FloorsComboBox
        {
            get { return floorsComboBox; }
            set
            {

                SetProperty(ref floorsComboBox, value, "FloorsComboBox");
            }
        }

        private ObservableCollection<ZSUMMER_SRV.Room> roomsComboBox;
        public ObservableCollection<ZSUMMER_SRV.Room> RoomsComboBox
        {
            get { return roomsComboBox; }
            set
            {

                SetProperty(ref roomsComboBox, value, "RoomsComboBox");
            }
        }

        private ZSUMMER_SRV.Building selectedBuilding;

        public ZSUMMER_SRV.Building SelectedBuilding
        {
            get { return selectedBuilding; }
            set
            {
                selectedBuilding = value;
                //OnPropertyChanged("SelectedBuilding");

                UpdateFloorComoboBox(selectedBuilding);
            }
        }

        private ZSUMMER_SRV.Floor selectedFloor;

        public ZSUMMER_SRV.Floor SelectedFloor
        {
            get { return selectedFloor; }
            set
            {
                selectedFloor = value;
                //OnPropertyChanged("SelectedBuilding");
                UpdateRoomComoboBox(selectedFloor);
            }
        }

        private ZSUMMER_SRV.Room selectedRoom;

        public ZSUMMER_SRV.Room SelectedRoom
        {
            get { return selectedRoom; }
            set
            {
                selectedRoom = value;
            }
        }

        private string firstNameTextBox;
        public string FirstNameTextBox
        {
            get { return firstNameTextBox; }
            set
            {

                SetProperty(ref firstNameTextBox, value, "FirstNameTextBox");
            }
        }

        private string lastNameTextBox;
        public string LastNameTextBox
        {
            get { return lastNameTextBox; }
            set
            {

                SetProperty(ref lastNameTextBox, value, "LastNameTextBox");
            }
        }

        #endregion

        #region Update ComboBoxes
        private void UpdateBuildingComoboBox()
        {
            var query = RestCallsService<ZSUMMER_SRV.Building>.GetItemsAsync();
            query.BeginExecute(OnBuildingQueryCompleted, query);
        }

        private void UpdateFloorComoboBox(ZSUMMER_SRV.Building building)
        {
            if (building == null || building.IdBuilding == "")
            {
                FloorsComboBox = new ObservableCollection<ZSUMMER_SRV.Floor>(new List<ZSUMMER_SRV.Floor>{
                    new ZSUMMER_SRV.Floor { IdFloor = "" } });
            }
            else
            {
                var query = RestCallsService<ZSUMMER_SRV.Floor>.GetItemsAsync(x => x.IdBuilding == building.IdBuilding);
                query.BeginExecute(OnFloorQueryCompleted, query);
            }
        }

        private void UpdateRoomComoboBox(ZSUMMER_SRV.Floor floor)
        {
            if (floor == null || floor.IdFloor == "")
            {
                RoomsComboBox = new ObservableCollection<ZSUMMER_SRV.Room>(new List<ZSUMMER_SRV.Room>{
                    new ZSUMMER_SRV.Room { IdRoom = "" } });
            }
            else
            {
                var query = RestCallsService<ZSUMMER_SRV.Room>.GetItemsAsync(x => x.IdFloor == floor.IdFloor);
                query.BeginExecute(OnRoomQueryCompleted, query);
            }

        }

        #endregion


        #region Commands
        private void OnBackToHomeCommandExecute()
        {
            _viewService.ShowView(Globals.ViewNameHomeView);
        }

        private void OnGoBackCommandExecute()
        {
            _viewService.ShowView(Globals.ViewNameHomeView);
        }

        private void OnSearchPersonCommandExecute()
        {
            //RestCallsService
            var query = RestCallsService<ZSUMMER_SRV.Person>.GetItems();

            if (SelectedBuilding != null && SelectedBuilding.IdBuilding != "")
            {
                query = query.Where(x => x.IdBuilding == SelectedBuilding.IdBuilding);
            }

            if (SelectedFloor != null && SelectedFloor.IdFloor != "")
            {
                query = query.Where(x => x.IdFloor == SelectedFloor.IdFloor);

            }

            if (SelectedRoom != null && SelectedRoom.IdRoom != "")
            {
                query = query.Where(x => x.IdRoom == SelectedRoom.IdRoom);
            }

            if (!String.IsNullOrWhiteSpace(FirstNameTextBox))
            {
                query = query.Where(x => x.FirstName.StartsWith(FirstNameTextBox));
            }
            if (!String.IsNullOrWhiteSpace(LastNameTextBox))
            {
                query = query.Where(x => x.LastName.StartsWith(LastNameTextBox));
            }
            ((DataServiceQuery<ZSUMMER_SRV.Person>)query).BeginExecute(OnQueryCompleted, query);


            //RestCallsService<ZSUMMER_SRV.Room>.GetItemsAsync(x=> x.)
        }

        //private void OnSearchRoomCommandExecute()
        //{
        //    //var test = RestCallsService<ZSUMMER_SRV.Person>.GetItems().AsEnumerable();
        //    //PersonsCollection = new ObservableCollection<ZSUMMER_SRV.Person>(test);

        //    var query = RestCallsService<ZSUMMER_SRV.Person>.GetItemsAsync();
        //    query.BeginExecute(OnQueryCompleted, query);
        //}
        #endregion

        private void OnBuildingQueryCompleted(IAsyncResult result)
        {
            DataServiceQuery<ZSUMMER_SRV.Building> query =
               result.AsyncState as DataServiceQuery<ZSUMMER_SRV.Building>;

            BuildingsComboBox = new ObservableCollection<ZSUMMER_SRV.Building>(
                        query.EndExecute(result));
            BuildingsComboBox.Insert(0, new ZSUMMER_SRV.Building { IdBuilding = "" });
        }

        private void OnFloorQueryCompleted(IAsyncResult result)
        {
            DataServiceQuery<ZSUMMER_SRV.Floor> query =
               result.AsyncState as DataServiceQuery<ZSUMMER_SRV.Floor>;

            FloorsComboBox = new ObservableCollection<ZSUMMER_SRV.Floor>(
                        query.EndExecute(result));
            FloorsComboBox.Insert(0, new ZSUMMER_SRV.Floor { IdFloor = "" });
        }

        private void OnRoomQueryCompleted(IAsyncResult result)
        {
            DataServiceQuery<ZSUMMER_SRV.Room> query =
               result.AsyncState as DataServiceQuery<ZSUMMER_SRV.Room>;

            RoomsComboBox = new ObservableCollection<ZSUMMER_SRV.Room>(
                        query.EndExecute(result));
            RoomsComboBox.Insert(0, new ZSUMMER_SRV.Room { IdRoom = "" });
        }

        private void OnQueryCompleted(IAsyncResult result)
        {

            DataServiceQuery<ZSUMMER_SRV.Person> query =
               result.AsyncState as DataServiceQuery<ZSUMMER_SRV.Person>;

            PersonsCollection = new ObservableCollection<ZSUMMER_SRV.Person>(
                        query.EndExecute(result));

            //foreach (ZSUMMER_SRV.Floor floor in query.EndExecute(result))
            //{
            //    Console.WriteLine("Id Floor: {0}", floor.IdFloor);
            //}


            //// Get the original query object from the state cache.
            //DataServiceQuery<ZSUMMER_SRV.Room> query =
            //       (DataServiceQuery<ZSUMMER_SRV.Room>)result.AsyncState;


            //// Use the Dispatcher to ensure that the query returns in the UI thread.
            //this.Dispatcher.BeginInvoke(new OperationResultCallback(delegate
            //{
            //    try
            //    {
            //        // Instantiate the binding collection using the 
            //        // results of the query execution.
            //        customerBinding = new DataServiceCollection<Customer>(
            //            query.EndExecute(result));

            //        // Bind the collection to the root element of the UI.
            //        this.LayoutRoot.DataContext = customerBinding;
            //    }
            //    catch (DataServiceRequestException ex)
            //    {
            //        MessageBox.Show(ex.ToString());
            //    }
            //}), null);
        }


    }

}
