using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using System.Data;

namespace ApplicationLayer
{
    public partial class ListSupplierServices : System.Web.UI.Page
    {
        BusinessClass b = new BusinessClass();

        protected void Page_Load(object sender, EventArgs e)
        {

           string serviceCode  = Request.QueryString["ServiceCode"];
           string serviceType = Request.QueryString["ServiceType"];
           string serviceName  = Request.QueryString["ServiceName"]; 
           string supplier     = Request.QueryString["Supplier"]; 
           string country      = Request.QueryString["Country"]; 
           string city         = Request.QueryString["City"]; 
           string companyxid   = Session["Companyid"].ToString();


           LoadSupplierServiceList(serviceCode, serviceType, serviceName, supplier, country, city, companyxid);
        }

        private void LoadSupplierServiceList(string ServiceCode, string SelectedServiceType, string ServiceName, string SelectedSupplier, string Country, string City, string Companyxid)
        {
            Rptr_ListSupplierServices.DataSource = b.BUSLoadSupplierServiceList(ServiceCode, SelectedServiceType, ServiceName, SelectedSupplier, Country, City, Companyxid);
            Rptr_ListSupplierServices.DataBind();
        }




        protected void Rptr_ListSupplierServices_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            DataRowView drv = (DataRowView)e.Item.DataItem;

            if (e.Item.ItemType == ListItemType.Header)
            {
                Label ServiceType = (Label)e.Item.FindControl("hdrServiceType");
                Label hdrServiceName = (Label)e.Item.FindControl("hdrServiceName");
                Label hdrStatus = (Label)e.Item.FindControl("hdrStatus");
                Label hdrSupplierName = (Label)e.Item.FindControl("hdrSupplierName");
                Label hdrCountry = (Label)e.Item.FindControl("hdrCountry");
                Label hdrCity = (Label)e.Item.FindControl("hdrCity");
                Label hdrServiceType = (Label)e.Item.FindControl("hdrContract");
                Label hdrContract = (Label)e.Item.FindControl("hdrDetails");
            }
            else
            {
                HiddenField hdnPid = (HiddenField)e.Item.FindControl("hndPid");
                
                Label lblServiceType = (Label)e.Item.FindControl("lblServiceType");
                lblServiceType.Text = drv.Row["ServiceType"].ToString();

                Label lblServiceName = (Label)e.Item.FindControl("lblServiceName");
                lblServiceName.Text = drv.Row["ServiceName"].ToString();

                Label lblStatus = (Label)e.Item.FindControl("lblStatus");
                lblStatus.Text = drv.Row["Status"].ToString();

                Label lblSupplierName = (Label)e.Item.FindControl("lblSupplierName");
                lblSupplierName.Text = drv.Row["Supplier"].ToString();

                Label lblCountry = (Label)e.Item.FindControl("lblCountry");
                lblCountry.Text = drv.Row["Country"].ToString();

                Label lblCity = (Label)e.Item.FindControl("lblCity");
                lblCity.Text = drv.Row["City"].ToString();

                HyperLink hypContract = (HyperLink)e.Item.FindControl("hypContract");
                hypContract.NavigateUrl = "abc.aspx";

                HyperLink hypDetails = (HyperLink)e.Item.FindControl("hypDetails");
                hypDetails.NavigateUrl = "OtherSupplierServiceDetails.aspx?SupplierServicePid=" + drv.Row["Pid"].ToString() ;

            }
        
        }

        protected void lnkNext_Click(object sender, EventArgs e)
        {

        }

        protected void lnkPrevious_Click(object sender, EventArgs e)
        {

        }
    }
}