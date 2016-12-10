using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

namespace ApplicationLayer
{
    public partial class SearchSupplierServices : System.Web.UI.Page
    {

        BusinessClass b = new BusinessClass();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            string Companyxid = Session["Companyid"].ToString();
            if(!IsPostBack)
            { 
                LoadDropDownListValues(Companyxid);
            }
        }


        private void LoadDropDownListValues(string Companyxid)
        {
           ddlServiceType.DataSource = b.BUSLoadServiceType(Companyxid);
           ddlServiceType.DataValueField="Pid";
           ddlServiceType.DataTextField="ServiceType";
           ddlServiceType.DataBind();
           ddlServiceType.Items.Insert(0, new ListItem("--Select--", "0"));

           ddlSupplier.DataSource = b.BUSLoadSupplier(Companyxid);
           ddlSupplier.DataValueField = "Pid";
           ddlSupplier.DataTextField = "Supplier";
           ddlSupplier.DataBind();
           ddlSupplier.Items.Insert(0, new ListItem("--Select--", "0"));

           ddlCountry.DataSource = b.BUSLoadCountry(Companyxid);
           ddlCountry.DataValueField = "Pid";
           ddlCountry.DataTextField = "Country";
           ddlCountry.DataBind();
           ddlCountry.Items.Insert(0, new ListItem("--Select", "0"));

           ddlCity.Enabled = false;
           ddlCity.Items.Add(new ListItem("--Select--", "0"));
        //   ddlCity.DataSource = b.BUSLoadCity(Companyxid);
        //   ddlCity.DataValueField = "Pid";
        //   ddlCity.DataTextField = "City";
        //   ddlCity.DataBind();
        //   ddlCity.Items.Insert(0, new ListItem("--Select--", "0"));

        }

        protected void ddlCountry_IndexChanged(object sender,EventArgs e)
        {
           // ddlCity.Items.Clear();
           
            ddlCity.DataSource = b.BUSLoadCity(ddlCountry.SelectedItem.Value.ToString());
            ddlCity.DataValueField = "Pid";
            ddlCity.DataTextField = "City";
            ddlCity.DataBind();
            if (ddlCity.Items.Count > 0)
            {
                ddlCity.Enabled = true;
//                ddlCity.Items.Add(new ListItem("--Select--", "0"));
            }
            else
            {
                ddlCity.Enabled = false;
            }
            ddlCity.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string ServiceCode = txtServiceCode.Text;
            string Country = ddlCountry.SelectedValue;
            string City = ddlCity.SelectedValue;
            string ServiceName = txtServiceName.Text;
            string SelectedServiceType = ddlServiceType.SelectedValue;
            string SelectedSupplier = ddlSupplier.SelectedValue;
  

            Response.Redirect("ListSupplierServices.aspx?ServiceCode=" + ServiceCode + "&Country=" + Country + "&City=" + City + "&ServiceName=" + ServiceName + "&ServiceType=" + SelectedServiceType + "&Supplier=" + SelectedSupplier );
        }
    }
}