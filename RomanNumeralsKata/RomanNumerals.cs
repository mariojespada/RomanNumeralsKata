namespace RomanNumeralsKata
{
    public class RomanNumerals
    {
        public static string ConvertNumeralToRoman(int number)
        {
            if (number == 1)
            {
                return "I";
            }
            if (number == 5)
            {
                return "V";
            }
            if (number == 10)
            {
                return "X";
            }

            return default;
        }
    }
}
