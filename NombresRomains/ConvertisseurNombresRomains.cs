using System.Text;
namespace NombresRomains
{
    public static class ConvertisseurNombresRomains
    {
        public static string ToRomains(uint chiffre)
            => chiffre switch
            {
                1000 => "M",
                900 => "CM",
                500 => "D",
                400 => "CD",
                100 => "C",
                90 => "XC",
                50 => "L",
                40 => "XL",
                10 => "X",                            
                9 => "IX",            
                5 => "V",                        
                4 => "IV",
                _ => "I"
            };
        public static string Convertir(uint number)
        {
            uint[] arabicValues = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

            StringBuilder roman = new StringBuilder();

            for (uint i = 0; i < arabicValues.Length; i++)
            {
                while (number >= arabicValues[i])
                {
                    roman.Append(ToRomains(arabicValues[i]));
                    number -= arabicValues[i];
                }
            }

            return roman.ToString();
        }
    }    
}