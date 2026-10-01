public class Amazon
{
    List<Order> _orders = new List<Order>();
    
    
    public Amazon()
    {
        
    }

    private string[] ReadFile()
    {
        string[] readFile = System.IO.File.ReadAllLines("orders.csv");

        return readFile;
    }

    public void AddOrders()
    {

        string[] readFile = ReadFile();

        for(int i = 1; i < readFile.Count(); i++) 
        {
            string line = readFile[i].Trim();
            string[] parts = line.Split("|");
            string customersName = parts[0];
            string[] addressParts = parts[1].Split("/");

            Address address = new Address(street:addressParts[0], city:addressParts[2], stateProvince:addressParts[1], country:addressParts[3]);
            Customer customer = new Customer(name:customersName, address:address);
            Order order = new Order(customer:customer);
            _orders.Add(order);         

            string[] products = parts[2].Split("/");

            foreach (string product in products)
            {
                string[] productParts = product.Split(",");
                string productName = productParts[0];
                double productPrice = double.Parse(productParts[1]);
                int productQuantity = int.Parse(productParts[2]);

                Product newProduct = new Product(name:productName, price:productPrice, quantity:productQuantity);
                order.AddProduct(newProduct);
            }

        }
    }

    public void DisplayAllOrders()
    {
        foreach(Order order in _orders)
        {
            order.DisplayOrder();
        }
    }
}