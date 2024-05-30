class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("915 N 150 E", "Provo", "UT", "USA");
        Address address2 = new Address("Cerrada millan 5033", "Culiacan", "SN", "Mexico");

        Customer customer1 = new Customer("Fernando Galvez", address1);
        Customer customer2 = new Customer("Amy Tracy", address2);

        Product product1 = new Product("PS4", 101, 500.0, 2);
        Product product2 = new Product("iPhone 15 Pro Max", 102, 999.0, 3);
        Product product3 = new Product("Tv 55 inches ", 103, 299.0, 5);
        Product product4 = new Product("Tesla Model Y", 104, 49999.5, 10);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}\n");
    }
}