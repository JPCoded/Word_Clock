namespace Word_Clock
{
    sealed partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.rtbWord = new System.Windows.Forms.RichTextBox();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // rtbWord
            // 
            this.rtbWord.BackColor = System.Drawing.Color.Black;
            this.rtbWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbWord.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rtbWord.DetectUrls = false;
            this.rtbWord.Font = new System.Drawing.Font("Lucida Console", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbWord.ForeColor = System.Drawing.Color.Silver;
            this.rtbWord.Location = new System.Drawing.Point(0, 0);
            this.rtbWord.Name = "rtbWord";
            this.rtbWord.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbWord.ShortcutsEnabled = false;
            this.rtbWord.Size = new System.Drawing.Size(213, 265);
            this.rtbWord.TabIndex = 0;
            this.rtbWord.Text = "ITTISITWENTY\nQUARTERHALFM\nTENFIVEEPAST\nTOATWELVEONE\nTWOTHREEFOUR\nFIVESIXSEVEN\nEIG" +
    "HTNINETEN\nELEVENNDDATE\nO\'CLOCKTIMEA";
            // 
            // tmrTime
            // 
            this.tmrTime.Enabled = true;
            this.tmrTime.Interval = 2000;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 267);
            this.Controls.Add(this.rtbWord);
            this.Name = "Form1";
            this.Text = "Word Clock";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbWord;
        private System.Windows.Forms.Timer tmrTime;
    }
}

