using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Subastas
{
    public partial class MakeBid : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("BidAuction2.aspx");//cambia la pagina
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("ParticipantsMenu.aspx");//cambia la pagina
        }
    }
}