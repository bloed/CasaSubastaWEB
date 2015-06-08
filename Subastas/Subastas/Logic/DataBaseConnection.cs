using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Security.Cryptography;
using System.Web.UI;

namespace Subastas
{
    public class DataBaseConnection
    {
        public static String _Url;
        public static DataBaseConnection instance = null;//singleton
        public SqlConnection _Con;
        public String _UserName;
        public Int32 _UserId;
        public SqlDataReader _CurrentReader;
        public static Page _Page;

        public static DataBaseConnection getDatabaseConnection(Page pPage){
            _Page = pPage;

            if(instance == null){
                instance = new DataBaseConnection();
            }
            return instance;
        }
        public String Sha1(String pText)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(pText);
            SHA1CryptoServiceProvider cryptoTransformSHA1 = new SHA1CryptoServiceProvider();
            String hashText = BitConverter.ToString(cryptoTransformSHA1.ComputeHash(buffer)).Replace("-", "");
            System.Diagnostics.Debug.WriteLine(hashText);
            return hashText;
        }

        public DataBaseConnection()
        {
            setConnection();
            
        }

        public void setConnection()
        {
            try
            {
                _Url = "Server = XELOP-PC; database = SUBASTAS; integrated security=SSPI";
                _Con = new SqlConnection(_Url);
                
            }
            catch (SqlException e)
            {
                _Page.ClientScript.RegisterStartupScript(this.GetType(), "Error", "alert('" + e.Message + "');", true);
            }
        }

        public Boolean verifyPassword(String pAlias, String pPassword)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("USP_GetPassForUsuario", _Con);
                cmd.Parameters.Add("@Alias", SqlDbType.VarChar).Value = pAlias;
                cmd.Parameters.Add("@Password", SqlDbType.VarChar,45).Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;
                _Con.Open();
                cmd.ExecuteNonQuery();
                String password =(cmd.Parameters["@Password"].Value.ToString());
                _Con.Close();

