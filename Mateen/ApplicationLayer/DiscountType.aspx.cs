using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BusinessLayer;

namespace ApplicationLayer
{
    public partial class DiscountType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadDiscountType();
        }
        private void LoadDiscountType()
        {
            BusinessClass b = new BusinessClass();
        //    Rptr.DataSource = b.LoaDDiscountBus();
        //    Rptr.DataBind();
        }

        protected void Rptr_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {

            DataRowView drv =(DataRowView)e.Item.DataItem;

            if(e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {

            Label lblDiscountType = (Label)e.Item.FindControl("lblDiscountType");
            lblDiscountType.Text = drv["DiscountType"].ToString();
       
            }

        }


    }
}