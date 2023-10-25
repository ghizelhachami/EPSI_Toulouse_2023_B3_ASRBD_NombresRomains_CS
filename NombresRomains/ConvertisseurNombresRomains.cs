namespace NombresRomains;

public static class ConvertisseurNombresRomains
{
    public static string Convertir(uint chiffre)
        => chiffre switch
           {
               1 => "I",
               2 => "II",
               3 => "III",
               4 => "IV",
               5 => "V",
               6 => "VI",
               7 => "VII",
               8 => "VIII",
               9 => "IX",
               _ => "X"
           };
}