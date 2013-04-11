﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace SNFramework.BSF.Moudles.SystemManage.FileManage
{
    /// <summary>
    /// Summary description for FileUpload
    /// </summary>
    public class FileUpload : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            try
            {
                HttpPostedFile file;
                for (int i = 0; i < context.Request.Files.Count; ++i)
                {
                    file = context.Request.Files[i];
                    if (file == null || file.ContentLength == 0 || string.IsNullOrEmpty(file.FileName)) continue;
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    string fileFullName = HttpContext.Current.Server.MapPath("~/Moudles/SystemManage/FileManage/UploadFiles" + "/" + fileName);
                    file.SaveAs(fileFullName);
                    context.Response.Write(fileName);
                    context.Response.Flush();
                }
            }
            catch (Exception ex)
            {
                context.Response.StatusCode = 500;
                context.Response.Write(ex.Message);
                context.Response.End();
            }
            finally
            {
                context.Response.End();
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}