using Classes_Exercise_01;

#region TODOs 
// TODO: Create a public Product class

// TODO: Create a public ProductID property of type long
// TODO: Create a public Name property of type string
// TODO: Create a public Price property of type double
// TODO: Create a public CategoryID property of type int
// TODO: Create a public OnSale property of type bool
// TODO: Create a public StockLevel property of type int

// TODO: Create a default constructor 
// TODO: Create a parameterized constructor that initializes all of the properties

// TODO: Create a public method that displays all of the properties creatively
#endregion

#region TODOs 
// TODO: Create a public Products class that implements the IEnumerable<T> Interface (replace T -> Product)

// TODO: Create a private field of type List<Product> called productsList and give it a default implementation (default constructor)
// TODO: Create an Indexer with a getter that returns a Product from the field productsList
// and a setter that inserts a Product into the field productsList https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/indexers/

// TODO: Create a public GetEnumerator() method that returns an IEnumerator<Product>
// TODO: Create a private explicit implementation for the IEnumerable.GetEnumerator() method that returns an IEnumerator

#endregion

// TODO: Instanciate 3 products 1 using object initializer syntax, 1 using a parameterized constructor, and the last using dot notation
// and give their properties values 

var product1 = new Product();
product1.ProductID = 1;
product1.Name = "Grapes";
product1.Price = 2.99;
product1.CategoryID = 1;
product1.OnSale = true;
product1.StockLevel = 100;

var product2 = new Product()
{
    ProductID = 2,
    Name = "Apple",
    Price = 0.79,
    CategoryID = 1,
    OnSale = true,
    StockLevel = 50,
};

var product3 = new Product(3, "Bananas", 0.59, 1, true, 75);

// TODO: Instantiate 1 Products object and add all of the products to it
var products = new Products();
products[0] = product1;
products[1] = product2;
products[2] = product3;

// TODO: Use a foreach loop to iterate thru Products and call the ProductInfo() method 
foreach (var product in products)
{
    product.ProductInfo();
}