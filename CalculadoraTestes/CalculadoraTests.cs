using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTests
{
    private readonly CalculadoraImp _calc;
    
    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        // Arrange
        int num1 = 5;
        int num2 = 10;
        // Act
        var resultado = _calc.Somar(num1, num2);
        // Assert
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void DeveSomar10Com10ERetornar20()
    {
        // Arrange
        int num1 = 10;
        int num2 = 10;
        // Act
        var resultado = _calc.Somar(num1, num2);
        // Assert
        Assert.Equal(20, resultado);
    }

    [Fact]
    public void DeveVerificarSe4EhParERetornarTrue()
    {
        // Arrange
        int num = 4;
        // Act
        var resultado = _calc.EhPar(num);
        // Assert
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(new int[] { 2, 4, 6, 8, 10 })]
    public void DeveVerificarSeOsNumerosSaoParesERetornarTrue(int[] numeros)
    {
        // foreach (var item in numeros)
        // {
        //     var resultado = _calc.EhPar(item);
        //     Assert.True(resultado);
        // }
        
        // Act / Assert
        Assert.All(numeros, item => Assert.True(_calc.EhPar(item)));
    }
}