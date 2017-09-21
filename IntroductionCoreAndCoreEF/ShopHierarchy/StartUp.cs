namespace ShopHierarchy
{
    using System;
    using System.Linq;
    using Entities;

    class StartUp
    {
        static void Main()
        {
            using (ShopDb shopDatabase = new ShopDb())
            {
                ClearDatabase(shopDatabase);
                FillSalesmen(shopDatabase);
                FillItems(shopDatabase);
                ReadCommands(shopDatabase);
                //PrintSalesmenWithCustomerCount(shopDatabase);
                //PrintCustomersWithOrderAndReviewCount(shopDatabase);
                //PrintOrdersWithItemsAndReviews(shopDatabase);
                //PrintCustomerWithOrdersReviewsAndSalesman(shopDatabase);
                //PrintCustomerOrdersWithMoreThanOneItem(shopDatabase);
            }
        }

        private static void ClearDatabase(ShopDb shopDatabase)
        {
            shopDatabase.Database.EnsureDeleted();
            shopDatabase.Database.EnsureCreated();
        }

        private static void FillSalesmen(ShopDb shopDatabase)
        {
            string[] salesmenNames = Console.ReadLine().Split(';');

            foreach (string salesman in salesmenNames)
            {
                Salesman s = new Salesman()
                {
                    Name = salesman
                };

                shopDatabase.Add(s);
            }

            shopDatabase.SaveChanges();
        }

        private static void FillItems(ShopDb shopDatabase)
        {
            string itemLine;

            while (!(itemLine = Console.ReadLine()).Equals("END"))
            {
                string[] itemData = itemLine.Split(';');

                string name = itemData[0];
                decimal price = decimal.Parse(itemData[1]);

                shopDatabase.Add(new Item()
                {
                    Name = name,
                    Price = price
                });
            }

            shopDatabase.SaveChanges();
        }

        private static void ReadCommands(ShopDb shopDatabase)
        {
            string command;

            while (!(command = Console.ReadLine()).Equals("END"))
            {
                string[] commandArgs = command.Split('-');
                string commandType = commandArgs[0];

                switch (commandType)
                {
                    case "register":
                        string[] customerData = commandArgs[1].Split(';');
                        string name = customerData[0];
                        int salesmanId = int.Parse(customerData[1]);

                        shopDatabase.Add(new Customer()
                        {
                            Name = name,
                            SalesmanId = salesmanId
                        });

                        shopDatabase.SaveChanges();
                        break;

                    case "order":
                        string[] orderData = commandArgs[1].Split(';');
                        int customerId = int.Parse(orderData[0]);

                        Order order = new Order() { CustomerId = customerId };

                        for (int i = 1; i < orderData.Length; i++)
                        {
                            int itemId = int.Parse(orderData[i]);

                            order.Items.Add(new ItemOrder()
                            {
                                ItemId = itemId
                            });
                        }

                        shopDatabase.Add(order);
                        shopDatabase.SaveChanges();
                        break;

                    case "review":
                        string[] reviewData = commandArgs[1].Split(';');
                        customerId = int.Parse(reviewData[0]);
                        int id = int.Parse(reviewData[1]);

                        shopDatabase.Customers.Find(customerId).Reviews.Add(new Review()
                        {
                            CustomerId = customerId,
                            ItemId = id
                        });

                        shopDatabase.SaveChanges();
                        break;
                }
            }
        }

        private static void PrintSalesmenWithCustomerCount(ShopDb shopDatabase)
        {
            var salesmen = shopDatabase.Salesmen
                .Select(s => new
                {
                    s.Name,
                    Customers = s.Customers.Count
                }).ToList()
                .OrderByDescending(s => s.Customers)
                .ThenBy(s => s.Name);

            foreach (var salesman in salesmen)
            {
                Console.WriteLine($"{salesman.Name} - {salesman.Customers} customers");
            }
        }

        private static void PrintCustomersWithOrderAndReviewCount(ShopDb shopDatabase)
        {
            var customers = shopDatabase.Customers
                .Select(c => new
                {
                    c.Name,
                    Orders = c.Orders.Count,
                    Reviews = c.Reviews.Count
                })
                .ToList()
                .OrderByDescending(c => c.Orders)
                .ThenByDescending(c => c.Reviews);

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name);
                Console.WriteLine($"Orders: {customer.Orders}");
                Console.WriteLine($"Reviews: {customer.Reviews}");
            }
        }

        private static void PrintOrdersWithItemsAndReviews(ShopDb shopDatabase)
        {
            int customerId = int.Parse(Console.ReadLine());

            var customerItems = shopDatabase.Customers
                .Where(c => c.Id == customerId)
                .Select(c => new
                {
                    Orders = c.Orders.Select(o => new
                    {
                        o.Id,
                        o.Items.Count
                    }),
                    Reviews = c.Reviews.Count
                }).FirstOrDefault();

            foreach (var order in customerItems.Orders)
            {
                Console.WriteLine($"order {order.Id}: {order.Count}");
            }
            Console.WriteLine($"reviews: {customerItems.Reviews}");
        }

        private static void PrintCustomerWithOrdersReviewsAndSalesman(ShopDb shopDatabase)
        {
            int customerId = int.Parse(Console.ReadLine());

            var customorInfo = shopDatabase.Customers
                .Where(c => c.Id == customerId)
                .Select(c => new
                {
                    c.Name,
                    Orders = c.Orders.Count,
                    Reviews = c.Reviews.Count,
                    Salesman = c.Salesman.Name
                })
                .FirstOrDefault();

            Console.WriteLine($"Customer: {customorInfo.Name}");
            Console.WriteLine($"Orders count: {customorInfo.Orders}");
            Console.WriteLine($"Reviews count: {customorInfo.Reviews}");
            Console.WriteLine($"Salesman: {customorInfo.Salesman}");
        }

        private static void PrintCustomerOrdersWithMoreThanOneItem(ShopDb shopDatabase)
        {
            int customerId = int.Parse(Console.ReadLine());

            int ordersCount = shopDatabase.Customers
                .FirstOrDefault(c => c.Id == customerId)
                .Orders.Count(o => o.Items.Count > 1);

            Console.WriteLine($"Orders: {ordersCount}");
        }

    }
}
