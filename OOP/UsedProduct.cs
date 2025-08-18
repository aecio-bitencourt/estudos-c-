namespace OOP;

public class UsedProduct : Product
{   // Será DateOnly?
    public DateOnly ManufactureDate { get; set; }

    public UsedProduct()
    {
    }

    public UsedProduct(string name, double price, DateOnly manufactureDate) : base(name, price)
    {
        ManufactureDate = manufactureDate;
    }
    
    // override aqui
}