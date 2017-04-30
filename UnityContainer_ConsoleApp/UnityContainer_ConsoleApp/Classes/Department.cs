using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityContainer_ConsoleApp.Interfaces;

namespace UnityContainer_ConsoleApp.Classes
{
    public class Department : Interfaces.IDepartment
    {
        private ICorporation _iCorporation;

        public int numberEmplyee { get; set; }

        public Department()
        {
     
        }

        public int NumberofEmployeey(int number)
        {
            numberEmplyee = number;
            Console.WriteLine("number: " + number);
            return number;

        }
    }
}
