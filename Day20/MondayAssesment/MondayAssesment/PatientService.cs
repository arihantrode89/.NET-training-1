using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MondayAssesment
{
    internal class PatientService : IPatient
    {
        List<Patient> patients = new List<Patient>();

        public void Updatesucc(string value)
        {
            Console.WriteLine($"Patient {value} updated successfully");
            Console.WriteLine("".PadLeft(30, '-'));

        }
        public void AddPatient(byte age,string name,string address,string doctor_incharge,string disease,string room_no)
        {
            Patient patient = new Patient(name,address,disease,doctor_incharge,room_no,age);
            patients.Add(patient);
        }

        public Patient SpecificPatient(string id)
        {
            foreach(Patient patient in patients)
            {
                if(patient.Id == id)
                {
                    return patient;
                }
            }
            return null;
        }
        public Boolean UpdatePatient(string id)
        {
            try
            {
                Console.WriteLine("Choose detail for updation\n" +
                    "1.Name\n2.Age\n3.Address\n4.Doctor-In-Charge\n5.Disease\n6.Room\n7.Exit");
                byte ch = byte.Parse(Console.ReadLine());
                Patient pt = SpecificPatient(id);
                if (pt != null) {
                    switch (ch)
                    {
                        case 1:
                            Console.WriteLine("Enter Name:");
                            pt.Name = Console.ReadLine();
                            Updatesucc("Name");
                            return true;

                        case 2:
                            Console.WriteLine("Enter Age:");
                            pt.Age = byte.Parse(Console.ReadLine());
                            Updatesucc("Age");
                            return true;
                        case 3:
                            Console.WriteLine("Enter Address:");
                            pt.Address = Console.ReadLine();
                            Updatesucc("Address");
                            return true;
                        case 4:
                            Console.WriteLine("Enter Doctor-In-Charge:");
                            pt.DoctorInCharge = Console.ReadLine();
                            Updatesucc("Doctor-In-Charge");
                            return true;
                        case 5:
                            Console.WriteLine("Enter Disease:");
                            pt.Disease = Console.ReadLine();
                            Updatesucc("Disease");
                            return true;
                        case 6:
                            Console.WriteLine("Enter Room Number:");
                            pt.Room = Console.ReadLine();
                            Updatesucc("Room");
                            return true;
                        default:
                            Console.WriteLine("Thanks you using");
                            return false;
                    }
                }
                else
                {
                    throw new PatientException();
                }
            }
            catch(PatientException pe)
            {
                pe.InvalidPatientId();
                return false;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public void DeletePatient(string id)
        {
            try
            {
                Patient pt = SpecificPatient(id);
                if (pt != null)
                {
                    patients.Remove(pt);
                    Console.WriteLine("Patient Details Deleted Successfully");

                }
            }
            catch(PatientException pe)
            {
                pe.InvalidPatientId();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        public void ShowPatientDetails()
        {
            try
            {
                if (patients.Count!=0)
                {
                    Console.WriteLine("Following are Patients Details:\n");
                    foreach (Patient p in patients)
                    {

                        Console.WriteLine($"Id:{p.Id}\nName:{p.Name}\nAge:{p.Age}\n" +
                            $"Address:{p.Address}\nDoctor-In-Charge:{p.Address}\nRoom:{p.Room}");

                        Console.WriteLine("".PadLeft(30, '-'));
                    }
                }
                else
                {
                    throw new PatientException();
                }
            }
            catch(PatientException pe)
            {
                pe.EmptyList();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void ShowSpecificPatient(string id)
        {
            try
            {
                Patient pt = SpecificPatient(id);
                if (pt != null)
                {
                    Console.WriteLine($"Following are details of patient having id {pt.Id}\n");
                    Console.WriteLine($"Id:{pt.Id}\nName:{pt.Name}\nAge:{pt.Age}\n" +
                    $"Address:{pt.Address}\nDoctor-In-Charge:{pt.Address}\nRoom:{pt.Room}");

                    Console.WriteLine("".PadLeft(30, '-'));
                }
                else
                {
                    throw new PatientException();
                }
            }
            catch(PatientException pe)
            {
                pe.InvalidPatientId();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
