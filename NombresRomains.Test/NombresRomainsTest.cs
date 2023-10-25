namespace NombresRomains.Test;

public class NombresRomainsTest
{
    [Fact]
    public void Test1()
    {
        // ETANT DONNE le chiffre 1
        const uint chiffre = 1;

        // QUAND on le convertit en nombres romains
        var nombreRomain =
            ConvertisseurNombresRomains.Convertir(chiffre);

        // ALORS on obtient "I"
        Assert.Equal("I", nombreRomain);
    }

    [Fact]
    public void Test2()
    {
        // ETANT DONNE le chiffre 2
        const uint chiffre = 2;

        // QUAND on le convertit en nombres romains
        var nombreRomain =
            ConvertisseurNombresRomains.Convertir(chiffre);

        // ALORS on obtient "II"
        Assert.Equal("II", nombreRomain);
    }

    [Fact]
    public void Test3()
    {
        // ETANT DONNE le chiffre 3
        const uint chiffre = 3;

        // QUAND on le convertit en nombres romains
        var nombreRomain =
            ConvertisseurNombresRomains.Convertir(chiffre);

        // ALORS on obtient "III"
        Assert.Equal("III", nombreRomain);
    }

    [Fact]
    public void Test4()
    {
        // ETANT DONNE le chiffre 4
        const uint chiffre = 4;

        // QUAND on le convertit en nombres romains
        var nombreRomain =
            ConvertisseurNombresRomains.Convertir(chiffre);

        // ALORS on obtient "IV"
        Assert.Equal("IV", nombreRomain);
    }

    [Fact]
    public void Test5()
    {
        // ETANT DONNE le chiffre 5
        const uint chiffre = 5;

        // QUAND on le convertit en nombres romains
        var nombreRomain =
            ConvertisseurNombresRomains.Convertir(chiffre);

        // ALORS on obtient "V"
        Assert.Equal("V", nombreRomain);
    }

    [Fact]
    public void Test6()
    {
        // ETANT DONNE le chiffre 6
        const uint chiffre = 6;

        // QUAND on le convertit en nombres romains
        var nombreRomain =
            ConvertisseurNombresRomains.Convertir(chiffre);

        // ALORS on obtient "VI"
        Assert.Equal("VI", nombreRomain);
    }
    
    [Fact]
    public void Test7()
    {
        // ETANT DONNE le chiffre 7
        const uint chiffre = 7;

        // QUAND on le convertit en nombres romains
        var nombreRomain =
            ConvertisseurNombresRomains.Convertir(chiffre);

        // ALORS on obtient "VII"
        Assert.Equal("VII", nombreRomain);
    }
    
    [Fact]
    public void Test8()
    {
        // ETANT DONNE le chiffre 8
        const uint chiffre = 8;

        // QUAND on le convertit en nombres romains
        var nombreRomain =
            ConvertisseurNombresRomains.Convertir(chiffre);

        // ALORS on obtient "VIII"
        Assert.Equal("VIII", nombreRomain);
    }
    
    [Fact]
    public void Test9()
    {
        // ETANT DONNE le chiffre 9
        const uint chiffre = 9;

        // QUAND on le convertit en nombres romains
        var nombreRomain =
            ConvertisseurNombresRomains.Convertir(chiffre);

        // ALORS on obtient "IX"
        Assert.Equal("IX", nombreRomain);
    }
    [Fact]
    public void Test10()
    {
        // ETANT DONNE le chiffre 10
        const uint chiffre = 10;

        // QUAND on le convertit en nombres romains
        var nombreRomain =
            ConvertisseurNombresRomains.Convertir(chiffre);

        // ALORS on obtient "X"
        Assert.Equal("X", nombreRomain);
    }    
}
