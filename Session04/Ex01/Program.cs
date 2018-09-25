using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Ex01
{
    class Program
    {
        static string LongestWord(List<string> list)
        {
            string longest = list[0];
            foreach (var word in list)
            {
                if (word.ToCharArray().Length > longest.ToCharArray().Length)
                    longest = word;
            }

            return longest;
        }
        static void Main(string[] args)
        {
            var wordList = new List<String>();
            try
            {
                using (var sr = new StreamReader("file.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine().Trim()) != null)
                    {
                        wordList.AddRange(line.Split(' ',';','.','\n','\t'));
                        wordList = wordList.Where(x => !string.IsNullOrEmpty(x)).ToList();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read");
                Console.WriteLine(e.Message);
            }

            foreach (var VARIABLE in wordList)
            {
                Console.WriteLine(VARIABLE);
            }
            
            Console.WriteLine($"Number of words in the file: {wordList.Count}");
            Console.WriteLine($"Longest word in the file: {LongestWord(wordList)}");
        }
    }
}