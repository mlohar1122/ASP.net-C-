using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Drawing.Text;
using Image = System.Drawing.Image;


namespace shapath
{
    public partial class certificate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PrivateFontCollection collection = new PrivateFontCollection();
            // Add the custom font families.
            // (Alternatively use AddMemoryFont if you have the font in memory, retrieved from a database).
            collection.AddFontFile(Server.MapPath("Content/privatefont.ttf"));
            string secondText = "RAJASTHAN JANARDAN RAI NAGAR VIDYAPEET UNIVERSITY";

            string imageFilePath = Server.MapPath("Content/certificate_mba.jpeg");
            Bitmap bitmap = (Bitmap)Image.FromFile(imageFilePath);//load the image file
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                Brush b = new SolidBrush(Color.Black);
                using (Font f = new Font(collection.Families.First(), 36))
                {
                    PointF firstLocation = new PointF(405f, 400f);
                    graphics.DrawString("Shri Mahendra Lohar",  f, b, firstLocation);
                }
                using (Font f = new Font("Roboto", 18))
                {
                    SizeF stringSize = graphics.MeasureString(secondText, f);
                    PointF secondLocation = new PointF((bitmap.Width-stringSize.Width)/2, 380f);
                    graphics.DrawString(secondText.ToUpper(), f, Brushes.White, secondLocation);
                }
            }
            bitmap.Save(Server.MapPath("certificateimage/certificate_mba.JPG"));

        }


    }
}