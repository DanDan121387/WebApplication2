//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Web;

//namespace WebApplication2
//{
//    public class Logic : WebForm1
//    {
//        protected void DirectoryHelp(object sender, EventArgs e)
//        {

//            if (Directory.Exists(Server.MapPath("~/upimg/hufu")) == false)//如果不存在就创建file文件夹
//            {
//                Directory.CreateDirectory(Server.MapPath("~/upimg/hufu"));
//            }

//            //Directory.Delete(Server.MapPath("~/upimg/hufu"), true);//删除文件夹以及文件夹中的子目录，文件    

//            //判断文件的存在

//            if (File.Exists(Server.MapPath("~/upimg/Data.html")))
//            {
//                Response.Write("Yes");

//                //存在文件

//            }

//            else
//            {
//                Response.Write("No");
//                //不存在文件
//                File.Create(MapPath("~/upimg/Data.html"));//创建该文件

//            }

//            string name = GetFiles.FileName;//获取已上传文件的名字
//            string size = GetFiles.PostedFile.ContentLength.ToString();//获取已上传文件的大小
//            string type = GetFiles.PostedFile.ContentType;//获取已上传文件的MIME
//            string postfix = name.Substring(name.LastIndexOf(".") + 1);//获取已上传文件的后缀
//            string ipath = Server.MapPath("upimg") + "\\" + name;//获取文件的实际路径
//            string fpath = Server.MapPath("upfile") + "\\" + name;
//            string dpath = "upimg\\" + name;//判断写入数据库的虚拟路径

//            ShowPic.Visible = true;//激活
//            ShowText.Visible = true;//激活

//            //判断文件格式
//            if (name == "")
//            {
//                Response.Write("<script>alert('上传文件不能为空')</script>");
//            }

//            else
//            {

//                if (postfix == "jpg" || postfix == "gif" || postfix == "bmp" || postfix == "png")
//                {
//                    GetFiles.SaveAs(ipath);
//                    ShowPic.ImageUrl = dpath;
//                    ShowText.Text = "你上传的图片名称是:" + name + "<br>" + "文件大小:" + size + "KB" + "<br>" + "文件类型:" + type + "<br>" + "存放的实际路径为:" + ipath;

//                }

//                else
//                {
//                    ShowPic.Visible = false;//隐藏图片
//                    GetFiles.SaveAs(fpath);//由于不是图片文件,因此转存在upfile这个文件夹
//                    ShowText.Text = "你上传的文件名称是:" + name + "<br>" + "文件大小:" + size + "KB" + "<br>" + "文件类型:" + type + "<br>" + "存放的实际路径为:" + fpath;

//                }
//            }
//        }
//    }

//}