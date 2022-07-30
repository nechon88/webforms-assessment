using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace assessment
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
                return;
            if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
            {
                string id = Request.QueryString["ID"];
            }
        }
    }
}