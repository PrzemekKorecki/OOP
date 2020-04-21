using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaawansowaneProgramowanieObiektoweZal
{
    public class Person
    {
        private string name, lastname;

        public string Name { get { return name; } set { name = value; } }
        public string Lastname { get { return lastname; } set { lastname = value; } }



        int age;
        public string pesel;


        public Person(string name, string lastname, int age, string pesel)
        {
            this.name = name;
            this.lastname = lastname;
            this.age = age;
            this.pesel = pesel;
        }

        public override string ToString()
        {
            return String.Format($"{name} {lastname}, wiek: {age}");
        }

    }
}
