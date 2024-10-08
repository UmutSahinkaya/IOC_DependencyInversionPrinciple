﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.console
{
    public class OracleDAL : IDAL
    {
        public List<Product> GetProducts()
        {
            //Oracle
            return new List<Product>() { new Product { Id=1,Name="Oracle Kalem 1",Price=100,Stock=200},
                                     new Product { Id=2,Name="Kalem 2",Price=200,Stock=200},
                                     new Product { Id=3,Name="Kalem 3",Price=300,Stock=200},
                                     new Product { Id=4,Name="Kalem 4",Price=400,Stock=200},
                                     new Product { Id=5,Name="Silgi",Price=200,Stock=100},
                                     new Product { Id=6,Name="Defter",Price=400,Stock=300}
        };
        }
    }
}
