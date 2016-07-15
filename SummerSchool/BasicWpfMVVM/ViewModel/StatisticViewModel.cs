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
    public class StatisticViewModel : ViewModelBase
    {
        #region  Must Be

        private readonly IViewService _viewService;

        public StatisticViewModel(IViewService viewService)
        {
            _viewService = viewService;
            InitializeCommands();
            UpdateBuildingComoboBox();
        }
        private void InitializeCommands()
        {
            // commands that are used in the view FirstView and its functions
            BackToHome = new DelegateCommand(OnBackToHomeCommandExecute);
            SearchToHome = new DelegateCommand(OnSearchToHomeCommandExecute);
            GoBack = new DelegateCommand(OnGoBackCommandExecute);
            SearchPerson = new DelegateCommand(OnSearchPersonCommandExecute);
            
        }

        private void OpenMouseClickCommanExecuted()
        {

            //TODO: implemntovat vybratie poschodia
            _viewService.ShowView(Globals.ViewNameStatisticView);
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

        private void OnGoToBuilding1CommanExecuted()
        {

            //TODO: implemntovat vybratie poschodia
            _viewService.ShowView(Globals.ViewNameFirstBuildingsView);
        }

        private void OnGoToBuilding2CommanExecuted()
        {

            //TODO: implemntovat vybratie poschodia
            _viewService.ShowView(Globals.ViewNameSecondBuildingsView);
        }


        /// <summary>
        /// Define for the button BackToHome
        /// </summary>
        public DelegateCommand BackToHome { get; private set; }
        public DelegateCommand SearchToHome { get; private set; }
        public DelegateCommand GoBack { get; private set; }
        
        public DelegateCommand SearchPerson { get; private set; }

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
            set { selectedFloor = value; }
        }

        private string numOfPeopleTextBlock;
        public string NumOfPeopleTextBlock
        {
            get { return numOfPeopleTextBlock; }
            set
            {

                SetProperty(ref numOfPeopleTextBlock, value, "NumOfPeopleTextBlock");
            }
        }

        private string numOfPeopleValueTextBlock;
        public string NumOfPeopleValueTextBlock
        {
            get { return numOfPeopleValueTextBlock; }
            set
            {

                SetProperty(ref numOfPeopleValueTextBlock, value, "NumOfPeopleValueTextBlock");
            }
        }

        private string numOfRoomsTextBlock;
        public string NumOfRoomsTextBlock
        {
            get { return numOfRoomsTextBlock; }
            set
            {

                SetProperty(ref numOfRoomsTextBlock, value, "NumOfRoomsTextBlock");
            }
        }

        private string numOfRoomsValueTextBlock;
        public string NumOfRoomsValueTextBlock
        {
            get { return numOfRoomsValueTextBlock; }
            set
            {

                SetProperty(ref numOfRoomsValueTextBlock, value, "NumOfRoomsValueTextBlock");
            }
        }

        private string capacityTextBlock;
        public string CapacityTextBlock
        {
            get { return capacityTextBlock; }
            set
            {

                SetProperty(ref capacityTextBlock, value, "CapacityTextBlock");
            }
        }

        private string capacityValueTextBlock;
        public string CapacityValueTextBlock
        {
            get { return capacityValueTextBlock; }
            set
            {

                SetProperty(ref capacityValueTextBlock, value, "CapacityValueTextBlock");
            }
        }

        #endregion

        #region Commands
        private void OnBackToHomeCommandExecute()
        {
            _viewService.ShowView(Globals.ViewNameHomeView);
        }
        #endregion

        public Action OnGoToStatistic { get; set; }



        private void UpdateBuildingComoboBox()
        {
            var query = RestCallsService<ZSUMMER_SRV.Building>.GetItemsAsync();
            query.BeginExecute(OnBuildingQueryCompleted, query);
        }

        private void UpdateFloorComoboBox(ZSUMMER_SRV.Building building)
        {
            var query = RestCallsService<ZSUMMER_SRV.Floor>.GetItemsAsync(x => x.IdBuilding == building.IdBuilding);
            query.BeginExecute(OnFloorQueryCompleted, query);
        }

        private void OnBuildingQueryCompleted(IAsyncResult result)
        {
            DataServiceQuery<ZSUMMER_SRV.Building> query =
               result.AsyncState as DataServiceQuery<ZSUMMER_SRV.Building>;

            BuildingsComboBox = new ObservableCollection<ZSUMMER_SRV.Building>(
                        query.EndExecute(result));
            //BuildingsComboBox.Insert(0, new ZSUMMER_SRV.Building { IdBuilding = "" });
        }

        private void OnFloorQueryCompleted(IAsyncResult result)
        {
            DataServiceQuery<ZSUMMER_SRV.Floor> query =
               result.AsyncState as DataServiceQuery<ZSUMMER_SRV.Floor>;

            FloorsComboBox = new ObservableCollection<ZSUMMER_SRV.Floor>(
                        query.EndExecute(result));
            FloorsComboBox.Insert(0, new ZSUMMER_SRV.Floor { IdFloor = "" });
        }

        private void OnSearchPersonCommandExecute()
        {
            //RestCallsService
            var query = RestCallsService<ZSUMMER_SRV.Room>.GetItems();

            if (SelectedBuilding != null && SelectedBuilding.IdBuilding != "")
            {
                query = query.Where(x => x.IdBuilding == SelectedBuilding.IdBuilding);
            }

            if (SelectedFloor != null && SelectedFloor.IdFloor != "")
            {
                query = query.Where(x => x.IdFloor == SelectedFloor.IdFloor);

                NumOfPeopleTextBlock = Resources.Strings.Resource.NumOfPeopleOnFloor + ":";
                NumOfRoomsTextBlock = Resources.Strings.Resource.NumOfRoomsOnFloor + ":";
                CapacityTextBlock = Resources.Strings.Resource.FloorCapacity + ":";
            } else
            {
                NumOfPeopleTextBlock = Resources.Strings.Resource.NumOfPeopleInBuilding + ":";
                NumOfRoomsTextBlock = Resources.Strings.Resource.NumOfRoomsInBuilding + ":";
                CapacityTextBlock = Resources.Strings.Resource.BuildingCapacity + ":";
            }
            ((DataServiceQuery<ZSUMMER_SRV.Room>)query).BeginExecute(OnQueryCompleted, query);

            //RestCallsService<ZSUMMER_SRV.Room>.GetItemsAsync(x=> x.)
        }

        private void OnQueryCompleted(IAsyncResult result)
        {
            DataServiceQuery<ZSUMMER_SRV.Room> query =
               result.AsyncState as DataServiceQuery<ZSUMMER_SRV.Room>;

            var collection = new ObservableCollection<ZSUMMER_SRV.Room>(
                        query.EndExecute(result));

            //StatisticsModel model = new StatisticsModel();
            NumOfPeopleValueTextBlock = collection.Sum(x => x.Occupied).ToString();
            NumOfRoomsValueTextBlock = collection.Count().ToString();
            CapacityValueTextBlock = collection.Sum(x => x.Capacity).ToString();

            //int occupiedSum = 0;
            //int capacitySum = 0;
            //int roomsCount = collection.Count();
            //foreach (var item in collection)
            //{
            //    occupiedSum += item.Occupied;
            //    capacitySum += item.Capacity;
            //}

            //model.NumberOfPeople = occupiedSum;
            //model.NumberOfRooms = roomsCount;
            //model.Capacity = capacitySum;
        }
    }
}
