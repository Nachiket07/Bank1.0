using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bank
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Name.Text = Session["Name"].ToString();
        }



        
        public void submitLogout(Object sender, EventArgs e)
        {
            //Response.Write(selectedincome.Value);

        }
        protected void income_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}