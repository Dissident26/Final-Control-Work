namespace ClassLibrary
{
    public static class Extentions
    {
        static Dictionary<string, string> DigitsToWordsDictionary = new()
        {
            { "0", "ноль" },
            { "1", "один" },
            { "2", "два" },
            { "3", "три" },
            { "4", "четыре" },
            { "5", "пять" },
            { "6", "шесть" },
            { "7", "семь" },
            { "8", "восемь" },
            { "9", "девять" },

        };
    public static string NumbersToWords(this int numbers)
        {
            string result = string.Empty;
            var stringArray = numbers.ToString().Select(number => new string(number, 1)).ToArray();

            foreach (var digit in stringArray)
            {
                result += DigitsToWordsDictionary[digit] + " ";
            }

            return result.TrimEnd();
        }
    }

}