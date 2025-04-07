using Xunit;

public class CalculadoraTests
{
    [Fact]
    public void Sumar_DosNumeros_RetornaSuma()
    {
        var calc = new Calculadora();
        var resultado = calc.Sumar(2, 3);
        Assert.Equal(5, resultado);
    }
}
