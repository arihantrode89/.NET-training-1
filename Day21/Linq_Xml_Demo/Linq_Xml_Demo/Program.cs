using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Linq_Xml_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string str = @"<?xml version=""1.0"" encoding=""utf-8""?>
                        <country name=""Arihant""><capital>Delhi</capital>
                        </country>";

            XDocument doc = XDocument.Parse(str,LoadOptions.PreserveWhitespace);
            Console.WriteLine(doc);

            XElement xele = XElement.Load(@"C:\Users\kalya\source\repos\arihantrode\.NET-training\Day21\Practice_Xml.xml");

            //var dict = (from element in xele.Descendants("HR")
            //            let name = element.Elements("Employee")
            //            let empname = element.Element("Employee").Element("Name")
            //            orderby name.Elements("Name")
            //            select new
            //            {
            //               Name = name.Select(s=>s.Elements("Name").ToList()),
            //               Role = name.Select(s=>s.Elements("Role"))
            //            }).ToDictionary(s=>s.Name,s=>s.Role);

            //foreach(var item in dict)
            //{
            //   foreach(var item2 in item.Key)
            //    {
            //        foreach (var item3 in item2)
            //        {
            //            Console.WriteLine(item3.Value);
            //        }
            //    }
            //}

            var result = (from element in xele.Descendants("Department").Descendants("Employee")
                         let EmpName = element.Element("Name").Value
                         let Role = element.Element("Role").Value
                         orderby EmpName
                         select new { Name = EmpName, Role = Role }).ToDictionary(s=>s.Name,s=>s.Role);
                           
            //var result = xele.Descendants("Department").Select( s=>new { Name=(string)s.Element("Name"),Role=(string)s.Element("Employee").Element("Role")});
            foreach(var a in result)
            {
                Console.WriteLine(a.Key + '-'+a.Value);
            }

    
        }
    }
}
