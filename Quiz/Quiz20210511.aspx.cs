
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quiz {
    public partial class Quiz20210511 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["ans1"] = TextBox1.Text;
            Session["ans2"] = TextBox2.Text;
            Response.Redirect("https://localhost:44321/Quiz20210511-1.aspx", false);
            HttpContext.Current.ApplicationInstance.CompleteRequest();
        }
    }
}
