using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected string Action = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            //Init_WebControls();
        }
        protected void FileUploadButtonVido_Click(object sender, EventArgs e)
        {
            if (MyFileUploadVoice.HasFile)
            {
                //string filePath = Server.MapPath("~/UploadFiles/");
                string fileName = Guid.NewGuid().ToString()+ MyFileUploadVoice.PostedFile.FileName;
                MyFileUploadVoice.SaveAs(@"D:\Test\" +  fileName);
                Response.Write("<p >上传成功!</p>");
            }
            else
            {
                Response.Write("<p >请选择要上传的文件!</p>");
            }
        }
        protected void FileUploadButtonVoice_Click(object sender, EventArgs e)
        {
            if (MyFileUploadVoice.HasFile)
            {
                //string filePath = Server.MapPath("~/UploadFiles/");

                string fileName = Guid.NewGuid().ToString() + MyFileUploadVoice.PostedFile.FileName;
                MyFileUploadVoice.SaveAs(@"D:\Test\" + fileName);
                Response.Write("<p >上传成功!</p>");
            }
            else
            {
                Response.Write("<p >请选择要上传的文件!</p>");
            }
        }
        //protected void Page_Load(object sender, EventArgs e)
        //{
            
        //}
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("<p >"+ Request.Form["authorName"] + "</p>");
        }
       
    }
}