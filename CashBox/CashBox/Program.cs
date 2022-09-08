using System.IO;
using System.Text.Json;

[Serializable]
class Product
{
    private string? name;
    private double price;
    private double quantity;
    private double total_quantity;

    public Product()
    {
        this.name = "Bread";
        this.price = 3.0;
        this.quantity = 1;
        this.total_quantity = 100;
    }
    public Product(string? name, double price, double quantity)
    {
        this.name = name;
        this.price = price;
        this.quantity = quantity;
        this.total_quantity = 100;
    }
    public void Add_product()
    {
        this.quantity++;
        this.total_quantity--;
    }
    public void Delete_product()
    {
        this.quantity--;
        this.total_quantity++;
    }

    public void Сhange_name(string new_name)
    {
        this.name = new_name;
    }

    public void Print()
    {
        Console.WriteLine($"Name of the product is: {this.name}");
        Console.WriteLine($"Price of the product is: {this.price}");
        Console.WriteLine($"Quantity of the product is: {this.quantity}");
        Console.Write($"Total quantity of the given product is: {this.total_quantity}");
        Console.WriteLine();
    }

    public void Add_To_File(FileStream my_file)
    {
        JsonSerializer.Serialize(my_file, this.name);
    }

    public static Product operator*(Product my_product, double number)
    {
        my_product.total_quantity -= (my_product.quantity * number - my_product.quantity);
        my_product.quantity *= number;
        return my_product;
    }

}

namespace Hw
{
    class CashBox
    {
        public static void Main()
        {
            using var file = new FileStream("data.json", FileMode.OpenOrCreate);
            Product my_product = new();
            my_product.Print();
            my_product.Add_product();
            my_product.Print();
            Console.WriteLine(my_product * 4.0);
            my_product.Print();


            List<Product> my_products = new()
            {
                my_product
            };

            my_products[0].Add_To_File(file);
        }
    }
}

