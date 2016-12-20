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
        public static void HightlightText(this RichTextBox rtBox, int[] startstop)
        {
            rtBox.Select(startstop[0], startstop[1]);
            rtBox.SelectionColor = Color.Red;
            rtBox.DeselectAll();
        }
        public static void ResetText(this RichTextBox rtBox, int start, int length)
        {
            rtBox.Select(start, length);
            rtBox.SelectionColor = Color.Silver;
            rtBox.DeselectAll();
        }

        public static void ResetText(this RichTextBox rtBox, int[] startstop)
        {
            rtBox.Select(startstop[0],startstop[1]);
            rtBox.SelectionColor = Color.Silver;
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