using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebAppDemo
{
    public partial class C17_FileUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //HyperLink1.NavigateUrl = "~/Uploads/StdPicture/689_796844.jpg";
            HyperLink1.NavigateUrl = "~/Uploads/StdPicture/100_Personal.accdb";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //SingleFileUpload();
            MultiFileUpload();
        }

        private void SingleFileUpload()
        {
            if (FileUpload1.HasFile)
            {
                string fileExtension = System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();

                //validate allowed extensions
                if (fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".gif")
                {
                    //validate max file size - maximum file size: 5 MB (1024 x 1024) * 5
                    if (FileUpload1.PostedFile.ContentLength > (100 * 1024))
                    {
                        LblError.Text = "Max File size is 100kb";
                    }
                    else
                    {
                        //Store Details into DB and Get Identity value to generate FileName
                        string IdentityID = TxtName.Text; //id

                        //Generate VirtualPath for storing into DB - Store Virtual Path + FileName in DB
                        string StPictPath = "~/Uploads/StdPicture/" + IdentityID.ToString() + '_' + FileUpload1.FileName;

                        // store only file name in DB
                        //string fileNameinDB = IdentityID.ToString() + '_' + FileUpload1.FileName;

                        //string TargetFolder = Server.MapPath("~/Uploads/StdPicture/");
                        string TargetFile = Server.MapPath("~/Uploads/StdPicture/") + IdentityID.ToString() + '_' + FileUpload1.FileName;
                        FileUpload1.SaveAs(TargetFile);

                        //Update DB - Update FileName in DB Table
                    }
                }
                else
                {
                    LblError.Text = "File Format not supported";
                }

            }
            else
            {
                LblError.Text = "File Not Selected";
            }
        }

        private void MultiFileUpload()
        {
            //Store Details into DB and Get Identity value to generate FileName
            string IdentityID = TxtName.Text; //id

            foreach (HttpPostedFile selectedFiles in FileUpload1.PostedFiles)
            {
                //Response.Write(selectedFiles.FileName + "<BR>");
                selectedFiles.SaveAs(Server.MapPath("~/Uploads/StdPicture/") + IdentityID.ToString() + '_' + selectedFiles.FileName);
            }

            /*
            //Generate VirtualPath for storing into DB
            string StPictPath = "~/Uploads/StdPicture/" + IdentityID.ToString() + '_' + FileUpload1.FileName;

            //string TargetFolder = Server.MapPath("~/Uploads/StdPicture/");
            string TargetFile = Server.MapPath("~/Uploads/StdPicture/") + IdentityID.ToString() + '_' + FileUpload1.FileName;
            FileUpload1.SaveAs(TargetFile);
            */
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Image1.ImageUrl = "~/Uploads/StdPicture/689_796844.jpg"; //from db
        }
    }
}