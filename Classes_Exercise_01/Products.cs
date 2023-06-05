using System.Collections;

namespace Classes_Exercise_01;

internal class Products : IEnumerable<Product>
{
    List<Product> products = new();

    public Product this[int index]
    {
        get => products[index];
        set => products.Insert(index, value);
    }

    public IEnumerator<Product> GetEnumerator() => products.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
