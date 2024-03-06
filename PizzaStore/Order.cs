using System;
namespace PizzaStore
{
	public class Order
	{
		double _taxpct;
        private double _taxPct;
        double _deliveryCosts;
		Pizza p;
        Costumer c;

		public Order(Pizza pizza, Costumer customer)
		{
			p = pizza;
            _taxpct = 25.0;
			_deliveryCosts = 40.0;
		}

        double TaxPct
        {
            get { return _taxPct; }
            set { _taxPct = value; }
        }

        double DeliveryCosts
        {
            get { return _deliveryCosts; }
            set { _deliveryCosts = value; }
        }

        public override string ToString()
        {
            return $"Pizza:{p.Name} - _taxpct:{_taxpct} - _deliveryCosts: {DeliveryCosts} - Total: {CalculateTotalPrice()}";
        }

        public double CalculateTotalPrice()
        {
            return p.Price * (1 + _taxPct / 100) + _deliveryCosts;
        }




    }






}

