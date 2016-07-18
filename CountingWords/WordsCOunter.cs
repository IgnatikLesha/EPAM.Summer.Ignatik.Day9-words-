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

        /// <summary>
        /// Search all words in the file and coutn them
        /// </summary>
        /// <param name="file">Path to the file</param>
        /// <returns>Dictionary : Word - count </returns>
        public Dictionary<string, int> CountWordsInFile(string file)
        {
            if (!File.Exists(file))
                throw new FileNotFoundException();
            string tempString = File.ReadAllText(file);
            return CountOfWords(tempString);
        }
        /// <summary>
        /// Search all words frequency in the text
        /// </summary>
        /// <param name="str">string where we want to find words and count them</param>
        /// <returns>Dictionary : Word - count pairs</returns>
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
