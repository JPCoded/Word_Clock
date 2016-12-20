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
            rtBox.DeselectAll();
        }

        public static void ResetColor(this RichTextBox rtBox)
        {
            rtBox.SelectAll();
            rtBox.SelectionColor = Color.Silver;
            rtBox.DeselectAll();
        }
    }
}