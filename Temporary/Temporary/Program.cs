using System.Text;
namespace Some
{
    class Array
    {
        public static void Main()
        {
            Console.WriteLine("Enter text: ");
            var my_str = new StringBuilder(Console.ReadLine());
            string[] not_allowed = { "die", "death", "Die", "Death", "DIE", "DEATH" };
            int i = 0;
            bool check = false;
            string[] temp_arr = new string[10];
            int j = 0;
            for (i = 0; i < my_str.Length; i++)
            {
                if (my_str[i] == ' ' || my_str[i] == '.' || my_str[i] == '?' || my_str[i] == '!')
                {
                    check = true;
                }
                if (check == false)
                {
                    temp_arr[j] += my_str[i].ToString();
                }
                if (check == true)
                {
                    j++;
                    check = false;
                }
            }

            for (i = 0; i < temp_arr.Length; i++)
            {
                Console.WriteLine(temp_arr[i]);
            }
            int count = 0;
            j = 0;
            check = false;
            for (i = 0; j < temp_arr.Length;)
            {
                if (temp_arr[j] == not_allowed[i])
                {
                    check = true;
                }
                if (check == false)
                {
                    if (i < not_allowed.Length - 1)
                    {
                        i++;
                    }
                    else
                    {
                        j++;
                        i = 0;
                    }
                }
                if (check == true)
                {
                    count++;
                    int counter = 0;
                    int length = temp_arr[j].Length;
                    temp_arr[j] = null;
                    while (counter < length)
                    {
                        temp_arr[j] += '*'.ToString();
                        counter++;
                    }
                    j++;
                    i = 0;
                    check = false;
                }
            }

            for (i = 0; i < temp_arr.Length; i++)
            {
                Console.Write(temp_arr[i] + ' ');
            }
            Console.WriteLine();
            Console.WriteLine($"{count} changes in the the text");
        }
    }
}