#region

using System.Collections.Generic;
using System.Windows.Forms;

#endregion

namespace Word_Clock
{
    public partial class Form1 : Form
    {
        public Dictionary<string, int[]> HoursDictionary = new Dictionary<string, int[]>
        {
            {"1", new[] {48, 3}},
            {"2", new[] {52, 3}},
            {"3", new[] {55, 5}},
            {"4", new[] {60, 4}},
            {"5", new[] {65, 4}},
            {"6", new[] {69, 3}},
            {"7", new[] {72, 5}},
            {"8", new[] {78, 5}},
            {"9", new[] {83, 4}},
            {"10", new[] {87, 3}},
            {"11", new[] {91, 6}},
            {"12", new[] {42, 6}}
        };

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
            //rtbWord.HightlightText(104, 7); // O'CLOCK

  
        }

        private void nudHours_ValueChanged(object sender, System.EventArgs e)
        {
            
            rtbWord.ResetColor();
            var hour = nudHours.Value.ToString();
            var values = HoursDictionary[hour];
            rtbWord.HightlightText(values[0],values[1]);
        }
    }
}