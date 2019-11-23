// C# program to code and decode Black Hand Cipher.
// This program cretaed by Sayed
using System;

namespace BHC
{
    class Program
    {
        /// <summary>
        /// Main Method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("| Welcome To Black Hand Cipher B.H.C |");
            Console.WriteLine("_______________________________________________________________________________________________");

            // Make new object of the cipher
            Cipher c = new Cipher();

            Console.WriteLine(">> Do you want to code or encode?");
            string Options = Console.ReadLine();

            switch (Options.ToLower())
            {
                // if user wants to code
                case "code":
                    Console.WriteLine(">> Enter Word: ");
                    string[] WordsToCode = Console.ReadLine().Split(" ");
                    for (int i = 0; i <= WordsToCode.Length - 1; i++)
                    {
                        Console.WriteLine(WordsToCode[i] + " -> " + c.GetCodeOf(WordsToCode[i].ToUpper()));
                    }
                    Console.WriteLine("_________");

                    for (int i = 0; i <= WordsToCode.Length - 1; i++)
                    {
                        Console.Write(c.GetCodeOf(WordsToCode[i].ToUpper()) + " ");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("_________");

                    AskForHelp();
                    break;

                // if user wants to decode
                case "decode":
                    Console.WriteLine(">> Enter Word");
                    string[] WordsToDecode = Console.ReadLine().Split(" ");
                    for (int i = 0; i <= WordsToDecode.Length - 1; i++)
                    {
                        Console.WriteLine(WordsToDecode[i] + " -> " + c.GetDecodeOf(WordsToDecode[i].ToUpper()));
                    }

                    AskForHelp();
                    break;

                default:

                    break;
            }
        }

        private static void AskForHelp()
        {
            Console.WriteLine(">> Do you need any help? ");
            string Answer = Console.ReadLine();

            if(Answer.ToUpper() == "YES")
            {
                Console.WriteLine(System.IO.File.ReadAllText(@"D:\C#\Consoles\BHC\Public\Help.txt"));
                Console.ReadLine();
            }

            Console.WriteLine(" Cipher Created By Pandaluem L. Quartes :) ");
            Console.WriteLine(" Program Made With Love By Sayed :) ");
            Console.ReadLine();
        }
    }
}
 