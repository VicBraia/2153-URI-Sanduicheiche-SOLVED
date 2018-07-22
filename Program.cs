using System;

namespace Sanduicheiche
{
    class Program
    {
        public static int pos_divisor, flag, offset;
        public static string substringFinalPalavra, substringRepetida;

        public static string word, newWord;
        static void Main(string[] args)
        {
            while ((word = Console.ReadLine()) != null)
            {
                flag = 0;
                if (word.Length % 2 == 0)
                {
                    pos_divisor = word.Length / 2 - 1;
                }
                else
                {
                    pos_divisor = word.Length / 2;
                }
                offset = word.Length / 2;
                while (pos_divisor < word.Length && flag == 0)
                {
                    
                    substringFinalPalavra = word.Substring(pos_divisor+1, offset);
                    substringRepetida = word.Substring(pos_divisor - offset +1, offset);

                    if (substringRepetida.Equals(substringFinalPalavra))
                    {
                        newWord = word.Substring(0, word.Length - substringFinalPalavra.Length);
                        flag = 1;
                    }
                    pos_divisor++;
                    offset--;
                }
                if(flag == 1)
                {
                    Console.WriteLine(newWord);
                }
                else
                {
                    Console.WriteLine(word);

                }
            }

        }
    }
}
