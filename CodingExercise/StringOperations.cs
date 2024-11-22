using System.Collections.Generic;

namespace CodingExercise
{
    public static class StringOperations
    {
        // Method to count the occurrences of each character in a string
        //Input string cannot be null or empty.
        //Input string must be at least 10 characters long.
        public static Dictionary<char, int> CountCharacterOccurrences(string input)
        {
            if (string.IsNullOrEmpty(input))
                throw new ArgumentException("Input string cannot be null or empty.", nameof(input));

            var characterCounts = new Dictionary<char, int>();

            foreach (var character in input)
            {
                if (characterCounts.ContainsKey(character))
                {
                    characterCounts[character]++;
                }
                else
                {
                    characterCounts[character] = 1;
                }
            }

            return characterCounts;
        }
    }
}