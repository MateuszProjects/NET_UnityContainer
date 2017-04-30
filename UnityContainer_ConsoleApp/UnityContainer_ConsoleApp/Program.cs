using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityContainer_ConsoleApp.Classes;
using UnityContainer_ConsoleApp.Interfaces;

namespace UnityContainer_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer();

            container.RegisterType<UnityContainer_ConsoleApp.Interfaces.ICorporation, Corporation>();
            container.RegisterType<UnityContainer_ConsoleApp.Interfaces.IDepartment, Department>();

            var generator = container.Resolve<ICorporation>();

            generator.NameCorporation("Microsoft", 10);


            Console.ReadKey();
        }
    }
}
