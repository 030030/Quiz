
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quiz {
    public partial class Quiz202111-1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            Response.Write(Session["ans1"]+"<br>");
            Response.Write(Session["ans2"] + "<br>");   
        }
    }
}
