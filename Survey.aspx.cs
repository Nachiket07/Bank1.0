using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
namespace Bank
{
    public partial class Survey : System.Web.UI.Page
    {
        SqlConnection con = null;
        String query=null;
        SqlCommand conn=null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Name"] != null)
            {
                Name.Text = Session["Name"].ToString();
            }
            else
            {
                Response.Redirect("login.aspx");
            }
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["Banks"].ConnectionString);
            con.Open();
            query = "SELECT * FROM Questions";
            conn = new SqlCommand(query, con);
            if (!IsPostBack)
            {
                try
                {
                    int j;
                    SqlDataReader r = conn.ExecuteReader();
                    //Response.Write("<div>");
                    int i = 0;
                    j = 0;
                    RadioButtonList radio;
                    Label label;
                    /*while(r.Read())
                    {
                        j = r.GetInt32(1);
                        Response.Write("<asp:Label id='Q"+j+"' Text='"+r.GetString(0)+"' runat='server' ></asp:Label><br />< asp:RadioButtonList id = '"+j+"' runat = 'server' value = '-1' >< asp:ListItem Value = '1' > Yes </ asp:ListItem >< asp:ListItem Value = '0' > No </ asp:ListItem ></ asp:RadioButtonList >< br /> ");
                        i += 1;
                    }
                    Response.Write("<asp:Button id='submit' runat='server' OnClick='submitClick' Text='submit'/>");
                    */
                    while (r.Read())
                    {
                        i += 1;
                        label = new Label();
                        label.Text = r.GetString(0);
                        j = r.GetInt32(1);
                        label.ID = "Q" + j;

                        radio = new RadioButtonList();
                        radio.ID = "q" + j;
                        radio.Items.Add(new ListItem("Yes", "1"));
                        radio.Items.Add(new ListItem("No", "0"));
                        SurveyQuestions.Controls.Add(label); // add to the panel.
                        SurveyQuestions.Controls.Add(radio);
                    }
                    Button b = new Button();
                    b.Text = "Submit";
                    b.ID = "SubmitSurvey";
                    b.OnClientClick = "submitClick";
                    SurveyQuestions.Controls.Add(b);
                    //Response.Write("</div>");
                }
                


                catch (Exception ex) { Response.Write(ex); }
            }
        }
        public void submitClick(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader r = conn.ExecuteReader();
                while (r.Read())
                {
                    // How to fetch those radio buttons here ?
                }
            }
            catch(Exception ex)
            {
                Response.Write(ex);
            }


            /*String no = "-1";
            String i=  a.SelectedValue;
            String j = b.SelectedValue;
            String k = c.SelectedValue;
            String l = d.SelectedValue;
            if (i.Equals(""))
            {
                i = no;
            }
            if (j.Equals(""))
            {
                j = no;
            }
            if (k.Equals(""))
            {
                k = no;
            }
            if (l.Equals(""))
            {
                l = no;
            }
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Banks"].ConnectionString);
            con.Open();
            String query = "Insert Into [Table] values(@w,@x,@y,@z)";
            SqlCommand cmd = new SqlCommand(query,con);
            cmd.Parameters.AddWithValue("@w",i);
            cmd.Parameters.AddWithValue("@x",j);
            cmd.Parameters.AddWithValue("@y",k);
            cmd.Parameters.AddWithValue("@z", l);
            //int res = (Int32)
            cmd.ExecuteScalar();
            //Console.WriteLine(res);
            con.Close();
            Session.Abandon();
            Response.Redirect("login.aspx");
            //Response.Write(i+j+k+l);
            */

            }
        protected void Page_UnLoad(object sender, EventArgs e)
        {
            if (con != null)
                con.Close();
        }
    }
}