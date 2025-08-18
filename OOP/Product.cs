using System.Globalization;

namespace OOP;

public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Product()
    {
    }

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }
    
    // Sobrescrever essa função nas subclasses ImportedProduct e usedProduct?
    public virtual string PriceTag()
    {
        return Name + " " + "$" + " " + Price.ToString("F2", CultureInfo.InvariantCulture);
    }
}