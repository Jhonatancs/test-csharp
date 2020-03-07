using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Empresa;

namespace EmpresaTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Funcionario f = new Funcionario("ok",1);
            Assert.IsFalse(!f.fazAlgo());

            //Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }

        [TestMethod]
        public void TestCalculo()
        {
            Funcionario f = new Funcionario("ok", 1);
            Assert.AreEqual(f.calcula(1,2), 3,0, "Account not debited correctly");
        }
    }
}
