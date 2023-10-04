using ProjetoTDD;

namespace TesteProjetoTDD
{
    public class UnitTest1
    {

        public Calculadora construirClasse()
        {
            string data = "04/10/2023";
            Calculadora calculadora = new Calculadora(data);

            return calculadora;
        }

        [Theory]
        [InlineData (1, 2, 3)]
        [InlineData (4, 5, 9)]
        public void TesteSomar(int val1, int val2, int res)
        {
            Calculadora calculadora = construirClasse();

            int resultado = calculadora.Somar(val1, val2);

            Assert.Equal(res, resultado);

        }

        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(5, 5, 0)]
        public void TesteSubtrair(int val1, int val2, int res)
        {
            Calculadora calculadora = construirClasse();

            int resultado = calculadora.Subtrair(val1, val2);

            Assert.Equal(res, resultado);

        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar(int val1, int val2, int res)
        {
            Calculadora calculadora = construirClasse();

            int resultado = calculadora.Multiplicar(val1, val2);

            Assert.Equal(res, resultado);

        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void TesteDividir(int val1, int val2, int res)
        {
            Calculadora calculadora = construirClasse();

            int resultado = calculadora.Dividir(val1, val2);

            Assert.Equal(res, resultado);

        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calculadora = construirClasse();

            Assert.Throws<DivideByZeroException> ( () => calculadora.Dividir(3, 0));
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calculadora = construirClasse();

            calculadora.Somar(1, 2);
            calculadora.Somar(2, 8);
            calculadora.Somar(3, 7);
            calculadora.Somar(4, 1);

            var lista = calculadora.Historico();

            Assert.NotEmpty(lista);
            Assert.Equal (3, lista.Count);
        }
    }
}