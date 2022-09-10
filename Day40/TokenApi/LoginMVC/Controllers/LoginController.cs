using LoginMVC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;
using TokenApi.Models;

namespace LoginMVC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string UserName, string Password)
        {
            string url = "https://localhost:44347/token";
            string getdetails = "https://localhost:44347/getdetails";

            NameValueCollection obj = new NameValueCollection();
            obj.Add("UserName", UserName);
            obj.Add("Password", Password);
            obj.Add("grant_type", "password");

            try
            {
                using (WebClient web = new WebClient())
                {
                    web.Headers.Add("Accept:*/*");
                    web.Headers.Add("Content-type:application/x-www-form-urlencoded");

                    var data = JsonConvert.SerializeObject(obj).ToString();
                    var resp = web.UploadValues(url, "Post", obj);
                    //var resp1= web.UploadData(url,"Post");
                    var str = Encoding.ASCII.GetString(resp);
                    var token = JsonConvert.DeserializeObject<Token>(str).access_token;
                    web.Headers.Add("Accept:*/*");
                    web.Headers.Add($"Authorization:Bearer {token}");
                    var dash = web.DownloadString(getdetails);
                    var userdata = JsonConvert.DeserializeObject<UserManagement>(dash);

                    Session["token"] = token;
                    Session["username"] = userdata.UserName;
                    Session["role"] = userdata.Role;
                    Session["email"] = userdata.EmailId;

                    TempData["token"] = token;

                    HttpCookie cook = new HttpCookie("UserData");
                    cook["Name"] = userdata.UserName;
                    cook["role"] = userdata.Role;
                    cook["email"] = userdata.EmailId;

                    Response.Cookies.Add(cook);


                }
                return RedirectToActionPermanent("Index", Session["role"].ToString());
            }
            catch(WebException httpex)
            {
                var resp = (HttpWebResponse)httpex.Response;
                if(resp.StatusCode == HttpStatusCode.BadRequest)
                {
                    ViewBag.Message = "Invalid Username or Password";
                    return View();
                }
            }
            return View();

        }

        public ActionResult Logout()
        {

            Session.Remove("token");
            Session.Remove("username");
            Session.Remove("role");
            Session.Remove("email");
            return RedirectToAction("Login", "Login");
        }

        public void Sample()
        {
            NameValueCollection obj = new NameValueCollection();
            obj.Add("username", "Arihant");
            obj.Add("password", "12345");
            using (WebClient web = new WebClient())
            {
                web.Headers.Add("Accept:*/*");
                //web.Headers.Add("Content-type:application/json");
                var resp = web.UploadValues("https://localhost:44347/Gett", "Post", obj);
                var str = Encoding.ASCII.GetString(resp);
            }
        }
    }

    public class Token
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public string expires_in { get; set; }
    }
}