using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion2
{
    class Person
    {
        private static int _NextPersonID = 1;

        public static int NextPersonID
        {
            get { return _NextPersonID; }
            set { _NextPersonID = value; }
        }

        string _Fornavn;
        string _Efternavn;
        int _Alder;

        public int Id { get; private set; }

        public Person(string fornavn, string efternavn)
            : this(fornavn, efternavn, null, null)
        { }

        public Person(string fornavn, string efternavn, Person mor, Person far)
        {
            this.Id = Person.NextPersonID;
            NextPersonID++;

            _Fornavn = fornavn;
            _Efternavn = efternavn;
            Mor = mor;
            Far = far;
        }

        public string Navn
        {
            get
            {
                return _Fornavn + " " + _Efternavn;
            }
        }

        public int alder { get { return _Alder; } set { if (value >= 0) _Alder = value; } }

        public Person Mor { set { if (value.Navn != null) Mor = value; } get { return Mor; } }
        public Person Far { set { if (value.Navn != null) Far = value; } get { return Far; } }
    }
}
