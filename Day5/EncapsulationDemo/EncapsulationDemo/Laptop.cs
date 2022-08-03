using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDemo
{
    
    internal class Laptop
    {
        #region Data fields
        string _laptopName;
        int _modelNumber;
        float _amount;
        byte _ram;
        #endregion

        #region Constructor
        public Laptop()
        {

        }
        /// <summary>
        /// Parameterised Constructor
        /// </summary>
        /// <param name="laptopName"></param>
        /// <param name="modelNumber"></param>
        /// <param name="amount"></param>
        /// <param name="ram"></param>
        public Laptop(string laptopName, int modelNumber, float amount, byte ram   )
        {
            this._laptopName = laptopName;
            this._modelNumber = modelNumber;
            this._amount = amount;
            this._ram = ram;
        }
        #endregion

        #region Properties
        public string GetLaptopName()
        { 
            return _laptopName;
        }

        public int GetModelNumber()
        {
            return _modelNumber;
        }

        public float GetAmount()
        {
            return _amount;
        }

        public byte GetRam()
        {
            return _ram;
        }

        #endregion

        #region Properties for setting and validation data fields

        public void SetLaptopName(string laptopname)
        {
            if (laptopname.Length != 0)
            { 
                _laptopName = laptopname;
            }
        }

        public void SetRam(byte ram)
        {
            if (ram!= 0)
            {
                _ram = ram;
            }
        }

        public void SetModelNumber(int modelnumber)
        {
            if (modelnumber!= 0)
            {
                _modelNumber = modelnumber;
            }
        }

        public void SetAmount(float amount)
        {
            if (amount!= 0)
            {
                _amount = amount;
            }
        }

        #endregion

    }
}
