using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args.Length);
            //foreach(string arg in args)
            //{
            //    Console.WriteLine(arg);
            //}
            try{
                String filenameWDir = args[0];
                FileStream fileStream = new FileStream(filenameWDir, FileMode.Open);
                StreamReader streamReader = new StreamReader(fileStream);
                int size = (int)fileStream.Length;
                char[] contents = new char[size];
                checked{
                    for(int i = 0; i < size; i++)
                    {
                        //зачем здесь каст?
                        contents[i] = (char)streamReader.Read();
                    }
                }
                foreach(char ch in contents)
                {
                    Console.WriteLine(ch);
                }
                Summarize(contents);
            }
            catch(Exception e){
                Console.WriteLine(e);
            }

            //just waiting key, comment in prod
            Console.ReadKey();
        }

        static void Summarize(char[] charArr)
        {
            int numConsonants = 0;
            int numVowels = 0;
            int numLines = 0;

            String allСonsonants = "bcdfghjklmnpqrstvwxz";
            //String allVowels = "аеiouy";
            foreach (char ch in charArr)
            {
                if (Char.IsLetter(ch))
                {
                    if (allСonsonants.IndexOf(Char.ToLower(ch)) != -1)
                    {
                        numConsonants++;
                    }
                    else
                        numVowels++;
                }else if (ch == '\n') { numLines++; }
            }

            Console.WriteLine("Total no of characters: {0}", charArr.Length);
            Console.WriteLine("Total no of vowels : {0}", numVowels);
            Console.WriteLine("Total no of consonants: {0}", numConsonants);
            Console.WriteLine("Total no of lines : {0}", numLines);

        }
    }
}
