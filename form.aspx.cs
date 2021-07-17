using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Drawing;
using Image = System.Drawing.Image;
using System.Data;
using System.Drawing.Text;
using System.Globalization;

namespace shapath
{
    public partial class form : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            bool isHuman = captchabox.Validate(txtcaptcha.Text);
            txtcaptcha.Text = null;
            if (!isHuman)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('PLEASE ENTER VALID CAPTCHA')", true);
            }
            else
            {
                if(txtmobile.Text.ToString().Length==10)
                {
                    SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial catalog =college; Integrated Security = True");

                    con.Open();
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.CommandText = "select mobile from [college].[dbo].[demo] where mobile='" + txtmobile.Text.Trim() + "'";
                    cmd1.Connection = con;
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd1;
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = "INSERT INTO [college].[dbo].[demo] ([salutation] ,[name] ,[gender] ,[state] ,[district] ,[email] ,[mobile]) VALUES ( '" + ddlprename.SelectedItem.Text + "','" + txtname.Text.Trim().ToUpper() + "' ,'" + ddlgender.SelectedItem.Text + "' ,'" + txtstate.Text.Trim().ToUpper() + "' ,'" + txtdistrict.Text.Trim().ToUpper() + "' ,'" + txtemail.Text.Trim() + "' ,'" + txtmobile.Text.Trim() + "');select SCOPE_IDENTITY();";
                        cmd.Connection = con;

                        int i = Convert.ToInt32(cmd.ExecuteScalar());
 
                        con.Close();

                        if (i == 0)
                        {
                            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Insertion Error. Contact Suppport.')", true);
                        }
                        else
                        {
                            PrivateFontCollection collection = new PrivateFontCollection();
                            collection.AddFontFile(Server.MapPath("Content/privatefont.ttf"));
                            string firstText = ddlprename.SelectedItem.Text + " " + txtname.Text.ToLower();
                            TextInfo cultInfo = new CultureInfo("en-US", false).TextInfo;
                            string output = string.Empty;

                            string imageFilePath = Server.MapPath("Content/certificate_mba.jpeg");
                            Bitmap bitmap = (Bitmap)Image.FromFile(imageFilePath); //load the image file
                            using (Graphics graphics = Graphics.FromImage(bitmap))
                            {
                                Brush b = new SolidBrush(Color.Black);
                                using (Font f = new Font(collection.Families.First(), 46))
                                {

                                    SizeF stringSize = graphics.MeasureString( cultInfo.ToTitleCase(firstText), f);
                                    PointF firstLocation = new PointF(100f, 400f);
                                    graphics.DrawString(cultInfo.ToTitleCase(firstText), f, b, firstLocation);
                                }
                                using (Font f = new Font("Roboto", 30))
                                {
                                    SizeF stringSize = graphics.MeasureString("of "+ cultInfo.ToTitleCase(txtstate.Text.Trim()), f);
                                    PointF secondLocation = new PointF((bitmap.Width - stringSize.Width) / 2, 380f);
                                    graphics.DrawString("", f, Brushes.White, secondLocation);
                                }
                            }
                            bitmap.Save(Server.MapPath("certificateimage/" + i + ".JPG"));
                            Response.Redirect("/response/"+i+"");
                        }
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('ALREADY REGISTERED')", true);
                    }
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Enter a valid 10 digit number')", true);
                }
            }
        }
    }
}