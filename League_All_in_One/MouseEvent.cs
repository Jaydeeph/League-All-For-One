using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace League_All_in_One
{
    static class MouseEvent
    {
        private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const uint MOUSEEVENTF_LEFTUP = 0x0004;

        [DllImport("user32.dll")]
        private static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

        public static void MoveCursorTo(int x, int y)
        {
            Point newCursorPosition = new Point(x, y);
            Cursor.Position = newCursorPosition;
        }

        public static void LeftClick()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            Thread.Sleep(100);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }

        public static void MoveMouseXYToAndClick(int x, int y)
        {
            MoveCursorTo(x, y);
            LeftClick();
        }
    }
}
