﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Subastas
{
    public partial class WonBidsHistoryUser : System.Web.UI.Page
    {
        DataBaseConnection _Connection;
        protected void Page_Load(object sender, EventArgs e)
        {
            _Connection = DataBaseConnection.getDatabaseConnection(this);
        }

        protected void _btn_Back_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("MenuAll.aspx");//cambia la pagina
        }

        protected void _btn_List_Click(object sender, EventArgs e)
        {
            GridView1.DataSource=_Connection.getAuctionsWon(_txt_ID.Text);
            GridView1.DataBind();
            _Connection._Con.Close();
        }
    }
}