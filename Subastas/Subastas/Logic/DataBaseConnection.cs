using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Security.Cryptography;

namespace Subastas
{
    public class DataBaseConnection
    {
        public static String _Url;
        public static DataBaseConnection instance = null;//singleton
        public SqlConnection _Con;
        public String _UserName;
        public String _UserId;

        public static DataBaseConnection getDatabaseConnection(){
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
            _Url = "Server = XELOP-PC; database = SUBASTAS; integrated security=SSPI";
            _Con = new SqlConnection(_Url);
            var data = System.Text.Encoding.ASCII.GetBytes("caca");
            data = System.Security.Cryptography.SHA1.Create().ComputeHash(data);
            System.Diagnostics.Debug.WriteLine("sha1");
            Sha1("caca");
        }

        public void setConnection()
        {
            
        }

        

        public void createAuction(String pName, String pDescriptionItem, String pDeliveryDetails, String pImage, String pSubcategory, String pCategory, String pDate, int pPrice)
        {
            SqlCommand cmd = new SqlCommand("USP_CreateSubasta", _Con);
            cmd.CommandType = CommandType.StoredProcedure;
            System.Diagnostics.Debug.WriteLine(pName);
            cmd.Parameters.Add("@NombreItem", SqlDbType.VarChar).Value = pName;
            cmd.Parameters.Add("@DescripcionItem", SqlDbType.VarChar).Value = pDescriptionItem;
            cmd.Parameters.Add("@FotoItem", SqlDbType.Image).Value = DBNull.Value;//por mientras manda un nulo
            cmd.Parameters.Add("@Subcategoria", SqlDbType.VarChar).Value = pSubcategory;
            cmd.Parameters.Add("@Categoria", SqlDbType.VarChar).Value = pCategory;
            cmd.Parameters.Add("@FechaFinal", SqlDbType.DateTime).Value = pDate;
            cmd.Parameters.Add("@DetallesEntrega", SqlDbType.VarChar).Value = pDeliveryDetails;
            cmd.Parameters.Add("@PrecioBase", SqlDbType.Int).Value = pPrice;
            cmd.Parameters.Add("@AliasVendedor", SqlDbType.VarChar).Value = _UserName;
           
            _Con.Open();
            cmd.ExecuteNonQuery();
            _Con.Close();
        }
        public SqlDataReader getRestartableAuctions(){
            SqlCommand cmd = new SqlCommand("USP_GetSubastasReiniciables", _Con);
            SqlDataReader rdr = null;

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@AliasUsuario", SqlDbType.VarChar).Value = _UserName; 

            _Con.Open();
            rdr = cmd.ExecuteReader();
            //la conexion queda abaierta para darle el rdr al gridview

            return rdr;
        }
        public SqlDataReader getSubastasCategoria(String pCategory, String pSubcategory)
        {
            SqlCommand cmd = new SqlCommand("USP_GetSubastasActivasCategoria", _Con);
            SqlDataReader rdr = null;

            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.Add("@Categoria", SqlDbType.VarChar).Value = pCategory;
            cmd.Parameters.Add("@SubCategoria", SqlDbType.VarChar).Value = pSubcategory;

            _Con.Open();
            rdr = cmd.ExecuteReader();
            //la conexion queda abaierta para darle el rdr al gridview

            return rdr;
        }
        public void restartSubasta(int pId)
        {
            SqlCommand cmd = new SqlCommand("USP_RestartSubasta", _Con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@IdSubasta", SqlDbType.Int).Value = pId;
            _Con.Open();
            cmd.ExecuteNonQuery();
            _Con.Close();
        }
        public void createBid(int pId, int pMoney)
        {
            SqlCommand cmd = new SqlCommand("USP_RestartSubasta", _Con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@IdSubasta", SqlDbType.Int).Value = pId;
            cmd.Parameters.Add("@Monto", SqlDbType.Int).Value = pMoney;
            cmd.Parameters.Add("@Alias", SqlDbType.VarChar).Value = _UserName;
            _Con.Open();
            cmd.ExecuteNonQuery();
            _Con.Close();

        }
        public SqlDataReader getBidsForAuction(int pId)
        {
            SqlCommand cmd = new SqlCommand("USP_GetPujasForSubasta", _Con);
            SqlDataReader rdr = null;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@IdSubasta", SqlDbType.Int).Value = pId;
            _Con.Open();
            rdr = cmd.ExecuteReader();
            return rdr; // queda abierto para que el grid lo pueda leer, se debe cerrar del otro lado
        }

        public SqlDataReader getAuctionsForUser(String pAlias)
        {
            SqlCommand cmd = new SqlCommand("USP_GetSubastasForVendedor", _Con);
            SqlDataReader rdr = null;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Alias", SqlDbType.VarChar).Value = pAlias;
            _Con.Open();
            rdr = cmd.ExecuteReader();
            return rdr; // queda abierto para que el grid lo pueda leer, se debe cerrar del otro lado
        }
        public SqlDataReader getAuctionsWon(String pAlias)
        {
            SqlCommand cmd = new SqlCommand("USP_GetSubastasForVendedor", _Con);
            SqlDataReader rdr = null;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Alias", SqlDbType.VarChar).Value = pAlias;
            _Con.Open();
            rdr = cmd.ExecuteReader();
            return rdr; // queda abierto para que el grid lo pueda leer, se debe cerrar del otro lado
        }
        public SqlDataReader getBoughtAuctions()
        {
            SqlCommand cmd = new SqlCommand("USP_GetComprasForComprador", _Con);
            SqlDataReader rdr = null;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@IdComprador", SqlDbType.VarChar).Value = _UserId ;
            _Con.Open();
            rdr = cmd.ExecuteReader();
            return rdr; // queda abierto para que el grid lo pueda leer, se debe cerrar del otro lado
        }
        public SqlDataReader getSoldAuctions()
        {
            SqlCommand cmd = new SqlCommand("USP_GetVentasForVendedor", _Con);
            SqlDataReader rdr = null;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@IdVendedor", SqlDbType.VarChar).Value = _UserId;
            _Con.Open();
            rdr = cmd.ExecuteReader();
            return rdr;
        }
        public void setBoughtComment(String pComment, int pAuctionId)
        {
            SqlCommand cmd = new SqlCommand("USP_AddCommentComprador", _Con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@ComentarioxComprador", SqlDbType.VarChar).Value = pComment;
            cmd.Parameters.Add("@IdSubasta", SqlDbType.Int).Value = pAuctionId;

            _Con.Open();
            cmd.ExecuteNonQuery();
            _Con.Close();
        }
        public void setSoldComment(String pComment, int pAuctionId)
        {
            SqlCommand cmd = new SqlCommand("USP_AddCommentVendedor", _Con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@ComentarioxVendedor", SqlDbType.VarChar).Value = pComment;
            cmd.Parameters.Add("@IdSubasta", SqlDbType.Int).Value = pAuctionId;

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
        // ClientScript.RegisterStartupScript(this.GetType(), "esto no afecta", "alert('" + display + "');", true);
    }
}