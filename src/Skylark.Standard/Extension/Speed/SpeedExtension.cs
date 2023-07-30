﻿using SE = Skylark.Exception;
using SSMSSM = Skylark.Standard.Manage.Speed.SpeedManage;

namespace Skylark.Standard.Extension.Speed
{
    /// <summary>
    /// 
    /// </summary>
    public static class SpeedExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cms"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal CmsToMps(decimal Cms = MSSM.Value, decimal Constant = MSSM.Cms_Mps_Constant)
        {
            try
            {
                return Cms / Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cms"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> CmsToMpsAsync(decimal Cms = MSSM.Value, decimal Constant = MSSM.Cms_Mps_Constant)
        {
            return await Task.Run(() => CmsToMps(Cms, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cms"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal CmsToKph(decimal Cms = MSSM.Value, decimal Constant = MSSM.Cms_Kph_Constant)
        {
            try
            {
                return Cms * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cms"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> CmsToKphAsync(decimal Cms = MSSM.Value, decimal Constant = MSSM.Cms_Kph_Constant)
        {
            return await Task.Run(() => CmsToKph(Cms, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cms"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal CmsToFts(decimal Cms = MSSM.Value, decimal Constant = MSSM.Cms_Fts_Constant)
        {
            try
            {
                return Cms / Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cms"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> CmsToFtsAsync(decimal Cms = MSSM.Value, decimal Constant = MSSM.Cms_Fts_Constant)
        {
            return await Task.Run(() => CmsToFts(Cms, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cms"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal CmsToMph(decimal Cms = MSSM.Value, decimal Constant = MSSM.Cms_Mph_Constant)
        {
            try
            {
                return Cms * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cms"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> CmsToMphAsync(decimal Cms = MSSM.Value, decimal Constant = MSSM.Cms_Mph_Constant)
        {
            return await Task.Run(() => CmsToMph(Cms, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cms"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal CmsToKnot(decimal Cms = MSSM.Value, decimal Constant = MSSM.Cms_Knot_Constant)
        {
            try
            {
                return Cms * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cms"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> CmsToKnotAsync(decimal Cms = MSSM.Value, decimal Constant = MSSM.Cms_Knot_Constant)
        {
            return await Task.Run(() => CmsToKnot(Cms, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cms"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal CmsToMach(decimal Cms = MSSM.Value, decimal Constant = MSSM.Cms_Mach_Constant)
        {
            try
            {
                return Cms * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cms"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> CmsToMachAsync(decimal Cms = MSSM.Value, decimal Constant = MSSM.Cms_Mach_Constant)
        {
            return await Task.Run(() => CmsToMach(Cms, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mps"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal MpsToCms(decimal Mps = MSSM.Value, decimal Constant = MSSM.Mps_Cms_Constant)
        {
            try
            {
                return Mps * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mps"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> MpsToCmsAsync(decimal Mps = MSSM.Value, decimal Constant = MSSM.Mps_Cms_Constant)
        {
            return await Task.Run(() => MpsToCms(Mps, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mps"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal MpsToKph(decimal Mps = MSSM.Value, decimal Constant = MSSM.Mps_Kph_Constant)
        {
            try
            {
                return Mps * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mps"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> MpsToKphAsync(decimal Mps = MSSM.Value, decimal Constant = MSSM.Mps_Kph_Constant)
        {
            return await Task.Run(() => MpsToKph(Mps, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mps"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal MpsToFts(decimal Mps = MSSM.Value, decimal Constant = MSSM.Mps_Fts_Constant)
        {
            try
            {
                return Mps * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mps"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> MpsToFtsAsync(decimal Mps = MSSM.Value, decimal Constant = MSSM.Mps_Fts_Constant)
        {
            return await Task.Run(() => MpsToFts(Mps, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mps"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal MpsToMph(decimal Mps = MSSM.Value, decimal Constant = MSSM.Mps_Mph_Constant)
        {
            try
            {
                return Mps * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mps"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> MpsToMphAsync(decimal Mps = MSSM.Value, decimal Constant = MSSM.Mps_Mph_Constant)
        {
            return await Task.Run(() => MpsToMph(Mps, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mps"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal MpsToKnot(decimal Mps = MSSM.Value, decimal Constant = MSSM.Mps_Knot_Constant)
        {
            try
            {
                return Mps * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mps"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> MpsToKnotAsync(decimal Mps = MSSM.Value, decimal Constant = MSSM.Mps_Knot_Constant)
        {
            return await Task.Run(() => MpsToKnot(Mps, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mps"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal MpsToMach(decimal Mps = MSSM.Value, decimal Constant = MSSM.Mps_Mach_Constant)
        {
            try
            {
                return Mps * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mps"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> MpsToMachAsync(decimal Mps = MSSM.Value, decimal Constant = MSSM.Mps_Mach_Constant)
        {
            return await Task.Run(() => MpsToMach(Mps, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal KphToCms(decimal Kph = MSSM.Value, decimal Constant = MSSM.Kph_Cms_Constant)
        {
            try
            {
                return Kph / Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> KphToCmsAsync(decimal Kph = MSSM.Value, decimal Constant = MSSM.Kph_Cms_Constant)
        {
            return await Task.Run(() => KphToCms(Kph, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal KphToMps(decimal Kph = MSSM.Value, decimal Constant = MSSM.Kph_Mps_Constant)
        {
            try
            {
                return Kph / Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> KphToMpsAsync(decimal Kph = MSSM.Value, decimal Constant = MSSM.Kph_Mps_Constant)
        {
            return await Task.Run(() => KphToMps(Kph, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal KphToFts(decimal Kph = MSSM.Value, decimal Constant = MSSM.Kph_Fts_Constant)
        {
            try
            {
                return Kph / Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> KphToFtsAsync(decimal Kph = MSSM.Value, decimal Constant = MSSM.Kph_Fts_Constant)
        {
            return await Task.Run(() => KphToFts(Kph, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal KphToMph(decimal Kph = MSSM.Value, decimal Constant = MSSM.Kph_Mph_Constant)
        {
            try
            {
                return Kph / Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> KphToMphAsync(decimal Kph = MSSM.Value, decimal Constant = MSSM.Kph_Mph_Constant)
        {
            return await Task.Run(() => KphToMph(Kph, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal KphToKnot(decimal Kph = MSSM.Value, decimal Constant = MSSM.Kph_Knot_Constant)
        {
            try
            {
                return Kph / Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> KphToKnotAsync(decimal Kph = MSSM.Value, decimal Constant = MSSM.Kph_Knot_Constant)
        {
            return await Task.Run(() => KphToKnot(Kph, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal KphToMach(decimal Kph = MSSM.Value, decimal Constant = MSSM.Kph_Mach_Constant)
        {
            try
            {
                return Kph * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> KphToMachAsync(decimal Kph = MSSM.Value, decimal Constant = MSSM.Kph_Mach_Constant)
        {
            return await Task.Run(() => KphToMach(Kph, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fts"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal FtsToCms(decimal Fts = MSSM.Value, decimal Constant = MSSM.Fts_Cms_Constant)
        {
            try
            {
                return Fts * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fts"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> FtsToCmsAsync(decimal Fts = MSSM.Value, decimal Constant = MSSM.Fts_Cms_Constant)
        {
            return await Task.Run(() => FtsToCms(Fts, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fts"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal FtsToMps(decimal Fts = MSSM.Value, decimal Constant = MSSM.Fts_Mps_Constant)
        {
            try
            {
                return Fts * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fts"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> FtsToMpsAsync(decimal Fts = MSSM.Value, decimal Constant = MSSM.Fts_Mps_Constant)
        {
            return await Task.Run(() => FtsToMps(Fts, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fts"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal FtsToKph(decimal Fts = MSSM.Value, decimal Constant = MSSM.Fts_Kph_Constant)
        {
            try
            {
                return Fts * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fts"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> FtsToKphAsync(decimal Fts = MSSM.Value, decimal Constant = MSSM.Fts_Kph_Constant)
        {
            return await Task.Run(() => FtsToKph(Fts, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fts"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal FtsToMph(decimal Fts = MSSM.Value, decimal Constant = MSSM.Fts_Mph_Constant)
        {
            try
            {
                return Fts * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fts"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> FtsToMphAsync(decimal Fts = MSSM.Value, decimal Constant = MSSM.Fts_Mph_Constant)
        {
            return await Task.Run(() => FtsToMph(Fts, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fts"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal FtsToKnot(decimal Fts = MSSM.Value, decimal Constant = MSSM.Fts_Knot_Constant)
        {
            try
            {
                return Fts * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fts"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> FtsToKnotAsync(decimal Fts = MSSM.Value, decimal Constant = MSSM.Fts_Knot_Constant)
        {
            return await Task.Run(() => FtsToKnot(Fts, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fts"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal FtsToMach(decimal Fts = MSSM.Value, decimal Constant = MSSM.Fts_Mach_Constant)
        {
            try
            {
                return Fts * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fts"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> FtsToMachAsync(decimal Fts = MSSM.Value, decimal Constant = MSSM.Fts_Mach_Constant)
        {
            return await Task.Run(() => FtsToMach(Fts, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal MphToCms(decimal Mph = MSSM.Value, decimal Constant = MSSM.Mph_Cms_Constant)
        {
            try
            {
                return Mph * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> MphToCmsAsync(decimal Mph = MSSM.Value, decimal Constant = MSSM.Mph_Cms_Constant)
        {
            return await Task.Run(() => MphToCms(Mph, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal MphToMps(decimal Mph = MSSM.Value, decimal Constant = MSSM.Mph_Mps_Constant)
        {
            try
            {
                return Mph * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> MphToMpsAsync(decimal Mph = MSSM.Value, decimal Constant = MSSM.Mph_Mps_Constant)
        {
            return await Task.Run(() => MphToMps(Mph, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal MphToKph(decimal Mph = MSSM.Value, decimal Constant = MSSM.Mph_Kph_Constant)
        {
            try
            {
                return Mph * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> MphToKphAsync(decimal Mph = MSSM.Value, decimal Constant = MSSM.Mph_Kph_Constant)
        {
            return await Task.Run(() => MphToKph(Mph, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal MphToFts(decimal Mph = MSSM.Value, decimal Constant = MSSM.Mph_Fts_Constant)
        {
            try
            {
                return Mph * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> MphToFtsAsync(decimal Mph = MSSM.Value, decimal Constant = MSSM.Mph_Fts_Constant)
        {
            return await Task.Run(() => MphToFts(Mph, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal MphToKnot(decimal Mph = MSSM.Value, decimal Constant = MSSM.Mph_Knot_Constant)
        {
            try
            {
                return Mph * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> MphToKnotAsync(decimal Mph = MSSM.Value, decimal Constant = MSSM.Mph_Knot_Constant)
        {
            return await Task.Run(() => MphToKnot(Mph, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal MphToMach(decimal Mph = MSSM.Value, decimal Constant = MSSM.Mph_Mach_Constant)
        {
            try
            {
                return Mph * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> MphToMachAsync(decimal Mph = MSSM.Value, decimal Constant = MSSM.Mph_Mach_Constant)
        {
            return await Task.Run(() => MphToMach(Mph, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Knot"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal KnotToCms(decimal Knot = MSSM.Value, decimal Constant = MSSM.Knot_Cms_Constant)
        {
            try
            {
                return Knot * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Knot"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> KnotToCmsAsync(decimal Knot = MSSM.Value, decimal Constant = MSSM.Knot_Cms_Constant)
        {
            return await Task.Run(() => KnotToCms(Knot, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Knot"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal KnotToMps(decimal Knot = MSSM.Value, decimal Constant = MSSM.Knot_Mps_Constant)
        {
            try
            {
                return Knot * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Knot"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> KnotToMpsAsync(decimal Knot = MSSM.Value, decimal Constant = MSSM.Knot_Mps_Constant)
        {
            return await Task.Run(() => KnotToMps(Knot, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Knot"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal KnotToKph(decimal Knot = MSSM.Value, decimal Constant = MSSM.Knot_Kph_Constant)
        {
            try
            {
                return Knot * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Knot"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> KnotToKphAsync(decimal Knot = MSSM.Value, decimal Constant = MSSM.Knot_Kph_Constant)
        {
            return await Task.Run(() => KnotToKph(Knot, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Knot"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal KnotToFts(decimal Knot = MSSM.Value, decimal Constant = MSSM.Knot_Fts_Constant)
        {
            try
            {
                return Knot * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Knot"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> KnotToFtsAsync(decimal Knot = MSSM.Value, decimal Constant = MSSM.Knot_Fts_Constant)
        {
            return await Task.Run(() => KnotToFts(Knot, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Knot"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal KnotToMph(decimal Knot = MSSM.Value, decimal Constant = MSSM.Knot_Mph_Constant)
        {
            try
            {
                return Knot * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Knot"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> KnotToMphAsync(decimal Knot = MSSM.Value, decimal Constant = MSSM.Knot_Mph_Constant)
        {
            return await Task.Run(() => KnotToMph(Knot, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Knot"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal KnotToMach(decimal Knot = MSSM.Value, decimal Constant = MSSM.Knot_Mach_Constant)
        {
            try
            {
                return Knot / Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Knot"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> KnotToMachAsync(decimal Knot = MSSM.Value, decimal Constant = MSSM.Knot_Mach_Constant)
        {
            return await Task.Run(() => KnotToMach(Knot, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mach"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal MachToCms(decimal Mach = MSSM.Value, decimal Constant = MSSM.Mach_Cms_Constant)
        {
            try
            {
                return Mach * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mach"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> MachToCmsAsync(decimal Mach = MSSM.Value, decimal Constant = MSSM.Mach_Cms_Constant)
        {
            return await Task.Run(() => MachToCms(Mach, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mach"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal MachToMps(decimal Mach = MSSM.Value, decimal Constant = MSSM.Mach_Mps_Constant)
        {
            try
            {
                return Mach * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mach"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> MachToMpsAsync(decimal Mach = MSSM.Value, decimal Constant = MSSM.Mach_Mps_Constant)
        {
            return await Task.Run(() => MachToMps(Mach, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mach"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal MachToKph(decimal Mach = MSSM.Value, decimal Constant = MSSM.Mach_Kph_Constant)
        {
            try
            {
                return Mach * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mach"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> MachToKphAsync(decimal Mach = MSSM.Value, decimal Constant = MSSM.Mach_Kph_Constant)
        {
            return await Task.Run(() => MachToKph(Mach, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mach"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal MachToFts(decimal Mach = MSSM.Value, decimal Constant = MSSM.Mach_Fts_Constant)
        {
            try
            {
                return Mach * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mach"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> MachToFtsAsync(decimal Mach = MSSM.Value, decimal Constant = MSSM.Mach_Fts_Constant)
        {
            return await Task.Run(() => MachToFts(Mach, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mach"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal MachToMph(decimal Mach = MSSM.Value, decimal Constant = MSSM.Mach_Mph_Constant)
        {
            try
            {
                return Mach * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mach"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> MachToMphAsync(decimal Mach = MSSM.Value, decimal Constant = MSSM.Mach_Mph_Constant)
        {
            return await Task.Run(() => MachToMph(Mach, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mach"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal MachToKnot(decimal Mach = MSSM.Value, decimal Constant = MSSM.Mach_Knot_Constant)
        {
            try
            {
                return Mach * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mach"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> MachToKnotAsync(decimal Mach = MSSM.Value, decimal Constant = MSSM.Mach_Knot_Constant)
        {
            return await Task.Run(() => MachToKnot(Mach, Constant));
        }
    }
}