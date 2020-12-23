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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSpeakEnglish = new System.Windows.Forms.Button();
            this.cbWord = new System.Windows.Forms.ComboBox();
            this.btnSearchImage = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cmbLanguage = new System.Windows.Forms.ToolStripComboBox();
            this.âmThanhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbVolume = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbSpeed = new System.Windows.Forms.ToolStripComboBox();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmTừToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gópÝToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rTxbExplan = new System.Windows.Forms.RichTextBox();
            this.cmbHistory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbTu = new System.Windows.Forms.ComboBox();
            this.btnLike = new System.Windows.Forms.Button();
            this.cmbLike = new System.Windows.Forms.ComboBox();
            this.dGvIrrVerbs = new System.Windows.Forms.DataGridView();
            this.Base = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PastSimple = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PastParticiple = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Definition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSetting = new Từ_điển.Btn();
            this.btnIrrVerbs = new Từ_điển.Btn();
            this.btnFavorite = new Từ_điển.Btn();
            this.btnHelp = new Từ_điển.Btn();
            this.btnTranslator = new Từ_điển.Btn();
            this.btnHistory = new Từ_điển.Btn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGvIrrVerbs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSpeakEnglish
            // 
            this.btnSpeakEnglish.BackColor = System.Drawing.SystemColors.Control;
            this.btnSpeakEnglish.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSpeakEnglish.BackgroundImage")));
            this.btnSpeakEnglish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSpeakEnglish.Location = new System.Drawing.Point(208, 102);
            this.btnSpeakEnglish.Name = "btnSpeakEnglish";
            this.btnSpeakEnglish.Size = new System.Drawing.Size(40, 40);
            this.btnSpeakEnglish.TabIndex = 2;
            this.btnSpeakEnglish.UseVisualStyleBackColor = false;
            this.btnSpeakEnglish.Click += new System.EventHandler(this.btnSpeakEnglish_Click);
            // 
            // cbWord
            // 
            this.cbWord.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbWord.BackColor = System.Drawing.Color.LavenderBlush;
            this.cbWord.DropDownHeight = 100;
            this.cbWord.DropDownWidth = 300;
            this.cbWord.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWord.IntegralHeight = false;
            this.cbWord.Location = new System.Drawing.Point(254, 52);
            this.cbWord.Name = "cbWord";
            this.cbWord.Size = new System.Drawing.Size(731, 33);
            this.cbWord.Sorted = true;
            this.cbWord.TabIndex = 2;
            this.cbWord.SelectedIndexChanged += new System.EventHandler(this.Search);
            // 
            // btnSearchImage
            // 
            this.btnSearchImage.BackgroundImage = global::Từ_điển.Properties.Resources.tải_xuống__1_;
            this.btnSearchImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchImage.Location = new System.Drawing.Point(208, 148);
            this.btnSearchImage.Name = "btnSearchImage";
            this.btnSearchImage.Size = new System.Drawing.Size(40, 40);
            this.btnSearchImage.TabIndex = 3;
            this.btnSearchImage.UseVisualStyleBackColor = true;
            this.btnSearchImage.Click += new System.EventHandler(this.btnSearchImage_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmbLanguage,
            this.âmThanhToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(997, 34);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.BackColor = System.Drawing.Color.Gold;
            this.cmbLanguage.DropDownWidth = 150;
            this.cmbLanguage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbLanguage.Items.AddRange(new object[] {
            "Anh - Việt",
            "Việt - Anh"});
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(121, 30);
            this.cmbLanguage.SelectedIndexChanged += new System.EventHandler(this.cmbLanguage_SelectedIndexChanged);
            // 
            // âmThanhToolStripMenuItem
            // 
            this.âmThanhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.âmThanhToolStripMenuItem.Name = "âmThanhToolStripMenuItem";
            this.âmThanhToolStripMenuItem.Size = new System.Drawing.Size(98, 30);
            this.âmThanhToolStripMenuItem.Text = "Âm thanh";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmbVolume});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(173, 26);
            this.toolStripMenuItem1.Text = "Âm lượng";
            // 
            // cmbVolume
            // 
            this.cmbVolume.Items.AddRange(new object[] {
            "0",
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.cmbVolume.Name = "cmbVolume";
            this.cmbVolume.Size = new System.Drawing.Size(121, 28);
            this.cmbVolume.SelectedIndexChanged += new System.EventHandler(this.cmbVolume_SelectedIndexChanged);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmbSpeed});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(173, 26);
            this.toolStripMenuItem2.Text = "Tốc độ";
            // 
            // cmbSpeed
            // 
            this.cmbSpeed.Items.AddRange(new object[] {
            "-2",
            "-1",
            "0",
            "1",
            "2"});
            this.cmbSpeed.Name = "cmbSpeed";
            this.cmbSpeed.Size = new System.Drawing.Size(121, 28);
            this.cmbSpeed.SelectedIndexChanged += new System.EventHandler(this.cmbSpeed_SelectedIndexChanged);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hướngDẫnToolStripMenuItem,
            this.thêmTừToolStripMenuItem,
            this.gópÝToolStripMenuItem});
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(93, 30);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // hướngDẫnToolStripMenuItem
            // 
            this.hướngDẫnToolStripMenuItem.Name = "hướngDẫnToolStripMenuItem";
            this.hướngDẫnToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.hướngDẫnToolStripMenuItem.Text = "Hướng dẫn";
            // 
            // thêmTừToolStripMenuItem
            // 
            this.thêmTừToolStripMenuItem.Name = "thêmTừToolStripMenuItem";
            this.thêmTừToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.thêmTừToolStripMenuItem.Text = "Thêm từ";
            // 
            // gópÝToolStripMenuItem
            // 
            this.gópÝToolStripMenuItem.Name = "gópÝToolStripMenuItem";
            this.gópÝToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.gópÝToolStripMenuItem.Text = "Góp ý";
            // 
            // rTxbExplan
            // 
            this.rTxbExplan.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rTxbExplan.Location = new System.Drawing.Point(254, 102);
            this.rTxbExplan.Name = "rTxbExplan";
            this.rTxbExplan.Size = new System.Drawing.Size(731, 464);
            this.rTxbExplan.TabIndex = 6;
            this.rTxbExplan.Text = "";
            // 
            // cmbHistory
            // 
            this.cmbHistory.DropDownHeight = 210;
            this.cmbHistory.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbHistory.FormattingEnabled = true;
            this.cmbHistory.IntegralHeight = false;
            this.cmbHistory.Location = new System.Drawing.Point(12, 54);
            this.cmbHistory.Name = "cmbHistory";
            this.cmbHistory.Size = new System.Drawing.Size(190, 33);
            this.cmbHistory.TabIndex = 7;
            this.cmbHistory.SelectedIndexChanged += new System.EventHandler(this.cmbSearch_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LavenderBlush;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(294, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(666, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Loading data. Please wait!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(257, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
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
            this.cbTu.Location = new System.Drawing.Point(254, 52);
            this.cbTu.Name = "cbTu";
            this.cbTu.Size = new System.Drawing.Size(731, 33);
            this.cbTu.Sorted = true;
            this.cbTu.TabIndex = 17;
            this.cbTu.SelectedIndexChanged += new System.EventHandler(this.Search);
            // 
            // btnLike
            // 
            this.btnLike.BackColor = System.Drawing.Color.Transparent;
            this.btnLike.BackgroundImage = global::Từ_điển.Properties.Resources.NotLike;
            this.btnLike.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLike.Location = new System.Drawing.Point(208, 194);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new System.Drawing.Size(40, 40);
            this.btnLike.TabIndex = 22;
            this.btnLike.UseVisualStyleBackColor = false;
            this.btnLike.Click += new System.EventHandler(this.btnLike_Click);
            // 
            // cmbLike
            // 
            this.cmbLike.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbLike.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbLike.FormattingEnabled = true;
            this.cmbLike.IntegralHeight = false;
            this.cmbLike.Location = new System.Drawing.Point(12, 54);
            this.cmbLike.Name = "cmbLike";
            this.cmbLike.Size = new System.Drawing.Size(190, 33);
            this.cmbLike.TabIndex = 23;
            // 
            // dGvIrrVerbs
            // 
            this.dGvIrrVerbs.AllowUserToAddRows = false;
            this.dGvIrrVerbs.AllowUserToDeleteRows = false;
            this.dGvIrrVerbs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGvIrrVerbs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dGvIrrVerbs.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dGvIrrVerbs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGvIrrVerbs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGvIrrVerbs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGvIrrVerbs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Base,
            this.PastSimple,
            this.PastParticiple,
            this.Definition});
            this.dGvIrrVerbs.Location = new System.Drawing.Point(254, 102);
            this.dGvIrrVerbs.Name = "dGvIrrVerbs";
            this.dGvIrrVerbs.RowHeadersVisible = false;
            this.dGvIrrVerbs.RowHeadersWidth = 51;
            this.dGvIrrVerbs.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dGvIrrVerbs.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dGvIrrVerbs.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGvIrrVerbs.RowTemplate.Height = 24;
            this.dGvIrrVerbs.RowTemplate.ReadOnly = true;
            this.dGvIrrVerbs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGvIrrVerbs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGvIrrVerbs.Size = new System.Drawing.Size(731, 464);
            this.dGvIrrVerbs.TabIndex = 31;
            // 
            // Base
            // 
            this.Base.FillWeight = 32.58945F;
            this.Base.HeaderText = "Base";
            this.Base.MinimumWidth = 6;
            this.Base.Name = "Base";
            // 
            // PastSimple
            // 
            this.PastSimple.FillWeight = 48.68F;
            this.PastSimple.HeaderText = "Past Simple";
            this.PastSimple.MinimumWidth = 6;
            this.PastSimple.Name = "PastSimple";
            // 
            // PastParticiple
            // 
            this.PastParticiple.FillWeight = 53.92393F;
            this.PastParticiple.HeaderText = "Past Participle";
            this.PastParticiple.MinimumWidth = 6;
            this.PastParticiple.Name = "PastParticiple";
            // 
            // Definition
            // 
            this.Definition.FillWeight = 66.48212F;
            this.Definition.HeaderText = "Definition";
            this.Definition.MinimumWidth = 6;
            this.Definition.Name = "Definition";
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSetting.Location = new System.Drawing.Point(12, 434);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(190, 50);
            this.btnSetting.TabIndex = 30;
            this.btnSetting.Text = "Setting";
            this.btnSetting.UseVisualStyleBackColor = false;
            // 
            // btnIrrVerbs
            // 
            this.btnIrrVerbs.BackColor = System.Drawing.Color.Transparent;
            this.btnIrrVerbs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIrrVerbs.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnIrrVerbs.Location = new System.Drawing.Point(12, 268);
            this.btnIrrVerbs.Name = "btnIrrVerbs";
            this.btnIrrVerbs.Size = new System.Drawing.Size(190, 50);
            this.btnIrrVerbs.TabIndex = 29;
            this.btnIrrVerbs.Text = "Irregular Verbs";
            this.btnIrrVerbs.UseVisualStyleBackColor = false;
            this.btnIrrVerbs.Click += new System.EventHandler(this.btnIrrVerbs_Click);
            // 
            // btnFavorite
            // 
            this.btnFavorite.BackColor = System.Drawing.Color.Transparent;
            this.btnFavorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavorite.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFavorite.Location = new System.Drawing.Point(12, 102);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.Size = new System.Drawing.Size(190, 50);
            this.btnFavorite.TabIndex = 28;
            this.btnFavorite.Text = "Favorite";
            this.btnFavorite.UseVisualStyleBackColor = true;
            this.btnFavorite.Click += new System.EventHandler(this.btnFavorite_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHelp.Location = new System.Drawing.Point(12, 516);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(190, 50);
            this.btnHelp.TabIndex = 27;
            this.btnHelp.Text = "How to use?";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHDSD_Click);
            // 
            // btnTranslator
            // 
            this.btnTranslator.BackColor = System.Drawing.Color.Transparent;
            this.btnTranslator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTranslator.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTranslator.Location = new System.Drawing.Point(12, 351);
            this.btnTranslator.Name = "btnTranslator";
            this.btnTranslator.Size = new System.Drawing.Size(190, 50);
            this.btnTranslator.TabIndex = 26;
            this.btnTranslator.Text = "Translator";
            this.btnTranslator.UseVisualStyleBackColor = false;
            this.btnTranslator.Click += new System.EventHandler(this.btnTranslator_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.Transparent;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHistory.Location = new System.Drawing.Point(12, 185);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(190, 50);
            this.btnHistory.TabIndex = 25;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(997, 578);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnIrrVerbs);
            this.Controls.Add(this.btnFavorite);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnTranslator);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.cmbLike);
            this.Controls.Add(this.btnLike);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbHistory);
            this.Controls.Add(this.btnSearchImage);
            this.Controls.Add(this.btnSpeakEnglish);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cbTu);
            this.Controls.Add(this.cbWord);
            this.Controls.Add(this.rTxbExplan);
            this.Controls.Add(this.dGvIrrVerbs);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dictionary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGvIrrVerbs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSpeakEnglish;
        private System.Windows.Forms.ComboBox cbWord;
        private System.Windows.Forms.Button btnSearchImage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem âmThanhToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cmbLanguage;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripComboBox cmbVolume;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripComboBox cmbSpeed;
        private System.Windows.Forms.RichTextBox rTxbExplan;
        private System.Windows.Forms.ComboBox cmbHistory;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gópÝToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem thêmTừToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbTu;
        private System.Windows.Forms.Button btnLike;
        private System.Windows.Forms.ComboBox cmbLike;
        private Btn btnHistory;
        private Btn btnTranslator;
        private Btn btnHelp;
        private Btn btnFavorite;
        private Btn btnIrrVerbs;
        private Btn btnSetting;
        private System.Windows.Forms.DataGridView dGvIrrVerbs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Base;
        private System.Windows.Forms.DataGridViewTextBoxColumn PastSimple;
        private System.Windows.Forms.DataGridViewTextBoxColumn PastParticiple;
        private System.Windows.Forms.DataGridViewTextBoxColumn Definition;
    }
}

