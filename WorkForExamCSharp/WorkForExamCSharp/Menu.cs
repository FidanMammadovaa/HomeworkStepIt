using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Menu
{

    public static List<string> Logins = new(16);

    public static List<string> Passwords = new(16);

    
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }

    }
    public void Enter()
    {
        int choice = 0;
        Console.WriteLine("Enter your choice:\n1. Registration\n2. Authorization\n3. Exit");

        try
        {
            choice = Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception my_ex)
        {
            Console.WriteLine(my_ex.Message);
        }

        switch (choice)
        {
            case 1:
                User user = new User();
                Register(user);
                try
                {
                    AddLogin(user);
                }
                catch (UserExistException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                break;
            case 2:
                break;
            case 3:
                break;
            default:
                break;
        }
    }

    private User Register(User user)
    {
        Console.WriteLine("Enter your login: ");
        var login = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Enter your password: ");
        var password = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Enter your birthday in this format\nFor example (7.5.2004)");
        var birthDate = Convert.ToDateTime(Console.ReadLine());

        user.Login = login;
        user.Password = password;
        user.BirthDate = birthDate;
        return user;
    }

    private void Authorize()
    {
        Console.WriteLine("Enter your login: ");
        var login = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Enter your password: ");
        var password = Convert.ToString(Console.ReadLine());


    }

    public List<string> AddLogin(User user)
    {
        if (Logins.Count == Logins.Capacity)
        {
            Logins.EnsureCapacity(Logins.Capacity * 2);
        }
        else
        {
            if (Logins.Count > 0)
            {
                int counter = 0;
                for (int i = 0; i < Logins.Count; i++)
                {

                    if (user.Login != Logins[i])
                    {
                        counter++;
                    }
                    else
                    {
                        throw new UserExistException("This user already exists");
                    }
                }
                if (counter == Logins.Count)
                {
                    Logins.Add(user.Login);
                }

            }
            else
            {
                Logins.Add(user.Login);
            }
        }
        return Logins;
    }

    public List<string> AddPassword(User user)
    {
        if (Passwords.Count == Passwords.Capacity)
        {
            Passwords.EnsureCapacity(Passwords.Capacity * 2);
        }
        else
        {
            Passwords.Add(user.Password);
        }
        return Passwords;
    }
    public void Show_Users()
    {
        foreach(var user in Logins)
        {
            Console.WriteLine(Logins + " ");
        }
    }

    public void Show_Passwords()
    {
        foreach (var user in Passwords)
        {
            Console.WriteLine(Passwords + " ");
        }
    }
}





