using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Utwórz klasę
Employees, z polem jako listą pracowników, i dodaj w tej klasie indeksator zwracający
jednego pracownika na podstawie podanego indeksu. W tej samej klasie utwórz też drugi
indeksator, który zwraca pracownika na podstawie jego imienia i nazwiska.*/


namespace ZaawansowaneProgramowanieObiektoweZal
{
    class Employees
    {
        List<Employee> employeesList = new List<Employee>();


        public List<Employee> EmployeesList { get { return employeesList; } }

        public Employee this[int i]
        {
            get
            {
                return EmployeesList[i];
            }
        }

        public Employee this[string name, string lastname]
        {
            get
            {
                foreach (Employee emp in employeesList)
                {
                    if (emp.Name.Equals(name)&&emp.Lastname.Equals(lastname))
                    {
                        return emp;
                    }
                }
                Console.WriteLine($"Brak pracownika: {name} {lastname}");
                return null;
            }
        }



        public void AddEmpolyee(Employee employee)
        {
            if (EmployeesList.Contains(employee))
            {
                Console.WriteLine("Użytkownik już istnieje");
                return;
            }

            foreach (Employee emp in employeesList)
            {
                if (emp.pesel.Equals(employee.pesel))
                {
                    Console.WriteLine("Uzytkownik o podanym peselu juz istnieje");
                    return;
                }
            }

            employeesList.Add(employee);
        }
        public void DeleteEmployee(Employee employee)
        {
            if (EmployeesList.Contains(employee))
            {
                Console.WriteLine($"Usunięto {employee}");
                employeesList.Remove(employee);
                return;
            }

            foreach (Employee emp in EmployeesList)
            {
                if (emp.Name==employee.Name&&emp.Lastname==employee.Lastname&&emp.pesel==employee.pesel)
                {
                    Console.WriteLine($"Usunięto {emp}");
                    employeesList.Remove(emp);
                    return;
                }
            }

            Console.WriteLine($"Nie ma takiego pracownika: {employee}");
            return;

        }

        public List<Employee> GetEployeesList()
        {
            foreach (Employee emp in EmployeesList)
            {
                Console.WriteLine(emp);
            }
            return EmployeesList;
        }







    }
}
