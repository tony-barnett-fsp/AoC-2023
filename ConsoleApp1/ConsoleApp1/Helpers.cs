using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal static class Helpers
    {
        private static void Swap(ref char a, ref char b)
        {
            if (a == b) return;

            (b, a) = (a, b);
        }

        public static IEnumerable<char[]> GetPer(char[] list)
        {
            int x = list.Length - 1;
            return GetPer(list, 0, x);
        }

        private static IEnumerable<char[]> GetPer(char[] list, int k, int m)
        {
            if (k == m)
            {
                yield return list;
            }
            else
            {
                for (int i = k; i <= m; i++)
                {
                    //Swap(ref list[k], ref list[i]);
                    (list[k], list[i]) = (list[i], list[k]);
                    foreach (var item in GetPer(list, k + 1, m))
                    {
                        yield return item;
                    }
                    (list[k], list[i]) = (list[i], list[k]);
                    //Swap(ref list[k], ref list[i]);
                }
            }
        }

        private static bool SequencesAreSame(char[] s1, char[] s2)
        {
            for (var i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static IEnumerable<char[]> GetPermutations(char[] items)
        {
            var first = 0;
            var last = items.Length;

            while (true)
            {
                var next = last - 1;
                while (true)
                {
                    var next1 = next;
                    next--;
                    if (items[next] != items[next1])
                    {
                        var mid = last - 1;
                        while (items[next] == items[mid])
                        {
                            mid--;
                        }

                        (items[next], items[mid]) = (items[mid], items[next]);

                        var start = next1;
                        var end = last - 1;
                        while (true)
                        {
                            (items[start], items[end]) = (items[end], items[start]);
                            if (start == end || start + 1 == end)
                            {
                                break;
                            }

                            start++;
                            end--;
                        }

                        yield return items;
                    }

                    if(next  == first)
                    {
                        yield return items;
                        break;
                    }
                }
            }
        }
    }
}
