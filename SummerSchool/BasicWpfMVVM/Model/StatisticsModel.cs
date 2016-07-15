using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWpfMVVM.Model
{
    class StatisticsModel
    {
        public int NumberOfPeople { get; set; }
        public int NumberOfRooms { get; set; }
        public int Capacity { get; set; }

        public StatisticsModel()
        {
            NumberOfPeople = 0;
            NumberOfRooms = 0;
            Capacity = 0;
        }
    }
}
