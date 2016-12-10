using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

namespace ApplicationLayer
{
    public partial class ServiceDescriptionDetails : System.Web.UI.Page
    {
        BusinessClass b = new BusinessClass();

        protected void Page_Load(object sender, EventArgs e)
        {
            LoadServiceDescriptionDetails();
        }

        private void LoadServiceDescriptionDetails()
        {

        }
    }
}