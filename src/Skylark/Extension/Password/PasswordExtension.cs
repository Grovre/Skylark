﻿using EAPT = Skylark.Enum.AlphabeticPasswordType;
using ESPT = Skylark.Enum.SpecialPasswordType;
using HC = Skylark.Helper.Converter;
using HL = Skylark.Helper.Length;
using HPH = Skylark.Helper.PasswordHelper;
using ME = Skylark.Manage.External;
using MPM = Skylark.Manage.PasswordManage;

namespace Skylark.Extension
{
    public class PasswordExtension
    {
        public static string Generate(int Length = MPM.Length, string Alphabetic = MPM.DefaultType, string Special = MPM.DefaultType, string Prefix = MPM.Prefix, string Suffix = MPM.Suffix)
        {
            return Generate(Length, HC.Convert(Alphabetic, MPM.AlphabeticType), HC.Convert(Special, MPM.SpecialType), Prefix, Suffix);
        }

        public static string Generate(int Length = MPM.Length, EAPT Alphabetic = MPM.AlphabeticType, ESPT Special = MPM.SpecialType, string Prefix = MPM.Prefix, string Suffix = MPM.Suffix)
        {
            try
            {
                Prefix = HL.Parameter(Prefix, MPM.Prefix);
                Suffix = HL.Parameter(Suffix, MPM.Suffix);

                string Chars = HPH.GetAlphabetic(Alphabetic) + HPH.GetSpecial(Special);

                if (Chars.Length <= 0)
                {
                    return MPM.Error;
                }

                string Password = new(Enumerable.Repeat(Chars, HL.Number(Length, MPM.MinLength, MPM.MaxLength))
                    .Select(Char => Char[ME.Randomise.Next(Char.Length)]).ToArray());

                return Prefix + Password + Suffix;
            }
            catch
            {
                return MPM.Error;
            }
        }
    }
}