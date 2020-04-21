using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Mariusz Krzak nr indeksu 44002

namespace ZaawansowaneProgramowanieObiektoweZal
{
    class Program
    {
        static void Main(string[] args)
        {
            //tworzenie instancji Employee
            Employee employee1 = new Employee("Mariusz", "Krzak", 35, Contract.FullTime,"84010203121",5678.88m);
            Employee employee2 = new Employee("Anna", "Kowalska", 22, Contract.PartTime, "84011234121",4532.18m);
            Employee employee3 = new Employee("Ferdynand", "Andrzejski", 35, Contract.Contract, "84010212345",3345.23m);

            //dodanie operacji dla employee1
            employee1.AddOperation("Wypłata", 3500.88m, new DateTime(2013, 11, 25));
            employee1.AddOperation("Wypłata", 3500.33m, new DateTime(2014, 12, 25));
            employee1.AddOperation("Wypłata", 3700.88m, new DateTime(2015, 01, 25));
            employee1.AddOperation("Wypłata", 40020.21m, new DateTime(2014, 02, 25));
            employee1.AddOperation("Wypłata", 4000.22m, new DateTime(2014, 03, 25));
            employee1.AddOperation("Nadgodziny", 800.26m, new DateTime(2017, 03, 25));
            employee1.AddOperation("Nadgodziny", 999.11m, new DateTime(2018, 03, 25));
            employee1.AddOperation("Premia", 1200.22m, new DateTime(2019, 03, 25));
            employee1.AddOperation("Premia", 1500.29m, new DateTime(2021, 03, 25));

            //dodanie operacji dla employee2
            employee2.AddOperation("Wypłata", 3500.88m, new DateTime(2013, 11, 25));
            employee2.AddOperation("Wypłata", 3500.33m, new DateTime(2014, 12, 25));
            employee2.AddOperation("Wypłata", 37100.88m, new DateTime(2015, 01, 25));
            employee2.AddOperation("Wypłata", 4000.21m, new DateTime(2014, 02, 25));
            employee2.AddOperation("Wypłata", 4000.22m, new DateTime(2014, 03, 25));
            employee2.AddOperation("Nadgodziny", 8100.26m, new DateTime(2017, 03, 25));
            employee2.AddOperation("Nadgodziny", 999.11m, new DateTime(2018, 03, 25));
            employee2.AddOperation("Premia", 12010.22m, new DateTime(2019, 03, 25));
            employee2.AddOperation("Premia", 1500.29m, new DateTime(2021, 03, 25));

            //dodanie operacji dla employee3
            employee3.AddOperation("Wypłata", 3500.88m, new DateTime(2013, 11, 25));
            employee3.AddOperation("Wypłata", 35020.33m, new DateTime(2014, 12, 25));
            employee3.AddOperation("Wypłata", 3110.88m, new DateTime(2015, 01, 25));
            employee3.AddOperation("Wypłata", 4200.21m, new DateTime(2014, 02, 25));
            employee3.AddOperation("Wypłata", 40100.21m, new DateTime(2014, 03, 25));
            employee3.AddOperation("Nadgodziny", 8001.26m, new DateTime(2017, 03, 25));
            employee3.AddOperation("Nadgodziny", 9919.11m, new DateTime(2018, 03, 25));
            employee3.AddOperation("Premia", 12020.22m, new DateTime(2019, 03, 25));
            employee3.AddOperation("Premia", 1500.29m, new DateTime(2021, 03, 25));

            //Sumy wszystkich operacji
            Console.WriteLine("Suma operacji dla : " + employee1);
            Console.WriteLine(employee1.GetSumOfOperations());
            Console.WriteLine("--------------");
            Console.WriteLine("Suma operacji dla : " + employee2);
            Console.WriteLine(employee2.GetSumOfOperations());
            Console.WriteLine("--------------");
            Console.WriteLine("Suma operacji dla : " + employee3);
            Console.WriteLine(employee3.GetSumOfOperations());
            Console.WriteLine("--------------");
            Console.WriteLine();


            //Wyswietla operacje od daty do daty
            Console.WriteLine("Operacje od do");
            employee1.GetOperationsFromTo(new DateTime(2013, 11, 25), new DateTime(2021, 03, 25));
            Console.WriteLine();
            employee2.GetOperationsFromTo(new DateTime(2015, 05, 11), new DateTime(2021, 03, 25));
            Console.WriteLine();
            employee3.GetOperationsFromTo(new DateTime(2014, 02, 01), new DateTime(2021, 03, 25));
            Console.WriteLine();
            
            //Urzycie indeksatora
            Console.WriteLine("Uzycie indexatora dla listy porecji");
            Console.WriteLine(employee1[1]);
            Console.WriteLine(employee1[0]);
            Console.WriteLine(employee1[2]);
            Console.WriteLine(employee2[1]);
            Console.WriteLine(employee2[0]);
            Console.WriteLine(employee3[2]);
            Console.WriteLine();

            //Lista pracownikow
            Employees employees = new Employees();

            employees.AddEmpolyee(employee1);
            employees.AddEmpolyee(employee2);
            employees.AddEmpolyee(employee3);

            //Uzycie indeksatora dla listy pracownikow
            Console.WriteLine("Pracownicy");
            Console.WriteLine(employees[0]);
            Console.WriteLine(employees[1]);
            Console.WriteLine(employees[2]);
            Console.WriteLine(employees["Mariusz","Krzak"]);
            Console.WriteLine();


            

            employees.AddEmpolyee(new Employee("uu","aa",22,Contract.PartTime, "84010212345",2323m)); //tu sie nie doda, poniewaz pedel jest juz uzyty
            employees.AddEmpolyee(new Employee("uu","aa",100,Contract.FullTime, "00010212345",23223m));
            Console.WriteLine();

            //Pobranie listy pracownikow
            Console.WriteLine("Sprawdzenie listy pracownikow" );
            employees.GetEployeesList();
            Console.WriteLine();

            //Dodanie pracownikow (usuwanie po referencji do obiektu lub jeśli dane są identyczne)
            employees.DeleteEmployee(new Employee("Mariusz", "Krzak", 35, Contract.FullTime, "84010203121",1112m));  
            employees.DeleteEmployee(employee1);

            //Uzywanie fabryki obiektów
            employees.GetEployeesList();

            employees.AddEmpolyee(EmployeesFactory.AddFullTime3000("Jan", "Dzban", 43, "222323"));
            employees.AddEmpolyee(EmployeesFactory.AddPartTimeJanusz("Kowalski", 33, "435435345", 4567m));
            Console.WriteLine();


            //Przeciazenia operatorow
            Console.WriteLine("Przeciazenia operatorow");
            Console.WriteLine(employee1 > employee2);
            Console.WriteLine(employee1 < employee2);
            Console.WriteLine("Przed dodaniem liczby");
            Console.WriteLine(employees[0]);
            Console.WriteLine("Po dodaniu liczby");
            Console.WriteLine(employees[0] + 22.32m);
            Console.WriteLine(employees[0]);
            Console.WriteLine();


            //Zmiania imiona pracownika, - wywoluje sie delegat
            Console.WriteLine("Zmiana imiona");
            employee1.ChangeName("Jakub", "Dzięcioł");
            employee1.ChangeName("Marian", "Konewka");
            Console.WriteLine();

            //Sprawdzenie listy starych imion
            foreach (var item in employee1.oldNamesList)
            {
                Console.WriteLine(item);
            }












        }








    }
}
