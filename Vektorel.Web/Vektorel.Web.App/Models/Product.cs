namespace Vektorel.Web.App.Models;

public class Product
{
    public string Name { get; set; }
    public int Stock { get; set; }
    public decimal Price { get; set; }
}


public class ProductViewModel
{
    public List<Product> Products { get; set; }
    public bool IsTable { get; set; }
}