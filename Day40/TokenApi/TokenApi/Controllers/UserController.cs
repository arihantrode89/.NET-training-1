using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Http;
using TokenApi.Models;

namespace TokenApi.Controllers
{
    public class UserController : ApiController
    {
        ForumSiteEntities db = new ForumSiteEntities();


        [Authorize(Roles ="Admin")]
        [Route("Admin")]
        [HttpGet]
        public UserManagement Admin()
        {
            var user = User.Identity;
            return db.UserManagements.FirstOrDefault(s => s.UserName == user.Name);
        }

        [Authorize(Roles = "Admin")]
        [Route("Student")]
        [HttpGet]
        public UserManagement Student()
        {
            var user = User.Identity;
            return db.UserManagements.FirstOrDefault(s => s.UserName == user.Name);
        }

        [Route("GetDetails")]
        [HttpGet]
        public UserManagement GetUserDetails()
        {
            var user = User.Identity;
            return db.UserManagements.FirstOrDefault(s => s.UserName == user.Name);
        }

        [HttpPost]
        [Route("Data")]
        public void UploadFile([FromBody] JToken ee)
        {

            var data = JsonConvert.DeserializeObject<FileModel>(ee.ToString());
            var bytes = Encoding.ASCII.GetBytes(data.Image);
            var path = Path.Combine("~/UploadedData","image");
            File.WriteAllBytes(HostingEnvironment.MapPath(path), bytes);
            
            //var img = (HttpPostedFileBase)new MemoryPostedFile(bytes,"sample.jpg");
            //var path = Path.Combine("~/LoginMVC/UploadedData", img.FileName);
            //img.SaveAs(path);
            
        }


        [Route("Gett")]
        [HttpPost]
        public UserManagement ABc([FromBody] JToken ee)
        {
            var user = User.Identity;
            var data = JsonConvert.DeserializeObject<model>(ee.ToString());
            return db.UserManagements.FirstOrDefault(s => s.UserName == data.username && s.Password == data.password);
        }
    }
    public class model
    {
        public string username { get; set; }
        public string password { get; set; }
    }

    public class FileModel
    {
        public string Image { get; set; }
        public string Pdf { get; set; }
    }

    public class MemoryPostedFile : HttpPostedFileBase
    {
        private readonly byte[] fileBytes;

        public MemoryPostedFile(byte[] fileBytes, string fileName = null)
        {
            this.fileBytes = fileBytes;
            this.FileName = fileName;
            this.InputStream = new MemoryStream(fileBytes);
        }

        public override int ContentLength => fileBytes.Length;

        public override string FileName { get; }

        public override Stream InputStream { get; }

        public override void SaveAs(string filename)
        {
            base.SaveAs(filename);
        }
    }
}
