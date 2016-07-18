using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingWords
{
    public class WordsCounter
    {
        public Dictionary<string, int> CountWordsInFile(string file)
        {
            if (!File.Exists(file))
                throw new FileNotFoundException();
            string tempString = File.ReadAllText(file);
            return CountOfWords(tempString);
        }

        private static Dictionary<string, int> CountOfWords(string str)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            string[] tempStrArray = str.Split(' ', ',', '.', ':', '!', '?', '\t');

            foreach (var word in tempStrArray)
            {
                if (dictionary.ContainsKey(word))
                    dictionary[word]++;
                else
                    dictionary.Add(word, 1);
            }
            return dictionary;
        }
    }
}
