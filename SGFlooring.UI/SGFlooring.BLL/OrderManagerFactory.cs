﻿using SGFlooring.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFlooring.BLL
{
    public static class OrderManagerFactory
    {
        public static OrderManager Create()
        {
            string mode = ConfigurationManager.AppSettings["Mode"].ToString();

            switch(mode)
            {
                case "TestData":
                    return new OrderManager(new OrderTestRepository(), new ProductTestRepository(), new TaxTestRepository());
                case "FileData":
                    return new OrderManager(new OrderFileRepository(@"C:\Repos\dotnet-jake-ganser\SGFlooring.UI\SGFlooring.Data\SampleData\Orders\"), new ProductFileRepository(@"C:\Repos\dotnet-jake-ganser\SGFlooring.UI\SGFlooring.Data\SampleData\Products.txt"), new TaxFileRepository(@"C:\Repos\dotnet-jake-ganser\SGFlooring.UI\SGFlooring.Data\SampleData\Taxes.txt"));
                default:
                    throw new Exception("Mode value in app config is not valid");
            }
        }
    }
}
