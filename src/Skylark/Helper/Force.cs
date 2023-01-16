﻿using System.Linq;
using EDT = Skylark.Enum.DetectType;
using HD = Skylark.Helper.Detect;
using HF = Skylark.Helper.Format;
using HA = Skylark.Helper.Adaptation;

namespace Skylark.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public class Force
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Decimal"></param>
        /// <param name="Fraction"></param>
        /// <param name="Digit"></param>
        /// <param name="Number"></param>
        /// <returns></returns>
        public static string Fix(decimal Value, bool Decimal = true, bool Fraction = true, int Digit = 2, char Number = '0')
        {


            string Temp = $"{Value}";
            string Last = Temp.Contains(HD.Char) ? Temp.Substring(Temp.IndexOf(HD.Char)) : Temp;
            string First = Temp.Contains(HD.Char) ? Temp.Substring(0, Temp.IndexOf(HD.Char)) : Temp;
            
            if (Decimal)
            {
                Temp = string.Empty;

                for (int Count = 0; Count < First.Length; Count++)
                {
                    if (First.Substring(Count, First.Length - Count - 1).Length % 3 == 0)
                    {
                        Temp += $"{First.Substring(Count, 1)}{HD.CharCross}";
                    }
                    else
                    {
                        Temp += First.Substring(Count, 1);
                    }
                }

                First = Temp.Substring(0, Temp.Length - 1);
            }

            if (Fraction && Digit > 0)
            {
                if (Last.Contains(HD.Char))
                {
                    Last = Last.Substring(Last.IndexOf(HD.Char), Last.Length - Last.IndexOf(HD.Char));
                }
                else
                {
                    Last = $"{HD.Char}{new string(Number, Digit)}";
                }

                if (Last.Length < Digit + 1)
                {
                    Last += new string(Number, Digit + 1 - Last.Length);
                }
                else
                {
                    Last = Last.Substring(0, Digit + 1);
                }
            }
            else
            {
                Last = string.Empty;
            }

            return First + Last;
        }
    }
}