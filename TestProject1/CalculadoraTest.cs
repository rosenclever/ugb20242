using AulasPOO.uteis;

namespace TestProject1
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void SomaTest()
        {
            //cenário
            var calc = new Calculadora();
            int num1 = 20;
            int num2 = 22;
            int resultado;
            //ação
            resultado = calc.Soma(num1, num2);
            //teste
            Assert.AreEqual(42, resultado);
        }
        [TestMethod]
        public void MultiplicaTest()
        {
            //cenario
            int num1 = 10;
            int num2 = 10;
            int resultado;
            //acao
            resultado = Calculadora.Multiplica(num1, num2);
            //verificação
            Assert.AreEqual(100, resultado);
        }
        [TestMethod]
        public void ImcTest()
        {
            //cenario
            float peso = 87.5f;
            float altura = 1.8f;
            float imc;
            //acao
            imc = Calculadora.IMC(peso, altura);
            //verificacao
            Assert.AreEqual(27.01, Math.Round(imc, 2));
        }
    }
}