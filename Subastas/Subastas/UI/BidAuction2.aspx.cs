using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Subastas
{
    public partial class BidAuction2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataBaseConnection con = DataBaseConnection.getDatabaseConnection();
            GridView1.DataSource = con._CurrentReader;
            try
            {
                GridView1.DataBind();
            }
            catch (Exception E) { }
            con._Con.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("BidAuction.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Int32 Id = Int32.Parse(this.txt_Id.Text);
            Int32 Amount = Int32.Parse(this.txt_Amount.Text);
            DataBaseConnection con = DataBaseConnection.getDatabaseConnection();
            con.createBid(Id, Amount);
            Page.Response.Redirect("ParticipantsMenu.aspx");
        }
    }
}