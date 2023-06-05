namespace Classes_Exercise_01;
internal class Product
{
    public int ProductID { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int CategoryID { get; set; }
    public bool OnSale { get; set; }
    public int StockLevel { get; set; }

    public Product()
    {
        
    }

    public Product(int productID, string name, double price, int categoryID, bool onSale, int stockLevel)
    {
        ProductID = productID;
        Name = name;
        Price = price;
        CategoryID = categoryID;
        OnSale = onSale;
        StockLevel = stockLevel;
    }

    public void ProductInfo()
    {
        Console.WriteLine($"Product ID: {ProductID}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Price: ${Price}");
        Console.WriteLine($"Category ID: {CategoryID}");
        Console.WriteLine($"On Sale: {OnSale}");
        Console.WriteLine($"Stock Level: {StockLevel}\n");
    }
}
