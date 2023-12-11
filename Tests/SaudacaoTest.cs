namespace Tests;

using Collections;

public class SaudacaoTest
{
    [Fact]
    public void Ola()
    {
        String saudacaoOla = new Saudacao().Ola("Guilherme");
        Assert.Equal("Ola Guilherme", saudacaoOla);
    }
}