using Xunit;
using projeto_banco;
using System;

public  class testclass
{
    Conta conta = new Conta();
    
    Conta conta2 = new Conta();

    Operacoes operacao = new Operacoes ();

   
    [Fact]
    public void testeCreditar () {
        Assert.Equal(150.0, operacao.creditar(150.0, conta));
    }

    [Theory]
    [InlineData (10.0, 10.0)]
    [InlineData (20.0, 20.0)]
    [InlineData (130.0, 130.0)]
    public void TestCreditar(double valor, double esperado)
    {
        conta.saldo = 150.0;
        double resultado = operacao.transferir(valor, conta, conta2);
        Assert.Equal (esperado, resultado);    
    }

    [Fact]
    public void testExceptionCreditar () 
    {
        Conta ct = new Conta ();
        var exceptionCreditar = Assert.Throws<Exception> (() => operacao.creditar(-5.0,ct));
        Assert.Equal ("Valor menor ou igual 0!", exceptionCreditar.Message);


    }



}
