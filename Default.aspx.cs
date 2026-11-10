using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ai
{
    public partial class _Default : Page
        
    {
    public string st = "";
    protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form["btnSubmit"] != null)
            {
                st += "<table dir = 'ltr' border = '1'>";
                st += "<tr><th colspan = '2'>User Information</th></tr>";

                string uName = Request.Form["uName"];
                string fName = Request.Form["fName"];
                string lName = Request.Form["lName"];
                string email = Request.Form["email"];

                st += "<tr><td>User Name</td><td>" + uName + "</td></tr>";
                st += "<tr><td>First Name</td><td>" + fName + "</td></tr>";
                st += "<tr><td>Last Name</td><td>" + lName + "</td></tr>";
                st += "<tr><td>Email</td><td>" + email + "</td></tr>";

                st += "</table>";


                {
                    
                }

                int year = DateTime.Now.Year;
                int from = year - 100;
                int to = year - 10;
                for (int i = from; i <= to; i++)
                {
                    st += "<option value = '" + i + "'>" + i + "</option>";
                }
            }
        }
    }
}