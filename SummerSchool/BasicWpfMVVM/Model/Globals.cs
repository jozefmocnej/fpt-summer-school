using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWpfMVVM.Model
{
    public class Globals
    {
        public static string ViewNameBuildingsView = "BuildingsView";
        public static string ViewNameFirstView = "FirstView";
        public static string ViewNameSecondView = "SecondView";
        public static string ViewNameB1Floor0View = "B1Floor0View";
        public static string ViewNameB1Floor1View = "B1Floor1View";
        public static string ViewNameHomeView = "HomeView";

        public static string ViewNameFirstBuildingsView = "FirstBuilding";
        public static string ViewNameSecondBuildingsView = "SecondBuilding";

        public static string ViewNameSearchView = "SearchView";
        public static string ViewNameStatisticView = "StatisticView";
        public static string RoomView = "RoomView";
        public static string ViewNameInfoView = "InfoView";


        public static string IdRoom = "";
        public static string SelectedFloor = "";
        public static string IdBuilding = "";

        public static string LastSelectedView { get; set; }
    }
}
