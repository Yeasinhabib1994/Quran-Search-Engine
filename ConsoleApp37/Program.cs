using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleApp37
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] documents = System.IO.Directory.GetFiles("quran");
            string[] verse = new string[documents.Length];

            for (int i = 0; i < documents.Length; i++)
            {
                verse[i] = File.ReadAllText(documents[i]);
            }

            Console.WriteLine("input the word you want to search in Quran:");
            string key = Console.ReadLine();
            Console.WriteLine("");

            int found = 0;
            for (int i = 0; i < documents.Length; i++)
            {
                string[] words = verse[i].Split(' ');
                
                for (int j = 0; j < words.Length; j++)
                {
                    if (words[j].ToLower() == key)
                    {
                        var fileNameEditor = new FileNameEditor();
                        fileNameEditor.FileName = documents[i];
                        string fileName = fileNameEditor.FileName;
                        Console.Write(fileName + ":  ");
                        Console.WriteLine(verse[i]);
                        Console.WriteLine("");
                        found++;
                        break;
                    }
                }
            }

            Console.WriteLine("found " + found + " times.");
        }
    }
}
