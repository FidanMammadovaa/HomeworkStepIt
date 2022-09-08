#region Task 1
/*Array my_array = new(6);
Console.WriteLine($"Number of numbers that are less than given number is: {my_array.Less(3)}");
Console.WriteLine($"Number of numbers that are greater than given number is: {my_array.Greater(3)}");


public interface ICalc
{
    int Less(int valueToCompare);
    int Greater(int valueToCompare);
}


class Array : ICalc
{
    private int length;
    public Array()
    {
        this.length = 5;
    }

    public Array(int length)
    {
        this.length = length;
    }
    public int Less(int valueToCompare)
    {
        int counter = 0;
        int[] arr = new int[this.length];

        for (int i = 0; i < this.length; i++)
        {
            Console.WriteLine("Enter" + ' ' + (i + 1) + ' ' + "element: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < this.length; i++)
        {
            if (arr[i] < valueToCompare)
            {
                counter++;
            }
        }
        return counter;
    }

    public int Greater(int valueToCompare)
    {
        int counter = 0;
        int[] arr = new int[this.length];

        for (int i = 0; i < this.length; i++)
        {
            Console.WriteLine("Enter" + ' ' + (i + 1) + ' ' + "element: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < this.length; i++)
        {
            if (arr[i] > valueToCompare)
            {
                counter++;
            }
        }
        return counter;
    }
}*/
#endregion
#region Task 2
/*Array my_array = new();
my_array.ShowEven();
my_array.ShowOdd();
public interface IOutput2
{
    void ShowEven();
    void ShowOdd();
}


class Array : IOutput2
{
    private int length;
    public Array()
    {
        this.length = 5;
    }
    public Array(int length)
    {
        this.length = length;
    }
    public void ShowEven()
    {
        int[] arr = new int[length];

        int i;
        for (i = 0; i < this.length; i++)
        {
            Console.WriteLine("Enter" + ' ' + (i + 1) + ' ' + "number:");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (i = 0; i < this.length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                Console.Write(arr[i] + " ");
            }
        }

        Console.WriteLine();
    }

    public void ShowOdd()
    {
        int[] arr = new int[length];

        int i;
        for (i = 0; i < this.length; i++)
        {
            Console.WriteLine("Enter" + ' ' + (i + 1) + ' ' + "number:");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (i = 0; i < this.length; i++)
        {
            if (arr[i] % 2 != 0)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}*/
#endregion
#region Task 3
/*Array my_array = new();
Console.WriteLine(my_array.CountDistinct());
Console.WriteLine(my_array.EqualToValue(3));

interface ICalc2
{
    int CountDistinct();
    int EqualToValue(int valueToCompare);
}

class Array : ICalc2
{
    private int length;
    public Array()
    {
        this.length = 5;
    }
    public Array(int length)
    {
        this.length = length;
    }

    public int CountDistinct()
    {
        int counter = 0;
        int[] arr = new int[this.length];

        int i;
        for (i = 0; i < this.length; i++)
        {
            Console.WriteLine("Enter" + ' ' + (i + 1) + ' ' + "number:");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        int j;
        int temp_counter = 0;
        for (i = 0; i < this.length; i++)
        {
            for (j = 0; j < arr.Length; j++)
            {
                if (arr[i] != arr[j])
                {
                    temp_counter++;
                }
            }
            if (temp_counter == this.length - 1)
            {
                counter++;
            }
            temp_counter = 0;
        }
        return counter;
    }

    public int EqualToValue(int valueToCompare)
    {
        int counter = 0;
        int[] arr = new int[this.length];

        int i;
        for (i = 0; i < this.length; i++)
        {
            Console.WriteLine("Enter" + ' ' + (i + 1) + ' ' + "number:");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (i = 0; i < this.length; i++)
        {
            if (arr[i] == valueToCompare)
            {
                counter++;
            }
        }
        return counter;
    }
}*/
#endregion
