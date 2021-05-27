using System;
using System.Collections.Generic;
using System.Text;

namespace CorePrograms
{
    class VowelConsonant
    {
        public void CheckVowel(char alphabet)
        {
            if (alphabet == 'a' | alphabet == 'e' | alphabet == 'i' | alphabet == 'o' | alphabet == 'u' | alphabet == 'A' | alphabet == 'E' | alphabet == 'I' | alphabet == 'O' | alphabet == 'U')
            {
                Console.WriteLine(alphabet + " is Vowel");
            }
            else
            {
                Console.WriteLine(alphabet + " is Consonant");
            }
        }
    }

}
