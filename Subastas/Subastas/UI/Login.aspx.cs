using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Subastas
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string connection = "Server = server; database = SUBASTAS; user id =  ; password = ";//SQL Server authentication
            string connection = "Server = PC-GAME; database = SUBASTAS; integrated security=SSPI";//windows authentication
            // data source.   es local server
            /*using (SqlConnection con = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand("USP_GetSubastas", con))
                {
                    //cmd.CommandType = CommandType.StoredProcedure;

                    //cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = txtFirstName.Text;
                    //cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = txtLastName.Text;

                    con.Open();
                    //GridView1.DataSource = cmd.ExecuteReader();
                    //GridView1.DataBind();
                    con.Close();
                }
            }*/
        }

        protected void btn_Login_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("ParticipantsMenu.aspx");//cambia la pagina
        }
    }
}