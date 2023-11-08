using Calculadora.Services;
namespace CalculadoraTestes;

public class CalculadoraTestes
{
    private CalculadoraImp _calc;

    public CalculadoraTestes()
    {
        _calc = new CalculadoraImp();
    }

    [Theory]
    [InlineData(10, 5, 15)]
    public void ReturnSum(int num1, int num2, int resultadoEsperado)
    {
        var resultado = _calc.Somar(num1, num2);

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(10, 5, 5)]
    public void ReturnSubtraction(int num1, int num2, int resultadoEsperado)
    {
        var resultado = _calc.Subtrair(num1, num2);

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(10, 5, 50)]
    public void ReturnMultiplication(int num1, int num2, int resultadoEsperado)
    {
        var resultado = _calc.Multiplicar(num1, num2);

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(10, 2, 5)]
    public void ReturnDivision(int num1, int num2, int resultadoEsperado)
    {
        var resultado = _calc.Dividir(num1, num2);

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void ReturnDivisionByZero()
    {
        Assert.Throws<DivideByZeroException>(() => _calc.Dividir(15, 0));
    }

    [Theory]
    [InlineData(60, 1.7321)]
    public void Tangente(double angulo, double resultadoEsperado)
    {
        var resultado = _calc.Tangente(angulo);

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(60, 0.866)]
    public void Seno(double angulo, double resultadoEsperado)
    {
        var resultado = _calc.Seno(angulo);

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(60, 0.5)]
    public void Coseno(double angulo, double resultadoEsperado)
    {
        var resultado = _calc.Coseno(angulo);

        Assert.Equal(resultadoEsperado, resultado);
    }
}