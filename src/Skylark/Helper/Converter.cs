﻿using EAPT = Skylark.Enum.AlphabeticPasswordType;
using ECNT = Skylark.Enum.ClearNumericType;
using ECWT = Skylark.Enum.CompressWebType;
using EMST = Skylark.Enum.ModeStorageType;
using ESPT = Skylark.Enum.SpecialPasswordType;
using EST = Skylark.Enum.StorageType;
using ETET = Skylark.Enum.TimeType;
using ETXT = Skylark.Enum.TaxType;
using HN = Skylark.Helper.Numeric;
using MPPM = Skylark.Manage.Password.PasswordManage;
using MSSM = Skylark.Manage.Storage.StorageManage;
using MTTEM = Skylark.Manage.Time.TimeManage;
using MTTXM = Skylark.Manage.Tax.TaxManage;
using MWWM = Skylark.Manage.Web.WebManage;

namespace Skylark.Helper
{
    /// <summary>
    /// 
    /// </summary>
    internal static class Converter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="Back"></param>
        /// <returns></returns>
        public static EST Convert(string Type, EST Back = MSSM.InputType)
        {
            foreach (EST Types in (EST[])System.Enum.GetValues(typeof(EST)))
            {
                if (Check(Type, Types))
                {
                    return Types;
                }
            }

            return Back;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="Back"></param>
        /// <returns></returns>
        public static ECNT Convert(string Type, ECNT Back = HN.ClearType)
        {
            foreach (ECNT Types in (ECNT[])System.Enum.GetValues(typeof(ECNT)))
            {
                if (Check(Type, Types))
                {
                    return Types;
                }
            }

            return Back;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="Back"></param>
        /// <returns></returns>
        public static EMST Convert(string Type, EMST Back = MSSM.ModeType)
        {
            foreach (EMST Types in (EMST[])System.Enum.GetValues(typeof(EMST)))
            {
                if (Check(Type, Types))
                {
                    return Types;
                }
            }

            return Back;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="Back"></param>
        /// <returns></returns>
        public static ETET Convert(string Type, ETET Back = MTTEM.InputType)
        {
            foreach (ETET Types in (ETET[])System.Enum.GetValues(typeof(ETET)))
            {
                if (Check(Type, Types))
                {
                    return Types;
                }
            }

            return Back;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="Back"></param>
        /// <returns></returns>
        public static ETXT Convert(string Type, ETXT Back = MTTXM.TaxType)
        {
            foreach (ETXT Types in (ETXT[])System.Enum.GetValues(typeof(ETXT)))
            {
                if (Check(Type, Types))
                {
                    return Types;
                }
            }

            return Back;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="Back"></param>
        /// <returns></returns>
        public static ESPT Convert(string Type, ESPT Back = MPPM.SpecialType)
        {
            foreach (ESPT Types in (ESPT[])System.Enum.GetValues(typeof(ESPT)))
            {
                if (Check(Type, Types))
                {
                    return Types;
                }
            }

            return Back;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="Back"></param>
        /// <returns></returns>
        public static ECWT Convert(string Type, ECWT Back = MWWM.CompressType)
        {
            foreach (ECWT Types in (ECWT[])System.Enum.GetValues(typeof(ECWT)))
            {
                if (Check(Type, Types))
                {
                    return Types;
                }
            }

            return Back;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="Back"></param>
        /// <returns></returns>
        public static EAPT Convert(string Type, EAPT Back = MPPM.AlphabeticType)
        {
            foreach (EAPT Types in (EAPT[])System.Enum.GetValues(typeof(EAPT)))
            {
                if (Check(Type, Types))
                {
                    return Types;
                }
            }

            return Back;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        private static bool Check(object Text, object Type)
        {
            return Check($"{Text}", $"{Type}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        private static bool Check(string Text, string Type)
        {
            if (Text == Type || Text.ToUpper() == Type || Text.ToUpperInvariant() == Type || Text == Type.ToLower() || Text == Type.ToLowerInvariant())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}