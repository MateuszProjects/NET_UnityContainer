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

        public List<IEmployee> _iemployee;
        public int numberEmplyee { get; set; }

        public Department(List<IEmployee> employee) 
        {
            _iemployee = employee;
        }

        public int gerSizeListEmployee()
        {
            int dane = _iemployee.Count;
            Console.Out.WriteLine("dane" + dane);
            return dane;
        }

        public int NumberofEmployeey(int number)
        {
            numberEmplyee = number;
            Console.WriteLine("number: " + number);
            return number;

        }
    }
}
