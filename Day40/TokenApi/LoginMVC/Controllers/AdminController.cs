using LoginMVC.Filters;
using LoginMVC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace LoginMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: User

        [AuthorizationFilter]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public void Upload(FileUpload emp)
        {
            NameValueCollection obj = new NameValueCollection();
            using(WebClient webClient = new WebClient())
            {
                webClient.Headers.Add("Accept:*/*");
                webClient.Headers.Add("Content-type:application/x-www-form-urlencoded");
                MemoryStream mem = new MemoryStream();
                emp.inputImg.InputStream.CopyTo(mem);
                byte[] target = mem.ToArray();

                emp.inputImg.InputStream.Read(target, 0, target.Length);
                var filecontent = new ByteArrayContent(target);
                var str = Encoding.ASCII.GetString(target);
                obj.Add("Image",str );

                //webClient.UploadFile()
                var resp = webClient.UploadValues("https://localhost:44347/Data", "Post", obj);

                //var resp = webClient.UploadData("https://localhost:44347/Data", "Post", target);


            }
        }




    }
    public class FileUpload
    {
        public HttpPostedFileBase inputImg { get; set; }
        public HttpPostedFileBase inputPdf { get; set; }
    }
}