using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication2.Models;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected string Action = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            //Init_WebControls();
        }
        protected void FileUploadButtonVideo_Click(object sender, EventArgs e)
        {
            FileSave(MyFileUploadVoice, "Video");
            //if (MyFileUploadVoice.HasFile)
            //{
            //    //string filePath = Server.MapPath("~/UploadFiles/");
            //    string fileName =/* Guid.NewGuid().ToString() + "@" +*/ MyFileUploadVedio.PostedFile.FileName;
            //    if (Directory.Exists(Server.MapPath(@"C:\Test\" + Request.Form["AuthorName"] + @"\Video\")) == false)//如果不存在就创建file文件夹
            //    {
            //        Directory.CreateDirectory(Server.MapPath(@"C:\Test\" + Request.Form["AuthorName"] + @"\Video\"));
            //    }
            //    if (File.Exists(Server.MapPath(@"C:\Test\" + Request.Form["AuthorName"] + @"\Video\" + fileName)))
            //    {
            //        Response.Write("文件已存在，请更换其他文件上传");
            //        //存在文件
            //    }
            //    else
            //    {
            //        MyFileUploadVoice.SaveAs(@"C:\Test\" + Request.Form["AuthorName"] + @"\Video\" + fileName);
            //        Response.Write("<p >上传成功!</p>");
            //    }              
            //}
            //else
            //{
            //    Response.Write("<p >请选择要上传的文件!</p>");
            //}
        }
        protected void FileUploadButtonVoice_Click(object sender, EventArgs e)
        {
            FileSave(MyFileUploadVoice, "Voice");
            //if (MyFileUploadVoice.HasFile)
            //{
            //    //string filePath = Server.MapPath("~/UploadFiles/");
            //    string fileName =/* Guid.NewGuid().ToString() + "@" +*/ MyFileUploadVoice.PostedFile.FileName;
            //    if (Directory.Exists(Server.MapPath(@"C:\Test\" + Request.Form["AuthorName"] + @"\Voice\")) == false)//如果不存在就创建file文件夹
            //    {
            //        Directory.CreateDirectory(Server.MapPath(@"C:\Test\" + Request.Form["AuthorName"] + @"\Voice\"));
            //    }
            //    if (File.Exists(Server.MapPath(@"C:\Test\" + Request.Form["AuthorName"] + @"\Voice\" + fileName)))
            //    {
            //        Response.Write("文件已存在，请更换其他文件上传");
            //        //存在文件
            //    }
            //    else
            //    {
            //        MyFileUploadVoice.SaveAs(@"C:\Test\" + Request.Form["AuthorName"] + @"\Voice\" + fileName);
            //        Response.Write("<p >上传成功!</p>");
            //    }               
            //}
            //else
            //{
            //    Response.Write("<p >请选择要上传的文件!</p>");
            //}
        }        
        protected void Button1_Click(object sender, EventArgs e)
        {
            Authors _as = new Authors();
            _as.AuthorName = Request.Form["AuthorName"];
            _as.AuthorTelephone = Request.Form["AuthorTelephone"];
            _as.AuthorUnit = Request.Form["AuthorUnit"];
            StringBuilder Info = new StringBuilder();
            Info.Append("/r/n");
            Info.Append("作者姓名：");
            Info.Append(_as.AuthorName);
            Info.Append("/r/n");
            Info.Append("/r/n");
            Info.Append("作者电话：");
            Info.Append(_as.AuthorTelephone);
            Info.Append("/r/n");
            Info.Append("/r/n");
            Info.Append("作者单位：");
            Info.Append(_as.AuthorUnit);
            Info.Append("/r/n");
            string Path = @"C:\Test\" + Request.Form["AuthorName"] + @"\AuthorInfo.txt";
            SaveAuthorInfo(Info, Path, File.Exists(Server.MapPath(Path)));
            //if (File.Exists(Server.MapPath(Path)))
            //{
            //    FileStream fs = new FileStream(Path, FileMode.Append);
            //    StreamWriter sw = new StreamWriter(fs);
            //    //开始写入
            //    sw.Write(Info.ToString());
            //    //清空缓冲区
            //    sw.Flush();
            //    //关闭流
            //    sw.Close();
            //    fs.Close();
            //}
            //else
            //{
               
            //}

            Response.Write("<p>提交已完成，感谢您的参与！</p>");
        }
        protected void SaveAuthorInfo(StringBuilder Info,string Path,bool CreateType)
        {
            var temp = CreateType ? FileMode.Append : FileMode.Create;
            FileStream fs = new FileStream(Path, temp);
            StreamWriter sw = new StreamWriter(fs);
            //开始写入
            sw.Write(Info.ToString());
            //清空缓冲区
            sw.Flush();
            //关闭流
            sw.Close();
            fs.Close();
        }

        protected void FileSave(FileUpload Files,string FileType)
        {
            if (Files.HasFile)
            {
                //string filePath = Server.MapPath("~/UploadFiles/");
                string fileName =/* Guid.NewGuid().ToString() + "@" +*/ Files.PostedFile.FileName;
                if (Directory.Exists(@"C:/Test/" + Request.Form["AuthorName"] + @"/Voice/") == false)//如果不存在就创建file文件夹
                {
                    Directory.CreateDirectory(@"C:\Test\" + Request.Form["AuthorName"] + @"\" + FileType + @"\");
                }
                if (File.Exists(@"C:\Test\" + Request.Form["AuthorName"] + @"\"+FileType+@"\" + fileName))
                {
                    Response.Write("文件已存在，请更换其他文件上传");
                    //存在文件
                }
                else
                {
                    Files.SaveAs(@"C:\Test\" + Request.Form["AuthorName"] + @"\" + FileType + @"\" + fileName);
                    Response.Write("<p >上传成功!</p>");
                }
            }
            else
            {
                Response.Write("<p >请选择要上传的文件!</p>");
            }
        }
       
    }
}