using DB_csahrp.Models;
using DB_csahrp.Repositories;
using System;
using System.Collections.Generic;

namespace DB_csahrp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserRepository userRepository = new UserRepository();
            userRepository.Create("sas", "ssss", "ssss", 22, "ssa");



           // Console.WriteLine(asad.Lastname);
           //foreach (var item in asas) Console.WriteLine(item.Lastname); 
            Console.WriteLine("done");
        }
    }
}
