namespace Word_Clock
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbWord = new System.Windows.Forms.RichTextBox();
            this.nudHours = new System.Windows.Forms.NumericUpDown();
            this.nudMinutes = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbWord
            // 
            this.rtbWord.BackColor = System.Drawing.Color.Black;
            this.rtbWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbWord.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rtbWord.Font = new System.Drawing.Font("Lucida Console", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbWord.ForeColor = System.Drawing.Color.Silver;
            this.rtbWord.Location = new System.Drawing.Point(0, 0);
            this.rtbWord.Name = "rtbWord";
            this.rtbWord.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbWord.Size = new System.Drawing.Size(217, 258);
            this.rtbWord.TabIndex = 0;
            this.rtbWord.Text = "ITTISITWENTY\nQUARTERHALFM\nTENFIVEEPAST\nTOATWELVEONE\nTWOTHREEFOUR\nFIVESIXSEVEN\nEIG" +
    "HTNINETEN\nELEVENNDDATE\nO\'CLOCKTIMEA";
            // 
            // nudHours
            // 
            this.nudHours.Location = new System.Drawing.Point(223, 12);
            this.nudHours.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudHours.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHours.Name = "nudHours";
            this.nudHours.Size = new System.Drawing.Size(39, 20);
            this.nudHours.TabIndex = 1;
            this.nudHours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHours.ValueChanged += new System.EventHandler(this.nudHours_ValueChanged);
            // 
            // nudMinutes
            // 
            this.nudMinutes.Location = new System.Drawing.Point(268, 12);
            this.nudMinutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudMinutes.Name = "nudMinutes";
            this.nudMinutes.Size = new System.Drawing.Size(59, 20);
            this.nudMinutes.TabIndex = 2;
            this.nudMinutes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMinutes.ValueChanged += new System.EventHandler(this.nudMinutes_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 261);
            this.Controls.Add(this.nudMinutes);
            this.Controls.Add(this.nudHours);
            this.Controls.Add(this.rtbWord);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbWord;
        private System.Windows.Forms.NumericUpDown nudHours;
        private System.Windows.Forms.NumericUpDown nudMinutes;
    }
}

