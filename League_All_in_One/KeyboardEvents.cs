using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace League_All_in_One
{
    static class KeyboardEvents
    {
        public static void SetClipboardText(string text)
        {
            Clipboard.SetText(text);
        }

        public static void PasteFromClipboard()
        {
            SendKeys.SendWait("^{v}");
        }

    }
}
