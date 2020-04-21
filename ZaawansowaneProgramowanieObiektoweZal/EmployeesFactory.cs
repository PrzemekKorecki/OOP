using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaawansowaneProgramowanieObiektoweZal
{
    public static class EmployeesFactory
    {
        //name, lastname, age,pesel
        public static Employee AddPartTimeJanusz(string lastname,int age, string pesel,decimal salary)
        {
            return new Employee("Janusz", lastname, age, Contract.PartTime, pesel, salary);
        }

        public static Employee AddFullTime3000(string name, string lastname,int age, string pesel)
        {
            return new Employee(name, lastname, age, Contract.FullTime, pesel, 3000m);
        }
    }
}
