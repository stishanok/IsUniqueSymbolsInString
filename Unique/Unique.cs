using System;
using System.Collections.Generic;
using System.Linq;

namespace Unique
{
    public static class Unique
    {
        public static bool IsUniqueSymbolsInStringHashSet(string str)
        {
            if (str == null)
            {
                throw new NullReferenceException();
            }
            
            var hashSet = new HashSet<char>();

            foreach (var symbol in str)
            {
                if (hashSet.Contains(symbol))
                {
                    return false;
                }
            
                hashSet.Add(symbol);
            }

            return true;
        }

        public static bool IsUniqueSymbolsInStringLinq(string str)
        {
            if (str == null)
            {
                throw new NullReferenceException();
            }
            
            return str.Distinct().Count() == str.Length;
        }
    }
}