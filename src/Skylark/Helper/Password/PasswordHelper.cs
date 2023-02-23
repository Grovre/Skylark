﻿using System.Diagnostics;
using System.Text.RegularExpressions;
using EAPT = Skylark.Enum.AlphabeticPasswordType;
using EMPT = Skylark.Enum.MeterPasswordType;
using ESLPT = Skylark.Enum.SpecialPasswordType;
using ESRPT = Skylark.Enum.SimilarPasswordType;
using HF = Skylark.Helper.Format;
using MPPM = Skylark.Manage.Password.PasswordManage;

namespace Skylark.Helper.Password
{
    /// <summary>
    /// 
    /// </summary>
    internal static class PasswordHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Separator"></param>
        /// <returns></returns>
        public static string GetPlaces(decimal Value, bool Separator)
        {
            if (Separator)
            {
                return HF.Formatter("{0:N2}", Value);
            }
            else
            {
                return HF.Formatter("{0:0.00}", Value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Password"></param>
        /// <returns></returns>
        public static EMPT GetMeter(string Password)
        {
            EMPT Point = 0;

            if (Password.Length >= (int)MPPM.MeterOptions["MinLength"])
            {
                Point = Point.UpgradeMeterLevel();
            }

            if (Regex.IsMatch(Password, MPPM.MeterOptions["RegexDigit"] as string))
            {
                Point = Point.UpgradeMeterLevel();
            }

            if (Regex.IsMatch(Password, MPPM.MeterOptions["RegexSymbol"] as string))
            {
                Point = Point.UpgradeMeterLevel();
            }

            if (Regex.IsMatch(Password, MPPM.MeterOptions["RegexLowercase"] as string))
            {
                Point = Point.UpgradeMeterLevel();
            }

            if (Regex.IsMatch(Password, MPPM.MeterOptions["RegexUppercase"] as string))
            {
                Point = Point.UpgradeMeterLevel();
            }

            return Point;
        }

        public static double GetSimilarity(string Password1, string Password2, ESRPT Similar)
        {
            switch (Similar)
            {
                case ESRPT.Cosine:
                    Dictionary<string, int> Dict1 = new();
                    Dictionary<string, int> Dict2 = new();

                    foreach (string Word in Password1.Split())
                    {
                        if (Dict1.ContainsKey(Word))
                        {
                            Dict1[Word]++;
                        }
                        else
                        {
                            Dict1[Word] = 1;
                        }
                    }

                    foreach (string Word in Password2.Split())
                    {
                        if (Dict2.ContainsKey(Word))
                        {
                            Dict2[Word]++;
                        }
                        else
                        {
                            Dict2[Word] = 1;
                        }
                    }

                    HashSet<string> Keys = new(Dict1.Keys.Concat(Dict2.Keys));

                    double DotProduct = 0;
                    double Magnitude1 = 0;
                    double Magnitude2 = 0;

                    foreach (string Key in Keys)
                    {
                        int Count1 = Dict1.ContainsKey(Key) ? Dict1[Key] : 0;
                        int Count2 = Dict2.ContainsKey(Key) ? Dict2[Key] : 0;

                        DotProduct += Count1 * Count2;
                        Magnitude1 += Count1 * Count1;
                        Magnitude2 += Count2 * Count2;
                    }

                    double Magnitude = Math.Sqrt(Magnitude1) * Math.Sqrt(Magnitude2);

                    return DotProduct / Magnitude;
                case ESRPT.Jaccard:
                    HashSet<char> Set1 = new(Password1);
                    HashSet<char> Set2 = new(Password2);

                    int Intersection = 0;

                    foreach (char c in Set1)
                    {
                        if (Set2.Contains(c))
                        {
                            Intersection++;
                        }
                    }

                    int union = Set1.Count + Set2.Count - Intersection;

                    return (double)Intersection / union;
                case ESRPT.Jaccardy:
                    HashSet<string> Set3 = new(Password1.Split());
                    HashSet<string> Set4 = new(Password2.Split());

                    int IntersectionCount = Set3.Intersect(Set4).Count();
                    int UnionCount = Set3.Union(Set4).Count();

                    return (double)IntersectionCount / UnionCount;
                default:
                    int P1 = Password1.Length;
                    int P2 = Password2.Length;

                    int[,] D = new int[P1 + 1, P2 + 1];

                    if (P1 == 0)
                    {
                        return P2;
                    }

                    if (P2 == 0)
                    {
                        return P1;
                    }

                    for (int i = 1; i <= P1; i++)
                    {
                        for (int j = 1; j <= P2; j++)
                        {
                            int Cost = (Password2[j - 1] == Password1[i - 1]) ? 0 : 1;

                            D[i, j] = Math.Min(Math.Min(D[i - 1, j] + 1, D[i, j - 1] + 1), D[i - 1, j - 1] + Cost);
                        }
                    }

                    return D[P1, P2];
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mode"></param>
        /// <returns></returns>
        public static string GetSpecial(ESLPT Mode)
        {
            return Mode switch
            {
                ESLPT.None => string.Empty,
                ESLPT.Number => MPPM.Number,
                ESLPT.Symbol => MPPM.Symbol,
                _ => MPPM.Number + MPPM.Symbol,
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mode"></param>
        /// <returns></returns>
        public static string GetAlphabetic(EAPT Mode)
        {
            return Mode switch
            {
                EAPT.Big => MPPM.Big,
                EAPT.None => string.Empty,
                EAPT.Small => MPPM.Small,
                _ => MPPM.Big + MPPM.Small,
            };
        }

        /// <summary>
        /// If more password strengths are removed, this will compute it automatically
        /// </summary>
        private static readonly int LowestPasswordStrength = typeof(EMPT)
            .GetEnumValues()
            .Cast<int>()
            .Min();

        /// <summary>
        /// If more password strengths are added, this will compute it automatically
        /// </summary>
        private static readonly int HighestPasswordStrength = typeof(EMPT)
            .GetEnumValues()
            .Cast<int>()
            .Max();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="MeterPasswordType"></param>
        /// <returns></returns>
        private static EMPT UpgradeMeterLevel(this EMPT MeterPasswordType)
        {
            int Result = (int)MeterPasswordType + 20;

            Skymath.Clamp(Result, LowestPasswordStrength, HighestPasswordStrength);
            Debug.Assert(Result % 20 == 0);
            return (EMPT)Result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="MeterPasswordType"></param>
        /// <returns></returns>
        private static EMPT DowngradeMeterLevel(this EMPT MeterPasswordType)
        {
            int Result = (int)MeterPasswordType - 20;

            Skymath.Clamp(Result, LowestPasswordStrength, HighestPasswordStrength);
            Debug.Assert(Result % 20 == 0);
            return (EMPT)Result;
        }
    }
}