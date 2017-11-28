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
        public void TesteQuarendaEDois()
        {
            Assert.AreEqual(_Conversor.ProcessarNumero("42"),"42 - Quarenta e dois reais");
        }
    }
}
