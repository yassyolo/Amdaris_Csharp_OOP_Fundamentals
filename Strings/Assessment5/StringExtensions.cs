namespace Assessment5
{
    internal static class StringExtensions
    {
        public static int CountWordsInString(this string input)
        {
            return input.Split(new[] { ' ', '\t', '\n', '\r', '.', ',', ';', '!', '?', ':', ';', '(', ')', '"', '[', ']', '-', '_', '/', '\\' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static int CountSentences(this string input)
        {
            return input.Split(new[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static string ReverseWordsInString(this string input)
        {
            var reversedWords = new string[input.Length];

            var inputAsArray = input.Split(new[] { ' ', '\t', '\n', '\r', '.', ',', ';', '!', '?', ':', ';', '(', ')', '"', '[', ']', '-', '_', '/', '\\' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            for (int i = 0; i < inputAsArray.Length; i++)
            {
                reversedWords[i] = inputAsArray[inputAsArray.Length - 1 - i];
            }
            return string.Join(" ", reversedWords);
        }

        public static string ReverseCharactersInString(this string input)
        {
            var reversedCharacters = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                reversedCharacters[i] = input[input.Length - 1 - i];
            }
            return new string(reversedCharacters);
        }

        public static int CountOccurrences(this string input, string word)
        {
            int ocurrences = 0;
            int nextWordIndex = 0;
            while (nextWordIndex < input.Length)
            {
                nextWordIndex = input.IndexOf(word, nextWordIndex, StringComparison.OrdinalIgnoreCase);
                if (nextWordIndex == -1) break;

                ocurrences++;
                nextWordIndex += word.Length;
            }

            return ocurrences;
        }
    }
}

