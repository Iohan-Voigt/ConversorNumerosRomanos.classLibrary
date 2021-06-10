using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConversorNumerosRomanos;

namespace UnitTestProjectConverteNumerosRomanos
{
    [TestClass]
    public class UnitTestProjectConverteNumerosRomanos
    {
        public ConverteAlgarismos converteAlgarismos = new ConverteAlgarismos();

        [TestMethod]
        public void DeveRetornarI()
        {
            Assert.AreEqual("I",converteAlgarismos.ConverteParaArabicos("1"));
        }

        [TestMethod]
        public void DeveRetornarIII()
        {
            Assert.AreEqual("III", converteAlgarismos.ConverteParaArabicos("3"));
        }

        [TestMethod]
        public void DeveRetornarIV()
        {
            Assert.AreEqual("IV", converteAlgarismos.ConverteParaArabicos("4"));
        }

        [TestMethod]
        public void DeveRetornarV()
        {
            Assert.AreEqual("V", converteAlgarismos.ConverteParaArabicos("5"));
        }

        [TestMethod]
        public void DeveRetornarVII()
        {
            Assert.AreEqual("VII", converteAlgarismos.ConverteParaArabicos("7"));
        }

        [TestMethod]
        public void DeveRetornarIX()
        {
            Assert.AreEqual("IX", converteAlgarismos.ConverteParaArabicos("9"));
        }

        [TestMethod]
        public void DeveRetornarX()
        {
            Assert.AreEqual("X", converteAlgarismos.ConverteParaArabicos("10"));
        }

        [TestMethod]
        public void DeveRetornarXV()
        {
            Assert.AreEqual("XV", converteAlgarismos.ConverteParaArabicos("15"));
        }

        [TestMethod]
        public void DeveRetornarXX()
        {
            Assert.AreEqual("XX", converteAlgarismos.ConverteParaArabicos("20"));
        }

        [TestMethod]
        public void DeveRetornarXL()
        {
            Assert.AreEqual("XL", converteAlgarismos.ConverteParaArabicos("40"));
        }

        [TestMethod]
        public void DeveRetornarL()
        {
            Assert.AreEqual("L", converteAlgarismos.ConverteParaArabicos("50"));
        }

        [TestMethod]
        public void DeveRetornarLXXIII()
        {
            Assert.AreEqual("LXXIII", converteAlgarismos.ConverteParaArabicos("73"));
        }

        [TestMethod]
        public void DeveRetornarXC()
        {
            Assert.AreEqual("XC", converteAlgarismos.ConverteParaArabicos("90"));
        }

        [TestMethod]
        public void DeveRetornarCXLIX()
        {
            Assert.AreEqual("CXLIX", converteAlgarismos.ConverteParaArabicos("149"));
        }

        [TestMethod]
        public void DeveRetornarCD()
        {
            Assert.AreEqual("CD", converteAlgarismos.ConverteParaArabicos("400"));
        }

        [TestMethod]
        public void DeveRetornarD()
        {
            Assert.AreEqual("D", converteAlgarismos.ConverteParaArabicos("500"));
        }

        [TestMethod]
        public void DeveRetornarCM()
        {
            Assert.AreEqual("CM", converteAlgarismos.ConverteParaArabicos("900"));
        }

        [TestMethod]
        public void DeveRetornarM()
        {
            Assert.AreEqual("M", converteAlgarismos.ConverteParaArabicos("1000"));
        }

        [TestMethod]
        public void DeveRetornarMD()
        {
            Assert.AreEqual("MD", converteAlgarismos.ConverteParaArabicos("1500"));
        }

        [TestMethod]
        public void DeveRetornarMMM()
        {
            Assert.AreEqual("MMM", converteAlgarismos.ConverteParaArabicos("3000"));
        }

        [TestMethod]
        public void DeveRetornarMMMCII()
        {
            Assert.AreEqual("MMMCII", converteAlgarismos.ConverteParaArabicos("3102"));
        }

        [TestMethod]
        public void DeveRetornarĪV̄()
        {
            Assert.AreEqual("ĪV̄", converteAlgarismos.ConverteParaArabicos("4000"));
        }

        [TestMethod]
        public void DeveRetornarV̄()
        {
            Assert.AreEqual("V̄", converteAlgarismos.ConverteParaArabicos("5000"));
        }

        [TestMethod]
        public void DeveRetornarV̄ĪĪ()
        {
            Assert.AreEqual("V̄ĪĪ", converteAlgarismos.ConverteParaArabicos("7000"));
        }

        [TestMethod]
        public void DeveRetornarĪX̄()
        {
            Assert.AreEqual("ĪX̄", converteAlgarismos.ConverteParaArabicos("9000"));
        }

        [TestMethod]
        public void DeveRetornarĪX̄CXLIX()
        {
            Assert.AreEqual("ĪX̄CXLIX", converteAlgarismos.ConverteParaArabicos("9149"));
        }

        [TestMethod]
        public void DeveRetornarX̄()
        {
            Assert.AreEqual("X̄", converteAlgarismos.ConverteParaArabicos("10000"));
        }

    }
}
