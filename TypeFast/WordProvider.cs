using System;
using System.IO;

namespace TypeFast
{
    static class WordProvider
    {
        public static string[] GetWords()
        {
            string words = File.ReadAllText(@"Resources\words.txt");
            return words.Split('\n');
        }
    }
}
