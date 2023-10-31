namespace CalculadoraTeste;
using Calculadora.models;
public class UnitTest1
{

    public Calculadora construirClasse(){
        string data = "31/10/23";
        Calculadora calc = new Calculadora("31/10/23");
        return calc;
    }

    [Theory]
    [InlineData(1,2,3)]
    [InlineData(3,2,5)]
    public void SomarTeste(int val1, int val2, int result)
    {
        Calculadora calc =  construirClasse();

        int resultado = calc.somar(val1,val2);

        Assert.Equal(result,resultado);
    }

    [Theory]
    [InlineData(3,2,1)]
    [InlineData(3,1,2)]
    public void SubtrairTeste(int val1, int val2, int result)
    {
        Calculadora calc = construirClasse();

        int resultado = calc.subtrair(val1,val2);

        Assert.Equal(result,resultado);
    }

    [Theory]
    [InlineData(1,2,2)]
    [InlineData(3,2,6)]
    public void multiplicarTeste(int val1, int val2, int result)
    {
        Calculadora calc =  construirClasse();

        int resultado = calc.multiplicar(val1,val2);

        Assert.Equal(result,resultado);
    }

    [Theory]
    [InlineData(2,1,2)]
    [InlineData(3,3,1)]
    public void DividirTeste(int val1, int val2, int result)
    {
        Calculadora calc =  construirClasse();

        int resultado = calc.dividir(val1,val2);

        Assert.Equal(result,resultado);
    }

    [Fact]
    public void HistoricoTeste(){
        Calculadora calc =  construirClasse();
        calc.somar(2,3);
        calc.somar(4,5);
        calc.somar(6,7);

        var lista = calc.historico();
        Assert.NotEmpty(lista);
        Assert.Equal(3,lista.Count);
    }
}