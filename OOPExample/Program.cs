﻿using System;

namespace OOPExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new CoorporateCustomer();
            IndividualCustomer individualCustomer = new IndividualCustomer();
            Customer cust = new IndividualCustomer();
            
            CustomerManager customerManager = new CustomerManager();
            
            //customerManager.Add(cust);
            

        }
    }
}
