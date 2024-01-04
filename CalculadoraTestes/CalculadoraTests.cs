using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTests
{
    private CalculadoraImp _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5com10eRetornar15()
    {
        //Arrange
        int num1 = 5;
        int num2 = 10;

        //Act
        int resultado = _calc.Somar(num1, num2);

        //Assert
        Assert.Equal(15, resultado);
    }

    
    [Fact]
    public void DeveSomar10com10eRetornar20()
    {
        //Arrange
        int num1 = 10;
        int num2 = 10;

        //Act
        int resultado = _calc.Somar(num1, num2);
        
        //Assert
        Assert.Equal(20, resultado);
    }

    [Fact]
    public void DeveVerificarSe4ehParEretornarVerdadeiro()
    {
        //Arrange
        int numero = 4;

        //act
        bool resultado = _calc.Ehpar(numero);

        //Assert
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(new int[] {2, 4, 6})]
    [InlineData(new int[] {6, 8, 10})]
    public void SeOsmeusNumerosParesRetornarTrue(int[] numero)
    {
        
        Assert.All(numero, num =>  Assert.True(_calc.Ehpar(num)));
    }
}