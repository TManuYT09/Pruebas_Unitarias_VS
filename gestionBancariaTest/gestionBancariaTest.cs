using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using gestionBancariaApp;

namespace gestionBancariaTest
{
    [TestClass]
    public class gestionBancariaTest
    {
        /*[TestMethod]
        public void validarMetodoIngreso()
        {
            double saldoInicial = 1000;
            double ingreso = 500;
            double saldoActual = 0;
            double saldoEsperado = 1500;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            cuenta.realizarIngreso(ingreso);
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }*/
        /*[TestMethod]
        public void realizarIngresoActividad11()
        {
            double saldoInicial = 1000;
            double ingreso = -100;
            double saldoActual = 0;
            double saldoEsperado = 1000;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            cuenta.realizarIngreso(ingreso);
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }
        [TestMethod]
        public void realizarIngresoActividad12()
        {
            double saldoInicial = 1000;
            double ingreso = 100;
            double saldoActual = 0;
            double saldoEsperado = 1100;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            cuenta.realizarIngreso(ingreso);
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }

        [TestMethod]
        public void realizarReintegroActividad11()
        {
            double saldoInicial = 1000;
            double ingreso = -100;
            double saldoActual = 0;
            double saldoEsperado = 1000;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            cuenta.realizarReintegro(ingreso);
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }
        [TestMethod]
        public void realizarReintegroActividad12()
        {
            double saldoInicial = 1000;
            double ingreso = 100;
            double saldoActual = 0;
            double saldoEsperado = 900;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            cuenta.realizarReintegro(ingreso);
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }*/
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void realizarReintegroActividad21()
        {
            double saldoInicial = 1000;
            double ingreso = 1100;
            double saldoActual = 0;
            double saldoEsperado = 1000;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            cuenta.realizarReintegro(ingreso);
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void realizarReintegroActividad22()
        {
            double saldoInicial = 1000;
            double ingreso = -100;
            double saldoActual = 0;
            double saldoEsperado = 1000;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            cuenta.realizarReintegro(ingreso);
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void realizarIngresoActividad23()
        {
            double saldoInicial = 1000;
            double ingreso = -100;
            double saldoActual = 0;
            double saldoEsperado = 1000;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            cuenta.realizarIngreso(ingreso);
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }
    }
}
