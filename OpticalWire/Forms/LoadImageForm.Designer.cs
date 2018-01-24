namespace OpticalWire
{
    partial class LoadImageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadImageForm));
            this.cbZoom = new System.Windows.Forms.CheckBox();
            this.bnSelectImage = new System.Windows.Forms.Button();
            this.lbSelectedArea = new System.Windows.Forms.Label();
            this.msTopMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbLoadImage = new System.Windows.Forms.PictureBox();
            this.pbSelectedArea = new System.Windows.Forms.PictureBox();
            this.ImagePanel = new System.Windows.Forms.Panel();
            this.msTopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedArea)).BeginInit();
            this.ImagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbZoom
            // 
            this.cbZoom.AutoSize = true;
            this.cbZoom.Location = new System.Drawing.Point(541, 313);
            this.cbZoom.Name = "cbZoom";
            this.cbZoom.Size = new System.Drawing.Size(53, 17);
            this.cbZoom.TabIndex = 0;
            this.cbZoom.Text = "Zoom";
            this.cbZoom.UseVisualStyleBackColor = true;
            this.cbZoom.CheckedChanged += new System.EventHandler(this.cbZoom_CheckedChanged);
            // 
            // bnSelectImage
            // 
            this.bnSelectImage.Location = new System.Drawing.Point(541, 353);
            this.bnSelectImage.Name = "bnSelectImage";
            this.bnSelectImage.Size = new System.Drawing.Size(243, 33);
            this.bnSelectImage.TabIndex = 1;
            this.bnSelectImage.Text = "Select";
            this.bnSelectImage.UseVisualStyleBackColor = true;
            this.bnSelectImage.Click += new System.EventHandler(this.bnSelectImage_Click);
            // 
            // lbSelectedArea
            // 
            this.lbSelectedArea.AutoSize = true;
            this.lbSelectedArea.Location = new System.Drawing.Point(538, 27);
            this.lbSelectedArea.Name = "lbSelectedArea";
            this.lbSelectedArea.Size = new System.Drawing.Size(67, 13);
            this.lbSelectedArea.TabIndex = 3;
            this.lbSelectedArea.Text = "Seleted area";
            // 
            // msTopMenu
            // 
            this.msTopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.msTopMenu.Location = new System.Drawing.Point(0, 0);
            this.msTopMenu.Name = "msTopMenu";
            this.msTopMenu.Size = new System.Drawing.Size(798, 24);
            this.msTopMenu.TabIndex = 5;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.openFileToolStripMenuItem.Text = "Open file";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // pbLoadImage
            // 
            this.pbLoadImage.Location = new System.Drawing.Point(3, 3);
            this.pbLoadImage.Name = "pbLoadImage";
            this.pbLoadImage.Size = new System.Drawing.Size(517, 456);
            this.pbLoadImage.TabIndex = 6;
            this.pbLoadImage.TabStop = false;
            this.pbLoadImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbLoadImage_MouseDown);
            this.pbLoadImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbLoadImage_MouseMove);
            this.pbLoadImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbLoadImage_MouseUp);
            // 
            // pbSelectedArea
            // 
            this.pbSelectedArea.Location = new System.Drawing.Point(541, 54);
            this.pbSelectedArea.Name = "pbSelectedArea";
            this.pbSelectedArea.Size = new System.Drawing.Size(243, 239);
            this.pbSelectedArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSelectedArea.TabIndex = 8;
            this.pbSelectedArea.TabStop = false;
            // 
            // ImagePanel
            // 
            this.ImagePanel.Controls.Add(this.pbLoadImage);
            this.ImagePanel.Location = new System.Drawing.Point(9, 27);
            this.ImagePanel.Name = "ImagePanel";
            this.ImagePanel.Size = new System.Drawing.Size(523, 462);
            this.ImagePanel.TabIndex = 9;
            // 
            // LoadImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 501);
            this.Controls.Add(this.ImagePanel);
            this.Controls.Add(this.pbSelectedArea);
            this.Controls.Add(this.lbSelectedArea);
            this.Controls.Add(this.bnSelectImage);
            this.Controls.Add(this.cbZoom);
            this.Controls.Add(this.msTopMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msTopMenu;
            this.Name = "LoadImageForm";
            this.Text = "Form1";
            this.msTopMenu.ResumeLayout(false);
            this.msTopMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedArea)).EndInit();
            this.ImagePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbZoom;
        private System.Windows.Forms.Button bnSelectImage;
        private System.Windows.Forms.Label lbSelectedArea;
        private System.Windows.Forms.MenuStrip msTopMenu;
        private System.Windows.Forms.PictureBox pbLoadImage;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbSelectedArea;
        private System.Windows.Forms.Panel ImagePanel;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

