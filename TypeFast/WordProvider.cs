using System;
using System.IO;

namespace TypeFast
{
    static class WordProvider
    {
        public static string[] GetWords()
        {
            string words = File.ReadAllText(@"Resources\words.txt");
            var splitWords =  words.Split('\n');

            for (int i = 0; i < splitWords.Length; i++)
            {
                splitWords[i] = splitWords[i].TrimEnd();
            }

            return splitWords;
        }
    }
}
