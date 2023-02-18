﻿using ME = Skylark.Manage.External;
using MI = Skylark.Manage.Internal;
using MLLM = Skylark.Manage.Lottery.LotteryManage;

namespace Skylark.Helper.Lottery
{
    /// <summary>
    /// 
    /// </summary>
    internal static class LotteryHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="List"></param>
        /// <param name="Repeated"></param>
        /// <returns></returns>
        public static string[] GetSplit(string List, bool Repeated)
        {
            List = List.Length > MI.TextLength ? MLLM.List : List;

            string[] Result = List.Split(MI.SplitNewLine, ME.SplitOption);

            return Repeated ? Result : Result.Distinct().ToArray();
        }
    }
}