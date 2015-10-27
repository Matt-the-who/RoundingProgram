namespace RoundingProgram
{
    partial class frmRounding
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
            this.txtNumberToRound = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.nudAmountOfDecimals = new System.Windows.Forms.NumericUpDown();
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountOfDecimals)).BeginInit();
            this.mnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumberToRound
            // 
            this.txtNumberToRound.Location = new System.Drawing.Point(85, 64);
            this.txtNumberToRound.Name = "txtNumberToRound";
            this.txtNumberToRound.Size = new System.Drawing.Size(100, 20);
            this.txtNumberToRound.TabIndex = 0;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(101, 142);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(48, 188);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 13);
            this.lblAnswer.TabIndex = 2;
            // 
            // nudAmountOfDecimals
            // 
            this.nudAmountOfDecimals.Location = new System.Drawing.Point(85, 102);
            this.nudAmountOfDecimals.Name = "nudAmountOfDecimals";
            this.nudAmountOfDecimals.Size = new System.Drawing.Size(100, 20);
            this.nudAmountOfDecimals.TabIndex = 3;
            // 
            // mnuStrip
            // 
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(285, 24);
            this.mnuStrip.TabIndex = 4;
            this.mnuStrip.Text = "menuStrip1";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(152, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // frmRounding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 261);
            this.Controls.Add(this.nudAmountOfDecimals);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtNumberToRound);
            this.Controls.Add(this.mnuStrip);
            this.MainMenuStrip = this.mnuStrip;
            this.Name = "frmRounding";
            this.Text = "Rounding Program";
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountOfDecimals)).EndInit();
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumberToRound;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.NumericUpDown nudAmountOfDecimals;
        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
    }
}

