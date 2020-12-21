namespace Từ_điển
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.btnFavorite = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnHDSD = new System.Windows.Forms.Button();
            this.btnLike = new System.Windows.Forms.Button();
            this.cmbLike = new System.Windows.Forms.ComboBox();
            this.btn2 = new Từ_điển.Btn();
            this.btn3 = new Từ_điển.Btn();
            this.btn4 = new Từ_điển.Btn();
            this.btn1 = new Từ_điển.Btn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            "Việt - Anh",
            "TOEIC 3000 từ"});
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
            // btnFavorite
            // 
            this.btnFavorite.BackColor = System.Drawing.Color.Orange;
            this.btnFavorite.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFavorite.Location = new System.Drawing.Point(285, 102);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.Size = new System.Drawing.Size(190, 80);
            this.btnFavorite.TabIndex = 18;
            this.btnFavorite.Text = "Favorite";
            this.btnFavorite.UseVisualStyleBackColor = false;
            this.btnFavorite.Click += new System.EventHandler(this.btnFavorite_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.SpringGreen;
            this.btnHistory.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHistory.Location = new System.Drawing.Point(285, 230);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(190, 80);
            this.btnHistory.TabIndex = 19;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSetting.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSetting.Location = new System.Drawing.Point(285, 358);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(190, 80);
            this.btnSetting.TabIndex = 20;
            this.btnSetting.Text = "Setting";
            this.btnSetting.UseVisualStyleBackColor = false;
            // 
            // btnHDSD
            // 
            this.btnHDSD.BackColor = System.Drawing.Color.Orchid;
            this.btnHDSD.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHDSD.Location = new System.Drawing.Point(285, 486);
            this.btnHDSD.Name = "btnHDSD";
            this.btnHDSD.Size = new System.Drawing.Size(190, 80);
            this.btnHDSD.TabIndex = 21;
            this.btnHDSD.Text = "How to use?";
            this.btnHDSD.UseVisualStyleBackColor = false;
            this.btnHDSD.Click += new System.EventHandler(this.btnHDSD_Click);
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
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Transparent;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn2.Location = new System.Drawing.Point(12, 230);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(190, 80);
            this.btn2.TabIndex = 25;
            this.btn2.Text = "History";
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Transparent;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn3.Location = new System.Drawing.Point(12, 359);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(190, 80);
            this.btn3.TabIndex = 26;
            this.btn3.Text = "Setting";
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Transparent;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn4.Location = new System.Drawing.Point(12, 486);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(190, 80);
            this.btn4.TabIndex = 27;
            this.btn4.Text = "How to use?";
            this.btn4.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Transparent;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn1.Location = new System.Drawing.Point(12, 102);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(190, 80);
            this.btn1.TabIndex = 28;
            this.btn1.Text = "Favorite";
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(997, 578);
            this.Controls.Add(this.rTxbExplan);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.cmbLike);
            this.Controls.Add(this.btnLike);
            this.Controls.Add(this.btnHDSD);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnFavorite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbHistory);
            this.Controls.Add(this.btnSearchImage);
            this.Controls.Add(this.btnSpeakEnglish);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cbTu);
            this.Controls.Add(this.cbWord);
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
        private System.Windows.Forms.Button btnFavorite;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnHDSD;
        private System.Windows.Forms.Button btnLike;
        private System.Windows.Forms.ComboBox cmbLike;
        private Btn btn2;
        private Btn btn3;
        private Btn btn4;
        private Btn btn1;
    }
}

