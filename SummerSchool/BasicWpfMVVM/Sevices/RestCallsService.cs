using BasicWpfMVVM.Model;
using System;
using System.Collections.Generic;
using System.Data.Services.Client;
using System.Linq;
using System.Linq.Expressions;
using System.Net;

namespace BasicWpfMVVM.Sevices
{
    public static class RestCallsService<T>
    {
        static readonly string uriString = "http://54.169.86.172:8000/sap/opu/odata/SAP/ZSUMMER_SRV/";
        static readonly string username = "trainee06";
        static readonly string password = "school1234";

        private static ZSUMMER_SRV.ZSUMMER_SRV_Entities container;
        private static ZSUMMER_SRV.ZSUMMER_SRV_Entities Container
        {
            get
            {
                if (container == null)
                {
                    container = new ZSUMMER_SRV.ZSUMMER_SRV_Entities(new Uri(uriString));
                    container.Credentials = new NetworkCredential(username, password);
                }

                return container;
            }
        }

        private static string entitySetName;
        private static string EntitySetName
        {
            get
            {
                if (entitySetName == null)
                {
                    entitySetName = typeof(T).Name + "Set";
                }

                return entitySetName;
            }
        }

        public static IQueryable<T> GetItems(Expression<Func<T, bool>> predicate)
        {
            return Container.CreateQuery<T>(EntitySetName).Where(predicate);
        }

        public static IQueryable<T> GetItems()
        {
            return Container.CreateQuery<T>(EntitySetName);
        }

        public static DataServiceQuery<T> GetItemsAsync(Expression<Func<T, bool>> predicate)
        {
            return (DataServiceQuery<T>)(Container.CreateQuery<T>(EntitySetName).Where(predicate));
        }

        public static DataServiceQuery<T> GetItemsAsync()
        {
            return Container.CreateQuery<T>(EntitySetName);
        }

       

    }
}
