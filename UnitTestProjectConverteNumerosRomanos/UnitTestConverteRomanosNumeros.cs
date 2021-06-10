using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConversorNumerosRomanos;
using System;

namespace UnitTestProjectConverteRomanosNumeros
{

    [TestClass]
    public class UnitTestConverteRomanosNumeros
    {
        public ConverteAlgarismos converteAlgarismos = new ConverteAlgarismos();

        [TestMethod]
        public void DeveRetornar1()
        {
            Assert.AreEqual("1", converteAlgarismos.ConverteParaRomanos("I"));
        }

        [TestMethod]
        public void DeveRetornar3()
        {
            Assert.AreEqual("3", converteAlgarismos.ConverteParaRomanos("III"));
        }

        [TestMethod]
        public void DeveRetornar4()
        {
            Assert.AreEqual("4", converteAlgarismos.ConverteParaRomanos("IV"));
        }

        [TestMethod]
        public void DeveRetornar5()
        {
            Assert.AreEqual("5", converteAlgarismos.ConverteParaRomanos("V"));
        }

        [TestMethod]
        public void DeveRetornar8()
        {
            Assert.AreEqual("8", converteAlgarismos.ConverteParaRomanos("VIII"));
        }

        [TestMethod]
        public void DeveRetornar9()
        {
            Assert.AreEqual("9", converteAlgarismos.ConverteParaRomanos("IX"));
        }

        [TestMethod]
        public void DeveRetornar10()
        {
            Assert.AreEqual("10", converteAlgarismos.ConverteParaRomanos("X"));
        }

        [TestMethod]
        public void DeveRetornar14()
        {
            Assert.AreEqual("14", converteAlgarismos.ConverteParaRomanos("XIV"));
        }

        [TestMethod]
        public void DeveRetornar30()
        {
            Assert.AreEqual("30", converteAlgarismos.ConverteParaRomanos("XXX"));
        }

        [TestMethod]
        public void DeveRetornar40()
        {
            Assert.AreEqual("40", converteAlgarismos.ConverteParaRomanos("XL"));
        }

        [TestMethod]
        public void DeveRetornar50()
        {
            Assert.AreEqual("50", converteAlgarismos.ConverteParaRomanos("L"));
        }

        [TestMethod]
        public void DeveRetornar90()
        {
            Assert.AreEqual("90", converteAlgarismos.ConverteParaRomanos("XC"));
        }

        [TestMethod]
        public void DeveRetornar100()
        {
            Assert.AreEqual("100", converteAlgarismos.ConverteParaRomanos("C"));
        }

        [TestMethod]
        public void DeveRetornar132()
        {
            Assert.AreEqual("132", converteAlgarismos.ConverteParaRomanos("CXXXII"));
        }

        [TestMethod]
        public void DeveRetornar400()
        {
            Assert.AreEqual("400", converteAlgarismos.ConverteParaRomanos("CD"));
        }

        [TestMethod]
        public void DeveRetornar978()
        {
            Assert.AreEqual("978", converteAlgarismos.ConverteParaRomanos("CMLXXVIII"));
        }

        [TestMethod]
        public void DeveRetornar1000()
        {
            Assert.AreEqual("1000", converteAlgarismos.ConverteParaRomanos("M"));
        }

        [TestMethod]
        public void DeveRetornar1500()
        {
            Assert.AreEqual("1500", converteAlgarismos.ConverteParaRomanos("MD"));
        }

        [TestMethod]
        public void DeveRetornar4000()
        {
            Assert.AreEqual("4000", converteAlgarismos.ConverteParaRomanos("ĪV̄"));
        }

        [TestMethod]
        public void DeveRetornar5000()
        {
            Assert.AreEqual("5000", converteAlgarismos.ConverteParaRomanos("V̄"));
        }

        [TestMethod]
        public void DeveRetornar8000()
        {
            Assert.AreEqual("8000", converteAlgarismos.ConverteParaRomanos("V̄ĪĪĪ"));
        }

        [TestMethod]
        public void DeveRetornar9874()
        {
            Assert.AreEqual("9874", converteAlgarismos.ConverteParaRomanos("ĪX̄DCCCLXXIV"));
        }

        [TestMethod]
        public void DeveRetornar10000()
        {
            Assert.AreEqual("10000", converteAlgarismos.ConverteParaRomanos("X̄"));
        }
    }
}
