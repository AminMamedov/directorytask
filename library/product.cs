using System.Data.SqlTypes;

namespace library;

public class Products
{
    public string Name { get; set; }
    public int Price { get; set; }
    public string AddProduct(string name , int price)
    {
        Name = name;
        Price = price;
        return $"Product name : {name} | product price {price}";
    }
    public void UpdateProduct(string name ,string Newname, int Newprice)
    {

    } 
}
