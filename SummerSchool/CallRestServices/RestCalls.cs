using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CallRestServices
{
    class RestCalls
    {
        static readonly string uriString = "http://54.169.86.172:8000/sap/opu/odata/SAP/ZSUMMER_SRV/";
        static readonly string username = "trainee06";
        static readonly string password = "school1234";

        ZSUMMER_SRV.ZSUMMER_SRV_Entities container;

        public RestCalls()
        {
            container = new ZSUMMER_SRV.ZSUMMER_SRV_Entities(new Uri(uriString));
            container.Credentials = new NetworkCredential(username, password); 
        }


            //ZSUMMER_SRV.ZSUMMER_SRV_Entities container = new ZSUMMER_SRV.ZSUMMER_SRV_Entities(
            //    new Uri("http://54.169.86.172:8000/sap/opu/odata/SAP/ZSUMMER_SRV/"));
    }
}
