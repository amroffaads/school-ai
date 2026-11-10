using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ai
{
    public partial class SiteMaster : MasterPage
    {
        public string loginMsg = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            loginMsg = "مرحبا بك يا " + Session["userFName"].ToString();
            loginMsg += "<h3>";
        }
    }
}