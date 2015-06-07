using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Subastas
{
    public partial class BidsHistoryProduct : System.Web.UI.Page
    {
        DataBaseConnection _Connection;
        protected void Page_Load(object sender, EventArgs e)
        {
            _Connection = DataBaseConnection.getDatabaseConnection(this);
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("MenuAll.aspx");
        }

        protected void _btn_List_Click(object sender, EventArgs e)
        {
            _Grid.DataSource=_Connection.getBidsForAuction(Convert.ToInt32(_txt_ID.Text));
            _Grid.DataBind();
            _Connection._Con.Close();

        }

        protected void _btn_Back_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("MenuAll.aspx");
        }
    }
}