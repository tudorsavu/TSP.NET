using System;
using System.Collections.Generic;


namespace ModelDesignerFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Model Designer First");
            AddCustomersAndOrders();
            Console.ReadKey();
        }
        static void TestPerson()
        {
            using (Model1Container context = new Model1Container())
            {
                Person p = new Person()
                {
                    FirstName = "Julie",
                    LastName = "Andrew",
                    MiddleName = "T",
                    TelephoneNumber = "1234567890"
                };
                context.People.Add(p);
                context.SaveChanges();
                var items = context.People;
                foreach (var x in items)
                    Console.WriteLine("{0} {1}", x.Id, x.FirstName); 
            }   
            //TesTOneToMany();

        }

        static void TesTOneToMany()
        {
            Console.WriteLine("One to many association");
            using (Model1Container context =
                new Model1Container())
            {
                Customer c = new Customer()
                {
                    Name = "Customer 1",
                    City = "Iasi"
                };
                Order o1 = new Order()
                {
                    TotalValue = 200,
                    Date = DateTime.Now,
                    Customer = c
                };
                Order o2 = new Order()
                {
                    TotalValue = 300,
                    Date = DateTime.Now,
                    Customer = c
                };
                context.Customers.Add(c);
                context.Orders.Add(o1);
                context.Orders.Add(o2);
                context.SaveChanges();
                var items = context.Customers;
                foreach (var x in items)
                {
                    Console.WriteLine("Customer : {0}, {1}, {2}",
                        x.Id, x.Name, x.City);
                    foreach (var ox in x.Orders)
                        Console.WriteLine("\tOrders: {0}, {1}, {2}",
                            ox.Id, ox.Date, ox.TotalValue);
                }
            }
        }

        static void AddCustomersAndOrders()
        {
            Console.WriteLine("Enter number of customers to be added: ");
            int numberOfCustomers = Convert.ToInt32(Console.ReadLine());
            using (Model1Container context = new Model1Container())
            {
                for (int i = 0; i < numberOfCustomers; i++)
                {
                    Console.WriteLine("Enter customer name: ");
                    string customerName = Console.ReadLine();
                    Console.WriteLine("Enter customer city: ");
                    string customerCity = Console.ReadLine();
                    Customer customer = new Customer()
                    {
                        City = customerCity,
                        Name = customerName
                    };
                    context.Customers.Add(customer);

                    Console.WriteLine("Enter number of orders for customer: ");
                    int numberOfOrders = Convert.ToInt32(Console.ReadLine());

                    for (int j = 0; j < numberOfOrders; j++)
                    {
                        Console.WriteLine("Enter order total value: ");
                        int totalValue = Convert.ToInt32(Console.ReadLine());
                        context.Orders.Add(new Order()
                        {
                            Customer = customer,
                            CustomerId = customer.Id,
                            Date = DateTime.Now,
                            TotalValue = totalValue
                        });

                    }
                    
                }

                Console.WriteLine("Customers and orders added!");
                context.SaveChanges();
            }
        }
    }

}
