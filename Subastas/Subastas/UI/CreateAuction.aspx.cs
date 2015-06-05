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
            DataBaseConnection con = DataBaseConnection.getDatabaseConnection();
            String itemName = this.txt_ItemName.Text;
            String category = this.txt_Category.Text;
            String subcategory = this.txt_SubCategory.Text;
            String deliveryDetails = this.txt_DeliveryDetails.Text;
            String lastDate = this.txt_LastDate.Text;
            Int32 price = Int32.Parse(this.txt_InitialPrice.Text);
            String itemDescription = this.txt_ItemDescription.Text;
            byte[] image  = null; 
            if (this.up_Image.HasFile)
            {
                image = new byte[up_Image.PostedFile.ContentLength];
                HttpPostedFile uploadImage = up_Image.PostedFile;
                uploadImage.InputStream.Read(image, 0, up_Image.PostedFile.ContentLength);       
            }   
            else//no image
            {

            }
            //con.createAuction(itemName, itemDescription, deliveryDetails, image, subcategory, category, lastDate, price);
            Page.Response.Redirect("ParticipantsMenu.aspx");//cambia la pagina
        }
    }
}