using FibonacciNumberGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FibonacciNumberGenerator.DAL
{
    public interface IUserDAL
    {
        List<User> DisplayUsers();

        bool SaveUserInput(long inputNumber, string ipAddress);
    }
}