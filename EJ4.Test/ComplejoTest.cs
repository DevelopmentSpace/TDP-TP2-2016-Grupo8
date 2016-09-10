using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using EJ4;

namespace EJ4.Test
{
    [TestClass]
    public class ComplejoTest
    {
        [TestMethod]
        public void TestObtenerReal()
        {
            double mNumeroReal = 20;
            double mNumeroImaginario = 0;

            double mResultadoEsperado = 20;
            double mResultado = Complejo.Crear(mNumeroReal,mNumeroImaginario).Real;

            Assert.AreEqual(mResultadoEsperado, mResultado);
        }

        [TestMethod]
        public void TestGrados()
        {
            double mNumeroReal = 1;
            double mNumeroImaginario = 1;

            double mResultadoEsperado = 45;
            double mResultado = Complejo.Crear(mNumeroReal, mNumeroImaginario).ArgumentoEnGrados;

            Assert.AreEqual(mResultadoEsperado, mResultado);
        }

        [TestMethod]
        public void TestRadianes()
        {
            double mNumeroReal = 1;
            double mNumeroImaginario = 1;

            double mResultadoEsperado = Math.Atan(1);
            double mResultado = Complejo.Crear(mNumeroReal, mNumeroImaginario).ArgumentoEnRadianes;

            Assert.AreEqual(mResultadoEsperado, mResultado);
        }

        [TestMethod]
        public void TestConjugado()
        {
            double mNumeroReal = 1;
            double mNumeroImaginario = 1;

            Complejo mAuxResultadoEsperado = Complejo.Crear(mNumeroReal,-mNumeroImaginario);
            Complejo mAuxResultado = Complejo.Crear(mNumeroReal, mNumeroImaginario).Conjugado;

            Assert.IsTrue(mAuxResultado.EsIgual(mAuxResultadoEsperado));
        }

        [TestMethod]
        public void TestMagnitud()
        {
            double mNumeroReal = 1;
            double mNumeroImaginario = 1;

            double mResultadoEsperado = Math.Pow(2,1/2);
            double mResultado = Complejo.Crear(mNumeroReal, mNumeroImaginario).Magnitud;

            Assert.AreEqual(mResultadoEsperado, mResultado);
        }

        [TestMethod]
        public void TestEsReal()
        {
            double mNumeroReal = 0;
            double mNumeroImaginario = 1;

            Assert.IsFalse(Complejo.Crear(mNumeroReal, mNumeroImaginario).EsReal());
        }

        [TestMethod]
        public void TestEsImaginario()
        {
            double mNumeroReal = 5;
            double mNumeroImaginario = 1;

            Assert.IsTrue(Complejo.Crear(mNumeroReal, mNumeroImaginario).EsImaginario());
        }

        [TestMethod]
        public void TestEsIgual1()
        {
            double mNumeroReal = 1;
            double mNumeroImaginario = 1;

            Assert.IsTrue(Complejo.Crear(mNumeroReal, mNumeroImaginario).EsIgual(Complejo.Crear(mNumeroReal, mNumeroImaginario)));
        }

        [TestMethod]
        public void TestEsIgual2()
        {
            double mNumeroReal = 1;
            double mNumeroImaginario = 1;

            Assert.IsFalse(Complejo.Crear(mNumeroReal, mNumeroImaginario).EsIgual(mNumeroReal, -mNumeroImaginario));
        }

        [TestMethod]
        public void TestSumar()
        {
            double mNumeroReal = 2;
            double mNumeroImaginario = 2;

            Complejo mAuxResultadoEsperado = Complejo.Crear(mNumeroReal*4,mNumeroImaginario*2);
            Complejo mAuxSuma = Complejo.Crear(mNumeroReal*3, mNumeroImaginario);
            Complejo mAuxResultado = Complejo.Crear(mNumeroReal, mNumeroImaginario).Sumar(mAuxSuma);

            Assert.IsTrue(mAuxResultado.EsIgual(mAuxResultadoEsperado));
        }

        [TestMethod]
        public void TestResta()
        {
            double mNumeroReal = 2;
            double mNumeroImaginario = 2;

            Complejo mAuxResultadoEsperado = Complejo.Crear(mNumeroReal*-2, mNumeroImaginario*0);
            Complejo mAuxSuma = Complejo.Crear(mNumeroReal*3, mNumeroImaginario);
            Complejo mAuxResultado = Complejo.Crear(mNumeroReal, mNumeroImaginario).Restar(mAuxSuma);

            Assert.IsTrue(mAuxResultado.EsIgual(mAuxResultadoEsperado));
        }

        [TestMethod]
        public void TestMultiplicar()
        {

            Complejo mAuxResultadoEsperado = Complejo.Crear(-35, -15);
            Complejo mAuxMultiplicar = Complejo.Crear(-5, 2);
            Complejo mMultiplicarResultado = Complejo.Crear(5, 5).MultiplicarPor(mAuxMultiplicar);

            Assert.IsTrue(mMultiplicarResultado.EsIgual(mAuxResultadoEsperado));
        }

        [TestMethod]
        public void TestDivision()
        {

            Complejo mAuxResultadoEsperado = Complejo.Crear(-0.5, -1);
            Complejo mAuxDivision = Complejo.Crear(-10, 10);
            Complejo mDivisionResultado = Complejo.Crear(15, 5).DividirPor(mAuxDivision);

            Assert.IsTrue(mDivisionResultado.EsIgual(mAuxResultadoEsperado));
        }
    }
}
