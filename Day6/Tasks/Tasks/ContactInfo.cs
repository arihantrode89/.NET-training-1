using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class ContactInfo
    {
        #region Data fields
        string _address, _city,_state,_country,_phoneNo,_mobileNo,_email;

        #endregion

        #region Constructor
        public ContactInfo(string address,string city,string state,string country,string phoneNo,string email)
        {
            this._address = address;    
            this._email = email;
            this._city = city;
            this._state = state;
            this._country = country;
            this._phoneNo = phoneNo;
        }

        #endregion

        #region Properties
        public string Address
        {
            get 
            {
                return _address;
            }

            set
            { 
                _address = value;
            }
        }

        public string City
        {
            get
            {
                return _city;
            }

            set
            {
                _city = value;
            }
        }

        public string State
        {
            get
            {
                return _state;
            }

            set
            {
                _state = value;
            }
        }

        public string Country
        {
            get
            {
                return _country;
            }

            set
            {
                _country = value;
            }
        }

        public string Phone
        {
            get
            {
                return _phoneNo;
            }

            set
            {
                _phoneNo = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

        public string Mobile
        {
            get
            {
                return _mobileNo;
            }

            set
            {
                _mobileNo = value;
            }
        }

        #endregion
    }
}
