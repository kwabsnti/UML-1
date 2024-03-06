using System;
using System.Xml.Linq;

namespace PizzaStore
{
    public class Costumer
    {
        string _name;

        string _adresse;
        string _tlfnr;
        private string v1;
        private string v2;

        public Costumer(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public Costumer(string name, string adresse, string tlfnr)
        {
            _name = name;

            _adresse = adresse;
            _tlfnr = tlfnr;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }



        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }

        public string Tlfnr
        {
            get { return _tlfnr; }
            set { _tlfnr = value; }
        }

        public override string ToString()
        {
            return $"Navn: {Name} - Telefon nummer: {Tlfnr} - Adresse: {Adresse}";

        }
    }
}
