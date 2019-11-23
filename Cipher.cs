using System;
using System.Collections.Generic;
using System.Text;

namespace BHC
{
    /// <summary>
    /// This is our cipher manager
    /// </summary>
    public class Cipher
    {
        private string Alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZ";

        /// <summary>
        /// Codes the given word
        /// </summary>
        /// <param name="WordToCode">Word that you want to code it.</param>
        /// <returns></returns>
        public string GetCodeOf(string WordToCode)
        {
            int Key = WordToCode.Length;
            string CodedWord = "";

            for (int i = 0; i <= WordToCode.Length - 1; i++)
            {
                int IndexInAlpha = Alpha.IndexOf(WordToCode[i].ToString());
                int b = IndexInAlpha + Key;
                char ch = Alpha[b];
                CodedWord += ch.ToString();
            }

            return CodedWord;

        }

        /// <summary>
        /// Decodes the given word
        /// </summary>
        /// <param name="WordToDecode">Word that you want to decode</param>
        /// <returns></returns>
        public string GetDecodeOf(string WordToDecode)
        {
            int Key = WordToDecode.Length;
            string DecodedWord = "";

            for (int i = 0; i <= WordToDecode.Length - 1; i++)
            {
                int IndexInAlpha = Alpha.IndexOf(WordToDecode[i].ToString());
                int b = IndexInAlpha - Key;
                char ch = Alpha[b];
                DecodedWord += ch.ToString();
            }

            return DecodedWord;
        }
    }
}
