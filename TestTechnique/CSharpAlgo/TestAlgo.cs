using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpAlgo
{
    public static class TestAlgo
    {
        /// <summary>
        /// Une anagramme est un mot obtenu par transposition des lettres d'un autre
        /// mot (ex. Marie - Aimer)
        /// Retrouvez et affichez les anagrammes
        /// </summary>
        public static void TestAnagram()
        {
            var words = new string[] { "bao", "abab", "aob", "meteor", "remote", "thing", "night", "marie", "aimer"};
        }

        /// <summary>
        /// Regrouper les mots en deux groupes : Palindromes ou Pas palindrome
        /// </summary>
        public static void TestPalindrome()
        {
            var words = new string[] {"madam", "test", "tenet", "okapi", "bob"};
        }

        /// <summary>
        /// En utilisant UNIQUEMENT Linq afficher le nombre
        /// d'occurences de chaque charactère dans la phrase
        /// </summary>
        public static void TestLinqCountOccurence()
        {
            var message = "Welcome to citeo my friend";


        }
    }
}
