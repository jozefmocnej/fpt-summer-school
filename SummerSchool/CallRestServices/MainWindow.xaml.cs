using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CallRestServices
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ZSUMMER_SRV.ZSUMMER_SRV_Entities container = new ZSUMMER_SRV.ZSUMMER_SRV_Entities(
                new Uri("http://54.169.86.172:8000/sap/opu/odata/SAP/ZSUMMER_SRV/"));
            
            //Create an instance of the CredentialCache class.
            //CredentialCache cache = new CredentialCache();

            //// Add a NetworkCredential instance to CredentialCache.
            //// Negotiate for NTLM or Kerberos authentication.
            //cache.Add(container.BaseUri, "Basic" ,new NetworkCredential("trainee06", "school1234")); 
            ////Assign CredentialCache to the Web service Client Proxy(myProxy) Credetials property.
            //container.Credentials = cache;

            container.Credentials = new NetworkCredential("trainee06", "school1234"); 

            var buildingsQuery = from t in container.BuildingSet                                 
                                 where t.IdBuilding == "JT6"
                                 select t;

            foreach (var item in buildingsQuery)
            {
                
            }


            var quert = from t in container.BuildingSet select t;

            foreach (var item in quert)
            {
                
            }

        }
    }
}
