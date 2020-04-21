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

        int counter = 1; //licznik zmian imienia i nazwiska

        public List<string> oldNamesList = new List<string>(); // lista starych imion i nazwisk

        public delegate void ChangedNameOrLastname(string str); //delegat
        public ChangedNameOrLastname changedNameOrLastname; // zmienna delegata

        public void ChangeName(string newName, string newLastname)
        {
            changedNameOrLastname(newName +" "+ newLastname);
            Name = newName;
            Lastname = newLastname;

        }


        // metody dodane do delegata changedNameOrLastname
        public void ChangedA(string a)
        {
            Console.WriteLine("Jest to "+ counter++ +" zmiana imienia i nazwiska z: " + this +" na -> "+a );
        }

        public void NewlineNotice(string a)
        {
            Console.WriteLine("Zmiana danych zapisana w rejestrze zapisana w rejestrze");
            oldNamesList.Add(a);
        }

        public void MrsKrystynaAnswer(string a)
        {
            Console.WriteLine("Pani Krystyna jest zła na " + a + ", ponieważ wprowadzenie zmiany przeszkodziło w piciu kawy!!!!\n");
        }
        //------------------------------------------------


        List<Operation> operations = new List<Operation>(); //prywatna lista operacji pracownika
        public List<Operation> Operations { get { return operations; } } //zablkowoanie bezposredniej zmiany operacji (od tego jest metoda AddOperation)

        decimal salary; //wynagrodzenie
        Contract contract; //rodzaj zatrunienia (enum)

        public Employee(string name, string lastname, int age, Contract contract, string pesel, decimal salary) : base(name, lastname, age,pesel)
        {
            this.contract = contract;
            this.salary = salary;

            //Dodananie metod do delegata
            changedNameOrLastname += ChangedA;
            changedNameOrLastname += NewlineNotice;
            changedNameOrLastname += MrsKrystynaAnswer;
            //----------------------------

            oldNamesList.Add(name+" "+lastname); //zapisanie imiona do listy ktora prowadzi historie zmian imienia i nazwiska
        }


        public Operation this[int i]
        {
            get { return operations[i]; }

            // Brak settera, poniewaz do dodawania uzywamy metody AddOperation.
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



        //Przeciazenia operatorów

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
