public class Control
{
    private List<Order> _orders = new();
    public Control(){}

    public void Set()
    {
        List<string> orders = new List<string>
        {
            "C001,P001",
            "C002,P002",
            "C003,P003"
        };
        List<string> products = new List<string>
        {
            "P001,I02,2",
            "P001,I06,1",
            "P001,I09,3",
            "P002,I03,2",
            "P002,I06,2",
            "P002,I08,1",
            "P003,I07,4",
            "P003,I06,4",
            "P003,I02,3"
        };
        List<string> productDetails = new List<string>
        {
            "I01,bread,2",
            "I02,cereal,3",
            "I03,eggs,3",
            "I04,milk,4",
            "I05,bananas,3",
            "I06,cheese,2",
            "I07,chips,6",
            "I08,cookies,5",
            "I09,soda,2"
        };
        List<string> customers = new List<string>
        {
            "C001,Liam Garcia",
            "C002,Olivia Wilson",
            "C003,Noah Taylor"
        };
        List<string> addresses = new List<string>
        {
            "C001,390,Walnut Street,Boston,MA,02108,USA",
            "C002,588,Maple Road,Los Angeles,CA,90001,USA",
            "C003,773,Park Avenue,Montreal,QC,H32 2Y7,Canada"
        };

        foreach (string order in orders)
        {
            string[] orderParts = order.Split(",");
            foreach (string customer in customers)
            {
                string[] customerParts = customer.Split(",");
                foreach (string address in addresses)
                {
                    string[] addressParts = address.Split(",");
                    if (customerParts[0] == addressParts[0] && customerParts[0] == orderParts[0])
                    {
                        Address newAddress = new(addressParts[1], addressParts[2], addressParts[3], addressParts[4], addressParts[5], addressParts[6]);
                        Customer newCustomer = new(customerParts[1], newAddress);
                        Order newOrder = new(newCustomer, orderParts[0]);
                        _orders.Add(newOrder);
                        
                        foreach (string product in products)
                        {
                            string[] productParts = product.Split(',');
                            foreach (string detail in productDetails)
                            {
                                string[] detailParts = detail.Split(',');
                                if (productParts[1] == detailParts[0] && orderParts[1] == productParts[0])
                                {
                                    Product newProduct = new(detailParts[1],detailParts[0],float.Parse(detailParts[2]),int.Parse(productParts[2]));
                                    newOrder.AddProduct(newProduct);
                                }
                            }
                        }
                    }
                }
            }
        }
    }

    public void Start()
    {
        Set();
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("All Orders");
            for(int i = 0; i < _orders.Count(); i++)
            {
                Console.WriteLine($"  {i + 1}. {_orders[i].GetOrder()}");
            }
            Console.Write("Select an order (1-3), type '4' to quit: ");            
            string selection = Console.ReadLine();

            if (int.TryParse(selection, out int value))
            {
                int index = value - 1;
                if (value == 4)
                {
                    isRunning = false;
                } else if (index < _orders.Count())
                {
                    DisplayOrderDetails(index);
                } else {
                    Console.WriteLine("\nTry again.\n");
                }
            } else {
                Console.WriteLine("\nTry again.\n");
            }
        }
    }

    public void DisplayOrderDetails(int index)
    {
        float total = _orders[index].GetIntShipping() ? 0 : 25;
        Console.WriteLine($"\nCustomer Name:\t{_orders[index].GetCustName()}\nOrder Number:\t{_orders[index].GetOrder()}");
        Console.WriteLine($"\nPacking Label:");
        int count = _orders[index].GetProductList().Count();

        Console.WriteLine($"  NO.\tItem\tQty\tPrice");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"  {i + 1}.\t{_orders[index].GetProductList()[i].GetProductName()}\t{_orders[index].GetProductList()[i].GetQuantity()}\t{string.Format("{0:C}", _orders[index].GetProductList()[i].GetPrice())}");
            total += _orders[index].GetProductList()[i].CalculateProductTotal();
        }

        Console.WriteLine($"\t\t\t{string.Format("{0:C}", total)}\tTotal");

        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(_orders[index].GetShippingLabel());        
    }
}