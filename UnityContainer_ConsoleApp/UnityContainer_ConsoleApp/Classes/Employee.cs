using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityContainer_ConsoleApp.Interfaces;

namespace UnityContainer_ConsoleApp.Classes
{
    public class Employee : IEmployee
    {
        public string Name { get; set; }

        public Employee(string name)
        {
            Name = name;
        }
    }
}
