using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Subastas.UI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public int decrease;
        protected void Page_Load(object sender, EventArgs e)
        {
            DataBaseConnection con = DataBaseConnection.getDatabaseConnection(this);
            decrease=con.getAmountReduce();
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("ParticipantsMenu.aspx");//cambia la pagina
        }

        protected void Button1_Click(object sender, EventArgs e) //Done
        {
            if (Int32.Parse(this.txt_InitialPrice.Text) <= decrease)
            {
                DataBaseConnection con = DataBaseConnection.getDatabaseConnection(this);
                String itemName = this.txt_ItemName.Text;
                String category = this.txt_Category.Text;
                String subcategory = this.txt_SubCategory.Text;
                String deliveryDetails = this.txt_DeliveryDetails.Text;
                String lastDate = this.txt_LastDate.Text;
                Int32 price = Int32.Parse(this.txt_InitialPrice.Text);
                String itemDescription = this.txt_ItemDescription.Text;
                byte[] image = null;
                ulong imageSize = 0;
                if (this.up_Image.HasFile)
                {
                    image = new byte[up_Image.PostedFile.ContentLength];
                    HttpPostedFile uploadImage = up_Image.PostedFile;
                    uploadImage.InputStream.Read(image, 0, up_Image.PostedFile.ContentLength);
                    try
                    {
                        imageSize = (ulong)image.Length;
                    }
                    catch (Exception ex)
                    {
                        imageSize = 25001;
                    }
                }
                if (imageSize > 25000)
                {
                    this.ClientScript.RegisterStartupScript(this.GetType(), "Error", "alert('Solo se pueden poner imagenes no mayores a 25 KB.');", true);
                }
                else
                {
                    Boolean error = con.createAuction(itemName, itemDescription, deliveryDetails, image, subcategory, category, lastDate, price);
                    Boolean error2 = con.restartSubasta(con.idSubasta);
           
                    if (!error&&!error2)
                    {
                        Page.Response.Redirect("ParticipantsMenu.aspx");//cambia la pagina
                    }
                }
            }
            else
            {
                this.ClientScript.RegisterStartupScript(this.GetType(), "Error", "alert('Su valor debe ser igual o menor a "+decrease+"');", true);
            }
        }
    }
}