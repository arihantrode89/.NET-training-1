using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MondayAssesment
{
    internal class PatientIO
    {
        PatientService patientservice = new PatientService();
        public byte Menu()
        {
            Console.WriteLine("Enter your choice:\n" +
                "1.Add Patient\n2.Update Patient Details\n3.Delete Patient Details\n4.Show All Patient Details\n" +
                "5.Show Specific Patient Details\n6.Exit");

            try
            {
                byte ch = byte.Parse(Console.ReadLine());
                Console.WriteLine("".PadLeft(30, '-'));
                return ch;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }

            
        }

        public void Add()
        {
            try
            {
                Console.WriteLine("Enter Patient Name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter Patient Age:");
                byte age = byte.Parse(Console.ReadLine());

                Console.WriteLine("Enter Patient Address:");
                string address = Console.ReadLine();

                Console.WriteLine("Enter Patient's Doctor-In-Charge:");
                string doctor_incharge = Console.ReadLine();

                Console.WriteLine("Enter Patient Disease:");
                string disease = Console.ReadLine();

                Console.WriteLine("Enter Patient Room Number:");
                string room_no = Console.ReadLine();

                patientservice.AddPatient(age, name, address, doctor_incharge, disease, room_no);
                Console.WriteLine("".PadLeft(30, '-'));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }

        public void Update()
        {
            Console.WriteLine("Enter Patient Id for Updation");
            string id = Console.ReadLine();
            Boolean flg = true;
            do
            {
                flg = patientservice.UpdatePatient(id);
                Console.WriteLine("".PadLeft(30, '-'));

            } while (flg);
        }

        public void Delete()
        {
            Console.WriteLine("Enter Patient Id for Deletion");
            string id = Console.ReadLine();
            patientservice.DeletePatient(id);
            Console.WriteLine("".PadLeft(30, '-'));

        }

        public void ShowDetails()
        {
            Console.WriteLine("Following are Patients Details:\n");
            patientservice.ShowPatientDetails();
            Console.WriteLine("".PadLeft(30, '-'));

        }

        public void SpecificDetails()
        {
            Console.WriteLine("Enter Patient Id for Specific Details:");
            string id = Console.ReadLine();
            patientservice.ShowSpecificPatient(id);
            Console.WriteLine("".PadLeft(30, '-'));

        }
    }
}
