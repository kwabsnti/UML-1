using System;
namespace PizzaStore
{
	public class Store
	{
		public Store()
		{
		}
		public void Start()
		{
			Pizza pizza1 = new Pizza("Vesuvio", 75);
            Pizza pizza2 = new Pizza("Calzone", 80);
            Pizza pizza3 = new Pizza("Naples", 79);

            Costumer customer1 = new Costumer("Jason","Vejebrovej 4");
            Costumer customer2 = new Costumer("David","Byvenget 12");
            Costumer customer3 = new Costumer("John","Gildbrovej 8");

			Order o1 = new Order(pizza1, customer1);
            Order o2 = new Order(pizza2, customer1);
            Order o3 = new Order(pizza3, customer1);

            Console.WriteLine("Order Information");

            Console.WriteLine(pizza1);
            Console.WriteLine(pizza2);
            Console.WriteLine(pizza3);



            Console.WriteLine(o1);
            Console.WriteLine(o2);
            Console.WriteLine(o3);

            Console.WriteLine(customer1);
            Console.WriteLine(customer2);
            Console.WriteLine(customer3);


        }
    }
}

