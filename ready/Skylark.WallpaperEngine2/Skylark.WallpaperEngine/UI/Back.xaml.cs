﻿using CefSharp;
using Skylark.Enum;
using Skylark.Struct.Monitor;
using Skylark.Wing.Helper;
using Skylark.Wing.Utility;
using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Forms;

namespace Skylark.WallpaperEngine.UI
{
    /// <summary>
    /// Interaction logic for Back.xaml
    /// </summary>
    public partial class Back : Window
    {
        public int ScreenIndex { get; private set; } = 0;

        public bool IsFixed { get; private set; } = false;

        public bool State { get; private set; } = false;

        public bool Hook { get; private set; } = false;

        private static IntPtr MouseHook = IntPtr.Zero;

        public Back(string Uri = "https://www.vegalya.com", bool Hook = false)
        {
            InitializeComponent();

            this.Hook = Hook;
            WallView.Address = Uri;

            WallView.MenuHandler = new CustomContextMenuHandler();

            PinToBackground();
        }

        private void WallView_Loaded(object sender, RoutedEventArgs e)
        {
            if (Hook)
            {
                State = true;

                MouseEventCall = CatchMouseEvent;
                MouseHook = WinAPI.SetWindowsHookEx(14, MouseEventCall, IntPtr.Zero, 0);
            }
        }

        protected bool PinToBackground()
        {
            IsFixed = DesktopIcon.FixWindow(this);

            if (IsFixed)
            {
                Screene.FillScreenWindow(this, OwnerScreen);
            }

            return IsFixed;
        }

        public int OwnerScreenIndex
        {
            get => ScreenIndex;
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                else if (value >= Screen.AllScreens.Length)
                {
                    value = 0;
                }

                if (ScreenIndex != value)
                {
                    ScreenIndex = value;

                    PinToBackground();
                }
            }
        }

        public MonitorStruct OwnerScreen
        {
            get
            {
                if (OwnerScreenIndex < Screene.Screens.Length)
                {
                    return Screene.Screens[OwnerScreenIndex];
                }

                return new MonitorStruct()
                {
                    rcMonitor = Screen.PrimaryScreen.Bounds,
                    rcWork = Screen.PrimaryScreen.WorkingArea,
                };
            }
        }

        private static WinAPI.MouseEventCallback? MouseEventCall;

        [StructLayout(LayoutKind.Sequential)]
        private struct MousePoint
        {
            public int X;
            public int Y;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct MouseHookStruct
        {
            public MousePoint pt;
            public IntPtr hwnd;
            public uint wHitTestCode;
            public IntPtr dwExtraInfo;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct MouseExtraHookStruct
        {
            public MousePoint Point;
            public int MouseData;
            public int Flags;
            public int Time;
            public IntPtr ExtraInfo;
        }

        private IntPtr CatchMouseEvent(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (State)
            {
                IBrowserHost WVHost = WallView.GetBrowser().GetHost();

                MouseExtraHookStruct mouseHookStruct = (MouseExtraHookStruct)Marshal.PtrToStructure(lParam, typeof(MouseExtraHookStruct));
                int X = mouseHookStruct.Point.X;
                int Y = mouseHookStruct.Point.Y;

                if (nCode >= 0 && MouseMessagesType.WM_WHEEL == (MouseMessagesType)wParam)
                {
                    int delta = (mouseHookStruct.MouseData >> 16) & 0xFFFF;
                    bool isScrollDown = (delta & 0x8000) != 0;

                    int deltaX = mouseHookStruct.MouseData & 0xFFFF;
                    int deltaY = (mouseHookStruct.MouseData >> 16) & 0xFFFF;

                    int amount = 120;

                    if (isScrollDown)
                    {
                        //deltaX = -+(delta / amount);
                        deltaY = -amount;
                    }
                    else
                    {
                        //deltaX = delta / amount;
                        deltaY = amount;
                    }

                    MouseEvent mouseEvent = new(deltaX, deltaY, CefEventFlags.None);
                    WVHost.SendMouseWheelEvent(mouseEvent, deltaX, deltaY);
                }
                else if (nCode >= 0 && MouseMessagesType.WM_LBUTTONDOWN == (MouseMessagesType)wParam)
                {
                    // Sol tuşa basma olayı
                    // İlgili işlemleri burada gerçekleştirin
                    WVHost.SendMouseClickEvent(X, Y, MouseButtonType.Left, false, 1, CefEventFlags.None);
                }
                else if (nCode >= 0 && MouseMessagesType.WM_LBUTTONUP == (MouseMessagesType)wParam)
                {
                    // Sol tuştan el çekme olayı
                    // İlgili işlemleri burada gerçekleştirin
                    WVHost.SendMouseClickEvent(X, Y, MouseButtonType.Left, true, 1, CefEventFlags.None);
                }
                else if (nCode >= 0 && MouseMessagesType.WM_RBUTTONDOWN == (MouseMessagesType)wParam)
                {
                    // Sağ tuşa basma olayı
                    // İlgili işlemleri burada gerçekleştirin
                    WVHost.SendMouseClickEvent(X, Y, MouseButtonType.Right, false, 1, CefEventFlags.None);
                }
                else if (nCode >= 0 && MouseMessagesType.WM_RBUTTONUP == (MouseMessagesType)wParam)
                {
                    // Sağ tuştan el çekme olayı
                    // İlgili işlemleri burada gerçekleştirin
                    WVHost.SendMouseClickEvent(X, Y, MouseButtonType.Right, true, 1, CefEventFlags.None);
                }
                else if (nCode >= 0 && MouseMessagesType.WM_MOVE == (MouseMessagesType)wParam)
                {
                    // Fare hareketi olayı
                    // İlgili işlemleri burada gerçekleştirin
                    WVHost.SendMouseMoveEvent(X, Y, false, CefEventFlags.None);
                }
            }

            return WinAPI.CallNextHookEx(IntPtr.Zero, nCode, wParam, lParam);
        }
    }

    public class CustomContextMenuHandler : IContextMenuHandler
    {
        public void OnBeforeContextMenu(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model)
        {
            model.Clear();
        }

        public bool OnContextMenuCommand(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IContextMenuParams parameters, CefMenuCommand commandId, CefEventFlags eventFlags)
        {
            return false;
        }

        public void OnContextMenuDismissed(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame)
        {
            return;
        }

        public bool RunContextMenu(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model, IRunContextMenuCallback callback)
        {
            return false;
        }
    }
}