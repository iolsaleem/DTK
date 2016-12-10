using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace DALLayer

{
    public class DALClass
    {
        private string Conn1 = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;

        DataTable loadServiceType = new DataTable();
        DataTable loadSupplier =    new DataTable();
        DataTable loadCountry =     new DataTable();
        DataTable loadCity = new DataTable();

        DataTable loadSuppierServiceList = new DataTable();

        //Load Dropdown for Service Type on Page SearchSupplierService
        public DataTable DALLoadServiceType(string Companyxid)
        {
            SqlConnection sCon = new SqlConnection(Conn1);
            sCon.Open();
            try
            {
                SqlCommand sCmd = new SqlCommand();
                sCmd.Connection = sCon;
                sCmd.CommandType = CommandType.Text;
                sCmd.CommandText = "Select Pid,ServiceType from M_ServiceType where companyxid = '" + Companyxid + "' order by ServiceType";

                SqlDataReader sDR = sCmd.ExecuteReader();
                loadServiceType.Load(sDR);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error Message" + ex.Message);
            }
            return loadServiceType;
        }

        //Load Dropdown for Supplier on Page SearchSupplierService
        public DataTable DALLoadSupplier(string Companyxid)
        {
            SqlConnection sCon = new SqlConnection(Conn1);
            sCon.Open();
            try
            {
                SqlCommand sCmd = new SqlCommand();
                sCmd.Connection = sCon;
                sCmd.CommandType = CommandType.Text;
                sCmd.CommandText = "select Pid,Supplier from M_Supplier where CompanyXid='" + Companyxid + "' and  status = 'A' order by Supplier ";
                SqlDataReader sDR = sCmd.ExecuteReader();
                loadSupplier.Load(sDR);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Message" + ex.Message);
            }
            return loadSupplier;
        }
        //Load Dropdown for Country on Page SearchSupplierService
        public DataTable DALLoadCountry(string Companyxid)
        {
            SqlConnection sCon = new SqlConnection(Conn1);
            sCon.Open();
            try
            {
                SqlCommand sCmd = new SqlCommand();
                sCmd.Connection = sCon;
                sCmd.CommandType = CommandType.Text;
                sCmd.CommandText = "select Pid,Country from M_Country where CompanyXid='" + Companyxid + "'  order by Country ";
                SqlDataReader sDR = sCmd.ExecuteReader();
                loadCountry.Load(sDR);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Message" + ex.Message);
            }
            return loadCountry;
        }

        //Load Dropdown for City on Page SearchSupplierService
        public DataTable DALLoadCity(string CountryId)
        {
            SqlConnection sCon = new SqlConnection(Conn1);
            sCon.Open();
            try
            {
                SqlCommand sCmd = new SqlCommand();
                sCmd.Connection = sCon;
                sCmd.CommandType = CommandType.Text;
                sCmd.CommandText = "select Pid,City from M_City where CountryXid='" + CountryId + "' order by City ";
                SqlDataReader sDR = sCmd.ExecuteReader();
                loadCity.Load(sDR);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Message" + ex.Message);
            }
            return loadCity;
        }




        public DataTable LoadSupplierServiceList(string ServiceCode, string SelectedServiceType, string ServiceName, string SelectedSupplier, string Country, string City, string Companyxid)
        {
            SqlConnection sCon = new SqlConnection(Conn1);
            sCon.Open();
            try
            {
                SqlCommand sCmd = new SqlCommand();

                sCmd.Connection = sCon;
                sCmd.CommandType = CommandType.StoredProcedure;
                sCmd.CommandText = "Usp_SearchSupplierService";
                sCmd.Parameters.Add("@als_Code", SqlDbType.VarChar).Value = ServiceCode;
                sCmd.Parameters.Add("@als_ServiceType", SqlDbType.VarChar).Value = SelectedServiceType;
                sCmd.Parameters.Add("@als_ServiceName", SqlDbType.VarChar).Value = ServiceName;
                sCmd.Parameters.Add("@als_Supplier", SqlDbType.VarChar).Value = SelectedSupplier;
                sCmd.Parameters.Add("@als_Country", SqlDbType.VarChar).Value = Country;
                sCmd.Parameters.Add("@als_City", SqlDbType.VarChar).Value = City;
                sCmd.Parameters.Add("@ali_CompanyXid", SqlDbType.Int).Value = Convert.ToInt16(Companyxid);


                SqlDataReader sDR = sCmd.ExecuteReader();

                loadSuppierServiceList.Load(sDR);

            }
            catch(Exception e)
            {
                Console.WriteLine("Error Message " + e.Message);
            }
            return loadSuppierServiceList;
        }

        //public DataTable Load1()
        //{
        //  SqlConnection sCon = new SqlConnection(Conn1);
        // try
        //    {
        //        sCon.Open();

        //        SqlCommand sCmd = new SqlCommand();

        //        sCmd.Connection = sCon;
        //        sCmd.CommandType = CommandType.Text;

        //        sCmd.CommandText = "Select DiscountType from m_discounttype";
                    
        //        SqlDataAdapter sDA = new SqlDataAdapter();
        //        sDA.SelectCommand = sCmd;
        //        sDA.Fill(dt);
        //    }
        //    catch
        //    {

        //    }
        //    finally
        //    {
        //        try
        //        {
        //            sCon.Close();
        //        }
        //        catch
        //        {

        //        }
        //    }
        //    return dt;
        //}
       
      }
    }