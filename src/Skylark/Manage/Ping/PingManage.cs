﻿using System.Net.NetworkInformation;
using System.Text;
using SPSS = Skylark.Struct.PingSendStruct;

namespace Skylark.Manage
{
    /// <summary>
    /// 
    /// </summary>
    internal class PingManage
    {
        /// <summary>
        /// 
        /// </summary>
        public const int Ttl = 64;
        /// <summary>
        /// 
        /// </summary>
        public const int MinTtl = 30;
        /// <summary>
        /// 
        /// </summary>
        public const int MaxTtl = 255;

        /// <summary>
        /// 
        /// </summary>
        public const int Timeout = 3000;
        /// <summary>
        /// 
        /// </summary>
        public const int MinTimeout = 300;
        /// <summary>
        /// 
        /// </summary>
        public const int MaxTimeout = 6000;

        /// <summary>
        /// 
        /// </summary>
        public const bool Fragment = true;

        /// <summary>
        /// 
        /// </summary>
        public const string Address = "www.google.com";

        /// <summary>
        /// 
        /// </summary>
        public const string Data = "TaiizorSkylark_Ping_Package_Data";

        /// <summary>
        /// 
        /// </summary>
        public static readonly byte[] Buffer = Encoding.ASCII.GetBytes(Data);

        /// <summary>
        /// 
        /// </summary>
        public static readonly SPSS Result = new()
        {
            Result = IPStatus.Unknown,
            Fragment = Fragment,
            Address = Address,
            RoundTrip = 0,
            Buffer = 0,
            Ttl = 0
        };
    }
}