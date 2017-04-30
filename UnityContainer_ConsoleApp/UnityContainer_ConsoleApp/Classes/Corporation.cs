using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityContainer_ConsoleApp.Interfaces;

namespace UnityContainer_ConsoleApp.Classes
{
    public class Corporation : Interfaces.ICorporation
    {

        private IDepartment _iDepartament;

        public string Name { get;  set; }

        public Corporation(IDepartment departament)
        {
            _iDepartament = departament;
        }


        public string NameCorporation(string name, int number)
        {
            Console.WriteLine("Corporation Name: " + name);
            _iDepartament.NumberofEmployeey(number);
            return name;
        }
    }
}
