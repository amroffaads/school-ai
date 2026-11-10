using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ai
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        public string loginMsg = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            loginMsg = "<h3>مرحبا بك يا ";
            loginMsg += Session["userFName"].ToString();
            loginMsg += "</h3>";

            if (Session["admin"].ToString() == "yes")
            {
                loginMsg += "[<a href='AdminPage.aspx'>صفحة المسؤول</a>] <br />";
                loginMsg += "[<a href='Logout.aspx'>تسجيل الخروج</a>]";
            }
            else if (Session["userName"].ToString() == "زائر")
            {
                loginMsg += "[<a href='WebForm1.aspx'>التسجيل</a>] <br />";
                loginMsg += "[<a href='Login.aspx'>تسجيل الدخول</a>]";
            }
            else
            {
                loginMsg += "[<a href='Applications.aspx'>تطبيقاتي</a>] <br />";
                loginMsg += "[<a href='UpdateUser.aspx'>تحديث البيانات</a>] <br />";
                loginMsg += "[<a href='Logout.aspx'>تسجيل الخروج</a>]";
            }
        }
    }
}
