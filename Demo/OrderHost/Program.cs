﻿using System.Collections.Generic;
using Zaaby;

namespace OrderHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ZaabyServer.GetInstance().UseDynamicProxy(new Dictionary<string, List<string>>
                {
                    {"IFinanceApplication.ICustomerFinanceApplication", new List<string> {"http://localhost:3000"}}
                })
                .Run();
        }
    }
}