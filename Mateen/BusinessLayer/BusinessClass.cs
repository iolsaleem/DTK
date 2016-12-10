using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DALLayer;

namespace BusinessLayer
{
    public class BusinessClass
    {
        DALClass d = new DALClass();

        //public DataTable LoaDDiscountBus()
        //{
        //return  d.Load1();
        //}

        public DataTable BUSLoadServiceType(string Companyxid)
        {
            return d.DALLoadServiceType(Companyxid);
        }


        public DataTable BUSLoadSupplier(string Companyxid)
        {
            return d.DALLoadSupplier(Companyxid);
        }

        public DataTable BUSLoadCountry(string Companyxid)
        {
            return d.DALLoadCountry(Companyxid);
        }

        public DataTable BUSLoadCity(string CountryId)
        {
            return d.DALLoadCity(CountryId);
        }



        public DataTable BUSLoadSupplierServiceList(string ServiceCode, string SelectedServiceType, string ServiceName, string SelectedSupplier, string Country, string City, string Companyxid)
        {
            return d.LoadSupplierServiceList(ServiceCode, SelectedServiceType, ServiceName, SelectedSupplier, Country, City, Companyxid);
        }


    }
}