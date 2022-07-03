using Xunit;
using projeto_banco;


public  class testclass
{
    Conta conta = new Conta();
    
    Conta conta2 = new Conta();



    Operacoes operacao = new Operacoes ();

    [Fact]
    public void testadd()
    {
        Assert.Equal(4, Program.add(2,2)); 
    }

    [Theory]
    [InlineData (5, 3,2)]
    [InlineData (6, 3,3)]
    [InlineData (25, 3,22)]
    [InlineData (50, 30,20)]
    [InlineData (55, 35,20)]
    public void testAdd2(int valor, int a, int b)
    {
        int resultado = Program.add (a, b);
        Assert.Equal(valor, resultado); 
    }
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

    }



}
