using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MondayAssesment
{
    internal class HospitalManagement
    {
        static void Main(string[] args)
        {
            PatientIO hospital = new PatientIO();
            Boolean flag=true;
            do
            {
                switch(hospital.Menu())
                {
                    case 1:
                        hospital.Add();
                        flag=true;
                        break;
                    case 2:
                        hospital.Update();
                        flag = true;
                        break;
                    case 3:
                        hospital.Delete();
                        flag = true;
                        break;
                    case 4:
                        hospital.ShowDetails();
                        flag = true;
                        break;
                    case 5:
                        hospital.SpecificDetails();
                        flag = true;
                        break;
                    default:
                        flag = false;
                        break;
                }
                
            }while(flag);
        }
    }
}
