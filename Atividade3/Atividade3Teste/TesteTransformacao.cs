using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Atividade3;

namespace Atividade3Teste
{
    [TestClass]
    public class TesteTransformacao
    {
        private Form1 _Conversor;

        [TestInitialize]
        public void Inicializar()
        {
            _Conversor = new Form1();
        }

        /*
         * 
         * 42,00 = Quarenta e dois reais
678,00 = Seiscentos e setenta e oito reais
13,92 = Valor inválido
-23,00 = Valor Inválido
1456,00 = Valor Inválido
         * */

        [TestMethod]
        public void Teste42()
        {
            Assert.AreEqual(_Conversor.ProcessarNumero("42,00"),"42,00 - Quarenta e dois reais");
        }

        [TestMethod]
        public void Teste678()
        {
            Assert.AreEqual(_Conversor.ProcessarNumero("678,00"), "678,00 - Seiscentos e setenta e oito reais");
        }

        [TestMethod]
        public void Teste13_92()
        {
            Assert.AreEqual(_Conversor.ProcessarNumero("13,92"), "Valor inválido");
        }

        [TestMethod]
        public void Teste_23()
        {
            Assert.AreEqual(_Conversor.ProcessarNumero("-23,00"), "Valor inválido");
        }

        [TestMethod]
        public void Teste_1456()
        {
            Assert.AreEqual(_Conversor.ProcessarNumero("1456,00"), "Valor inválido");
        }
    }
}
