using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeApi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.Headers.Add("Accept:application/json");
                webClient.Headers.Add("Content-type:application/json");
                var response = webClient.DownloadString("https://localhost:44333/GetEmployee");
                Console.WriteLine(response);
            }
            
        }
    }
}
