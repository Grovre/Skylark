﻿using System;
using System.Diagnostics;
using System.Threading;
using System.Windows;
using System.Windows.Forms;
using SE = Skylark.Exception;
using SETFT = Skylark.Enum.TimeoutFlagsType;
using SWHFI = Skylark.Wing.Helper.FormInterop;
using SWHPI = Skylark.Wing.Helper.ProcessInterop;
using SWHWAPI = Skylark.Wing.Helper.WinAPI;
using SWHWI = Skylark.Wing.Helper.WindowInterop;

namespace Skylark.Wing.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public static class DesktopIcon
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Form"></param>
        /// <returns></returns>
        public static bool FixForm(Form Form)
        {
            try
            {
                return FixHandle(SWHFI.Handle(Form));
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Window"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static bool FixWindow(Window Window)
        {
            try
            {
                return FixHandle(SWHWI.EnsureHandle(Window));
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Process"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static bool FixProcess(Process Process)
        {
            try
            {
                return FixHandle(SWHPI.MainWindowHandle(Process));
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Handle"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static bool FixHandle(IntPtr Handle)
        {
            try
            {
                IntPtr Progman = SWHWAPI.FindWindow("Progman", "Program Manager"); //"Progman", null - "Progman", "Program Manager"

                if (Progman == IntPtr.Zero)
                {
                    return false;
                }

                IntPtr WorkerW = IntPtr.Zero;

                // Tried several times.
                for (int Count = 0; Count < 8; ++Count)
                {
                    // Skip once.
                    if (Count % 2 == 0)
                    {
                        IntPtr Result = IntPtr.Zero;
                        SWHWAPI.SendMessageTimeout(Progman, 0x052C, new IntPtr(0), IntPtr.Zero, SETFT.SMTO_NORMAL, 10000, out Result);
                    }

                    SWHWAPI.EnumWindows(new SWHWAPI.EnumWindowsProc((TopHandle, TopParamHandle) =>
                    {
                        IntPtr IntPtr = SWHWAPI.FindWindowEx(TopHandle, IntPtr.Zero, "SHELLDLL_DefView", IntPtr.Zero);

                        if (IntPtr != IntPtr.Zero)
                        {
                            WorkerW = SWHWAPI.FindWindowEx(IntPtr.Zero, TopHandle, "WorkerW", IntPtr.Zero);
                        }

                        return true;
                    }), IntPtr.Zero);


                    if (WorkerW == IntPtr.Zero)
                    {
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        break;
                    }
                }

                if (WorkerW == IntPtr.Zero)
                {
                    return false;
                }

                SWHWAPI.ShowWindow(WorkerW, 0); /*HIDE*/
                SWHWAPI.SetParent(Handle, Progman);

                return true;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }
    }
}