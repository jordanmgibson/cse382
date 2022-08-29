// There was a substatial time difference in the computing times each method took. The Hash List was the fastest, the List was in the middle for computing time, and the sorted set was the longest computing time.
// For looking up words in the dictionary, the normal List was by far the fastest. The sorted seta and hash set took similar amounts of time but they both took more than 8 minutes longer than the List.
// There are 972 three letter words.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace cs {
    public class IO {
        public static void IOMain(string[] args) {
            using (StreamWriter output = new StreamWriter("sorted.txt"))
            using (StreamReader input = new StreamReader("items.csv")) {
                while (!input.EndOfStream) {
                    string line = input.ReadLine();
                    string[] toks = line.Split(',');
                    int[] values = new int[toks.Length];
                    for (int i = 0; i < toks.Length; i++)
                        values[i] = Int32.Parse(toks[i]);
                    Array.Sort(values);
                    foreach (int value in values) {
                        output.Write(value + " ");
                    }
                    output.WriteLine();
                }
            }
        }
        // This method is complete and correct.
        public static List<string> ReadWordsList(string fileName) {
            List<string> result = new List<string>();
            using(StreamReader input = new StreamReader(fileName + ".txt"))
            {
                while (!input.EndOfStream)
                {
                    string line = input.ReadLine();
                    result.Add(line);
                }
            }
            return result;
        }
        // This method is complete and correct.
        public static SortedSet<string> ReadWordsSortedSet(string fileName) {
            SortedSet<string> result = new SortedSet<string>();
            using (StreamReader input = new StreamReader(fileName + ".txt"))
            {
                while (!input.EndOfStream)
                {
                    string line = input.ReadLine();
                    result.Add(line);
                }
            }
            return result;
        }
        // This method is complete and correct.
        public static HashSet<string> ReadWordsHashSet(string fileName) {
            HashSet<string> result = new HashSet<string>();
            using (StreamReader input = new StreamReader(fileName + ".txt"))
            {
                while (!input.EndOfStream)
                {
                    string line = input.ReadLine();
                    result.Add(line);
                }
            }
            return result;
        }
    }
}
