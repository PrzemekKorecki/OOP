using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaawansowaneProgramowanieObiektoweZal
{
    public class Operation
    {
        string name;
        decimal ammount;
        DateTime date;



        public decimal Ammount { get { return ammount; } }
        public DateTime Date { get { return date; } }




        public Operation(string name, decimal ammount, DateTime date)
        {
            this.name = name;
            this.ammount = ammount;
            this.date = date;
        }







        public override string ToString()
        {
            return String.Format($"{name} {ammount} zł, dnia: {date:dd/MM/yyyy} r.");
        }


    }
}
