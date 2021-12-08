using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesting
{
    public class WordWraper
    {
        public int CharacterCount { get; private set; }

        public WordWraper(int characterCount)
        {
            CharacterCount = characterCount;
        }

        public string WordWrap(string text)
        {
            var result = new StringBuilder();

            var counter = 0;
            var str = text ?? string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                var character = str[i];
                if (character != ' ' && character != '\n')
                {
                    counter++;
                }
                else if (character == '\n' && counter == 0)
                {
                    continue;
                }

                result.Append(character);

                if (counter == CharacterCount)
                {
                    result.Append("\n");
                    counter = 0;
                }
            }

            return result.ToString();
        }
    }
}