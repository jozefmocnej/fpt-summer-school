using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWpfMVVM.Model
{
    public class ViewContext
    {

        public static ViewContext CreateContext(string goBackToView,bool workInProgress = false, string idBuildig = "", string idFloor = "", string idRoom = "")
        {

           return new ViewContext
            {
                GoBackToView = goBackToView,
                WorkInProgress  = workInProgress ,
                IdBuildig   = idBuildig  ,
                IdFloor  = idFloor ,
                IdRoom  = idRoom 
            };
        }

        public string GoBackToView { get; set; }

        public bool WorkInProgress { get; set; }

        public string IdFloor { get; set; }

        public string IdRoom { get; set; }

        public string IdBuildig { get; set; }
    }
}
