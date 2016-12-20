#region

using System.Windows.Forms;

#endregion

namespace Word_Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rtbWord.HightlightText(0, 2); //IT
            rtbWord.HightlightText(3, 2); //IS
            //rtbWord.HightlightText(6,6); //TWENTY
            //rtbWord.HightlightText(13, 7); //QUARTER
            //rtbWord.HightlightText(20, 4); // HALF
            //rtbWord.HightlightText(26, 3); // TEN
            //rtbWord.HightlightText(29, 4); // FIVE
            //rtbWord.HightlightText(34, 4); // PAST
            //rtbWord.HightlightText(39, 2); // TO
            //rtbWord.HightlightText(42, 6); // TWELVE
            //rtbWord.HightlightText(48, 3); // ONE
            //rtbWord.HightlightText(52, 3); // TWO
            //rtbWord.HightlightText(55, 5); // THREE
            //rtbWord.HightlightText(60, 4); // FOUR
            //rtbWord.HightlightText(65, 4); // FIVE
            //rtbWord.HightlightText(69, 3); // SIX
            //rtbWord.HightlightText(72, 5); // SEVEN
            //rtbWord.HightlightText(78, 5); // EIGHT
            //rtbWord.HightlightText(83, 4); // NINE
            //rtbWord.HightlightText(87, 3); // TEN
            //rtbWord.HightlightText(91, 6); // ELEVEN
            //rtbWord.HightlightText(104, 7); // O'CLOCK
        }
    }
}