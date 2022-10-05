using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class UserExistException : Exception
{
    private string message;
    public UserExistException(string message) : base(message)
    {
        this.message = "This user is already exist.";
    }

}


