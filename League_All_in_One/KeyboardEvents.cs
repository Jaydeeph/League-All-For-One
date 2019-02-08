using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace League_All_in_One
{

    static class KeyboardEvents
    {
        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

        [DllImport("User32.dll")]
        public static extern short GetAsyncKeyState(Keys vKey);

        private const byte KEY_DOWN = 0x00;
        private const byte KEY_UP = 0x02;

        private const byte VK_CONTROL = 0x11;
        private const byte VK_ENTER = 0x0D;

        private const byte V_KEY = 0x56;

        public static void PressControlV()
        {
            keybd_event(VK_CONTROL, 0, KEY_DOWN, UIntPtr.Zero);
            keybd_event(V_KEY, 0, KEY_DOWN, UIntPtr.Zero);

            keybd_event(VK_CONTROL, 0, KEY_UP, UIntPtr.Zero);
            keybd_event(V_KEY, 0, KEY_UP, UIntPtr.Zero);
        }
        
        public static  void PressEnter()
        {
            keybd_event(VK_ENTER, 0, KEY_DOWN, UIntPtr.Zero);
            keybd_event(VK_ENTER, 0, KEY_UP, UIntPtr.Zero);
        }

        public static void SetClipboardText(string text)
        {
            Clipboard.SetText(text);
        }

        public static void ClearClipboard()
        {
            Clipboard.Clear();
        }
    }
}
