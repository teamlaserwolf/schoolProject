using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    class tester
    {
        public static void Main()
        {
            Console.WriteLine("We are live!");
            tester test = new tester();
            test.selectEmployee();
            Console.ReadLine();
        }

        private void selectEmployee()
        {
            EmployeeService employeeService = new EmployeeService();
            employeeService.selectEmployee(1);
            employeeService.display();
        }
    }
}
