#region

using System.Drawing;
using System.Windows.Forms;

#endregion

namespace Word_Clock
{
    public static class HightLightExtension
    {
        public static void HightlightText(this RichTextBox rtBox, int start, int length)
        {
            rtBox.Select(start, length);
            rtBox.SelectionColor = Color.Red;
        }
    }
}