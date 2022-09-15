using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;




[Serializable]
class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public double Quantity { get; set; }
    public double Total_quantity { get; set; }
    public void Add_product()
    {
        this.Quantity++;
        this.Total_quantity--;
    }
    public void Delete_product()
    {
        this.Quantity--;
        this.Total_quantity++;
    }

    public void Сhange_name(string new_name)
    {
        this.Name = new_name;
    }

    public static Product operator *(Product my_product, double number)
    {
        my_product.Total_quantity -= (my_product.Quantity * number - my_product.Quantity);
        my_product.Quantity *= number;
        return my_product;
    }

    public override string ToString()
    {
        return $"Name: {Name}\n" +
            $"Price: {Price}\n" +
            $"Quantity: {Quantity} \n" +
            $"Total quantity: {Total_quantity} \n";
    }


    public void Serialize(List<Product> my_products)
    {
        using var file = new FileStream("data.json", FileMode.OpenOrCreate);

        JsonSerializer.Serialize(file, my_products);

    }

    public void DeSerialize()
    {
        using var file = new FileStream("data.json", FileMode.OpenOrCreate);
        using var sr = new StreamReader(file);

        var result = JsonSerializer.Deserialize<List<Product>>(sr.ReadToEnd());

        foreach (var product in result)
        {
            Console.WriteLine(product);
        }
    }

}


namespace Hw
{
    class CashBox
    {
        public static void Main()
        {

            Product my_product = new() { Name = "Bread", Price = 1, Quantity = 1, Total_quantity = 50};
            Console.WriteLine(my_product);
            Console.WriteLine(my_product * 4.0);
            Console.WriteLine();


            List<Product> my_products = new()
            {
                new (){Name = "Cola", Price = 2, Quantity = 1, Total_quantity = 100},
                new (){Name = "Jelly", Price = 4, Quantity = 1, Total_quantity = 50}
            };

            my_product.Serialize(my_products);
            my_product.DeSerialize();

        }
    }
}