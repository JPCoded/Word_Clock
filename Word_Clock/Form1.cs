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

        private void ChangeTime(int hour, int minute)
        {
            foreach (var word in _hoursDictionary.Values)
            {
                rtbWord.ResetText(word);
            }
            foreach (var word in _descriptorDictionary.Values)
            {
                rtbWord.ResetText(word);
            }
            rtbWord.HightlightText(0, 2); //IT
            rtbWord.HightlightText(3, 2); //IS
            var values = _hoursDictionary[hour.ToString()];
            rtbWord.HightlightText(values);

            var pastto = (minute >= 35) ? _descriptorDictionary["TO"] : _descriptorDictionary["PAST"];

            if (minute < 30 || minute >= 35)
            {
                if (minute < 25 || minute >= 40)
                {
                    if (minute < 20 || minute >= 45)
                    {
                        if (minute < 15 || minute >= 50)
                        {
                            if (minute < 10 || minute >= 55)
                            {
                                if (minute < 5)
                                {
                                    var oclock = _descriptorDictionary["O'CLOCK"];
                                    rtbWord.HightlightText(oclock);
                                }
                                else
                                {
                                    var five = _descriptorDictionary["FIVE"];
                                    rtbWord.HightlightText(five);
                                    rtbWord.HightlightText(pastto);
                                }
                            }
                            else
                            {
                                var ten = _descriptorDictionary["TEN"];
                                rtbWord.HightlightText(ten);
                                rtbWord.HightlightText(pastto);
                            }
                        }
                        else
                        {
                            var quarter = _descriptorDictionary["QUARTER"];
                            rtbWord.HightlightText(quarter);
                            rtbWord.HightlightText(pastto);
                        }
                    }
                    else
                    {
                        var twenty = _descriptorDictionary["TWENTY"];
                        rtbWord.HightlightText(twenty);
                        rtbWord.HightlightText(pastto);
                    }
                }
                else
                {
                    var twenty = _descriptorDictionary["TWENTY"];
                    var five = _descriptorDictionary["FIVE"];
                    rtbWord.HightlightText(twenty);
                    rtbWord.HightlightText(five);
                    rtbWord.HightlightText(pastto);
                }
            }
            else
            {
                var half = _descriptorDictionary["HALF"];
                rtbWord.HightlightText(half);
                rtbWord.HightlightText(pastto);
            }
        }

        private void nudHours_ValueChanged(object sender, EventArgs e)
        {
            foreach (var word in _hoursDictionary.Values)
            {
                rtbWord.ResetText(word);
            }
            var hour = nudHours.Value.ToString();
            var values = _hoursDictionary[hour];
            rtbWord.HightlightText(values);
        }

        private void nudMinutes_ValueChanged(object sender, EventArgs e)
        {
            foreach (var word in _descriptorDictionary.Values)
            {
                rtbWord.ResetText(word);
            }

            var seconds = nudMinutes.Value;
            var pastto = (seconds >= 35) ? _descriptorDictionary["TO"] : _descriptorDictionary["PAST"];

            if (seconds < 30 || seconds >= 35)
            {
                if (seconds < 25 || seconds >= 40)
                {
                    if (seconds < 20 || seconds >= 45)
                    {
                        if (seconds < 15 || seconds >= 50)
                        {
                            if (seconds < 10 || seconds >= 55)
                            {
                                if (seconds < 5)
                                {
                                    var oclock = _descriptorDictionary["O'CLOCK"];
                                    rtbWord.HightlightText(oclock);
                                }
                                else
                                {
                                    var five = _descriptorDictionary["FIVE"];
                                    rtbWord.HightlightText(five);
                                    rtbWord.HightlightText(pastto);
                                }
                            }
                            else
                            {
                                var ten = _descriptorDictionary["TEN"];
                                rtbWord.HightlightText(ten);
                                rtbWord.HightlightText(pastto);
                            }
                        }
                        else
                        {
                            var quarter = _descriptorDictionary["QUARTER"];
                            rtbWord.HightlightText(quarter);
                            rtbWord.HightlightText(pastto);
                        }
                    }
                    else
                    {
                        var twenty = _descriptorDictionary["TWENTY"];
                        rtbWord.HightlightText(twenty);
                        rtbWord.HightlightText(pastto);
                    }
                }
                else
                {
                    var twenty = _descriptorDictionary["TWENTY"];
                    var five = _descriptorDictionary["FIVE"];
                    rtbWord.HightlightText(twenty);
                    rtbWord.HightlightText(five);
                    rtbWord.HightlightText(pastto);
                }
            }
            else
            {
                var half = _descriptorDictionary["HALF"];
                rtbWord.HightlightText(half);
                rtbWord.HightlightText(pastto);
            }
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            var hour = DateTime.Now.Hour;
            var minute = DateTime.Now.Minute;
            hour = (hour > 12) ? hour - 12 : hour;
            ChangeTime(hour, minute);
        }
    }
}