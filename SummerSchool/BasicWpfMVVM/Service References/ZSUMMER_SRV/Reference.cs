//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Original file name:
// Generation date: 14.07.2016 10:48:23
namespace BasicWpfMVVM.ZSUMMER_SRV
{
    
    /// <summary>
    /// There are no comments for ZSUMMER_SRV_Entities in the schema.
    /// </summary>
    public partial class ZSUMMER_SRV_Entities : global::System.Data.Services.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new ZSUMMER_SRV_Entities object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public ZSUMMER_SRV_Entities(global::System.Uri serviceRoot) : 
                base(serviceRoot)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            global::System.Type resolvedType = this.DefaultResolveType(typeName, "ZSUMMER_SRV", "BasicWpfMVVM.ZSUMMER_SRV");
            if ((resolvedType != null))
            {
                return resolvedType;
            }
            return null;
        }
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            if (clientType.Namespace.Equals("BasicWpfMVVM.ZSUMMER_SRV", global::System.StringComparison.Ordinal))
            {
                return string.Concat("ZSUMMER_SRV.", clientType.Name);
            }
            return null;
        }
        /// <summary>
        /// There are no comments for RoomSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Room> RoomSet
        {
            get
            {
                if ((this._RoomSet == null))
                {
                    this._RoomSet = base.CreateQuery<Room>("RoomSet");
                }
                return this._RoomSet;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Room> _RoomSet;
        /// <summary>
        /// There are no comments for FloorSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Floor> FloorSet
        {
            get
            {
                if ((this._FloorSet == null))
                {
                    this._FloorSet = base.CreateQuery<Floor>("FloorSet");
                }
                return this._FloorSet;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Floor> _FloorSet;
        /// <summary>
        /// There are no comments for PersonSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Person> PersonSet
        {
            get
            {
                if ((this._PersonSet == null))
                {
                    this._PersonSet = base.CreateQuery<Person>("PersonSet");
                }
                return this._PersonSet;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Person> _PersonSet;
        /// <summary>
        /// There are no comments for BuildingSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Building> BuildingSet
        {
            get
            {
                if ((this._BuildingSet == null))
                {
                    this._BuildingSet = base.CreateQuery<Building>("BuildingSet");
                }
                return this._BuildingSet;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Building> _BuildingSet;
        /// <summary>
        /// There are no comments for RoomSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToRoomSet(Room room)
        {
            base.AddObject("RoomSet", room);
        }
        /// <summary>
        /// There are no comments for FloorSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToFloorSet(Floor floor)
        {
            base.AddObject("FloorSet", floor);
        }
        /// <summary>
        /// There are no comments for PersonSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToPersonSet(Person person)
        {
            base.AddObject("PersonSet", person);
        }
        /// <summary>
        /// There are no comments for BuildingSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToBuildingSet(Building building)
        {
            base.AddObject("BuildingSet", building);
        }
    }
    /// <summary>
    /// There are no comments for ZSUMMER_SRV.Building in the schema.
    /// </summary>
    /// <KeyProperties>
    /// IdBuilding
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("BuildingSet")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("IdBuilding")]
    public partial class Building : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Building object.
        /// </summary>
        /// <param name="idBuilding">Initial value of IdBuilding.</param>
        /// <param name="description">Initial value of Description.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Building CreateBuilding(string idBuilding, string description)
        {
            Building building = new Building();
            building.IdBuilding = idBuilding;
            building.Description = description;
            return building;
        }
        /// <summary>
        /// There are no comments for Property IdBuilding in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string IdBuilding
        {
            get
            {
                return this._IdBuilding;
            }
            set
            {
                this.OnIdBuildingChanging(value);
                this._IdBuilding = value;
                this.OnIdBuildingChanged();
                this.OnPropertyChanged("IdBuilding");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _IdBuilding;
        partial void OnIdBuildingChanging(string value);
        partial void OnIdBuildingChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for ToFloorSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceCollection<Floor> ToFloorSet
        {
            get
            {
                return this._ToFloorSet;
            }
            set
            {
                this._ToFloorSet = value;
                this.OnPropertyChanged("ToFloorSet");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceCollection<Floor> _ToFloorSet = new global::System.Data.Services.Client.DataServiceCollection<Floor>(null, global::System.Data.Services.Client.TrackingMode.None);
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for ZSUMMER_SRV.Room in the schema.
    /// </summary>
    /// <KeyProperties>
    /// IdRoom
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("RoomSet")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("IdRoom")]
    public partial class Room : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Room object.
        /// </summary>
        /// <param name="idRoom">Initial value of IdRoom.</param>
        /// <param name="idBuilding">Initial value of IdBuilding.</param>
        /// <param name="occupied">Initial value of Occupied.</param>
        /// <param name="idFloor">Initial value of IdFloor.</param>
        /// <param name="capacity">Initial value of Capacity.</param>
        /// <param name="description">Initial value of Description.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Room CreateRoom(string idRoom, string idBuilding, short occupied, string idFloor, short capacity, string description)
        {
            Room room = new Room();
            room.IdRoom = idRoom;
            room.IdBuilding = idBuilding;
            room.Occupied = occupied;
            room.IdFloor = idFloor;
            room.Capacity = capacity;
            room.Description = description;
            return room;
        }
        /// <summary>
        /// There are no comments for Property IdRoom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string IdRoom
        {
            get
            {
                return this._IdRoom;
            }
            set
            {
                this.OnIdRoomChanging(value);
                this._IdRoom = value;
                this.OnIdRoomChanged();
                this.OnPropertyChanged("IdRoom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _IdRoom;
        partial void OnIdRoomChanging(string value);
        partial void OnIdRoomChanged();
        /// <summary>
        /// There are no comments for Property IdBuilding in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string IdBuilding
        {
            get
            {
                return this._IdBuilding;
            }
            set
            {
                this.OnIdBuildingChanging(value);
                this._IdBuilding = value;
                this.OnIdBuildingChanged();
                this.OnPropertyChanged("IdBuilding");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _IdBuilding;
        partial void OnIdBuildingChanging(string value);
        partial void OnIdBuildingChanged();
        /// <summary>
        /// There are no comments for Property Occupied in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public short Occupied
        {
            get
            {
                return this._Occupied;
            }
            set
            {
                this.OnOccupiedChanging(value);
                this._Occupied = value;
                this.OnOccupiedChanged();
                this.OnPropertyChanged("Occupied");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private short _Occupied;
        partial void OnOccupiedChanging(short value);
        partial void OnOccupiedChanged();
        /// <summary>
        /// There are no comments for Property IdFloor in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string IdFloor
        {
            get
            {
                return this._IdFloor;
            }
            set
            {
                this.OnIdFloorChanging(value);
                this._IdFloor = value;
                this.OnIdFloorChanged();
                this.OnPropertyChanged("IdFloor");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _IdFloor;
        partial void OnIdFloorChanging(string value);
        partial void OnIdFloorChanged();
        /// <summary>
        /// There are no comments for Property Capacity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public short Capacity
        {
            get
            {
                return this._Capacity;
            }
            set
            {
                this.OnCapacityChanging(value);
                this._Capacity = value;
                this.OnCapacityChanged();
                this.OnPropertyChanged("Capacity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private short _Capacity;
        partial void OnCapacityChanging(short value);
        partial void OnCapacityChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for ToPersonSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceCollection<Person> ToPersonSet
        {
            get
            {
                return this._ToPersonSet;
            }
            set
            {
                this._ToPersonSet = value;
                this.OnPropertyChanged("ToPersonSet");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceCollection<Person> _ToPersonSet = new global::System.Data.Services.Client.DataServiceCollection<Person>(null, global::System.Data.Services.Client.TrackingMode.None);
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for ZSUMMER_SRV.Floor in the schema.
    /// </summary>
    /// <KeyProperties>
    /// IdFloor
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("FloorSet")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("IdFloor")]
    public partial class Floor : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Floor object.
        /// </summary>
        /// <param name="idFloor">Initial value of IdFloor.</param>
        /// <param name="idBuilding">Initial value of IdBuilding.</param>
        /// <param name="description">Initial value of Description.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Floor CreateFloor(string idFloor, string idBuilding, string description)
        {
            Floor floor = new Floor();
            floor.IdFloor = idFloor;
            floor.IdBuilding = idBuilding;
            floor.Description = description;
            return floor;
        }
        /// <summary>
        /// There are no comments for Property IdFloor in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string IdFloor
        {
            get
            {
                return this._IdFloor;
            }
            set
            {
                this.OnIdFloorChanging(value);
                this._IdFloor = value;
                this.OnIdFloorChanged();
                this.OnPropertyChanged("IdFloor");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _IdFloor;
        partial void OnIdFloorChanging(string value);
        partial void OnIdFloorChanged();
        /// <summary>
        /// There are no comments for Property IdBuilding in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string IdBuilding
        {
            get
            {
                return this._IdBuilding;
            }
            set
            {
                this.OnIdBuildingChanging(value);
                this._IdBuilding = value;
                this.OnIdBuildingChanged();
                this.OnPropertyChanged("IdBuilding");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _IdBuilding;
        partial void OnIdBuildingChanging(string value);
        partial void OnIdBuildingChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for ToRoomSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceCollection<Room> ToRoomSet
        {
            get
            {
                return this._ToRoomSet;
            }
            set
            {
                this._ToRoomSet = value;
                this.OnPropertyChanged("ToRoomSet");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceCollection<Room> _ToRoomSet = new global::System.Data.Services.Client.DataServiceCollection<Room>(null, global::System.Data.Services.Client.TrackingMode.None);
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for ZSUMMER_SRV.Person in the schema.
    /// </summary>
    /// <KeyProperties>
    /// IdPerson
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("PersonSet")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("IdPerson")]
    public partial class Person : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Person object.
        /// </summary>
        /// <param name="idBuilding">Initial value of IdBuilding.</param>
        /// <param name="idPerson">Initial value of IdPerson.</param>
        /// <param name="idFloor">Initial value of IdFloor.</param>
        /// <param name="idRoom">Initial value of IdRoom.</param>
        /// <param name="firstName">Initial value of FirstName.</param>
        /// <param name="lastName">Initial value of LastName.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Person CreatePerson(string idBuilding, int idPerson, string idFloor, string idRoom, string firstName, string lastName)
        {
            Person person = new Person();
            person.IdBuilding = idBuilding;
            person.IdPerson = idPerson;
            person.IdFloor = idFloor;
            person.IdRoom = idRoom;
            person.FirstName = firstName;
            person.LastName = lastName;
            return person;
        }
        /// <summary>
        /// There are no comments for Property IdBuilding in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string IdBuilding
        {
            get
            {
                return this._IdBuilding;
            }
            set
            {
                this.OnIdBuildingChanging(value);
                this._IdBuilding = value;
                this.OnIdBuildingChanged();
                this.OnPropertyChanged("IdBuilding");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _IdBuilding;
        partial void OnIdBuildingChanging(string value);
        partial void OnIdBuildingChanged();
        /// <summary>
        /// There are no comments for Property IdPerson in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int IdPerson
        {
            get
            {
                return this._IdPerson;
            }
            set
            {
                this.OnIdPersonChanging(value);
                this._IdPerson = value;
                this.OnIdPersonChanged();
                this.OnPropertyChanged("IdPerson");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _IdPerson;
        partial void OnIdPersonChanging(int value);
        partial void OnIdPersonChanged();
        /// <summary>
        /// There are no comments for Property IdFloor in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string IdFloor
        {
            get
            {
                return this._IdFloor;
            }
            set
            {
                this.OnIdFloorChanging(value);
                this._IdFloor = value;
                this.OnIdFloorChanged();
                this.OnPropertyChanged("IdFloor");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _IdFloor;
        partial void OnIdFloorChanging(string value);
        partial void OnIdFloorChanged();
        /// <summary>
        /// There are no comments for Property IdRoom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string IdRoom
        {
            get
            {
                return this._IdRoom;
            }
            set
            {
                this.OnIdRoomChanging(value);
                this._IdRoom = value;
                this.OnIdRoomChanged();
                this.OnPropertyChanged("IdRoom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _IdRoom;
        partial void OnIdRoomChanging(string value);
        partial void OnIdRoomChanged();
        /// <summary>
        /// There are no comments for Property FirstName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string FirstName
        {
            get
            {
                return this._FirstName;
            }
            set
            {
                this.OnFirstNameChanging(value);
                this._FirstName = value;
                this.OnFirstNameChanged();
                this.OnPropertyChanged("FirstName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _FirstName;
        partial void OnFirstNameChanging(string value);
        partial void OnFirstNameChanged();
        /// <summary>
        /// There are no comments for Property LastName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string LastName
        {
            get
            {
                return this._LastName;
            }
            set
            {
                this.OnLastNameChanging(value);
                this._LastName = value;
                this.OnLastNameChanged();
                this.OnPropertyChanged("LastName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _LastName;
        partial void OnLastNameChanging(string value);
        partial void OnLastNameChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
}
