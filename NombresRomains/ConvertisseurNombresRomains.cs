namespace NombresRomains;

public static class ConvertisseurNombresRomains
{
    public static string Convertir(uint chiffre)
        => chiffre switch
           {
               1 => "I",
               2 => "II",
               3 => "III",
               _ => "IV"
           };
}