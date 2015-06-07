using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Subastas
{
    public partial class ListAuctions : System.Web.UI.Page
    {
        DataBaseConnection _Connection;
        protected void Page_Load(object sender, EventArgs e)
        {
            _Connection = DataBaseConnection.getDatabaseConnection(this);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("MenuAll.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GridView1.DataSource=_Connection.getSubastasCategoria(txt_Category.Text, txt_Subcategory.Text);
            GridView1.DataBind();
            _Connection._Con.Close();
        }
    }
}