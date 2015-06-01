using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Subastas
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string connection = "data source.; database = SUBASTAS; user id =  ; password = ";//SQL Server authentication
            string connection = "Server = PC-GAME; database = SUBASTAS; integrated security=SSPI";//windows authentication
            // data source.   es local server
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("select * from Usuarios", con);
            con.Open();
            GridView1.DataSource = cmd.ExecuteReader();
            GridView1.DataBind();
            con.Close();
        }
    }
}