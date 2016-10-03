﻿using System;
using System.Collections.Generic;
using System.Linq;
using Foundation.ObjectHydrator;


namespace NetConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Hydrator<Customer> hydrator = new Hydrator<Customer>();
            List<Customer> customers = hydrator.GetList(10).ToList();
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }
            Console.ReadLine();
        }
    }
}
