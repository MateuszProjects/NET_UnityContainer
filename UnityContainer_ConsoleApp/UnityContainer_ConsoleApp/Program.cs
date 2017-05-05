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

            var EmployeeJan = new Employee("Jan");
            var EmployeeTomasz = new Employee("Tomasz");
            var EmployeeAdam = new Employee("Adam");

            var employees = new List<IEmployee>();
            employees.Add(EmployeeJan);
            employees.Add(EmployeeTomasz);
            employees.Add(EmployeeAdam);


            var container = new UnityContainer();

            container.RegisterType<UnityContainer_ConsoleApp.Interfaces.ICorporation, Corporation>();
            container.RegisterType<UnityContainer_ConsoleApp.Interfaces.IDepartment, Department>(new InjectionConstructor(employees));
            container.RegisterType<UnityContainer_ConsoleApp.Interfaces.IEmployee, Employee>();



            var generator = container.Resolve<Department>();
            generator.gerSizeListEmployee();

            /*var generator = container.Resolve<ICorporation>();

            generator.NameCorporation("Microsoft", 10);
            */

            Console.ReadKey();
        }
    }
}
