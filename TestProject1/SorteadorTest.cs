using AulasPOO.uteis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestClass]
    public class SorteadorTest
    {
        [TestMethod]
        public void VerificaTamanhoListaSorteadaTest()
        {
            //cenario
            List<string> nomes = new List<string>() { "João", "Joana", "Clara", "Leandro" };
            List<string> sorteados;

            //ação
            sorteados = Sorteador.SortearNomes(nomes);

            //verificacao
            Assert.AreEqual(4, sorteados.Count);

        }
        [TestMethod]
        public void TestSortearNomes_UmNome_DeveRetornarListaComUmNome()
        {
            // Arrange
            List<string> nomes = new List<string> { "Alice" };

            // Act
            List<string> resultado = Sorteador.SortearNomes(nomes);

            // Assert
            Assert.AreEqual(1, resultado.Count, "A lista resultante deve conter um nome.");
            Assert.AreEqual("Alice", resultado[0], "O nome na lista resultante deve ser o mesmo que o nome de entrada.");
        }
    }
}
