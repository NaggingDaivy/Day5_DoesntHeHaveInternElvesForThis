using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_DoesntHeHaveInternElvesForThis
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"c:\Users\Daivy\Documents\Visual Studio 2013\Projects\Day5_DoesntHeHaveInternElvesForThis\day5.txt");
            int numberNice = 0;

            foreach (string source in lines)
            {
                int numberVowels = 0;
                bool containsTwoLetterRow = false;

                if (!source.Contains("ab") && !source.Contains("cd") && !source.Contains("pq") && !source.Contains("xy"))
                {
                    

                    for (int i = 0; i < source.Length; ++i)
                    {
                        char actualLetter = source[i];

                        //vowels
                        if (actualLetter == 'a')
                            ++numberVowels;
                        if (actualLetter == 'e')
                            ++numberVowels;
                        if (actualLetter == 'i')
                            ++numberVowels;
                        if (actualLetter == 'o')
                            ++numberVowels;
                        if (actualLetter == 'u')
                            ++numberVowels;

                        //double letters
                        if (i + 1 < source.Length)
                        {
                            char nextLetter = source[i + 1];
                            if (actualLetter == nextLetter)
                                containsTwoLetterRow = true;

                            if (actualLetter == nextLetter)
                                containsTwoLetterRow = true;
                        }
                        else
                            i = source.Length;
                    }

                    if (containsTwoLetterRow && numberVowels >= 3)
                        ++numberNice;



                }
            }

            Console.WriteLine("Number of nice strings : {0}", numberNice);
        }
    }
}
