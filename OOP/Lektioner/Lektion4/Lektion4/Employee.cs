using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion4
{
    class Employee : Person
    {
        private static int _NextEmployeeID = 1;

        public static int NextEmployeeID
        {
            get { return _NextEmployeeID; }
            set { _NextEmployeeID = value; }
        }

        public int EmplyeeId { get; private set; }

        public Employee(string fornavn, string efternavn, int alder) : base(fornavn, efternavn, alder)
        {
            this.EmplyeeId = NextEmployeeID;
            NextEmployeeID++;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nEmployeeId: {EmplyeeId}";
        }
    }
}
