using MeuPrimeiroTeste.App;
using Xunit;

namespace MeuPrimeiroTeste.Tests;

public class OlaMundoTeste
{
    [Fact]
    public void ObterMensagem_DeveRetornarHelloWorld()
    {
        var ola = new OlaMundo();

        var resultado = ola.ObterMensagem();

        Assert.Equal("Hello, World!", resultado);
    }
}