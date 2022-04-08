using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollOperation
{
    public class EmployeePayrollOperation
    {
        List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();

        public void addEmployeePayroll(List<EmployeeDetails> listEmployeeDetails)
        {
            listEmployeeDetails.ForEach(employeedata =>
            {
                Console.WriteLine("Employee being added : " + employeedata.EmployeeName);
                this.addEmployeePayroll(employeedata);
                Console.WriteLine("Employee added :" + employeedata.EmployeeName);
            }
            );
            Console.WriteLine(this.employeeDetails.ToString());
        }
        private void addEmployeePayRoll(EmployeeDetails emp)
        {
            employeeDetails.Add(emp);
        }

        public void addEmployeePayRollwiththread(List<EmployeeDetails> listemployeedetails)
        {
            listemployeedetails.ForEach(employeedata =>
         {
             Task thread = new Task(() =>
             {
                 Console.WriteLine("Employee being added : " + employeedata.EmployeeName);
                 this.addEmployeePayroll(employeedata);
                 Console.WriteLine("Employee added :" + employeedata.EmployeeName);

             });
             thread.Start();
         });
    }
    }
}

