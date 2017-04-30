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
        public ICorporation _ICorporation;


        public Corporation()
        {
         
        }

        public void PrintString(string name)
        {
            Console.WriteLine(name);
        }
    }
}
