﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace NConfigurationManager.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            NConfigurationManager.Initialize();
            System.Console.WriteLine(ConfigurationManager.AppSettings["environment"]);
            System.Console.ReadLine();
            System.Console.WriteLine(ConfigurationManager.AppSettings["environment"]);

        }
    }
}
