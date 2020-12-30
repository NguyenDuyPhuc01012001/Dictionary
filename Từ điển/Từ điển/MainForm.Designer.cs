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
            this.cbWord = new System.Windows.Forms.ComboBox();
            this.rTxbExplan = new System.Windows.Forms.RichTextBox();
            this.cmbHistory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTu = new System.Windows.Forms.ComboBox();
            this.cmbLike = new System.Windows.Forms.ComboBox();
            this.Pnl1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.cmbLanguage = new Guna.UI.WinForms.GunaComboBox();
            this.btnHDSD = new Guna.UI.WinForms.GunaGradientButton();
            this.btnHistory = new Guna.UI.WinForms.GunaGradientButton();
            this.btnSetting = new Guna.UI.WinForms.GunaGradientButton();
            this.btnFavorite = new Guna.UI.WinForms.GunaGradientButton();
            this.btnTranslator = new Guna.UI.WinForms.GunaGradientButton();
            this.btnPop = new Guna.UI.WinForms.GunaGradientButton();
            this.Pnl2 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.btnSearchOnline = new System.Windows.Forms.Button();
            this.btnLike = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSpeakEnglish = new System.Windows.Forms.Button();
            this.btnSearchImage = new System.Windows.Forms.Button();
            this.Pnl1.SuspendLayout();
            this.Pnl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbWord
            // 
            this.cbWord.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbWord.BackColor = System.Drawing.Color.LavenderBlush;
            this.cbWord.DropDownHeight = 100;
            this.cbWord.DropDownWidth = 300;
            this.cbWord.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWord.IntegralHeight = false;
            this.cbWord.Location = new System.Drawing.Point(40, 13);
            this.cbWord.Name = "cbWord";
            this.cbWord.Size = new System.Drawing.Size(533, 33);
            this.cbWord.Sorted = true;
            this.cbWord.TabIndex = 2;
            this.cbWord.SelectedIndexChanged += new System.EventHandler(this.Search);
            // 
            // rTxbExplan
            // 
            this.rTxbExplan.BackColor = System.Drawing.Color.White;
            this.rTxbExplan.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rTxbExplan.Location = new System.Drawing.Point(40, 80);
            this.rTxbExplan.Name = "rTxbExplan";
            this.rTxbExplan.ReadOnly = true;
            this.rTxbExplan.Size = new System.Drawing.Size(671, 473);
            this.rTxbExplan.TabIndex = 6;
            this.rTxbExplan.Text = "";
            // 
            // cmbHistory
            // 
            this.cmbHistory.BackColor = System.Drawing.Color.LavenderBlush;
            this.cmbHistory.DropDownHeight = 210;
            this.cmbHistory.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbHistory.FormattingEnabled = true;
            this.cmbHistory.IntegralHeight = false;
            this.cmbHistory.Location = new System.Drawing.Point(33, 18);
            this.cmbHistory.Name = "cmbHistory";
            this.cmbHistory.Size = new System.Drawing.Size(190, 33);
            this.cmbHistory.TabIndex = 7;
            this.cmbHistory.SelectedIndexChanged += new System.EventHandler(this.cmbHistory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LavenderBlush;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(80, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Loading data. Please wait!";
            // 
            // cbTu
            // 
            this.cbTu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTu.BackColor = System.Drawing.Color.LavenderBlush;
            this.cbTu.DropDownHeight = 100;
            this.cbTu.DropDownWidth = 300;
            this.cbTu.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTu.FormattingEnabled = true;
            this.cbTu.IntegralHeight = false;
            this.cbTu.Location = new System.Drawing.Point(40, 13);
            this.cbTu.Name = "cbTu";
            this.cbTu.Size = new System.Drawing.Size(533, 33);
            this.cbTu.Sorted = true;
            this.cbTu.TabIndex = 17;
            this.cbTu.SelectedIndexChanged += new System.EventHandler(this.Search);
            // 
            // cmbLike
            // 
            this.cmbLike.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbLike.BackColor = System.Drawing.Color.LavenderBlush;
            this.cmbLike.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbLike.FormattingEnabled = true;
            this.cmbLike.IntegralHeight = false;
            this.cmbLike.Location = new System.Drawing.Point(33, 18);
            this.cmbLike.Name = "cmbLike";
            this.cmbLike.Size = new System.Drawing.Size(190, 33);
            this.cmbLike.TabIndex = 23;
            this.cmbLike.SelectedIndexChanged += new System.EventHandler(this.cmbLike_SelectedIndexChanged);
            // 
            // Pnl1
            // 
            this.Pnl1.BorderColor = System.Drawing.Color.Black;
            this.Pnl1.BorderThickness = 2;
            this.Pnl1.Controls.Add(this.cmbLanguage);
            this.Pnl1.Controls.Add(this.btnHDSD);
            this.Pnl1.Controls.Add(this.btnHistory);
            this.Pnl1.Controls.Add(this.btnSetting);
            this.Pnl1.Controls.Add(this.btnFavorite);
            this.Pnl1.Controls.Add(this.btnTranslator);
            this.Pnl1.Controls.Add(this.btnPop);
            this.Pnl1.Controls.Add(this.cmbHistory);
            this.Pnl1.Controls.Add(this.cmbLike);
            this.Pnl1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Pnl1.FillColor3 = System.Drawing.Color.Blue;
            this.Pnl1.Location = new System.Drawing.Point(0, 0);
            this.Pnl1.Name = "Pnl1";
            this.Pnl1.ShadowDecoration.Parent = this.Pnl1;
            this.Pnl1.Size = new System.Drawing.Size(278, 579);
            this.Pnl1.TabIndex = 32;
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.BackColor = System.Drawing.Color.Transparent;
            this.cmbLanguage.BaseColor = System.Drawing.Color.White;
            this.cmbLanguage.BorderColor = System.Drawing.Color.Silver;
            this.cmbLanguage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguage.FocusedColor = System.Drawing.Color.Empty;
            this.cmbLanguage.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Italic);
            this.cmbLanguage.ForeColor = System.Drawing.Color.Black;
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Items.AddRange(new object[] {
            "Anh - Việt",
            "Việt - Anh"});
            this.cmbLanguage.Location = new System.Drawing.Point(33, 18);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbLanguage.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbLanguage.Size = new System.Drawing.Size(190, 33);
            this.cmbLanguage.TabIndex = 33;
            this.cmbLanguage.SelectedIndexChanged += new System.EventHandler(this.cmbLanguage_SelectedIndexChanged);
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
            this.btnHDSD.Location = new System.Drawing.Point(15, 495);
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
            this.btnHistory.Location = new System.Drawing.Point(15, 163);
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
            // btnSetting
            // 
            this.btnSetting.Animated = true;
            this.btnSetting.AnimationHoverSpeed = 0.07F;
            this.btnSetting.AnimationSpeed = 0.03F;
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.BaseColor1 = System.Drawing.Color.DodgerBlue;
            this.btnSetting.BaseColor2 = System.Drawing.Color.CornflowerBlue;
            this.btnSetting.BorderColor = System.Drawing.Color.Black;
            this.btnSetting.BorderSize = 2;
            this.btnSetting.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSetting.FocusedColor = System.Drawing.Color.Empty;
            this.btnSetting.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnSetting.Image = global::Từ_điển.Properties.Resources.Setting;
            this.btnSetting.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSetting.Location = new System.Drawing.Point(15, 412);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.OnHoverBaseColor1 = System.Drawing.Color.Fuchsia;
            this.btnSetting.OnHoverBaseColor2 = System.Drawing.Color.White;
            this.btnSetting.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSetting.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSetting.OnHoverImage = null;
            this.btnSetting.OnPressedColor = System.Drawing.Color.Black;
            this.btnSetting.Radius = 15;
            this.btnSetting.Size = new System.Drawing.Size(224, 50);
            this.btnSetting.TabIndex = 42;
            this.btnSetting.Text = "Setting";
            this.btnSetting.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSetting.UseTransfarantBackground = true;
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
            this.btnTranslator.Location = new System.Drawing.Point(15, 329);
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
            this.btnPop.Location = new System.Drawing.Point(15, 246);
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
            this.btnPop.Click += new System.EventHandler(this.btnIrrVerbs_Click);
            // 
            // Pnl2
            // 
            this.Pnl2.BackColor = System.Drawing.Color.Transparent;
            this.Pnl2.Controls.Add(this.btnSearchOnline);
            this.Pnl2.Controls.Add(this.btnLike);
            this.Pnl2.Controls.Add(this.label1);
            this.Pnl2.Controls.Add(this.pictureBox1);
            this.Pnl2.Controls.Add(this.cbTu);
            this.Pnl2.Controls.Add(this.cbWord);
            this.Pnl2.Controls.Add(this.btnSpeakEnglish);
            this.Pnl2.Controls.Add(this.btnSearchImage);
            this.Pnl2.Controls.Add(this.rTxbExplan);
            this.Pnl2.GradientColor1 = System.Drawing.Color.White;
            this.Pnl2.GradientColor2 = System.Drawing.Color.Navy;
            this.Pnl2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.Pnl2.Location = new System.Drawing.Point(284, 0);
            this.Pnl2.Name = "Pnl2";
            this.Pnl2.Size = new System.Drawing.Size(755, 579);
            this.Pnl2.TabIndex = 33;
            // 
            // btnSearchOnline
            // 
            this.btnSearchOnline.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchOnline.BackgroundImage")));
            this.btnSearchOnline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchOnline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchOnline.Location = new System.Drawing.Point(676, 12);
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
            this.btnLike.Location = new System.Drawing.Point(676, 80);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new System.Drawing.Size(35, 35);
            this.btnLike.TabIndex = 22;
            this.btnLike.UseVisualStyleBackColor = false;
            this.btnLike.Click += new System.EventHandler(this.btnLike_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnSpeakEnglish
            // 
            this.btnSpeakEnglish.AutoEllipsis = true;
            this.btnSpeakEnglish.BackColor = System.Drawing.Color.Transparent;
            this.btnSpeakEnglish.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSpeakEnglish.BackgroundImage")));
            this.btnSpeakEnglish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSpeakEnglish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpeakEnglish.Location = new System.Drawing.Point(594, 12);
            this.btnSpeakEnglish.Name = "btnSpeakEnglish";
            this.btnSpeakEnglish.Size = new System.Drawing.Size(35, 35);
            this.btnSpeakEnglish.TabIndex = 2;
            this.btnSpeakEnglish.UseVisualStyleBackColor = false;
            this.btnSpeakEnglish.Click += new System.EventHandler(this.btnSpeakEnglish_Click);
            // 
            // btnSearchImage
            // 
            this.btnSearchImage.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchImage.BackgroundImage")));
            this.btnSearchImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchImage.Location = new System.Drawing.Point(635, 12);
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
            this.ClientSize = new System.Drawing.Size(1040, 578);
            this.Controls.Add(this.Pnl2);
            this.Controls.Add(this.Pnl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EVDict";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Pnl1.ResumeLayout(false);
            this.Pnl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSpeakEnglish;
        private System.Windows.Forms.ComboBox cbWord;
        private System.Windows.Forms.Button btnSearchImage;
        private System.Windows.Forms.RichTextBox rTxbExplan;
        private System.Windows.Forms.ComboBox cmbHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbTu;
        private System.Windows.Forms.Button btnLike;
        private System.Windows.Forms.ComboBox cmbLike;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel Pnl1;
        private Guna.UI.WinForms.GunaGradientButton btnFavorite;
        private Guna.UI.WinForms.GunaGradientButton btnHistory;
        private Guna.UI.WinForms.GunaGradientButton btnHDSD;
        private Guna.UI.WinForms.GunaGradientButton btnSetting;
        private Guna.UI.WinForms.GunaGradientButton btnTranslator;
        private Guna.UI.WinForms.GunaGradientButton btnPop;
        private Guna.UI.WinForms.GunaComboBox cmbLanguage;
        private Guna.UI.WinForms.GunaGradient2Panel Pnl2;
        private System.Windows.Forms.Button btnSearchOnline;
    }
}

