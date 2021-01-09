namespace Từ_điển
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cboWord = new System.Windows.Forms.ComboBox();
            this.rtxtExplan = new System.Windows.Forms.RichTextBox();
            this.cboHistory = new System.Windows.Forms.ComboBox();
            this.lblLoading = new System.Windows.Forms.Label();
            this.cboTu = new System.Windows.Forms.ComboBox();
            this.cboFavorite = new System.Windows.Forms.ComboBox();
            this.Pnl1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.cboLanguage = new Guna.UI.WinForms.GunaComboBox();
            this.btnHDSD = new Guna.UI.WinForms.GunaGradientButton();
            this.btnHistory = new Guna.UI.WinForms.GunaGradientButton();
            this.btnFavorite = new Guna.UI.WinForms.GunaGradientButton();
            this.btnTranslator = new Guna.UI.WinForms.GunaGradientButton();
            this.btnPop = new Guna.UI.WinForms.GunaGradientButton();
            this.Pnl2 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.toolStripSetting = new System.Windows.Forms.ToolStrip();
            this.tstrCboLanguage = new System.Windows.Forms.ToolStripComboBox();
            this.tstrCboSize = new System.Windows.Forms.ToolStripComboBox();
            this.tstrCboFont = new System.Windows.Forms.ToolStripComboBox();
            this.tstrCboOnline = new System.Windows.Forms.ToolStripComboBox();
            this.btnSearchOnline = new System.Windows.Forms.Button();
            this.btnLike = new System.Windows.Forms.Button();
            this.picLoading = new System.Windows.Forms.PictureBox();
            this.btnSpeak = new System.Windows.Forms.Button();
            this.btnSearchImage = new System.Windows.Forms.Button();
            this.Pnl1.SuspendLayout();
            this.Pnl2.SuspendLayout();
            this.toolStripSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // cboWord
            // 
            this.cboWord.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboWord.BackColor = System.Drawing.Color.LavenderBlush;
            this.cboWord.DropDownHeight = 100;
            this.cboWord.DropDownWidth = 300;
            this.cboWord.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboWord.IntegralHeight = false;
            this.cboWord.Location = new System.Drawing.Point(40, 52);
            this.cboWord.Name = "cboWord";
            this.cboWord.Size = new System.Drawing.Size(533, 33);
            this.cboWord.Sorted = true;
            this.cboWord.TabIndex = 2;
            this.cboWord.SelectedIndexChanged += new System.EventHandler(this.Search);
            // 
            // rtxtExplan
            // 
            this.rtxtExplan.BackColor = System.Drawing.Color.White;
            this.rtxtExplan.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rtxtExplan.Location = new System.Drawing.Point(40, 104);
            this.rtxtExplan.Name = "rtxtExplan";
            this.rtxtExplan.ReadOnly = true;
            this.rtxtExplan.Size = new System.Drawing.Size(656, 460);
            this.rtxtExplan.TabIndex = 6;
            this.rtxtExplan.Text = "";
            // 
            // cboHistory
            // 
            this.cboHistory.BackColor = System.Drawing.Color.LavenderBlush;
            this.cboHistory.DropDownHeight = 210;
            this.cboHistory.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboHistory.FormattingEnabled = true;
            this.cboHistory.IntegralHeight = false;
            this.cboHistory.Location = new System.Drawing.Point(33, 18);
            this.cboHistory.Name = "cboHistory";
            this.cboHistory.Size = new System.Drawing.Size(190, 33);
            this.cboHistory.TabIndex = 7;
            this.cboHistory.SelectedIndexChanged += new System.EventHandler(this.cmbHistory_SelectedIndexChanged);
            // 
            // lblLoading
            // 
            this.lblLoading.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblLoading.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLoading.Location = new System.Drawing.Point(80, 57);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(472, 25);
            this.lblLoading.TabIndex = 13;
            this.lblLoading.Text = "Loading data. Please wait!";
            // 
            // cboTu
            // 
            this.cboTu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboTu.BackColor = System.Drawing.Color.LavenderBlush;
            this.cboTu.DropDownHeight = 100;
            this.cboTu.DropDownWidth = 300;
            this.cboTu.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTu.FormattingEnabled = true;
            this.cboTu.IntegralHeight = false;
            this.cboTu.Location = new System.Drawing.Point(40, 52);
            this.cboTu.Name = "cboTu";
            this.cboTu.Size = new System.Drawing.Size(533, 33);
            this.cboTu.Sorted = true;
            this.cboTu.TabIndex = 17;
            this.cboTu.SelectedIndexChanged += new System.EventHandler(this.Search);
            // 
            // cboFavorite
            // 
            this.cboFavorite.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboFavorite.BackColor = System.Drawing.Color.LavenderBlush;
            this.cboFavorite.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboFavorite.FormattingEnabled = true;
            this.cboFavorite.IntegralHeight = false;
            this.cboFavorite.Location = new System.Drawing.Point(33, 18);
            this.cboFavorite.Name = "cboFavorite";
            this.cboFavorite.Size = new System.Drawing.Size(190, 33);
            this.cboFavorite.TabIndex = 23;
            this.cboFavorite.SelectedIndexChanged += new System.EventHandler(this.cmbLike_SelectedIndexChanged);
            // 
            // Pnl1
            // 
            this.Pnl1.BorderColor = System.Drawing.Color.Black;
            this.Pnl1.BorderThickness = 2;
            this.Pnl1.Controls.Add(this.cboLanguage);
            this.Pnl1.Controls.Add(this.btnHDSD);
            this.Pnl1.Controls.Add(this.btnHistory);
            this.Pnl1.Controls.Add(this.btnFavorite);
            this.Pnl1.Controls.Add(this.btnTranslator);
            this.Pnl1.Controls.Add(this.btnPop);
            this.Pnl1.Controls.Add(this.cboHistory);
            this.Pnl1.Controls.Add(this.cboFavorite);
            this.Pnl1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Pnl1.FillColor3 = System.Drawing.Color.Blue;
            this.Pnl1.Location = new System.Drawing.Point(0, 0);
            this.Pnl1.Name = "Pnl1";
            this.Pnl1.ShadowDecoration.Parent = this.Pnl1;
            this.Pnl1.Size = new System.Drawing.Size(258, 579);
            this.Pnl1.TabIndex = 32;
            // 
            // cboLanguage
            // 
            this.cboLanguage.BackColor = System.Drawing.Color.Transparent;
            this.cboLanguage.BaseColor = System.Drawing.Color.White;
            this.cboLanguage.BorderColor = System.Drawing.Color.Silver;
            this.cboLanguage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLanguage.FocusedColor = System.Drawing.Color.Empty;
            this.cboLanguage.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Italic);
            this.cboLanguage.ForeColor = System.Drawing.Color.Black;
            this.cboLanguage.FormattingEnabled = true;
            this.cboLanguage.Items.AddRange(new object[] {
            "Eng - Vie",
            "Vie - Eng "});
            this.cboLanguage.Location = new System.Drawing.Point(33, 17);
            this.cboLanguage.Name = "cboLanguage";
            this.cboLanguage.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cboLanguage.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboLanguage.Size = new System.Drawing.Size(190, 33);
            this.cboLanguage.TabIndex = 33;
            this.cboLanguage.SelectedIndexChanged += new System.EventHandler(this.cmbLanguage_SelectedIndexChanged);
            // 
            // btnHDSD
            // 
            this.btnHDSD.Animated = true;
            this.btnHDSD.AnimationHoverSpeed = 0.07F;
            this.btnHDSD.AnimationSpeed = 0.03F;
            this.btnHDSD.BackColor = System.Drawing.Color.Transparent;
            this.btnHDSD.BaseColor1 = System.Drawing.Color.DodgerBlue;
            this.btnHDSD.BaseColor2 = System.Drawing.Color.CornflowerBlue;
            this.btnHDSD.BorderColor = System.Drawing.Color.Black;
            this.btnHDSD.BorderSize = 2;
            this.btnHDSD.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHDSD.FocusedColor = System.Drawing.Color.Empty;
            this.btnHDSD.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.btnHDSD.ForeColor = System.Drawing.Color.White;
            this.btnHDSD.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnHDSD.Image = ((System.Drawing.Image)(resources.GetObject("btnHDSD.Image")));
            this.btnHDSD.ImageSize = new System.Drawing.Size(20, 20);
            this.btnHDSD.Location = new System.Drawing.Point(12, 514);
            this.btnHDSD.Name = "btnHDSD";
            this.btnHDSD.OnHoverBaseColor1 = System.Drawing.Color.Fuchsia;
            this.btnHDSD.OnHoverBaseColor2 = System.Drawing.Color.White;
            this.btnHDSD.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHDSD.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHDSD.OnHoverImage = null;
            this.btnHDSD.OnPressedColor = System.Drawing.Color.Black;
            this.btnHDSD.Radius = 15;
            this.btnHDSD.Size = new System.Drawing.Size(224, 50);
            this.btnHDSD.TabIndex = 43;
            this.btnHDSD.Text = "How to use?";
            this.btnHDSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnHDSD.UseTransfarantBackground = true;
            this.btnHDSD.Click += new System.EventHandler(this.btnHDSD_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Animated = true;
            this.btnHistory.AnimationHoverSpeed = 0.07F;
            this.btnHistory.AnimationSpeed = 0.03F;
            this.btnHistory.BackColor = System.Drawing.Color.Transparent;
            this.btnHistory.BaseColor1 = System.Drawing.Color.DodgerBlue;
            this.btnHistory.BaseColor2 = System.Drawing.Color.CornflowerBlue;
            this.btnHistory.BorderColor = System.Drawing.Color.Black;
            this.btnHistory.BorderSize = 2;
            this.btnHistory.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHistory.FocusedColor = System.Drawing.Color.Empty;
            this.btnHistory.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.btnHistory.ForeColor = System.Drawing.Color.White;
            this.btnHistory.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnHistory.Image")));
            this.btnHistory.ImageSize = new System.Drawing.Size(20, 20);
            this.btnHistory.Location = new System.Drawing.Point(15, 188);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.OnHoverBaseColor1 = System.Drawing.Color.Fuchsia;
            this.btnHistory.OnHoverBaseColor2 = System.Drawing.Color.White;
            this.btnHistory.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHistory.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHistory.OnHoverImage = null;
            this.btnHistory.OnPressedColor = System.Drawing.Color.Black;
            this.btnHistory.Radius = 15;
            this.btnHistory.Size = new System.Drawing.Size(224, 50);
            this.btnHistory.TabIndex = 37;
            this.btnHistory.Text = "History";
            this.btnHistory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnHistory.UseTransfarantBackground = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnFavorite
            // 
            this.btnFavorite.Animated = true;
            this.btnFavorite.AnimationHoverSpeed = 0.07F;
            this.btnFavorite.AnimationSpeed = 0.03F;
            this.btnFavorite.BackColor = System.Drawing.Color.Transparent;
            this.btnFavorite.BaseColor1 = System.Drawing.Color.DodgerBlue;
            this.btnFavorite.BaseColor2 = System.Drawing.Color.CornflowerBlue;
            this.btnFavorite.BorderColor = System.Drawing.Color.Black;
            this.btnFavorite.BorderSize = 2;
            this.btnFavorite.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFavorite.FocusedColor = System.Drawing.Color.Empty;
            this.btnFavorite.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.btnFavorite.ForeColor = System.Drawing.Color.White;
            this.btnFavorite.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnFavorite.Image = ((System.Drawing.Image)(resources.GetObject("btnFavorite.Image")));
            this.btnFavorite.ImageSize = new System.Drawing.Size(20, 20);
            this.btnFavorite.Location = new System.Drawing.Point(15, 80);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.OnHoverBaseColor1 = System.Drawing.Color.Fuchsia;
            this.btnFavorite.OnHoverBaseColor2 = System.Drawing.Color.White;
            this.btnFavorite.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFavorite.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFavorite.OnHoverImage = null;
            this.btnFavorite.OnPressedColor = System.Drawing.Color.Black;
            this.btnFavorite.Radius = 15;
            this.btnFavorite.Size = new System.Drawing.Size(224, 50);
            this.btnFavorite.TabIndex = 36;
            this.btnFavorite.Text = "Favorite";
            this.btnFavorite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFavorite.UseTransfarantBackground = true;
            this.btnFavorite.Click += new System.EventHandler(this.btnFavorite_Click);
            // 
            // btnTranslator
            // 
            this.btnTranslator.Animated = true;
            this.btnTranslator.AnimationHoverSpeed = 0.07F;
            this.btnTranslator.AnimationSpeed = 0.03F;
            this.btnTranslator.BackColor = System.Drawing.Color.Transparent;
            this.btnTranslator.BaseColor1 = System.Drawing.Color.DodgerBlue;
            this.btnTranslator.BaseColor2 = System.Drawing.Color.CornflowerBlue;
            this.btnTranslator.BorderColor = System.Drawing.Color.Black;
            this.btnTranslator.BorderSize = 2;
            this.btnTranslator.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTranslator.FocusedColor = System.Drawing.Color.Empty;
            this.btnTranslator.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.btnTranslator.ForeColor = System.Drawing.Color.White;
            this.btnTranslator.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnTranslator.Image = null;
            this.btnTranslator.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTranslator.Location = new System.Drawing.Point(15, 404);
            this.btnTranslator.Name = "btnTranslator";
            this.btnTranslator.OnHoverBaseColor1 = System.Drawing.Color.Fuchsia;
            this.btnTranslator.OnHoverBaseColor2 = System.Drawing.Color.White;
            this.btnTranslator.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTranslator.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTranslator.OnHoverImage = null;
            this.btnTranslator.OnPressedColor = System.Drawing.Color.Black;
            this.btnTranslator.Radius = 15;
            this.btnTranslator.Size = new System.Drawing.Size(224, 50);
            this.btnTranslator.TabIndex = 41;
            this.btnTranslator.Text = "Translator";
            this.btnTranslator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTranslator.UseTransfarantBackground = true;
            this.btnTranslator.Click += new System.EventHandler(this.btnTranslator_Click);
            // 
            // btnPop
            // 
            this.btnPop.Animated = true;
            this.btnPop.AnimationHoverSpeed = 0.07F;
            this.btnPop.AnimationSpeed = 0.03F;
            this.btnPop.BackColor = System.Drawing.Color.Transparent;
            this.btnPop.BaseColor1 = System.Drawing.Color.DodgerBlue;
            this.btnPop.BaseColor2 = System.Drawing.Color.CornflowerBlue;
            this.btnPop.BorderColor = System.Drawing.Color.Black;
            this.btnPop.BorderSize = 2;
            this.btnPop.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPop.FocusedColor = System.Drawing.Color.Empty;
            this.btnPop.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.btnPop.ForeColor = System.Drawing.Color.White;
            this.btnPop.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnPop.Image = null;
            this.btnPop.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPop.Location = new System.Drawing.Point(15, 296);
            this.btnPop.Name = "btnPop";
            this.btnPop.OnHoverBaseColor1 = System.Drawing.Color.Fuchsia;
            this.btnPop.OnHoverBaseColor2 = System.Drawing.Color.White;
            this.btnPop.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPop.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPop.OnHoverImage = null;
            this.btnPop.OnPressedColor = System.Drawing.Color.Black;
            this.btnPop.Radius = 15;
            this.btnPop.Size = new System.Drawing.Size(224, 50);
            this.btnPop.TabIndex = 38;
            this.btnPop.Text = "Popular Words";
            this.btnPop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPop.UseTransfarantBackground = true;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // Pnl2
            // 
            this.Pnl2.BackColor = System.Drawing.Color.Transparent;
            this.Pnl2.Controls.Add(this.toolStripSetting);
            this.Pnl2.Controls.Add(this.btnSearchOnline);
            this.Pnl2.Controls.Add(this.btnLike);
            this.Pnl2.Controls.Add(this.lblLoading);
            this.Pnl2.Controls.Add(this.picLoading);
            this.Pnl2.Controls.Add(this.cboTu);
            this.Pnl2.Controls.Add(this.cboWord);
            this.Pnl2.Controls.Add(this.btnSpeak);
            this.Pnl2.Controls.Add(this.btnSearchImage);
            this.Pnl2.Controls.Add(this.rtxtExplan);
            this.Pnl2.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(209)))), ((int)(((byte)(220)))));
            this.Pnl2.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(134)))), ((int)(((byte)(229)))));
            this.Pnl2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.Pnl2.Location = new System.Drawing.Point(260, 0);
            this.Pnl2.Name = "Pnl2";
            this.Pnl2.Size = new System.Drawing.Size(733, 579);
            this.Pnl2.TabIndex = 33;
            // 
            // toolStripSetting
            // 
            this.toolStripSetting.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.toolStripSetting.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripSetting.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstrCboLanguage,
            this.tstrCboSize,
            this.tstrCboFont,
            this.tstrCboOnline});
            this.toolStripSetting.Location = new System.Drawing.Point(0, 0);
            this.toolStripSetting.Name = "toolStripSetting";
            this.toolStripSetting.Size = new System.Drawing.Size(733, 30);
            this.toolStripSetting.TabIndex = 34;
            // 
            // tstrCboLanguage
            // 
            this.tstrCboLanguage.BackColor = System.Drawing.Color.LavenderBlush;
            this.tstrCboLanguage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tstrCboLanguage.Items.AddRange(new object[] {
            "English",
            "Vietnamese"});
            this.tstrCboLanguage.Name = "tstrCboLanguage";
            this.tstrCboLanguage.Size = new System.Drawing.Size(130, 31);
            this.tstrCboLanguage.Text = "Language";
            this.tstrCboLanguage.SelectedIndexChanged += new System.EventHandler(this.toolStripCmbLanguage_SelectedIndexChanged);
            // 
            // tstrCboSize
            // 
            this.tstrCboSize.AutoSize = false;
            this.tstrCboSize.BackColor = System.Drawing.Color.LavenderBlush;
            this.tstrCboSize.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tstrCboSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.tstrCboSize.Name = "tstrCboSize";
            this.tstrCboSize.Size = new System.Drawing.Size(72, 30);
            this.tstrCboSize.Text = "Size";
            this.tstrCboSize.SelectedIndexChanged += new System.EventHandler(this.ChangeFontSize);
            // 
            // tstrCboFont
            // 
            this.tstrCboFont.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tstrCboFont.BackColor = System.Drawing.Color.LavenderBlush;
            this.tstrCboFont.DropDownWidth = 210;
            this.tstrCboFont.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tstrCboFont.Name = "tstrCboFont";
            this.tstrCboFont.Size = new System.Drawing.Size(200, 31);
            this.tstrCboFont.Text = "Font";
            this.tstrCboFont.SelectedIndexChanged += new System.EventHandler(this.ChangeFontSize);
            // 
            // tstrCboOnline
            // 
            this.tstrCboOnline.BackColor = System.Drawing.Color.LavenderBlush;
            this.tstrCboOnline.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tstrCboOnline.Items.AddRange(new object[] {
            "vdict",
            "soha",
            "vndic",
            "Oxford",
            "laban",
            "Cambridge"});
            this.tstrCboOnline.Name = "tstrCboOnline";
            this.tstrCboOnline.Size = new System.Drawing.Size(180, 31);
            this.tstrCboOnline.Text = "Online dictionary";
            // 
            // btnSearchOnline
            // 
            this.btnSearchOnline.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchOnline.BackgroundImage")));
            this.btnSearchOnline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchOnline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchOnline.Location = new System.Drawing.Point(661, 51);
            this.btnSearchOnline.Name = "btnSearchOnline";
            this.btnSearchOnline.Size = new System.Drawing.Size(35, 35);
            this.btnSearchOnline.TabIndex = 32;
            this.btnSearchOnline.UseVisualStyleBackColor = true;
            this.btnSearchOnline.Click += new System.EventHandler(this.btnSearchOnline_Click);
            // 
            // btnLike
            // 
            this.btnLike.BackColor = System.Drawing.Color.White;
            this.btnLike.BackgroundImage = global::Từ_điển.Properties.Resources.NotLike;
            this.btnLike.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLike.Location = new System.Drawing.Point(661, 105);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new System.Drawing.Size(35, 35);
            this.btnLike.TabIndex = 22;
            this.btnLike.UseVisualStyleBackColor = false;
            this.btnLike.Click += new System.EventHandler(this.btnLike_Click);
            // 
            // picLoading
            // 
            this.picLoading.BackColor = System.Drawing.Color.LavenderBlush;
            this.picLoading.Image = ((System.Drawing.Image)(resources.GetObject("picLoading.Image")));
            this.picLoading.Location = new System.Drawing.Point(43, 55);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(31, 30);
            this.picLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLoading.TabIndex = 14;
            this.picLoading.TabStop = false;
            // 
            // btnSpeak
            // 
            this.btnSpeak.AutoEllipsis = true;
            this.btnSpeak.BackColor = System.Drawing.Color.Transparent;
            this.btnSpeak.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSpeak.BackgroundImage")));
            this.btnSpeak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSpeak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpeak.Location = new System.Drawing.Point(579, 51);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(35, 35);
            this.btnSpeak.TabIndex = 2;
            this.btnSpeak.UseVisualStyleBackColor = false;
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click);
            // 
            // btnSearchImage
            // 
            this.btnSearchImage.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchImage.BackgroundImage")));
            this.btnSearchImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchImage.Location = new System.Drawing.Point(620, 51);
            this.btnSearchImage.Name = "btnSearchImage";
            this.btnSearchImage.Size = new System.Drawing.Size(35, 35);
            this.btnSearchImage.TabIndex = 3;
            this.btnSearchImage.UseVisualStyleBackColor = false;
            this.btnSearchImage.Click += new System.EventHandler(this.btnSearchImage_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(996, 582);
            this.Controls.Add(this.Pnl2);
            this.Controls.Add(this.Pnl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EVDict";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.Pnl1.ResumeLayout(false);
            this.Pnl2.ResumeLayout(false);
            this.Pnl2.PerformLayout();
            this.toolStripSetting.ResumeLayout(false);
            this.toolStripSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSpeak;
        private System.Windows.Forms.ComboBox cboWord;
        private System.Windows.Forms.Button btnSearchImage;
        private System.Windows.Forms.RichTextBox rtxtExplan;
        private System.Windows.Forms.ComboBox cboHistory;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.PictureBox picLoading;
        private System.Windows.Forms.ComboBox cboTu;
        private System.Windows.Forms.Button btnLike;
        private System.Windows.Forms.ComboBox cboFavorite;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel Pnl1;
        private Guna.UI.WinForms.GunaGradientButton btnFavorite;
        private Guna.UI.WinForms.GunaGradientButton btnHistory;
        private Guna.UI.WinForms.GunaGradientButton btnHDSD;
        private Guna.UI.WinForms.GunaGradientButton btnTranslator;
        private Guna.UI.WinForms.GunaGradientButton btnPop;
        private Guna.UI.WinForms.GunaComboBox cboLanguage;
        private Guna.UI.WinForms.GunaGradient2Panel Pnl2;
        private System.Windows.Forms.Button btnSearchOnline;
        private System.Windows.Forms.ToolStrip toolStripSetting;
        private System.Windows.Forms.ToolStripComboBox tstrCboLanguage;
        private System.Windows.Forms.ToolStripComboBox tstrCboSize;
        private System.Windows.Forms.ToolStripComboBox tstrCboFont;
        private System.Windows.Forms.ToolStripComboBox tstrCboOnline;
    }
}

