using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MondayAssesment
{
    internal interface IPatient
    {
        void AddPatient(byte age, string name, string address, string doctor_incharge, string disease, string room_no);

        Boolean UpdatePatient(string id);

        void DeletePatient(string id);

        void ShowPatientDetails();

        void ShowSpecificPatient(string id);

        Patient SpecificPatient(string id);
    }
}
