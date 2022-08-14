using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayers;
using Entity;

namespace BusinessLayer
{
    public class EmployeeDepartmentBusinessLayer
    {
        EmployeeDepartmentDataAccessLayer obj = new EmployeeDepartmentDataAccessLayer();
        public void AddEmployee(Employee e,string dept_name)
        {
            try
            {
                obj.InsertEmployeeData(e,dept_name);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public bool UpdateEmployee(int id ,string col)
        {
            try
            {
                return obj.UpdateEmployeeData(id,col);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool DeleteEmployee (int id)
        {
            try
            {
                return obj.DeleteEmployeeData(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public void ShowDetails()
        {
            try
            {
                obj.ShowDetails();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public bool? ShowSpecifcDetails(int id)
        {
            try
            {
                return obj.ShowSpecificEmployeeDetails(id);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public void UpdateEmpDept(int id,string dept_name)
        {
            try
            {
                obj.UpdateEmployeeDept(dept_name,id);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


    }
}
