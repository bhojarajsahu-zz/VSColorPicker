using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bhojarajsahu88.VSColorPicker.GUIElement
{
    public partial class VSColorPicker : Form
    {
        Color pixelColor = new Color();
        int xPos = 0;
        int yPos = 0;
        bool status = true;
        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point lpPoint);
        public VSColorPicker()
        {
            InitializeComponent();
            MouseHook.Start();
            MouseHook.MouseAction += new EventHandler(ClickEvent);
        }
        private void ClickEvent(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("Left mouse click!");
                MouseHook.stop();
                getDetails();
            }
            catch { }

        }
        public void getDetails()
        {
            if (status)
            {
                pixelColor = GetPixelColor(xPos, yPos);
            }
            textBoxR.Text = pixelColor.R.ToString();
            textBoxG.Text = pixelColor.G.ToString();
            textBoxB.Text = pixelColor.B.ToString();
            //textBoxA.Text = pixelColor.A.ToString();


            double hue;
            double saturation;
            double value;
            ColorToHSV(pixelColor, out hue, out saturation, out value);

            string hueValue = Convert.ToString(Convert.ToInt32(hue));
            string satValue = Convert.ToString(Convert.ToInt32(saturation));
            string valValue = Convert.ToString(Convert.ToInt32(value));

            //string hueValue = Convert.ToString(Convert.ToInt32(pixelColor.GetHue()));
            //string satValue = Convert.ToString(Convert.ToInt32(pixelColor.GetSaturation()));
            //string valValue = Convert.ToString(Convert.ToInt32(pixelColor.g()));
            textBoxHUE.Text = hueValue;
            textBoxSAT.Text = satValue;
            textBoxBRI.Text = valValue;

            panelColor.BackColor = pixelColor;

            textBoxRGB.Text = RGBConverter(pixelColor);
            textBoxHexa.Text = HexConverter(pixelColor);
        }
        private static String HexConverter(System.Drawing.Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }

        private static String RGBConverter(System.Drawing.Color c)
        {
            return c.R.ToString() + "," + c.G.ToString() + "," + c.B.ToString();
        }
        public static void ColorToHSV(Color color, out double hue, out double saturation, out double value)
        {
            int max = Math.Max(color.R, Math.Max(color.G, color.B));
            int min = Math.Min(color.R, Math.Min(color.G, color.B));

            hue = color.GetHue();
            saturation = (max == 0) ? 0 : 1d - (1d * min / max);
            value = max / 255d;
        }
        public static Color ColorFromHSV(double hue, double saturation, double value)
        {
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            double f = hue / 60 - Math.Floor(hue / 60);

            value = value * 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            if (hi == 0)
                return Color.FromArgb(255, v, t, p);
            else if (hi == 1)
                return Color.FromArgb(255, q, v, p);
            else if (hi == 2)
                return Color.FromArgb(255, p, v, t);
            else if (hi == 3)
                return Color.FromArgb(255, p, q, v);
            else if (hi == 4)
                return Color.FromArgb(255, t, p, v);
            else
                return Color.FromArgb(255, v, p, q);
        }
        [DllImport("user32.dll")]
        static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("user32.dll")]
        static extern Int32 ReleaseDC(IntPtr hwnd, IntPtr hdc);

        [DllImport("gdi32.dll")]
        static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);

        static public System.Drawing.Color GetPixelColor(int x, int y)
        {
            Color color = new Color();
            try
            {
                IntPtr hdc = GetDC(IntPtr.Zero);
                uint pixel = GetPixel(hdc, x, y);
                ReleaseDC(IntPtr.Zero, hdc);
                color = Color.FromArgb((int)(pixel & 0x000000FF),
                             (int)(pixel & 0x0000FF00) >> 8,
                             (int)(pixel & 0x00FF0000) >> 16);
            }
            catch { }
            return color;
        }

        private void VSColorPicker_Load(object sender, EventArgs e)
        {


        }

        private void timerMousePosition_Tick(object sender, EventArgs e)
        {
            try
            {
                Point pt = new Point();
                GetCursorPos(ref pt);
                xPos = pt.X;
                yPos = pt.Y;
                textBoxX.Text = pt.X.ToString();
                textBoxY.Text = pt.Y.ToString();
            }
            catch { }
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            try
            {
                MouseHook.Start();
                status = true;
                reset();
            }
            catch { }

        }
        public void reset()
        {
            try
            {
                panelColor.BackColor = Color.FromArgb(240, 240, 240);
                textBoxR.Text = "000";
                textBoxG.Text = "000";
                textBoxB.Text = "000";

                textBoxHUE.Text = "000";
                textBoxSAT.Text = "000";
                textBoxBRI.Text = "000";


                textBoxRGB.Text = "000";
                textBoxHexa.Text = "000";

            }
            catch { }

        }

        private void groupBoxPosition_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabelLazzyCoder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("http://www.lazzycoder.com");
            }
            catch { }
        }

        private void linkLabelFeedback_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("mailto:support@lazzycoder.com");
            }
            catch { }
        }


        private void buttonColorBox_Click(object sender, EventArgs e)
        {
            try
            {
                MouseHook.stop();
                status = false;
                DialogResult colorResult = colorDialogColor.ShowDialog();
                // See if user pressed ok.
                if (colorResult == DialogResult.OK)
                {
                    // Set form background to the selected color.
                    pixelColor = colorDialogColor.Color;
                    getDetails();

                }
                else
                {
                    MouseHook.Start();
                    status = true;
                }
            }
            catch { }

        }

        private void buttonRGBCopy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(textBoxRGB.Text, TextDataFormat.Text);
            }
            catch { }

        }

        private void buttonHexaCopy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(textBoxHexa.Text, TextDataFormat.Text);
            }
            catch { }
        }
    }
    public static class MouseHook
    {
        public static event EventHandler MouseAction = delegate { };

        public static void Start()
        {
            try
            {
                _hookID = SetHook(_proc);
            }
            catch { }
        }
        public static void stop()
        {
            try
            {
                UnhookWindowsHookEx(_hookID);
            }
            catch { }
        }

        private static LowLevelMouseProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;

        private static IntPtr SetHook(LowLevelMouseProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_MOUSE_LL, proc,
                  GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private delegate IntPtr LowLevelMouseProc(int nCode, IntPtr wParam, IntPtr lParam);

        private static IntPtr HookCallback(
          int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && MouseMessages.WM_LBUTTONDOWN == (MouseMessages)wParam)
            {
                MSLLHOOKSTRUCT hookStruct = (MSLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(MSLLHOOKSTRUCT));
                MouseAction(null, new EventArgs());
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        private const int WH_MOUSE_LL = 14;

        private enum MouseMessages
        {
            WM_LBUTTONDOWN = 0x0201,
            WM_LBUTTONUP = 0x0202,
            WM_MOUSEMOVE = 0x0200,
            WM_MOUSEWHEEL = 0x020A,
            WM_RBUTTONDOWN = 0x0204,
            WM_RBUTTONUP = 0x0205
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct POINT
        {
            public int x;
            public int y;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct MSLLHOOKSTRUCT
        {
            public POINT pt;
            public uint mouseData;
            public uint flags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
          LowLevelMouseProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
          IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
    }
}
