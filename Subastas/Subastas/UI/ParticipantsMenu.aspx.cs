using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Subastas
{
    public partial class ParticipantsMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("CreateAuction.aspx");//cambia la pagina
        }

        protected void btn_RestartAuction_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("RestartAuction.aspx");//cambia la pagina
        }

        protected void btn_Bid_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("BidAuction.aspx");//cambia la pagina
        }

        protected void btn_More_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("MenuAll.aspx");//cambia la pagina
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Page.Response.Redirect("CommentSales.aspx");//cambia la pagina
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("CommentWins.aspx");//cambia la pagina
        }
    }
}