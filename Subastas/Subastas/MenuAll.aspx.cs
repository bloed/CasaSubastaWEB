using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Subastas
{
    public partial class MenuAll : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("ParticipantsMenu.aspx");//cambia la pagina
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("ListAuctions.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("BidsHistoryProduct.aspx");//cambia la pagina
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("AuctionHistoryUse.aspx");//cambia la pagina
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("WonBidsHistoryUser.aspx");//cambia la pagina
        }
    }
}