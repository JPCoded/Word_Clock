#region

using System;
using System.Collections.Generic;
using System.Windows.Forms;

#endregion

namespace Word_Clock
{
    public partial class Form1 : Form
    {
        private readonly Dictionary<string, int[]> _descriptorDictionary = new Dictionary<string, int[]>
        {
            {"TWENTY", new[] {6, 6}},
            {"QUARTER", new[] {13, 7}},
            {"HALF", new[] {20, 4}},
            {"TEN", new[] {26, 3}},
            {"FIVE", new[] {29, 4}},
            {"PAST", new[] {34, 4}},
            {"TO", new[] {39, 2}},
            {"O'CLOCK", new[] {104, 7}}
        };

        private readonly Dictionary<string, int[]> _hoursDictionary = new Dictionary<string, int[]>
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
        }

        private void nudHours_ValueChanged(object sender, EventArgs e)
        {
            foreach (var x in _hoursDictionary.Values)
            {
                rtbWord.ResetText(x[0],x[1]);
            }
            var hour = nudHours.Value.ToString();
            var values = _hoursDictionary[hour];
            rtbWord.HightlightText(values);
        }

        private void nudMinutes_ValueChanged(object sender, EventArgs e)
        {
            foreach (var x in _descriptorDictionary.Values)
            {
                rtbWord.ResetText(x[0],x[1]);
            }
            var seconds = nudMinutes.Value;
            if (seconds < 5)
            {
                var y = _descriptorDictionary["O'CLOCK"];
                rtbWord.HightlightText(y[0],y[1]);
            }
        }
    }
}