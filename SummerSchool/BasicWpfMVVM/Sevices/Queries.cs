using BasicWpfMVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWpfMVVM.Sevices
{
    public static class Queries
    {
        //public static IEnumerable<StatisticsModel> GetStatistics(ZSUMMER_SRV.Floor floor)
        //{
        //    var query =
        //        from t in Container.RoomSet
        //        where t.IdBuilding == floor.IdBuilding && t.IdFloor == floor.IdFloor
        //        select t;

        //    var query = RestCallsService<ZSUMMER_SRV.Floor>.

        //    int occupiedSum = 0;
        //    int capacitySum = 0;
        //    int roomsCount = query.Count();
        //    foreach (var item in query)
        //    {
        //        occupiedSum += item.Occupied;
        //        capacitySum += item.Capacity;
        //    }
        //    StatisticsModel model = new StatisticsModel();
        //    model.NumberOfPeople = occupiedSum / roomsCount;
        //    model.NumberOfRooms = roomsCount;
        //    model.Capacity = capacitySum;


        //}
    }
}
