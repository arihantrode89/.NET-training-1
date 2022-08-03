using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class ContactInfoManager
    {

        #region Class Methods
        public void createContact(ContactInfo obj)
        {
            obj.Address = "Deshpande Layout";
            obj.City = "Nagpur";
            obj.State = "Maharashtra";
            obj.Email = "arihantrode89@gmail.com";
            obj.Phone = "9000000000";
            obj.Country = "India";
            obj.Mobile = "9637010084";


            Console.WriteLine("CreateContact func is called");
            Console.WriteLine("".PadLeft(30, '-'));
        }
        

        public void displayContact(ContactInfo obj)
        {
            Console.WriteLine("Address:{0}\nCity:{1}\nState:{2}\nCountry:{3}\nPhone:{4}\nEmailId:{5}\nMobileNo:{6}"
                ,obj.Address,obj.City,obj.State,obj.Country,obj.Phone,obj.Email,obj.Mobile);
        }

        #endregion
    }
}
