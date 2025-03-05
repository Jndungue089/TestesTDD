using NewTalents;

namespace NewTalentsTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1,2,3)]
        [InlineData(4, 5, 9)]
        [InlineData(6, 7, 13)]
        [InlineData(8, 9, 17)]
        [InlineData(10, 11, 21)]
        public void TesteSomar(int n1, int n2, int resultado)
        {
            Calculadora calc = new Calculadora();
            int resultadoCalculado = calc.somar(n1, n2);
            Assert.Equal(resultado, resultadoCalculado);
        }
        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(4, 4, 0)]
        [InlineData(20, 7, 13)]
        [InlineData(26, 9, 17)]
        [InlineData(32, 11, 21)]
        public void TesteSubtrair(int n1, int n2, int resultado)
        {
            Calculadora calc = new Calculadora();
            int resultadoCalculado = calc.subtrair(n1, n2);
            Assert.Equal(resultado, resultadoCalculado);
        }
        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        [InlineData(6, 5, 30)]
        [InlineData(9, 9, 81)]
        [InlineData(10, 11, 110)]
        public void TesteMultiplicar(int n1, int n2, int resultado)
        {
            Calculadora calc = new Calculadora();
            int resultadoCalculado = calc.multiplicar(n1, n2);
            Assert.Equal(resultado, resultadoCalculado);
        }
        [Theory]
        [InlineData(2, 1, 2)]
        [InlineData(2, 2, 1)]
        [InlineData(80, 10, 8)]
        [InlineData(200, 10, 20)]
        public void TesteDividir(int n1, int n2, int resultado)
        {
            Calculadora calc = new Calculadora();
            int resultadoCalculado = calc.dividir(n1, n2);
            Assert.Equal(resultado, resultadoCalculado);
        }
        [Fact]
        public void TesteDivisaoPorZero(int n1, int n2, int resultado)
        {
            Calculadora calc = new Calculadora();
            int resultadoCalculado = calc.dividir(n1, n2);
            Assert.Equal(resultado, resultadoCalculado);
        }
    }
}
