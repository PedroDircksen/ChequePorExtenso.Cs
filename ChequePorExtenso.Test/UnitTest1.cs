using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ChequePorExtenso;

namespace ChequePorExtenso.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DeveMostrar5Centavos()
        {
            Cheque cheque = new Cheque(0.05);
            Assert.AreEqual("cinco centavos de real", cheque.resultado);
        }

        [TestMethod]
        public void DeveMostrar2ReaisE25Centavos()
        {
            Cheque cheque = new Cheque(2.25);
            Assert.AreEqual("dois reais e vinte e cinco centavos de real", cheque.resultado);
        }

        [TestMethod]
        public void DeveMostrarSeteReais()
        {
            Cheque cheque = new Cheque(7.00);
            Assert.AreEqual("sete reais", cheque.resultado);
        }

        [TestMethod]
        public void DeveMostrarTrintaESeteReais()
        {
            Cheque cheque = new Cheque(37.00);
            Assert.AreEqual("trinta e sete reais", cheque.resultado);
        }

        [TestMethod]
        public void DeveMostrar637Reais()
        {
            Cheque cheque = new Cheque(637.00);
            Assert.AreEqual("seiscentos e trinta e sete reais", cheque.resultado);
        }

        [TestMethod]
        public void DeveMostrar1637Reais()
        {
            Cheque cheque = new Cheque(1637.00);
            Assert.AreEqual("um mil seiscentos e trinta e sete reais", cheque.resultado);
        }
        
        [TestMethod]
        public void DeveMostrar15415ReaisE16Centavos()
        {
            Cheque cheque = new Cheque(15415.16);
            Assert.AreEqual("quinze mil quatrocentos e quinze reais e dezesseis centavos de real", cheque.resultado);
        }

        [TestMethod]
        public void DeveMostrar61637Reais()
        {
            Cheque cheque = new Cheque(61637);
            Assert.AreEqual("sessenta e um mil seiscentos e trinta e sete reais", cheque.resultado);
        }
        
        [TestMethod]
        public void DeveMostrar961637Reais()
        {
            Cheque cheque = new Cheque(961637);
            Assert.AreEqual("novecentos e sessenta e um mil seiscentos e trinta e sete reais", cheque.resultado);
        }
        
        [TestMethod]
        public void DeveMostrar1852700Reais()
        {
            Cheque cheque = new Cheque(1852700);
            Assert.AreEqual("um milhão oitocentos e cinquenta e dois mil e setecentos reais", cheque.resultado);
        }
        
        [TestMethod]
        public void DeveMostrar5961637Reais()
        {
            Cheque cheque = new Cheque(5961637);
            Assert.AreEqual("cinco milhões novecentos e sessenta e um mil seiscentos e trinta e sete reais", cheque.resultado);
        }
        
        [TestMethod]
        public void DeveMostrar25961637Reais()
        {
            Cheque cheque = new Cheque(25961637);
            Assert.AreEqual("vinte e cinco milhões novecentos e sessenta e um mil seiscentos e trinta e sete reais", cheque.resultado);
        }
        
        [TestMethod]
        public void DeveMostrar425961637Reais()
        {
            Cheque cheque = new Cheque(425961637);
            Assert.AreEqual("quatrocentos e vinte e cinco milhões novecentos e sessenta e um mil seiscentos e trinta e sete reais", cheque.resultado);
        }
        
        [TestMethod]
        public void DeveMostrar8425961637Reais()
        {
            Cheque cheque = new Cheque(8425961637);
            Assert.AreEqual("oito bilhões quatrocentos e vinte e cinco milhões novecentos e sessenta e um mil seiscentos e trinta e sete reais", cheque.resultado);
        }

        [TestMethod]
        public void DeveMostrarNumeroInvalido()
        {
            Cheque cheque = new Cheque(111118425961637);
            Assert.AreEqual("Número Inválido", cheque.resultado);
        }
    }
}
