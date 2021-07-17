using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.FriendlyUrls;


namespace shapath
{
    public partial class response : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            IList<string> segments = Request.GetFriendlyUrlSegments();
            Response.ContentType = "image/jpg";
            Response.AddHeader("content-disposition", "attachment;filename=" + segments[0] + ".JPG");
            Response.TransmitFile(Server.MapPath("~/certificateimage/"+segments[0]+".JPG"));
            Response.End();
        }
    }
}