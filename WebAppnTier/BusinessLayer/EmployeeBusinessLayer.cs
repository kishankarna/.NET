using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DalLayer;
using System.Data;
namespace BusinessLayer
{
    public class EmployeeBusinessLayer
    {

        //Get Employee Data
        public IEnumerable<Employee> Employees
        {
        
            get{


                List<Employee> EmpList = new List<Employee>();
                DataTable dt = EmployeeSqlHelper.EmployeeData();

                foreach (DataRow row in dt.Rows)
                {
                    Employee em = new Employee();
                    em.ID = (int)row["ID"];
                    em.Name = (string)row["Name"];
                    em.Gender =(string)row["Gender"];
                    em.City = (string)row["City"];
                    em.Department_ID = (int)row["Department_ID"];
                    EmpList.Add(em);
                }

                return EmpList;
        
            }
        }
        //Add Employee
        public void AddEmployee(Employee emp)
        {

            EmployeeSqlHelper.AddEmployee( emp.Name, emp.Gender, emp.City, emp.Department_ID);


        }
        //Edit Employee
        public void EditEmployee(Employee emp)
        {

            EmployeeSqlHelper.EditEmployee(emp.ID, emp.Name, emp.Gender, emp.City, emp.Department_ID);
        }

        // Delete Employee

        public void DeleteEmployee( int id)
        {
            EmployeeSqlHelper.DeleteEmployee(id);

        }


    }
}
