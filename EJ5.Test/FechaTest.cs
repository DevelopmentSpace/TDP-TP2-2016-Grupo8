using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using EJ5;

namespace EJ5.Test
{
    [TestClass]
    public class FechaTest
    {

        [TestMethod]
        public void TestAñoBisiesto()
        {
            Fecha f = new Fecha(1, 5, 2016);

            Assert.IsTrue(f.AñoBisiesto());
        }

        [TestMethod]
        public void TestAñoBisiesto2()
        {
            Fecha f = new Fecha(1, 5, 2100);

            Assert.IsFalse(f.AñoBisiesto());
        }

        [TestMethod]
        public void TestAgregarDiasEnMismoMes()
        {
            Fecha f = new Fecha(1, 5, 2016);
            f = f.AgregarDias(9);

            DateTime dt = new DateTime(2016, 5, 1);
            dt = dt.AddDays(9);

            Assert.IsTrue(f.Dia == dt.Day);
            Assert.IsTrue(f.Mes == dt.Month);
            Assert.IsTrue(f.Año == dt.Year);
        }

        [TestMethod]
        public void TestAgregarDiasDistintoMes()
        {
            Fecha f = new Fecha(25, 1, 2016);
            f = f.AgregarDias(15);

            DateTime dt = new DateTime(2016, 1, 25);
            dt = dt.AddDays(15);

            Assert.IsTrue(f.Dia == dt.Day);
            Assert.IsTrue(f.Mes == dt.Month);
            Assert.IsTrue(f.Año == dt.Year);
        }

        [TestMethod]
        public void TestAgregarDiasDistintoMesBisiesto()
        {
            Fecha f = new Fecha(15, 2, 2016);
            f = f.AgregarDias(20);

            DateTime dt = new DateTime(2016, 2, 15);
            dt = dt.AddDays(20);

            Assert.IsTrue(f.Dia == dt.Day);
            Assert.IsTrue(f.Mes == dt.Month);
            Assert.IsTrue(f.Año == dt.Year);
        }

        [TestMethod]
        public void TestAgregarDiasHastaLimiteBisiesto()
        {
            Fecha f = new Fecha(25, 2, 2016);
            f = f.AgregarDias(4);

            DateTime dt = new DateTime(2016, 2, 25);
            dt = dt.AddDays(4);

            Assert.IsTrue(f.Dia == dt.Day);
            Assert.IsTrue(f.Mes == dt.Month);
            Assert.IsTrue(f.Año == dt.Year);
        }

        [TestMethod]
        public void TestAgregarDiasPasandoAño()
        {
            Fecha f = new Fecha(25, 12, 2014);
            f = f.AgregarDias(10);

            DateTime dt = new DateTime(2014, 12, 25);
            dt = dt.AddDays(10);

            Assert.IsTrue(f.Dia == dt.Day);
            Assert.IsTrue(f.Mes == dt.Month);
            Assert.IsTrue(f.Año == dt.Year);
        }

        [TestMethod]
        public void TestAgregarDiasMuchos()
        {
            Fecha f = new Fecha(25, 2, 2014);
            f = f.AgregarDias(2000);

            DateTime dt = new DateTime(2014, 2, 25);
            dt = dt.AddDays(2000);

            Assert.IsTrue(f.Dia == dt.Day);
            Assert.IsTrue(f.Mes == dt.Month);
            Assert.IsTrue(f.Año == dt.Year);
        }

        [TestMethod]
        public void TestDiaDeLaSemana()
        {
            Fecha f = new Fecha(9, 9, 2016);

            DiaSemana resultado = f.DiaDeLaSemana();
            DiaSemana resultadoEsperado = DiaSemana.Viernes;

            Assert.AreEqual(resultado, resultadoEsperado);
        }

        [TestMethod]
        public void TestAgregarMesesFinAño()
        {
            Fecha f = new Fecha(25, 11, 2016);
            f = f.AgregarMeses(2);

            DateTime dt = new DateTime(2016, 11, 25);
            dt = dt.AddMonths(2);

            Assert.IsTrue(f.Dia == dt.Day);
            Assert.IsTrue(f.Mes == dt.Month);
            Assert.IsTrue(f.Año == dt.Year);
        }

        [TestMethod]
        public void TestAgregarMesesMuchos()
        {
            Fecha f = new Fecha(25, 11, 2015);
            f = f.AgregarMeses(36);

            DateTime dt = new DateTime(2015, 11, 25);
            dt = dt.AddMonths(36);

            Assert.IsTrue(f.Dia == dt.Day);
            Assert.IsTrue(f.Mes == dt.Month);
            Assert.IsTrue(f.Año == dt.Year);
        }


        [TestMethod]
        public void TestAgregarAñosMuchos()
        {
            Fecha f = new Fecha(25, 11, 2015);
            f = f.AgregarAños(36);

            DateTime dt = new DateTime(2015, 11, 25);
            dt = dt.AddYears(36);
            
            Assert.IsTrue(f.Dia == dt.Day);
            Assert.IsTrue(f.Mes == dt.Month);
            Assert.IsTrue(f.Año == dt.Year);
        }

        [TestMethod]
        public void TestCompararFechasIguales()
        {
            Fecha f1 = new Fecha(25, 11, 2015);
            Fecha f2 = new Fecha(25, 11, 2015);

            Assert.IsTrue(Fecha.CompararFechas(f1, f2) == 0);
        }

        [TestMethod]
        public void TestCompararFechasMenorDia()
        {
            Fecha f1 = new Fecha(25, 11, 2015);
            Fecha f2 = new Fecha(15, 11, 2015);

            Assert.IsTrue(Fecha.CompararFechas(f1, f2) == 1);
        }

        [TestMethod]
        public void TestCompararFechasMayorDia()
        {
            Fecha f1 = new Fecha(2, 11, 2015);
            Fecha f2 = new Fecha(15, 11, 2015);

            Assert.IsTrue(Fecha.CompararFechas(f1, f2) == -1);
        }

    }
}
