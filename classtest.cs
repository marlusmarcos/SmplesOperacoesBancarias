using Xunit;
using projeto_banco;
public class testclass
{
    Conta conta = new Conta();
    Operacoes operacao = new Operacoes ();

    [Fact]
    public void TestName()
    {
        Assert.Equal(4, Program.add(2,2)); 
    }

    [Fact]
    public void testAdd2()
    {
        Assert.Equal(5, Program.add(3,2)); 
    }
    [Fact]
    public void testeCreditar () {
        Assert.Equal(15.0, operacao.creditar(15.0, conta));
    }



}
