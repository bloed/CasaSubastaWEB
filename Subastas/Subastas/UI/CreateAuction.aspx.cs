using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Subastas
{
    public partial class CreateAuction : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("ParticipantsMenu.aspx");//cambia la pagina
        }

        protected void Button1_Click(object sender, EventArgs e) //Done
        {
            DataBaseConnection x = new DataBaseConnection();
            x.createAuction("tres","tres",null,"caca2","caca","tres","2009-6-5",100);
            Page.Response.Redirect("ParticipantsMenu.aspx");//cambia la pagina
        }
    }
}