                if (password.Equals(Sha1(pPassword)))
                {
                    return false;
                }
                else
                {
                    _Page.ClientScript.RegisterStartupScript(this.GetType(), "Error", "alert('" + "PASSWORD incorrecto" + "');", true);
                    return true;
                }

            }
            catch (SqlException e)
            {
                _Page.ClientScript.RegisterStartupScript(this.GetType(), "Error", "alert('" + e.Message + "');", true);
                return true;
            }
        }

        public Boolean createAuction(String pName, String pDescriptionItem, String pDeliveryDetails, byte[] pImage, String pSubcategory, String pCategory, String pDate, int pPrice)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("USP_CreateSubasta", _Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@NombreItem", SqlDbType.VarChar).Value = pName;
                cmd.Parameters.Add("@DescripcionItem", SqlDbType.VarChar).Value = pDescriptionItem;
                cmd.Parameters.Add("@FotoItem", SqlDbType.Image).Value = pImage;//por mientras manda un nulo
                cmd.Parameters.Add("@Subcategoria", SqlDbType.VarChar).Value = pSubcategory;
                cmd.Parameters.Add("@Categoria", SqlDbType.VarChar).Value = pCategory;
                cmd.Parameters.Add("@FechaFinal", SqlDbType.DateTime).Value = pDate;
                cmd.Parameters.Add("@DetallesEntrega", SqlDbType.VarChar).Value = pDeliveryDetails;
                cmd.Parameters.Add("@PrecioBase", SqlDbType.Int).Value = pPrice;
                cmd.Parameters.Add("@AliasVendedor", SqlDbType.VarChar).Value = _UserName;

                _Con.Open();
                cmd.ExecuteNonQuery();
                _Con.Close();
                return false;
            }
            catch (SqlException e)
            {
                _Page.ClientScript.RegisterStartupScript(this.GetType(), "Error", "alert('" + e.Message + "');", true);
                return true;
            }
        }
        public SqlDataReader getRestartableAuctions(){
            try
            {
                SqlCommand cmd = new SqlCommand("USP_GetSubastasReiniciables", _Con);
                SqlDataReader rdr = null;

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@AliasUsuario", SqlDbType.VarChar).Value = _UserName;
                
                _Con.Open();
                rdr = cmd.ExecuteReader();
                //la conexion queda abaierta para darle el rdr al gridview

                return rdr;
            }
            catch (SqlException e)
            {
                _Con.Close();
                _Page.ClientScript.RegisterStartupScript(this.GetType(), "Error", "alert('" + e.Message + "');", true);
                return null;
            }
        }
        public SqlDataReader getSubastasCategoria(String pCategory, String pSubcategory)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("USP_GetSubastasActivasCategoria", _Con);
                SqlDataReader rdr = null;

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Categoria", SqlDbType.VarChar).Value = pCategory;
                cmd.Parameters.Add("@SubCategoria", SqlDbType.VarChar).Value = pSubcategory;

                _Con.Open();
                rdr = cmd.ExecuteReader();
                _CurrentReader = rdr;
                //la conexion queda abaierta para darle el rdr al gridview

                return rdr;
            }
            catch (SqlException e)
            {
                _Page.ClientScript.RegisterStartupScript(this.GetType(), "Error", "alert('" + e.Message + "');", true);
                _Con.Close();
                return null;
            }
        }
        public Boolean restartSubasta(int pId)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("USP_RestartSubasta", _Con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@IdSubasta", SqlDbType.Int).Value = pId;
                _Con.Open();
                cmd.ExecuteNonQuery();
                _Con.Close();
                return false;
            }
            catch (SqlException e)
            {
                _Page.ClientScript.RegisterStartupScript(this.GetType(), "Error", "alert('" + e.Message + "');", true);
                return true;
            }
        }
        public Boolean createBid(int pId, int pMoney)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("USP_CreatePuja", _Con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@IdSubasta", SqlDbType.Int).Value = pId;
                cmd.Parameters.Add("@Monto", SqlDbType.Int).Value = pMoney;
                cmd.Parameters.Add("@Alias", SqlDbType.VarChar).Value = _UserName;
                _Con.Open();
                cmd.ExecuteNonQuery();
                _Con.Close();
                return false;
            }
            catch (SqlException e)
            {
                _Page.ClientScript.RegisterStartupScript(this.GetType(), "Error", "alert('" + e.Message + "');", true);
                return true;
            }

        }
        public SqlDataReader getBidsForAuction(int pId)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("USP_GetPujasForSubasta", _Con);
                SqlDataReader rdr = null;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@IdSubasta", SqlDbType.Int).Value = pId;
                _Con.Open();
                rdr = cmd.ExecuteReader();

                return rdr; // queda abierto para que el grid lo pueda leer, se debe cerrar del otro lado
            }
            catch (SqlException e)
            {
                _Page.ClientScript.RegisterStartupScript(this.GetType(), "Error", "alert('" + e.Message + "');", true);
                _Con.Close();
                return null;
            }
        }

        public SqlDataReader getAuctionsForUser(String pAlias)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("USP_GetSubastasForVendedor", _Con);
                SqlDataReader rdr = null;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Alias", SqlDbType.VarChar).Value = pAlias;
                _Con.Open();
                rdr = cmd.ExecuteReader();
                return rdr; // queda abierto para que el grid lo pueda leer, se debe cerrar del otro lado
            }
            catch (SqlException e)
            {
                _Page.ClientScript.RegisterStartupScript(this.GetType(), "Error", "alert('" + e.Message + "');", true);
                _Con.Close();
                return null;
            }
        }
        public SqlDataReader getAuctionsWon(String pAlias)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("USP_GetPujasGanadorasForUsuario", _Con);
                SqlDataReader rdr = null;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Alias", SqlDbType.VarChar).Value = pAlias;
                _Con.Open();
                rdr = cmd.ExecuteReader();
                return rdr; // queda abierto para que el grid lo pueda leer, se debe cerrar del otro lado
            }
            catch (SqlException e)
            {
                _Page.ClientScript.RegisterStartupScript(this.GetType(), "Error", "alert('" + e.Message + "');", true);
                _Con.Close();
                return null;
            }
        }
        public SqlDataReader getBoughtAuctions()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("USP_GetComprasForComprador", _Con);
                SqlDataReader rdr = null;
                cmd.CommandType = CommandType.StoredProcedure;
                _UserId = 2;//para preubaa
                cmd.Parameters.Add("@IdComprador", SqlDbType.Int).Value = _UserId;
                _Con.Open();
                rdr = cmd.ExecuteReader();
                return rdr; // queda abierto para que el grid lo pueda leer, se debe cerrar del otro lado
            }
            catch (SqlException e)
            {
                _Page.ClientScript.RegisterStartupScript(this.GetType(), "Error", "alert('" + e.Message + "');", true);
                _Con.Close();
                return null;
            }
        }
        public SqlDataReader getSoldAuctions()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("USP_GetVentasForVendedor", _Con);
                SqlDataReader rdr = null;
                cmd.CommandType = CommandType.StoredProcedure;
                _UserId = 1;//para prueba
                cmd.Parameters.Add("@IdVendedor", SqlDbType.VarChar).Value = _UserId;
                _Con.Open();
                rdr = cmd.ExecuteReader();
                return rdr;
            }
            catch (SqlException e)
            {
                _Page.ClientScript.RegisterStartupScript(this.GetType(), "Error", "alert('" + e.Message + "');", true);
                _Con.Close();
                return null;
            }
        }
        public Boolean setBoughtComment(String pComment, int pAuctionId)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("USP_AddCommentComprador", _Con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ComentarioxComprador", SqlDbType.VarChar).Value = pComment;
                cmd.Parameters.Add("@IdSubasta", SqlDbType.Int).Value = pAuctionId;

                _Con.Open();
                cmd.ExecuteNonQuery();
                _Con.Close();
                return false;
            }
            catch (SqlException e)
            {
                _Page.ClientScript.RegisterStartupScript(this.GetType(), "Error", "alert('" + e.Message + "');", true);
                return true;
            }
        }
        public Boolean setSoldComment(String pComment, int pAuctionId)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("USP_AddCommentVendedor", _Con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ComentarioxVendedor", SqlDbType.VarChar).Value = pComment;
                cmd.Parameters.Add("@IdSubasta", SqlDbType.Int).Value = pAuctionId;

                _Con.Open();
                cmd.ExecuteNonQuery();
                _Con.Close();
                return false;
            }
            catch (SqlException e)
            {
                _Page.ClientScript.RegisterStartupScript(this.GetType(), "Error", "alert('" + e.Message + "');", true);
                return true;
            }
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
        // ClientScript.RegisterStartupScript(this.GetType(), "esto no afecta", "alert('" + display + "');", true);
    }
}