namespace OpticalWire.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gbIntensityAngle = new System.Windows.Forms.GroupBox();
            this.bnShowGraphic = new System.Windows.Forms.Button();
            this.bnHideGraphic = new System.Windows.Forms.Button();
            this.lbSelectGraphic = new System.Windows.Forms.Label();
            this.bnRemoveAll = new System.Windows.Forms.Button();
            this.cbExistIntenistyGraphics = new System.Windows.Forms.ComboBox();
            this.bnRemoveFromgraphic = new System.Windows.Forms.Button();
            this.bnAddIntensityOngraphic = new System.Windows.Forms.Button();
            this.bnClear = new System.Windows.Forms.Button();
            this.numericFreeAngle = new System.Windows.Forms.NumericUpDown();
            this.lbFreeAngle = new System.Windows.Forms.Label();
            this.bnDrawAngle = new System.Windows.Forms.Button();
            this.chb90 = new System.Windows.Forms.CheckBox();
            this.chb45 = new System.Windows.Forms.CheckBox();
            this.chb0 = new System.Windows.Forms.CheckBox();
            this.pbShowAngle = new System.Windows.Forms.PictureBox();
            this.lbMainAngle = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Loadlmagems = new System.Windows.Forms.ToolStripButton();
            this.toolStripBnLoadImage = new System.Windows.Forms.ToolStripButton();
            this.msTopMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadImageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZGTemperature = new ZedGraph.ZedGraphControl();
            this.gbFiltrs = new System.Windows.Forms.GroupBox();
            this.bnAppliedFiltr = new System.Windows.Forms.Button();
            this.cbFiltr = new System.Windows.Forms.ComboBox();
            this.lbFiltrName = new System.Windows.Forms.Label();
            this.gbBuildDiametr = new System.Windows.Forms.GroupBox();
            this.chBShouldNormalise = new System.Windows.Forms.CheckBox();
            this.bnBuildAllDiametr = new System.Windows.Forms.Button();
            this.numericToDiametr = new System.Windows.Forms.NumericUpDown();
            this.lbDiametr = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button12 = new System.Windows.Forms.Button();
            this.bnBuildDiametr = new System.Windows.Forms.Button();
            this.numericFromDiametr = new System.Windows.Forms.NumericUpDown();
            this.lbFromDiametr = new System.Windows.Forms.Label();
            this.button15 = new System.Windows.Forms.Button();
            this.bnWriteToExcel = new System.Windows.Forms.Button();
            this.gbParametersofGraphics = new System.Windows.Forms.GroupBox();
            this.tbDiam = new System.Windows.Forms.TextBox();
            this.lbDiam = new System.Windows.Forms.Label();
            this.tbExcess = new System.Windows.Forms.TextBox();
            this.tbAssimetry = new System.Windows.Forms.TextBox();
            this.lbExc = new System.Windows.Forms.Label();
            this.lbAssim = new System.Windows.Forms.Label();
            this.cbAllExistGraphics = new System.Windows.Forms.ComboBox();
            this.button8 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.button9 = new System.Windows.Forms.Button();
            this.lbSelectGraph = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.tbCorfficientIn = new System.Windows.Forms.TextBox();
            this.lbCoefficienIn = new System.Windows.Forms.Label();
            this.tbCorfficientOut = new System.Windows.Forms.TextBox();
            this.lbCoefficienOut = new System.Windows.Forms.Label();
            this.lbMaxDiametr = new System.Windows.Forms.Label();
            this.lbAnglemaxDiametr = new System.Windows.Forms.Label();
            this.lbMaxintensityValue = new System.Windows.Forms.Label();
            this.lbAnglemaxDaimetrValue = new System.Windows.Forms.Label();
            this.lbMaxDiametrValue = new System.Windows.Forms.Label();
            this.lbMaxintensity = new System.Windows.Forms.Label();
            this.bnClearGraphic = new System.Windows.Forms.Button();
            this.gbTemperatureInfluense = new System.Windows.Forms.GroupBox();
            this.tbWidthWall = new System.Windows.Forms.TextBox();
            this.lbWidthWall = new System.Windows.Forms.Label();
            this.bnBuildAllInfluence = new System.Windows.Forms.Button();
            this.numericToInfluence = new System.Windows.Forms.NumericUpDown();
            this.lbToInfluence = new System.Windows.Forms.Label();
            this.button24 = new System.Windows.Forms.Button();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.button25 = new System.Windows.Forms.Button();
            this.bnBuildSelectinfluence = new System.Windows.Forms.Button();
            this.numericFromInfluence = new System.Windows.Forms.NumericUpDown();
            this.lbFrominfluence = new System.Windows.Forms.Label();
            this.button27 = new System.Windows.Forms.Button();
            this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZGIntensity = new ZedGraph.ZedGraphControl();
            this.ZGDiametr = new ZedGraph.ZedGraphControl();
            this.gbIntensityAngle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFreeAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowAngle)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.msTopMenu.SuspendLayout();
            this.gbFiltrs.SuspendLayout();
            this.gbBuildDiametr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericToDiametr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFromDiametr)).BeginInit();
            this.gbParametersofGraphics.SuspendLayout();
            this.gbTemperatureInfluense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericToInfluence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFromInfluence)).BeginInit();
            this.SuspendLayout();
            // 
            // gbIntensityAngle
            // 
            this.gbIntensityAngle.Controls.Add(this.bnShowGraphic);
            this.gbIntensityAngle.Controls.Add(this.bnHideGraphic);
            this.gbIntensityAngle.Controls.Add(this.lbSelectGraphic);
            this.gbIntensityAngle.Controls.Add(this.bnRemoveAll);
            this.gbIntensityAngle.Controls.Add(this.cbExistIntenistyGraphics);
            this.gbIntensityAngle.Controls.Add(this.bnRemoveFromgraphic);
            this.gbIntensityAngle.Controls.Add(this.bnAddIntensityOngraphic);
            this.gbIntensityAngle.Controls.Add(this.bnClear);
            this.gbIntensityAngle.Controls.Add(this.numericFreeAngle);
            this.gbIntensityAngle.Controls.Add(this.lbFreeAngle);
            this.gbIntensityAngle.Controls.Add(this.bnDrawAngle);
            this.gbIntensityAngle.Controls.Add(this.chb90);
            this.gbIntensityAngle.Controls.Add(this.chb45);
            this.gbIntensityAngle.Controls.Add(this.chb0);
            this.gbIntensityAngle.Controls.Add(this.pbShowAngle);
            this.gbIntensityAngle.Controls.Add(this.lbMainAngle);
            this.gbIntensityAngle.Location = new System.Drawing.Point(27, 27);
            this.gbIntensityAngle.Name = "gbIntensityAngle";
            this.gbIntensityAngle.Size = new System.Drawing.Size(476, 232);
            this.gbIntensityAngle.TabIndex = 0;
            this.gbIntensityAngle.TabStop = false;
            this.gbIntensityAngle.Text = "Intensity at angte";
            // 
            // bnShowGraphic
            // 
            this.bnShowGraphic.Location = new System.Drawing.Point(215, 198);
            this.bnShowGraphic.Name = "bnShowGraphic";
            this.bnShowGraphic.Size = new System.Drawing.Size(121, 21);
            this.bnShowGraphic.TabIndex = 21;
            this.bnShowGraphic.Text = "Show";
            this.bnShowGraphic.UseVisualStyleBackColor = true;
            this.bnShowGraphic.Click += new System.EventHandler(this.bnShowGraphic_Click);
            // 
            // bnHideGraphic
            // 
            this.bnHideGraphic.Location = new System.Drawing.Point(215, 176);
            this.bnHideGraphic.Name = "bnHideGraphic";
            this.bnHideGraphic.Size = new System.Drawing.Size(121, 21);
            this.bnHideGraphic.TabIndex = 20;
            this.bnHideGraphic.Text = "Hide";
            this.bnHideGraphic.UseVisualStyleBackColor = true;
            this.bnHideGraphic.Click += new System.EventHandler(this.bnHideGraphic_Click);
            // 
            // lbSelectGraphic
            // 
            this.lbSelectGraphic.AutoSize = true;
            this.lbSelectGraphic.Location = new System.Drawing.Point(214, 133);
            this.lbSelectGraphic.Name = "lbSelectGraphic";
            this.lbSelectGraphic.Size = new System.Drawing.Size(128, 13);
            this.lbSelectGraphic.TabIndex = 19;
            this.lbSelectGraphic.Text = "Select graohic for remove";
            // 
            // bnRemoveAll
            // 
            this.bnRemoveAll.Location = new System.Drawing.Point(346, 185);
            this.bnRemoveAll.Name = "bnRemoveAll";
            this.bnRemoveAll.Size = new System.Drawing.Size(114, 34);
            this.bnRemoveAll.TabIndex = 12;
            this.bnRemoveAll.Text = "Remove all";
            this.bnRemoveAll.UseVisualStyleBackColor = true;
            this.bnRemoveAll.Click += new System.EventHandler(this.bnRemoveAll_Click);
            // 
            // cbExistIntenistyGraphics
            // 
            this.cbExistIntenistyGraphics.FormattingEnabled = true;
            this.cbExistIntenistyGraphics.Location = new System.Drawing.Point(215, 149);
            this.cbExistIntenistyGraphics.Name = "cbExistIntenistyGraphics";
            this.cbExistIntenistyGraphics.Size = new System.Drawing.Size(121, 21);
            this.cbExistIntenistyGraphics.TabIndex = 11;
            // 
            // bnRemoveFromgraphic
            // 
            this.bnRemoveFromgraphic.Location = new System.Drawing.Point(346, 149);
            this.bnRemoveFromgraphic.Name = "bnRemoveFromgraphic";
            this.bnRemoveFromgraphic.Size = new System.Drawing.Size(114, 34);
            this.bnRemoveFromgraphic.TabIndex = 10;
            this.bnRemoveFromgraphic.Text = "Remove from graphic";
            this.bnRemoveFromgraphic.UseVisualStyleBackColor = true;
            this.bnRemoveFromgraphic.Click += new System.EventHandler(this.bnRemoveFromgraphic_Click);
            // 
            // bnAddIntensityOngraphic
            // 
            this.bnAddIntensityOngraphic.Location = new System.Drawing.Point(217, 98);
            this.bnAddIntensityOngraphic.Name = "bnAddIntensityOngraphic";
            this.bnAddIntensityOngraphic.Size = new System.Drawing.Size(241, 23);
            this.bnAddIntensityOngraphic.TabIndex = 9;
            this.bnAddIntensityOngraphic.Text = "Add intensity on graphic";
            this.bnAddIntensityOngraphic.UseVisualStyleBackColor = true;
            this.bnAddIntensityOngraphic.Click += new System.EventHandler(this.bnAddIntensityOngraphic_Click);
            // 
            // bnClear
            // 
            this.bnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bnClear.Location = new System.Drawing.Point(345, 69);
            this.bnClear.Name = "bnClear";
            this.bnClear.Size = new System.Drawing.Size(113, 23);
            this.bnClear.TabIndex = 8;
            this.bnClear.Text = "Clear";
            this.bnClear.UseVisualStyleBackColor = true;
            this.bnClear.Click += new System.EventHandler(this.bnClear_Click);
            // 
            // numericFreeAngle
            // 
            this.numericFreeAngle.Location = new System.Drawing.Point(321, 41);
            this.numericFreeAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericFreeAngle.Name = "numericFreeAngle";
            this.numericFreeAngle.Size = new System.Drawing.Size(129, 20);
            this.numericFreeAngle.TabIndex = 6;
            this.numericFreeAngle.ValueChanged += new System.EventHandler(this.numericFreeAngle_ValueChanged);
            // 
            // lbFreeAngle
            // 
            this.lbFreeAngle.AutoSize = true;
            this.lbFreeAngle.Location = new System.Drawing.Point(214, 48);
            this.lbFreeAngle.Name = "lbFreeAngle";
            this.lbFreeAngle.Size = new System.Drawing.Size(57, 13);
            this.lbFreeAngle.TabIndex = 7;
            this.lbFreeAngle.Text = "Free angle";
            // 
            // bnDrawAngle
            // 
            this.bnDrawAngle.Location = new System.Drawing.Point(217, 67);
            this.bnDrawAngle.Name = "bnDrawAngle";
            this.bnDrawAngle.Size = new System.Drawing.Size(122, 25);
            this.bnDrawAngle.TabIndex = 2;
            this.bnDrawAngle.Text = "Draw angle at image";
            this.bnDrawAngle.UseVisualStyleBackColor = true;
            this.bnDrawAngle.Click += new System.EventHandler(this.bnDrawAngle_Click);
            // 
            // chb90
            // 
            this.chb90.AutoSize = true;
            this.chb90.Location = new System.Drawing.Point(436, 18);
            this.chb90.Name = "chb90";
            this.chb90.Size = new System.Drawing.Size(38, 17);
            this.chb90.TabIndex = 6;
            this.chb90.Text = "90";
            this.chb90.UseVisualStyleBackColor = true;
            this.chb90.CheckedChanged += new System.EventHandler(this.chb90_CheckedChanged);
            // 
            // chb45
            // 
            this.chb45.AutoSize = true;
            this.chb45.Location = new System.Drawing.Point(376, 18);
            this.chb45.Name = "chb45";
            this.chb45.Size = new System.Drawing.Size(38, 17);
            this.chb45.TabIndex = 5;
            this.chb45.Text = "45";
            this.chb45.UseVisualStyleBackColor = true;
            this.chb45.CheckedChanged += new System.EventHandler(this.chb45_CheckedChanged);
            // 
            // chb0
            // 
            this.chb0.AutoSize = true;
            this.chb0.Location = new System.Drawing.Point(321, 18);
            this.chb0.Name = "chb0";
            this.chb0.Size = new System.Drawing.Size(32, 17);
            this.chb0.TabIndex = 4;
            this.chb0.Text = "0";
            this.chb0.UseVisualStyleBackColor = true;
            this.chb0.CheckedChanged += new System.EventHandler(this.chb0_CheckedChanged);
            // 
            // pbShowAngle
            // 
            this.pbShowAngle.Location = new System.Drawing.Point(6, 19);
            this.pbShowAngle.Name = "pbShowAngle";
            this.pbShowAngle.Size = new System.Drawing.Size(200, 200);
            this.pbShowAngle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbShowAngle.TabIndex = 3;
            this.pbShowAngle.TabStop = false;
            // 
            // lbMainAngle
            // 
            this.lbMainAngle.AutoSize = true;
            this.lbMainAngle.Location = new System.Drawing.Point(212, 19);
            this.lbMainAngle.Name = "lbMainAngle";
            this.lbMainAngle.Size = new System.Drawing.Size(59, 13);
            this.lbMainAngle.TabIndex = 1;
            this.lbMainAngle.Text = "Main angle";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Loadlmagems});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(24, 687);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Loadlmagems
            // 
            this.Loadlmagems.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Loadlmagems.Image = ((System.Drawing.Image)(resources.GetObject("Loadlmagems.Image")));
            this.Loadlmagems.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Loadlmagems.Name = "Loadlmagems";
            this.Loadlmagems.Size = new System.Drawing.Size(21, 20);
            this.Loadlmagems.Text = "toolStripButton1";
            this.Loadlmagems.Click += new System.EventHandler(this.Loadlmagems_Click);
            // 
            // toolStripBnLoadImage
            // 
            this.toolStripBnLoadImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBnLoadImage.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBnLoadImage.Image")));
            this.toolStripBnLoadImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBnLoadImage.Name = "toolStripBnLoadImage";
            this.toolStripBnLoadImage.Size = new System.Drawing.Size(21, 20);
            this.toolStripBnLoadImage.Text = "toolStripBnLoadImage";
            // 
            // msTopMenu
            // 
            this.msTopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.settingsToolStripMenuItem1,
            this.helpToolStripMenuItem1});
            this.msTopMenu.Location = new System.Drawing.Point(0, 0);
            this.msTopMenu.Name = "msTopMenu";
            this.msTopMenu.Size = new System.Drawing.Size(1244, 24);
            this.msTopMenu.TabIndex = 5;
            this.msTopMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadImageToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // loadImageToolStripMenuItem1
            // 
            this.loadImageToolStripMenuItem1.Name = "loadImageToolStripMenuItem1";
            this.loadImageToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.loadImageToolStripMenuItem1.Text = "Load image";
            this.loadImageToolStripMenuItem1.Click += new System.EventHandler(this.loadImageToolStripMenuItem1_Click);
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem1.Text = "Settings";
            this.settingsToolStripMenuItem1.Click += new System.EventHandler(this.settingsToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // ZGTemperature
            // 
            this.ZGTemperature.Location = new System.Drawing.Point(518, 484);
            this.ZGTemperature.Name = "ZGTemperature";
            this.ZGTemperature.ScrollGrace = 0D;
            this.ZGTemperature.ScrollMaxX = 0D;
            this.ZGTemperature.ScrollMaxY = 0D;
            this.ZGTemperature.ScrollMaxY2 = 0D;
            this.ZGTemperature.ScrollMinX = 0D;
            this.ZGTemperature.ScrollMinY = 0D;
            this.ZGTemperature.ScrollMinY2 = 0D;
            this.ZGTemperature.Size = new System.Drawing.Size(720, 221);
            this.ZGTemperature.TabIndex = 6;
            // 
            // gbFiltrs
            // 
            this.gbFiltrs.Controls.Add(this.bnAppliedFiltr);
            this.gbFiltrs.Controls.Add(this.cbFiltr);
            this.gbFiltrs.Controls.Add(this.lbFiltrName);
            this.gbFiltrs.Location = new System.Drawing.Point(27, 602);
            this.gbFiltrs.Name = "gbFiltrs";
            this.gbFiltrs.Size = new System.Drawing.Size(247, 97);
            this.gbFiltrs.TabIndex = 13;
            this.gbFiltrs.TabStop = false;
            this.gbFiltrs.Text = "Filtrs";
            // 
            // bnAppliedFiltr
            // 
            this.bnAppliedFiltr.Location = new System.Drawing.Point(72, 43);
            this.bnAppliedFiltr.Name = "bnAppliedFiltr";
            this.bnAppliedFiltr.Size = new System.Drawing.Size(156, 27);
            this.bnAppliedFiltr.TabIndex = 10;
            this.bnAppliedFiltr.Text = "Appliy";
            this.bnAppliedFiltr.UseVisualStyleBackColor = true;
            this.bnAppliedFiltr.Click += new System.EventHandler(this.bnAppliedFiltr_Click);
            // 
            // cbFiltr
            // 
            this.cbFiltr.FormattingEnabled = true;
            this.cbFiltr.Location = new System.Drawing.Point(72, 16);
            this.cbFiltr.Name = "cbFiltr";
            this.cbFiltr.Size = new System.Drawing.Size(156, 21);
            this.cbFiltr.TabIndex = 11;
            // 
            // lbFiltrName
            // 
            this.lbFiltrName.AutoSize = true;
            this.lbFiltrName.Location = new System.Drawing.Point(6, 24);
            this.lbFiltrName.Name = "lbFiltrName";
            this.lbFiltrName.Size = new System.Drawing.Size(51, 13);
            this.lbFiltrName.TabIndex = 7;
            this.lbFiltrName.Text = "Name filtr";
            // 
            // gbBuildDiametr
            // 
            this.gbBuildDiametr.Controls.Add(this.chBShouldNormalise);
            this.gbBuildDiametr.Controls.Add(this.bnBuildAllDiametr);
            this.gbBuildDiametr.Controls.Add(this.numericToDiametr);
            this.gbBuildDiametr.Controls.Add(this.lbDiametr);
            this.gbBuildDiametr.Controls.Add(this.button11);
            this.gbBuildDiametr.Controls.Add(this.comboBox3);
            this.gbBuildDiametr.Controls.Add(this.button12);
            this.gbBuildDiametr.Controls.Add(this.bnBuildDiametr);
            this.gbBuildDiametr.Controls.Add(this.numericFromDiametr);
            this.gbBuildDiametr.Controls.Add(this.lbFromDiametr);
            this.gbBuildDiametr.Controls.Add(this.button15);
            this.gbBuildDiametr.Location = new System.Drawing.Point(27, 484);
            this.gbBuildDiametr.Name = "gbBuildDiametr";
            this.gbBuildDiametr.Size = new System.Drawing.Size(247, 120);
            this.gbBuildDiametr.TabIndex = 14;
            this.gbBuildDiametr.TabStop = false;
            this.gbBuildDiametr.Text = "Build diametrs";
            // 
            // chBShouldNormalise
            // 
            this.chBShouldNormalise.AutoSize = true;
            this.chBShouldNormalise.Location = new System.Drawing.Point(11, 95);
            this.chBShouldNormalise.Name = "chBShouldNormalise";
            this.chBShouldNormalise.Size = new System.Drawing.Size(80, 17);
            this.chBShouldNormalise.TabIndex = 17;
            this.chBShouldNormalise.Text = "checkBox1";
            this.chBShouldNormalise.UseVisualStyleBackColor = true;
            // 
            // bnBuildAllDiametr
            // 
            this.bnBuildAllDiametr.Location = new System.Drawing.Point(6, 56);
            this.bnBuildAllDiametr.Name = "bnBuildAllDiametr";
            this.bnBuildAllDiametr.Size = new System.Drawing.Size(114, 23);
            this.bnBuildAllDiametr.TabIndex = 15;
            this.bnBuildAllDiametr.Text = "Build for all angle";
            this.bnBuildAllDiametr.UseVisualStyleBackColor = true;
            this.bnBuildAllDiametr.Click += new System.EventHandler(this.bnBuildAllDiametr_Click);
            // 
            // numericToDiametr
            // 
            this.numericToDiametr.Location = new System.Drawing.Point(156, 56);
            this.numericToDiametr.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericToDiametr.Name = "numericToDiametr";
            this.numericToDiametr.Size = new System.Drawing.Size(72, 20);
            this.numericToDiametr.TabIndex = 13;
            // 
            // lbDiametr
            // 
            this.lbDiametr.AutoSize = true;
            this.lbDiametr.Location = new System.Drawing.Point(130, 58);
            this.lbDiametr.Name = "lbDiametr";
            this.lbDiametr.Size = new System.Drawing.Size(20, 13);
            this.lbDiametr.TabIndex = 14;
            this.lbDiametr.Text = "To";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(392, 235);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(114, 34);
            this.button11.TabIndex = 12;
            this.button11.Text = "Remove all";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(264, 198);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 11;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(393, 198);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(114, 34);
            this.button12.TabIndex = 10;
            this.button12.Text = "Remove from graphic";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // bnBuildDiametr
            // 
            this.bnBuildDiametr.Location = new System.Drawing.Point(6, 19);
            this.bnBuildDiametr.Name = "bnBuildDiametr";
            this.bnBuildDiametr.Size = new System.Drawing.Size(114, 23);
            this.bnBuildDiametr.TabIndex = 8;
            this.bnBuildDiametr.Text = "Build";
            this.bnBuildDiametr.UseVisualStyleBackColor = true;
            this.bnBuildDiametr.Click += new System.EventHandler(this.bnBuildDiametr_Click);
            // 
            // numericFromDiametr
            // 
            this.numericFromDiametr.Location = new System.Drawing.Point(156, 24);
            this.numericFromDiametr.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericFromDiametr.Name = "numericFromDiametr";
            this.numericFromDiametr.Size = new System.Drawing.Size(72, 20);
            this.numericFromDiametr.TabIndex = 6;
            // 
            // lbFromDiametr
            // 
            this.lbFromDiametr.AutoSize = true;
            this.lbFromDiametr.Location = new System.Drawing.Point(126, 26);
            this.lbFromDiametr.Name = "lbFromDiametr";
            this.lbFromDiametr.Size = new System.Drawing.Size(30, 13);
            this.lbFromDiametr.TabIndex = 7;
            this.lbFromDiametr.Text = "From";
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(88, 194);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(122, 25);
            this.button15.TabIndex = 2;
            this.button15.Text = "Draw angle at image";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // bnWriteToExcel
            // 
            this.bnWriteToExcel.Location = new System.Drawing.Point(280, 678);
            this.bnWriteToExcel.Name = "bnWriteToExcel";
            this.bnWriteToExcel.Size = new System.Drawing.Size(223, 21);
            this.bnWriteToExcel.TabIndex = 17;
            this.bnWriteToExcel.Text = "Write current graphic to Excel";
            this.bnWriteToExcel.UseVisualStyleBackColor = true;
            this.bnWriteToExcel.Click += new System.EventHandler(this.bnWriteToExcel_Click);
            // 
            // gbParametersofGraphics
            // 
            this.gbParametersofGraphics.Controls.Add(this.tbDiam);
            this.gbParametersofGraphics.Controls.Add(this.lbDiam);
            this.gbParametersofGraphics.Controls.Add(this.tbExcess);
            this.gbParametersofGraphics.Controls.Add(this.tbAssimetry);
            this.gbParametersofGraphics.Controls.Add(this.lbExc);
            this.gbParametersofGraphics.Controls.Add(this.lbAssim);
            this.gbParametersofGraphics.Controls.Add(this.cbAllExistGraphics);
            this.gbParametersofGraphics.Controls.Add(this.button8);
            this.gbParametersofGraphics.Controls.Add(this.comboBox4);
            this.gbParametersofGraphics.Controls.Add(this.button9);
            this.gbParametersofGraphics.Controls.Add(this.lbSelectGraph);
            this.gbParametersofGraphics.Controls.Add(this.button16);
            this.gbParametersofGraphics.Location = new System.Drawing.Point(29, 385);
            this.gbParametersofGraphics.Name = "gbParametersofGraphics";
            this.gbParametersofGraphics.Size = new System.Drawing.Size(474, 99);
            this.gbParametersofGraphics.TabIndex = 19;
            this.gbParametersofGraphics.TabStop = false;
            this.gbParametersofGraphics.Text = "Parameters of graphic";
            // 
            // tbDiam
            // 
            this.tbDiam.Location = new System.Drawing.Point(311, 74);
            this.tbDiam.Name = "tbDiam";
            this.tbDiam.Size = new System.Drawing.Size(141, 20);
            this.tbDiam.TabIndex = 18;
            // 
            // lbDiam
            // 
            this.lbDiam.AutoSize = true;
            this.lbDiam.Location = new System.Drawing.Point(247, 76);
            this.lbDiam.Name = "lbDiam";
            this.lbDiam.Size = new System.Drawing.Size(43, 13);
            this.lbDiam.TabIndex = 17;
            this.lbDiam.Text = "Diametr";
            // 
            // tbExcess
            // 
            this.tbExcess.Location = new System.Drawing.Point(311, 48);
            this.tbExcess.Name = "tbExcess";
            this.tbExcess.Size = new System.Drawing.Size(141, 20);
            this.tbExcess.TabIndex = 16;
            // 
            // tbAssimetry
            // 
            this.tbAssimetry.Location = new System.Drawing.Point(311, 22);
            this.tbAssimetry.Name = "tbAssimetry";
            this.tbAssimetry.Size = new System.Drawing.Size(141, 20);
            this.tbAssimetry.TabIndex = 15;
            // 
            // lbExc
            // 
            this.lbExc.AutoSize = true;
            this.lbExc.Location = new System.Drawing.Point(247, 52);
            this.lbExc.Name = "lbExc";
            this.lbExc.Size = new System.Drawing.Size(41, 13);
            this.lbExc.TabIndex = 14;
            this.lbExc.Text = "Excess";
            // 
            // lbAssim
            // 
            this.lbAssim.AutoSize = true;
            this.lbAssim.Location = new System.Drawing.Point(247, 25);
            this.lbAssim.Name = "lbAssim";
            this.lbAssim.Size = new System.Drawing.Size(57, 13);
            this.lbAssim.TabIndex = 13;
            this.lbAssim.Text = "Asymmetry";
            // 
            // cbAllExistGraphics
            // 
            this.cbAllExistGraphics.FormattingEnabled = true;
            this.cbAllExistGraphics.Location = new System.Drawing.Point(97, 22);
            this.cbAllExistGraphics.Name = "cbAllExistGraphics";
            this.cbAllExistGraphics.Size = new System.Drawing.Size(135, 21);
            this.cbAllExistGraphics.TabIndex = 12;
            this.cbAllExistGraphics.SelectedIndexChanged += new System.EventHandler(this.cbAllExistGraphics_SelectedIndexChanged);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(392, 235);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(114, 34);
            this.button8.TabIndex = 12;
            this.button8.Text = "Remove all";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(264, 198);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 11;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(393, 198);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(114, 34);
            this.button9.TabIndex = 10;
            this.button9.Text = "Remove from graphic";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // lbSelectGraph
            // 
            this.lbSelectGraph.AutoSize = true;
            this.lbSelectGraph.Location = new System.Drawing.Point(6, 25);
            this.lbSelectGraph.Name = "lbSelectGraph";
            this.lbSelectGraph.Size = new System.Drawing.Size(80, 13);
            this.lbSelectGraph.TabIndex = 7;
            this.lbSelectGraph.Text = "Select graphics";
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(88, 194);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(122, 25);
            this.button16.TabIndex = 2;
            this.button16.Text = "Draw angle at image";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // tbCorfficientIn
            // 
            this.tbCorfficientIn.Location = new System.Drawing.Point(80, 105);
            this.tbCorfficientIn.Name = "tbCorfficientIn";
            this.tbCorfficientIn.Size = new System.Drawing.Size(135, 20);
            this.tbCorfficientIn.TabIndex = 22;
            // 
            // lbCoefficienIn
            // 
            this.lbCoefficienIn.AutoSize = true;
            this.lbCoefficienIn.Location = new System.Drawing.Point(10, 108);
            this.lbCoefficienIn.Name = "lbCoefficienIn";
            this.lbCoefficienIn.Size = new System.Drawing.Size(19, 13);
            this.lbCoefficienIn.TabIndex = 21;
            this.lbCoefficienIn.Text = "n2";
            // 
            // tbCorfficientOut
            // 
            this.tbCorfficientOut.Location = new System.Drawing.Point(80, 80);
            this.tbCorfficientOut.Name = "tbCorfficientOut";
            this.tbCorfficientOut.Size = new System.Drawing.Size(135, 20);
            this.tbCorfficientOut.TabIndex = 20;
            // 
            // lbCoefficienOut
            // 
            this.lbCoefficienOut.AutoSize = true;
            this.lbCoefficienOut.Location = new System.Drawing.Point(10, 83);
            this.lbCoefficienOut.Name = "lbCoefficienOut";
            this.lbCoefficienOut.Size = new System.Drawing.Size(19, 13);
            this.lbCoefficienOut.TabIndex = 19;
            this.lbCoefficienOut.Text = "n1";
            // 
            // lbMaxDiametr
            // 
            this.lbMaxDiametr.AutoSize = true;
            this.lbMaxDiametr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMaxDiametr.ForeColor = System.Drawing.Color.DarkRed;
            this.lbMaxDiametr.Location = new System.Drawing.Point(23, 292);
            this.lbMaxDiametr.Name = "lbMaxDiametr";
            this.lbMaxDiametr.Size = new System.Drawing.Size(111, 20);
            this.lbMaxDiametr.TabIndex = 17;
            this.lbMaxDiametr.Text = "Max diametr ";
            // 
            // lbAnglemaxDiametr
            // 
            this.lbAnglemaxDiametr.AutoSize = true;
            this.lbAnglemaxDiametr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAnglemaxDiametr.ForeColor = System.Drawing.Color.DarkRed;
            this.lbAnglemaxDiametr.Location = new System.Drawing.Point(23, 321);
            this.lbAnglemaxDiametr.Name = "lbAnglemaxDiametr";
            this.lbAnglemaxDiametr.Size = new System.Drawing.Size(162, 20);
            this.lbAnglemaxDiametr.TabIndex = 20;
            this.lbAnglemaxDiametr.Text = "Angle with diametr ";
            // 
            // lbMaxintensityValue
            // 
            this.lbMaxintensityValue.AutoSize = true;
            this.lbMaxintensityValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMaxintensityValue.ForeColor = System.Drawing.Color.DarkRed;
            this.lbMaxintensityValue.Location = new System.Drawing.Point(369, 262);
            this.lbMaxintensityValue.Name = "lbMaxintensityValue";
            this.lbMaxintensityValue.Size = new System.Drawing.Size(51, 20);
            this.lbMaxintensityValue.TabIndex = 21;
            this.lbMaxintensityValue.Text = "value";
            // 
            // lbAnglemaxDaimetrValue
            // 
            this.lbAnglemaxDaimetrValue.AutoSize = true;
            this.lbAnglemaxDaimetrValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAnglemaxDaimetrValue.ForeColor = System.Drawing.Color.DarkRed;
            this.lbAnglemaxDaimetrValue.Location = new System.Drawing.Point(369, 321);
            this.lbAnglemaxDaimetrValue.Name = "lbAnglemaxDaimetrValue";
            this.lbAnglemaxDaimetrValue.Size = new System.Drawing.Size(51, 20);
            this.lbAnglemaxDaimetrValue.TabIndex = 22;
            this.lbAnglemaxDaimetrValue.Text = "value";
            // 
            // lbMaxDiametrValue
            // 
            this.lbMaxDiametrValue.AutoSize = true;
            this.lbMaxDiametrValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMaxDiametrValue.ForeColor = System.Drawing.Color.DarkRed;
            this.lbMaxDiametrValue.Location = new System.Drawing.Point(369, 292);
            this.lbMaxDiametrValue.Name = "lbMaxDiametrValue";
            this.lbMaxDiametrValue.Size = new System.Drawing.Size(51, 20);
            this.lbMaxDiametrValue.TabIndex = 24;
            this.lbMaxDiametrValue.Text = "value";
            // 
            // lbMaxintensity
            // 
            this.lbMaxintensity.AutoSize = true;
            this.lbMaxintensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMaxintensity.ForeColor = System.Drawing.Color.DarkRed;
            this.lbMaxintensity.Location = new System.Drawing.Point(23, 262);
            this.lbMaxintensity.Name = "lbMaxintensity";
            this.lbMaxintensity.Size = new System.Drawing.Size(118, 20);
            this.lbMaxintensity.TabIndex = 23;
            this.lbMaxintensity.Text = "Max intensity ";
            // 
            // bnClearGraphic
            // 
            this.bnClearGraphic.Location = new System.Drawing.Point(279, 653);
            this.bnClearGraphic.Name = "bnClearGraphic";
            this.bnClearGraphic.Size = new System.Drawing.Size(223, 23);
            this.bnClearGraphic.TabIndex = 25;
            this.bnClearGraphic.Text = "Clear field";
            this.bnClearGraphic.UseVisualStyleBackColor = true;
            this.bnClearGraphic.Click += new System.EventHandler(this.bnClearGraphic_Click);
            // 
            // gbTemperatureInfluense
            // 
            this.gbTemperatureInfluense.Controls.Add(this.tbWidthWall);
            this.gbTemperatureInfluense.Controls.Add(this.lbWidthWall);
            this.gbTemperatureInfluense.Controls.Add(this.tbCorfficientIn);
            this.gbTemperatureInfluense.Controls.Add(this.bnBuildAllInfluence);
            this.gbTemperatureInfluense.Controls.Add(this.lbCoefficienIn);
            this.gbTemperatureInfluense.Controls.Add(this.numericToInfluence);
            this.gbTemperatureInfluense.Controls.Add(this.tbCorfficientOut);
            this.gbTemperatureInfluense.Controls.Add(this.lbToInfluence);
            this.gbTemperatureInfluense.Controls.Add(this.lbCoefficienOut);
            this.gbTemperatureInfluense.Controls.Add(this.button24);
            this.gbTemperatureInfluense.Controls.Add(this.comboBox7);
            this.gbTemperatureInfluense.Controls.Add(this.button25);
            this.gbTemperatureInfluense.Controls.Add(this.bnBuildSelectinfluence);
            this.gbTemperatureInfluense.Controls.Add(this.numericFromInfluence);
            this.gbTemperatureInfluense.Controls.Add(this.lbFrominfluence);
            this.gbTemperatureInfluense.Controls.Add(this.button27);
            this.gbTemperatureInfluense.Location = new System.Drawing.Point(280, 484);
            this.gbTemperatureInfluense.Name = "gbTemperatureInfluense";
            this.gbTemperatureInfluense.Size = new System.Drawing.Size(223, 163);
            this.gbTemperatureInfluense.TabIndex = 16;
            this.gbTemperatureInfluense.TabStop = false;
            this.gbTemperatureInfluense.Text = "Influence by temperature";
            // 
            // tbWidthWall
            // 
            this.tbWidthWall.Location = new System.Drawing.Point(80, 135);
            this.tbWidthWall.Name = "tbWidthWall";
            this.tbWidthWall.Size = new System.Drawing.Size(135, 20);
            this.tbWidthWall.TabIndex = 24;
            // 
            // lbWidthWall
            // 
            this.lbWidthWall.AutoSize = true;
            this.lbWidthWall.Location = new System.Drawing.Point(10, 138);
            this.lbWidthWall.Name = "lbWidthWall";
            this.lbWidthWall.Size = new System.Drawing.Size(19, 13);
            this.lbWidthWall.TabIndex = 23;
            this.lbWidthWall.Text = "n2";
            // 
            // bnBuildAllInfluence
            // 
            this.bnBuildAllInfluence.Location = new System.Drawing.Point(6, 53);
            this.bnBuildAllInfluence.Name = "bnBuildAllInfluence";
            this.bnBuildAllInfluence.Size = new System.Drawing.Size(114, 23);
            this.bnBuildAllInfluence.TabIndex = 15;
            this.bnBuildAllInfluence.Text = "Build for all angle";
            this.bnBuildAllInfluence.UseVisualStyleBackColor = true;
            this.bnBuildAllInfluence.Click += new System.EventHandler(this.bnBuildAllInfluence_Click);
            // 
            // numericToInfluence
            // 
            this.numericToInfluence.Location = new System.Drawing.Point(156, 56);
            this.numericToInfluence.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericToInfluence.Name = "numericToInfluence";
            this.numericToInfluence.Size = new System.Drawing.Size(54, 20);
            this.numericToInfluence.TabIndex = 13;
            // 
            // lbToInfluence
            // 
            this.lbToInfluence.AutoSize = true;
            this.lbToInfluence.Location = new System.Drawing.Point(130, 58);
            this.lbToInfluence.Name = "lbToInfluence";
            this.lbToInfluence.Size = new System.Drawing.Size(20, 13);
            this.lbToInfluence.TabIndex = 14;
            this.lbToInfluence.Text = "To";
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(392, 235);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(114, 34);
            this.button24.TabIndex = 12;
            this.button24.Text = "Remove all";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(264, 198);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(121, 21);
            this.comboBox7.TabIndex = 11;
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(393, 198);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(114, 34);
            this.button25.TabIndex = 10;
            this.button25.Text = "Remove from graphic";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // bnBuildSelectinfluence
            // 
            this.bnBuildSelectinfluence.Location = new System.Drawing.Point(6, 19);
            this.bnBuildSelectinfluence.Name = "bnBuildSelectinfluence";
            this.bnBuildSelectinfluence.Size = new System.Drawing.Size(114, 23);
            this.bnBuildSelectinfluence.TabIndex = 8;
            this.bnBuildSelectinfluence.Text = "Build";
            this.bnBuildSelectinfluence.UseVisualStyleBackColor = true;
            this.bnBuildSelectinfluence.Click += new System.EventHandler(this.bnBuildSelectinfluence_Click);
            // 
            // numericFromInfluence
            // 
            this.numericFromInfluence.Location = new System.Drawing.Point(156, 24);
            this.numericFromInfluence.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericFromInfluence.Name = "numericFromInfluence";
            this.numericFromInfluence.Size = new System.Drawing.Size(54, 20);
            this.numericFromInfluence.TabIndex = 6;
            // 
            // lbFrominfluence
            // 
            this.lbFrominfluence.AutoSize = true;
            this.lbFrominfluence.Location = new System.Drawing.Point(126, 26);
            this.lbFrominfluence.Name = "lbFrominfluence";
            this.lbFrominfluence.Size = new System.Drawing.Size(30, 13);
            this.lbFrominfluence.TabIndex = 7;
            this.lbFrominfluence.Text = "From";
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(88, 194);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(122, 25);
            this.button27.TabIndex = 2;
            this.button27.Text = "Draw angle at image";
            this.button27.UseVisualStyleBackColor = true;
            // 
            // loadImageToolStripMenuItem
            // 
            this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadImageToolStripMenuItem.Text = "Load image";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // ZGIntensity
            // 
            this.ZGIntensity.Location = new System.Drawing.Point(518, 27);
            this.ZGIntensity.Name = "ZGIntensity";
            this.ZGIntensity.ScrollGrace = 0D;
            this.ZGIntensity.ScrollMaxX = 0D;
            this.ZGIntensity.ScrollMaxY = 0D;
            this.ZGIntensity.ScrollMaxY2 = 0D;
            this.ZGIntensity.ScrollMinX = 0D;
            this.ZGIntensity.ScrollMinY = 0D;
            this.ZGIntensity.ScrollMinY2 = 0D;
            this.ZGIntensity.Size = new System.Drawing.Size(720, 230);
            this.ZGIntensity.TabIndex = 26;
            // 
            // ZGDiametr
            // 
            this.ZGDiametr.Location = new System.Drawing.Point(518, 255);
            this.ZGDiametr.Name = "ZGDiametr";
            this.ZGDiametr.ScrollGrace = 0D;
            this.ZGDiametr.ScrollMaxX = 0D;
            this.ZGDiametr.ScrollMaxY = 0D;
            this.ZGDiametr.ScrollMaxY2 = 0D;
            this.ZGDiametr.ScrollMinX = 0D;
            this.ZGDiametr.ScrollMinY = 0D;
            this.ZGDiametr.ScrollMinY2 = 0D;
            this.ZGDiametr.Size = new System.Drawing.Size(720, 230);
            this.ZGDiametr.TabIndex = 27;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 711);
            this.Controls.Add(this.ZGDiametr);
            this.Controls.Add(this.ZGIntensity);
            this.Controls.Add(this.gbTemperatureInfluense);
            this.Controls.Add(this.bnClearGraphic);
            this.Controls.Add(this.lbMaxDiametrValue);
            this.Controls.Add(this.lbMaxintensity);
            this.Controls.Add(this.lbAnglemaxDaimetrValue);
            this.Controls.Add(this.lbMaxintensityValue);
            this.Controls.Add(this.lbAnglemaxDiametr);
            this.Controls.Add(this.lbMaxDiametr);
            this.Controls.Add(this.gbParametersofGraphics);
            this.Controls.Add(this.bnWriteToExcel);
            this.Controls.Add(this.gbBuildDiametr);
            this.Controls.Add(this.gbFiltrs);
            this.Controls.Add(this.ZGTemperature);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.msTopMenu);
            this.Controls.Add(this.gbIntensityAngle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msTopMenu;
            this.MaximumSize = new System.Drawing.Size(1260, 750);
            this.MinimumSize = new System.Drawing.Size(1260, 726);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.gbIntensityAngle.ResumeLayout(false);
            this.gbIntensityAngle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFreeAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowAngle)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.msTopMenu.ResumeLayout(false);
            this.msTopMenu.PerformLayout();
            this.gbFiltrs.ResumeLayout(false);
            this.gbFiltrs.PerformLayout();
            this.gbBuildDiametr.ResumeLayout(false);
            this.gbBuildDiametr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericToDiametr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFromDiametr)).EndInit();
            this.gbParametersofGraphics.ResumeLayout(false);
            this.gbParametersofGraphics.PerformLayout();
            this.gbTemperatureInfluense.ResumeLayout(false);
            this.gbTemperatureInfluense.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericToInfluence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFromInfluence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbIntensityAngle;
        private System.Windows.Forms.Button bnRemoveAll;
        private System.Windows.Forms.ComboBox cbExistIntenistyGraphics;
        private System.Windows.Forms.Button bnRemoveFromgraphic;
        private System.Windows.Forms.Button bnAddIntensityOngraphic;
        private System.Windows.Forms.Button bnClear;
        private System.Windows.Forms.NumericUpDown numericFreeAngle;
        private System.Windows.Forms.Label lbFreeAngle;
        private System.Windows.Forms.Button bnDrawAngle;
        private System.Windows.Forms.CheckBox chb90;
        private System.Windows.Forms.CheckBox chb45;
        private System.Windows.Forms.CheckBox chb0;
        private System.Windows.Forms.PictureBox pbShowAngle;
        private System.Windows.Forms.Label lbMainAngle;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBnLoadImage;
        private System.Windows.Forms.MenuStrip msTopMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private ZedGraph.ZedGraphControl ZGTemperature;
        private System.Windows.Forms.GroupBox gbFiltrs;
        private System.Windows.Forms.ComboBox cbFiltr;
        private System.Windows.Forms.Button bnAppliedFiltr;
        private System.Windows.Forms.Label lbFiltrName;
        private System.Windows.Forms.GroupBox gbBuildDiametr;
        private System.Windows.Forms.Button bnBuildAllDiametr;
        private System.Windows.Forms.NumericUpDown numericToDiametr;
        private System.Windows.Forms.Label lbDiametr;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button bnBuildDiametr;
        private System.Windows.Forms.NumericUpDown numericFromDiametr;
        private System.Windows.Forms.Label lbFromDiametr;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button bnWriteToExcel;
        private System.Windows.Forms.GroupBox gbParametersofGraphics;
        private System.Windows.Forms.TextBox tbExcess;
        private System.Windows.Forms.TextBox tbAssimetry;
        private System.Windows.Forms.Label lbExc;
        private System.Windows.Forms.Label lbAssim;
        private System.Windows.Forms.ComboBox cbAllExistGraphics;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label lbSelectGraph;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.TextBox tbDiam;
        private System.Windows.Forms.Label lbDiam;
        private System.Windows.Forms.Label lbMaxDiametr;
        private System.Windows.Forms.Label lbAnglemaxDiametr;
        private System.Windows.Forms.Label lbMaxintensityValue;
        private System.Windows.Forms.Label lbAnglemaxDaimetrValue;
        private System.Windows.Forms.Label lbMaxDiametrValue;
        private System.Windows.Forms.Label lbMaxintensity;
        private System.Windows.Forms.Label lbSelectGraphic;
        private System.Windows.Forms.Button bnClearGraphic;
        private System.Windows.Forms.GroupBox gbTemperatureInfluense;
        private System.Windows.Forms.Button bnBuildAllInfluence;
        private System.Windows.Forms.NumericUpDown numericToInfluence;
        private System.Windows.Forms.Label lbToInfluence;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button bnBuildSelectinfluence;
        private System.Windows.Forms.NumericUpDown numericFromInfluence;
        private System.Windows.Forms.Label lbFrominfluence;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button bnHideGraphic;
        private System.Windows.Forms.Button bnShowGraphic;
        private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton Loadlmagems;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private ZedGraph.ZedGraphControl ZGIntensity;
        private System.Windows.Forms.TextBox tbCorfficientIn;
        private System.Windows.Forms.Label lbCoefficienIn;
        private System.Windows.Forms.TextBox tbCorfficientOut;
        private System.Windows.Forms.Label lbCoefficienOut;
        private ZedGraph.ZedGraphControl ZGDiametr;
        private System.Windows.Forms.CheckBox chBShouldNormalise;
        private System.Windows.Forms.TextBox tbWidthWall;
        private System.Windows.Forms.Label lbWidthWall;
    }
}