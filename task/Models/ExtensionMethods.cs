using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticTask.Models
{
    internal static class ExtensionMethods
    {
        public static bool CustomContains(this string stringToSearch, char containsChar)
        {
            for (int i = 0; i < stringToSearch.Length; i++)
            {
                if (stringToSearch[i] == containsChar)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsPrime(this int Prime)
        {
            if (Prime <= 1)
            {
                return false;
            }
            if (Prime == 2)
            {
                return true;
            }
            for (int i = 2; i * i <= Prime; i++)
            {
                if (Prime % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsPowOfTwo(this int Pow)
        {
            int Power = 0;
            if (Pow <= 1)
            {
                return false;
            }
            while (Pow >= 2)
            {
                if (Pow % 16 == 0)
                {
                    Power += 4;
                    Pow /= 16;
                }
                else if (Pow % 8 == 0)
                {
                    Power += 3;
                    Pow /= 8;
                }
                else if (Pow % 4 == 0)
                {
                    Power += 2;
                    Pow /= 4;
                }
                else if (Pow % 2 == 0)
                {
                    Power++;
                    Pow /= 2;
                }
                else
                {
                    Power *= 0;
                    break;
                }
            }
            if (Power == 0)
            {
                return false;
            }
            Console.WriteLine($"2^{Power}");
            return true;
        }
    }
}
