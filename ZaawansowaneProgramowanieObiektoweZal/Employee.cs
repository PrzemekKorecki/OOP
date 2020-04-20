using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




/* Dodaj do klasy Employee metody umożliwiające przeglądanie jego operacji finansowych,
dodawanie nowej operacji, obliczanie sumy wszystkich operacji, pobieranie operacji z
podanego przedziału dat*/



namespace ZaawansowaneProgramowanieObiektoweZal
{
    public class Employee: Person
    {
        //public delegate Delegacja(string s);
        //public delegate zmiana;

        public delegate void ChangedNameOrLastname(string a);
        public ChangedNameOrLastname changedNameOrLastname; // zmienna, pole klasy


        

        //public void ChangeName

        














        List<Operation> operations = new List<Operation>();

        public List<Operation> Operations { get { return operations; } }

        decimal salary;



        Contract contract;

        public Employee(string name, string lastname, int age, Contract contract, string pesel, decimal salary) : base(name, lastname, age,pesel)
        {
            this.contract = contract;
            this.salary = salary;
        }


        public Operation this[int i]
        {
            get { return operations[i]; }

            // Nie uzywamy settera poniewaz do dodawania uzywamy metody AddOperation.
            // set { operations[i] = value; }
        }





        public void ShowAllOperations()
        {
            Console.WriteLine($"Operacje pracownika: {this}");
            for (int i = 0; i < operations.Count; i++)
            {
                Console.WriteLine($"{i+1}. {operations[i]}");
            }
        }
        public void AddOperation(string name, decimal ammount, DateTime date)
        {
            operations.Add(new Operation(name, ammount, date));
        }

        public decimal GetSumOfOperations()
        {
            decimal result = 0;
            foreach (Operation op in operations)
            {
                result += op.Ammount;
            }
            return result;
        }

        public List<Operation> GetOperationsFromTo(DateTime from, DateTime to)
        {
            List<Operation> result = new List<Operation>();
            int counter = 1;

            Console.WriteLine($"Operacje pracownika: {this}, w dniach od: {from:dd/MM/yyyy} do: {to:dd/MM/yyyy}");

            foreach (Operation op in operations)
            {
                if (op.Date>=from && op.Date<=to)
                {
                    result.Add(op);
                    Console.WriteLine(counter++ + ". " + op);
                }
            }

            return new List<Operation>();
        }


        public override string ToString()
        {
            return base.ToString() + " " + contract + " "+salary+" zł";
        }


        public static bool operator < (Employee emp1, Employee emp2)
        {
            if (emp1.salary < emp2.salary)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >(Employee emp1, Employee emp2)
        {
            if (emp1.salary > emp2.salary)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static decimal operator +(Employee emp1, decimal number)
        {
            emp1.salary += number;
            return emp1.salary;
        }











    }
}
