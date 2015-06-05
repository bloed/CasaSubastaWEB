using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace Subastas.UI
{
    public partial class CommentWins : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataBaseConnection con = DataBaseConnection.getDatabaseConnection();
            SqlDataReader caca = con.getBoughtAuctions();
            this.GridView1.DataSource = caca;
            GridView1.DataBind();
            con._Con.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("ParticipantsMenu.aspx");//cambia la pagina
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Int32 Id = Int32.Parse(this.txt_Id.Text);
            String Commment = this.txt_Comment.Text;
            DataBaseConnection con = DataBaseConnection.getDatabaseConnection();
            con.setBoughtComment(Commment, Id);
            Page.Response.Redirect("ParticipantsMenu.aspx");//cambia la pagina
        }
    }
}