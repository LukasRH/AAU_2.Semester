using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion4
{
    class Person
    {
        private static int _NextPersonID = 1;

        public static int NextPersonID
        {
            get { return _NextPersonID; }
            set { _NextPersonID = value; }
        }

        private string _Fornavn;
        private string _Efternavn;
        private int _Alder;

        public int Id { get; private set; }
        
        public Person(string fornavn, string efternavn, int alder)
        {
            this.Id = Person.NextPersonID;
            NextPersonID++;

            _Fornavn = fornavn;
            _Efternavn = efternavn;
            _Alder = alder;
        }

        public override string ToString()
        {
            return $"Fornavn: {_Fornavn} \nEfternavn: {_Efternavn}\nAlder: {_Alder}\nPerson ID: {Id}";
        }

        public string Navn
        {
            get
            {
                return _Fornavn + " " + _Efternavn;
            }
        }

        public int alder { get { return _Alder; } set { if (value >= 0) _Alder = value; } }
    }
}
