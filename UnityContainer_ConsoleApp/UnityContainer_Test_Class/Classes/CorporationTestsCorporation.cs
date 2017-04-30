using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnityContainer_ConsoleApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityContainer_ConsoleApp.Interfaces;

namespace UnityContainer_ConsoleApp.Classes.Tests
{
    [TestClass]
    public class CorporationTestsCorporation
    {

        Corporation corporation;
        Department department;

        [TestInitialize]
        public void init()
        {
            department = new Department();
            corporation = new Corporation(department);
        }



        [TestMethod]
        public void NameCorporation_Test()
        {
            var excepted = "Microsoft";
            
            var result = corporation.NameCorporation("Microsoft", 10);

            Assert.AreEqual(excepted, result);
        }

       
    }
}