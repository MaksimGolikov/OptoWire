namespace OpticalWire.Forms
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.bnAppliedChange = new System.Windows.Forms.Button();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.lbLanguage = new System.Windows.Forms.Label();
            this.lbMedian = new System.Windows.Forms.Label();
            this.lbAvarage = new System.Windows.Forms.Label();
            this.tbStepMedian = new System.Windows.Forms.TextBox();
            this.tbStepAvarage = new System.Windows.Forms.TextBox();
            this.bnChangeStep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bnAppliedChange
            // 
            this.bnAppliedChange.Location = new System.Drawing.Point(228, 31);
            this.bnAppliedChange.Name = "bnAppliedChange";
            this.bnAppliedChange.Size = new System.Drawing.Size(128, 29);
            this.bnAppliedChange.TabIndex = 2;
            this.bnAppliedChange.Text = "button1";
            this.bnAppliedChange.UseVisualStyleBackColor = true;
            this.bnAppliedChange.Click += new System.EventHandler(this.bnAppliedChange_Click);
            // 
            // cbLanguage
            // 
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Location = new System.Drawing.Point(16, 39);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(121, 21);
            this.cbLanguage.TabIndex = 3;
            // 
            // lbLanguage
            // 
            this.lbLanguage.AutoSize = true;
            this.lbLanguage.Location = new System.Drawing.Point(13, 13);
            this.lbLanguage.Name = "lbLanguage";
            this.lbLanguage.Size = new System.Drawing.Size(55, 13);
            this.lbLanguage.TabIndex = 4;
            this.lbLanguage.Text = "Language";
            // 
            // lbMedian
            // 
            this.lbMedian.AutoSize = true;
            this.lbMedian.Location = new System.Drawing.Point(13, 80);
            this.lbMedian.Name = "lbMedian";
            this.lbMedian.Size = new System.Drawing.Size(55, 13);
            this.lbMedian.TabIndex = 5;
            this.lbMedian.Text = "Language";
            // 
            // lbAvarage
            // 
            this.lbAvarage.AutoSize = true;
            this.lbAvarage.Location = new System.Drawing.Point(12, 128);
            this.lbAvarage.Name = "lbAvarage";
            this.lbAvarage.Size = new System.Drawing.Size(55, 13);
            this.lbAvarage.TabIndex = 6;
            this.lbAvarage.Text = "Language";
            // 
            // tbStepMedian
            // 
            this.tbStepMedian.Location = new System.Drawing.Point(16, 97);
            this.tbStepMedian.Name = "tbStepMedian";
            this.tbStepMedian.Size = new System.Drawing.Size(121, 20);
            this.tbStepMedian.TabIndex = 7;
            // 
            // tbStepAvarage
            // 
            this.tbStepAvarage.Location = new System.Drawing.Point(16, 153);
            this.tbStepAvarage.Name = "tbStepAvarage";
            this.tbStepAvarage.Size = new System.Drawing.Size(121, 20);
            this.tbStepAvarage.TabIndex = 8;
            // 
            // bnChangeStep
            // 
            this.bnChangeStep.Location = new System.Drawing.Point(228, 92);
            this.bnChangeStep.Name = "bnChangeStep";
            this.bnChangeStep.Size = new System.Drawing.Size(128, 49);
            this.bnChangeStep.TabIndex = 9;
            this.bnChangeStep.Text = "button1";
            this.bnChangeStep.UseVisualStyleBackColor = true;
            this.bnChangeStep.Click += new System.EventHandler(this.bnChangeStep_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 195);
            this.Controls.Add(this.bnChangeStep);
            this.Controls.Add(this.tbStepAvarage);
            this.Controls.Add(this.tbStepMedian);
            this.Controls.Add(this.lbAvarage);
            this.Controls.Add(this.lbMedian);
            this.Controls.Add(this.lbLanguage);
            this.Controls.Add(this.cbLanguage);
            this.Controls.Add(this.bnAppliedChange);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnAppliedChange;
        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.Label lbLanguage;
        private System.Windows.Forms.Label lbMedian;
        private System.Windows.Forms.Label lbAvarage;
        private System.Windows.Forms.TextBox tbStepMedian;
        private System.Windows.Forms.TextBox tbStepAvarage;
        private System.Windows.Forms.Button bnChangeStep;
    }
}