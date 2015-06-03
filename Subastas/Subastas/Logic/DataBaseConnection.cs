using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace Subastas
{
    public class DataBaseConnection
    {
        public static String _Url;
        public SqlConnection _Con;
        public String _UserName;
        public String _UserId;

        public DataBaseConnection()
        {
            _Url = "Server = XELOP-PC; database = SUBASTAS; integrated security=SSPI";
            _Con = new SqlConnection(_Url);
        }

        public void setConnection()
        {
            
        }

        public void createAuction(String pName, String pDescription, String pImage, String pSubcategory, String pCategory, String pDelivery, String pDate, int pPrice)
        {
            SqlCommand cmd = new SqlCommand("USP_CreateSubasta", _Con);
            cmd.CommandType = CommandType.StoredProcedure;

            System.Diagnostics.Debug.WriteLine(pName);
            cmd.Parameters.Add("@NombreItem", SqlDbType.VarChar).Value = pName;
            cmd.Parameters.Add("@DescripcionItem", SqlDbType.VarChar).Value = pDescription;
            cmd.Parameters.Add("@FotoItem", SqlDbType.Image).Value = DBNull.Value; 
            cmd.Parameters.Add("@Subcategoria", SqlDbType.VarChar).Value = pSubcategory;
            cmd.Parameters.Add("@Categoria", SqlDbType.VarChar).Value = pCategory;
            cmd.Parameters.Add("@FechaFinal", SqlDbType.Date).Value = pDate;
            cmd.Parameters.Add("@DetallesEntrega", SqlDbType.VarChar).Value = pDescription;
            cmd.Parameters.Add("@PrecioBase", SqlDbType.Int).Value = pPrice;
            cmd.Parameters.Add("@AliasVendedor", SqlDbType.VarChar).Value = "part";
           
            _Con.Open();
            cmd.ExecuteNonQuery();
            _Con.Close();
        }



        /*
        SqlConnection con = new SqlConnection(connection)
            {
                using (SqlCommand cmd = new SqlCommand("USP_GetSubastas", con))
                {
                    //cmd.CommandType = CommandType.StoredProcedure;

                    //cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = txtFirstName.Text;
                    //cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = txtLastName.Text;

                    con.Open();
                    con.Close();
                }
            }*/
    }
}