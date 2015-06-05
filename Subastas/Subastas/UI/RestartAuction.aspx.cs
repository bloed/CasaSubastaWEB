using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Subastas
{
    public partial class RestartAuction : System.Web.UI.Page
    {
        DataBaseConnection _Connection;
        protected void Page_Load(object sender, EventArgs e)
        {
            _Connection = DataBaseConnection.getDatabaseConnection();

            GridView1.DataSource = _Connection.getRestartableAuctions();
            GridView1.DataBind();
            _Connection._Con.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("ParticipantsMenu.aspx");//cambia la pagina
        }

        protected void btn_Restart_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("ParticipantsMenu.aspx");//cambia la pagina
        }
    }
}