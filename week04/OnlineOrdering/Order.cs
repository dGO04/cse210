public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer = new Customer();

    public Order(Customer customer)
    {
        _customer = customer;
    }
    
    private int CalculateShippingCost()
    {
        if (_customer.InsideUSA())
        {
            return 5;
        } else
        {
            return 35;
        }
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    private double CalculateTotalPrice()
    {
        double totalPrice = 0;

        foreach (Product product in _products)
        {
            totalPrice += product.CalculateTotalCost();
        }

        totalPrice += CalculateShippingCost();

        return totalPrice;
    }
    
    private void DisplayPckLabels()
    {
        foreach(Product product in _products)
        {
            Console.WriteLine(product.GetPackingLabel());
        }
    }

    public void DisplayOrder()
    {
        Console.WriteLine("Order:");
        DisplayPckLabels();
        Console.WriteLine();
        Console.WriteLine($"Total Price: {CalculateTotalPrice().ToString("F2")}");
        Console.WriteLine();
        Console.WriteLine(_customer.GetShippingLabel());
        Console.WriteLine();    
    }
}