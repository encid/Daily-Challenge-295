using System;

namespace ConsoleApplication1 {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first string: ");
            string word1 = Console.ReadLine();
            Console.WriteLine("Enter second string: ");
            string word2 = Console.ReadLine();
            Console.WriteLine("--------------------");

            ReplaceLetters(word1, word2);

            Console.ReadLine();

        }

        private static void ReplaceLetters(string string1, string string2)
        {
            char[] array1 = string1.ToCharArray();
            char[] array2 = string2.ToCharArray();

            Console.WriteLine(string1);
            for (int i = 0; i < array1.Length; i++) {
                array1[i] = array2[i];
                Console.WriteLine(array1);
            }
        }
    }
}