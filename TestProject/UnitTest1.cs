using RomanNumeralsKata;
using Xunit;

namespace TestProject
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(5, "V")]
        [InlineData(10, "X")]
        public void ConverNumeralsToRoman(int numeral, string roman)
        {
            var result = RomanNumerals.ConvertNumeralToRoman(numeral);
            Assert.Equal(roman, result);
        }
    }
}