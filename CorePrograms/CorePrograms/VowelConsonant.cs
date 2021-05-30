using System;
using System.Collections.Generic;
using System.Text;

namespace CorePrograms
{
    class VowelConsonant
    {
        public void CheckVowel(char alphabet)
        {

            char check = Char.ToLower(alphabet);
            if (check == 'a' | check == 'e' | check == 'i' | check == 'o' | check == 'u')       
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
