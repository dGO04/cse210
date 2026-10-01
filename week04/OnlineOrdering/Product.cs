using System.Security.Cryptography;

public class Product
{
    private string _name;
    private string _id;
    private double _price;
    private int _quantity;

    public Product(string name, double price, int quantity)
    {
        _name = name;
        _price = price;
        _quantity = quantity;
    }


    public double CalculateTotalCost()
    {
        return (double)_price * _quantity;
    }

    public string GetPackingLabel()
    {
        GetProductID();
        return $"{_name}[{_id}]";
    }

    public string GetProductID()
    {
        string idLetter = _name[0].ToString();
        string idLastLetter = _name[_name.Count() - 1].ToString();

        Random random = new Random();
        string randomNumbers = "";

        for (int i = 0; i < 5; i++)
        {
            int randomNumber = random.Next(0, 10);

            randomNumbers += randomNumber.ToString();
        }

        _id = $"{idLetter.ToUpper()}{idLastLetter.ToUpper()}{randomNumbers}";

        return _id;
    }
}