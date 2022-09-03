#region Task 1
/*class Money
{
    protected double whole;
    protected double pennies;

    public Money()
    {
        this.whole = 5.0;
        this.pennies = 0.64;
    }
    public Money(double whole, double pennies)
    {
        this.whole = whole;
        this.pennies = pennies;
    }

    public void show_sum()
    {
        double result = 0;
        result = this.whole + this.pennies;
        Console.WriteLine($"Your account is: {result}");
    }


}

class Product : Money
{
    private string product_name;
    private double price;
    public Product()
    {
        this.price = this.whole + this.pennies;
        this.product_name = "Marshmallow";
    }
    public Product(string product_name, double price)
    {
        this.product_name = product_name;
        this.price = price;
    }

    public void Decrease_price(double number)
    {
        if (this.price >= number)
        {
            Console.WriteLine($"Old price is: {this.price}");
            this.price -= number;
            Console.WriteLine($"New price is: {this.price}");
        }
        else
        {
            Console.WriteLine("Error!");
        }
    }


}

namespace Homework
{
    public class My_class
    {
        public static void Main()
        {
            Money my_money = new(10, 1.54);
            my_money.show_sum();
            Product my_product = new();
            my_product.Decrease_price(1.0);
            
        }
    }

}*/
#endregion
#region Task 2
/*abstract class Device
{
    protected string name;
    protected string description;
    public Device(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    protected Device(string name)
    {
        this.name = name;
        this.description = "Novelty";
    }

    public virtual void Sound()
    {

    }
    public void Show()
    {
        Console.WriteLine($"Device is: {this.name}");
    }

    public void Desc()
    {
        Console.WriteLine($"Description: {this.description}");
    }

}

class Kettle : Device
{
    public Kettle(string name) : base(name)
    {
    }
    public Kettle(string name, string description) : base(name, description)
    {
    }

    public override void Sound()
    {
        Console.WriteLine("Kettle makes sound");
    }
}

class Microwave : Device
{
    public Microwave(string name) : base(name)
    {
    }
    public Microwave(string name, string description) : base(name, description)
    {
    }
    public override void Sound()
    {
        Console.WriteLine("Microwave makes sound");
    }
}

class Car : Device
{
    public Car(string name) : base(name)
    {
    }
    public Car(string name, string description) : base(name, description)
    {
    }
    public override void Sound()
    {
        Console.WriteLine("Car makes sound");
    }
}

class Steamer : Device
{
    public Steamer(string name) : base(name)
    {
    }
    public Steamer(string name, string description) : base(name, description)
    {
    }
    public override void Sound()
    {
        Console.WriteLine("Steamer makes sound");
    }
}

namespace Homework
{
    public class My_class
    {
        public static void Main()
        {
            Kettle my_kettle = new("Samsung");
            my_kettle.Sound();
            my_kettle.Show();
            my_kettle.Desc();
            Car my_car = new("Mercedes", "Black color");
            my_car.Sound();
            my_car.Show();
            my_car.Desc();
        }
    }
}*/
#endregion
#region Task 3
/*abstract class Musical_instrument
{
    protected string? name;
    protected string? description;
    public Musical_instrument()
    {

    }
    public Musical_instrument(string name)
    {
        this.name = name;
        this.description = "Brown color";
    }
    public Musical_instrument(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public virtual void Sound()
    {

    }
    public virtual void Show()
    {

    }

    public virtual void Desc()
    {

    }

    public virtual void History()
    {

    }

}

class Violin : Musical_instrument
{
    public Violin()
    {
        this.name = "Violin";
        this.description = "Stringed";
    }
    public Violin(string name) : base(name)
    {
        this.description = "Stringed";
    }

    public Violin(string name, string description) : base(name, description)
    {
    }

    public override void Sound()
    {
        Console.WriteLine("Violin makes sound");
    }
    public override void Show()
    {
        Console.WriteLine($"Name of the instrument is: {this.name}");
    }
    public override void Desc()
    {
        Console.WriteLine($"Desc of the instrument is: {this.description}");
    }

    public override void History()
    {
        Console.WriteLine("Was created in 16th century");
    }

}

class Trombone : Musical_instrument
{
    public Trombone()
    {
        this.name = "Trombone";
        this.description = "Wind";
    }
    public Trombone(string name) : base(name)
    {
        this.description = "Wind";
    }

    public Trombone(string name, string description) : base(name, description)
    {
    }
    public override void Sound()
    {
        Console.WriteLine("Trombone makes sound");
    }

    public override void Show()
    {
        Console.WriteLine($"Name of the instrument is: {this.name}");
    }
    public override void Desc()
    {
        Console.WriteLine($"Desc of the instrument is: {this.description}");
    }
    public override void History()
    {
        Console.WriteLine("Was created in 6th century");
    }
}

class Ukulele : Musical_instrument
{
    public Ukulele()
    {
        this.name = "Ukulele";
        this.description = "Stringed";
    }
    public Ukulele(string name) : base(name)
    {
        this.description = "Stringed";
    }

    public Ukulele(string name, string description) : base(name, description)
    {
    }
    public override void Sound()
    {
        Console.WriteLine("Ukulele makes sound");
    }

    public override void Show()
    {
        Console.WriteLine($"Name of the instrument is: {this.name}");
    }
    public override void Desc()
    {
        Console.WriteLine($"Desc of the instrument is: {this.description}");
    }
    public override void History()
    {
        Console.WriteLine("Was created in 19th century");
    }
}

class Cello : Musical_instrument
{
    public Cello()
    {
        this.name = "Cello";
        this.description = "Stringed";
    }
    public Cello(string name) : base(name)
    {
        this.description = "Stringed";
    }

    public Cello(string name, string description) : base(name, description)
    {
    }
    public override void Sound()
    {
        Console.WriteLine("Cello makes sound");
    }
    public override void Show()
    {
        Console.WriteLine($"Name of the instrument is: {this.name}");
    }
    public override void Desc()
    {
        Console.WriteLine($"Desc of the instrument is: {this.description}");
    }
    public override void History()
    {
        Console.WriteLine("Was created in 17th century");
    }
}

namespace Homework
{
    public class My_class
    {
        public static void Main()
        {
            Violin my_violin = new();
            my_violin.Sound();
            my_violin.Show();
            my_violin.Desc();
            my_violin.History();
        }
    }
}*/
#endregion
#region Task 4
/*abstract class Worker
{
    public virtual void Print() { }
}


class President : Worker
{
    public override void Print() 
    {
        Console.WriteLine("The president is the head of the state");
    }
}

class Security : Worker
{
    public override void Print()
    {
        Console.WriteLine("Security is a group of people involved in the security of a particular person");
    }
}

class Manager : Worker
{
    public override void Print()
    {
        Console.WriteLine("Manager is specialist in the field of management and organization of work");
    }
}

class Engineer : Worker
{
    public override void Print()
    {
        Console.WriteLine("Engineer specialist with higher technical education");
    }
}

namespace Homework
{
    public class My_class
    {
        public static void Main()
        {
            President my_president = new ();
            my_president.Print();
            Security my_security = new Security ();
            my_security.Print();
        }
    }
}*/
#endregion