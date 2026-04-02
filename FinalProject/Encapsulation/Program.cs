
class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("-- ORDER 1 --");
        Console.WriteLine();

        Address address1 = new Address("123 Fake St, Fake City, Id, USA");
        Customer customer1 = new Customer("John Customer", address1);
        Order order1 = new Order(customer1);

        Product product1 = new Product("Mattress", "MA123", 399.99, 1);
        order1.AddProduct(product1);
        Product product2 = new Product("Pillow", "PI987", 23.99, 2);
        order1.AddProduct(product2);
        Product product3 = new Product("Comforter", "CO456", 30.49, 1);
        order1.AddProduct(product3);

        order1.DisplayShippingLabel();
        Console.WriteLine();

        order1.DisplayPackingLabel();
        Console.WriteLine();
        
        order1.GetTotalCost();
        Console.WriteLine();

        Console.WriteLine("-- ORDER 2 --");
        Console.WriteLine();

        Address address2 = new Address("456 Madeup Rd, Liar Town, AB, CA");
        Customer customer2 = new Customer("Jamie Buyer", address2);
        Order order2 = new Order(customer2);

        Product product4 = new Product("Gold", "AU365", 4697.20, 5);
        order2.AddProduct(product4);
        Product product5 = new Product("Platinum", "PT247", 1985.50, 10);
        order2.AddProduct(product5);

        order2.DisplayShippingLabel();
        Console.WriteLine();

        order2.DisplayPackingLabel();
        Console.WriteLine();
        
        order2.GetTotalCost();
        Console.WriteLine();

    }
}