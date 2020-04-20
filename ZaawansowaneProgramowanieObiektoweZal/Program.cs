using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


 /*Dodaj do klasy Employee metody umożliwiające przeglądanie jego operacji finansowych,
dodawanie nowej operacji, obliczanie sumy wszystkich operacji, pobieranie operacji z
podanego przedziału dat*/



namespace ZaawansowaneProgramowanieObiektoweZal
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Mariusz", "Krzak", 35, Contract.FullTime,"84010203121",5678.88m);
            Employee employee2 = new Employee("Anna", "Kowalska", 22, Contract.PartTime, "84011234121",4532.18m);
            Employee employee3 = new Employee("Ferdynand", "Andrzejski", 35, Contract.Contract, "84010212345",3345.23m);



            //dodanie operacji
            employee1.AddOperation("Wypłata", 3500.88m, new DateTime(2013, 11, 25));
            employee1.AddOperation("Wypłata", 3500.33m, new DateTime(2014, 12, 25));
            employee1.AddOperation("Wypłata", 3700.88m, new DateTime(2015, 01, 25));
            employee1.AddOperation("Wypłata", 4000.21m, new DateTime(2014, 02, 25));
            employee1.AddOperation("Wypłata", 4000.22m, new DateTime(2014, 03, 25));
            employee1.AddOperation("Nadgodziny", 800.26m, new DateTime(2017, 03, 25));
            employee1.AddOperation("Nadgodziny", 999.11m, new DateTime(2018, 03, 25));
            employee1.AddOperation("Premia", 1200.22m, new DateTime(2019, 03, 25));
            employee1.AddOperation("Premia", 1500.29m, new DateTime(2021, 03, 25));

            Console.WriteLine("Suma operacji:");
            Console.WriteLine("--------------");
            Console.WriteLine(employee1.GetSumOfOperations());
            Console.WriteLine("--------------");
            employee1.ShowAllOperations();
            Console.WriteLine("Operacje od do");
            employee1.GetOperationsFromTo(new DateTime(2013, 11, 25), new DateTime(2021, 03, 25));
            employee1.GetOperationsFromTo(new DateTime(2022, 11, 25), new DateTime(2023, 03, 25));

            //-------------------------------------------------------------------------------------
            Console.WriteLine("Uzycie indexatora");
            Console.WriteLine(employee1[1]);

            //---empolyees

            Employees employees = new Employees();

            employees.AddEmpolyee(employee1);
            employees.AddEmpolyee(employee2);
            employees.AddEmpolyee(employee3);

            Console.WriteLine("Pracownicy");
            Console.WriteLine(employees[0]);
            Console.WriteLine(employees[1]);
            Console.WriteLine(employees[2]);

            Console.WriteLine(employees["Mariusz","Krzak"]);

            //---------
            employees.AddEmpolyee(new Employee("uu","aa",22,Contract.PartTime, "84010212345",2323m));

            employees.DeleteEmployee(new Employee("Mariusz", "Krzak", 35, Contract.FullTime, "84010203121",1112m));
            employees.DeleteEmployee(employee1);

            //--- get employees list


            employees.GetEployeesList();


            employees.AddEmpolyee(EmployeesFactory.AddFullTime3000("Jan", "Dzban",43, "222323"));
            employees.AddEmpolyee(EmployeesFactory.AddPartTimeJanusz("Kowalski", 33, "435435345",4567m));

            employees.GetEployeesList();




            Console.WriteLine();

            Console.WriteLine(employee1 > employee2);
            Console.WriteLine(employee1 < employee2);
            Console.WriteLine("Przed dodanie liczby");
            Console.WriteLine(employees[0]);
            Console.WriteLine("Po dodaniu liczby");
            Console.WriteLine(employees[0] + 22.32m);
            Console.WriteLine(employees[0]);


        }








    }
}
