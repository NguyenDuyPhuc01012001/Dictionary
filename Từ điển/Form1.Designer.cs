namespace Từ_điển
{
    public partial class Form1
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
            this.rTxbExplan = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cmbLanguage = new System.Windows.Forms.ToolStripComboBox();
            this.âmThanhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbVolume = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbSpeed = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSpeakEnglish
            // 
            this.btnSpeakEnglish.BackColor = System.Drawing.SystemColors.Control;
            this.btnSpeakEnglish.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSpeakEnglish.BackgroundImage")));
            this.btnSpeakEnglish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSpeakEnglish.Location = new System.Drawing.Point(360, 48);
            this.btnSpeakEnglish.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSpeakEnglish.Name = "btnSpeakEnglish";
            this.btnSpeakEnglish.Size = new System.Drawing.Size(35, 39);
            this.btnSpeakEnglish.TabIndex = 2;
            this.btnSpeakEnglish.UseVisualStyleBackColor = false;
            this.btnSpeakEnglish.Click += new System.EventHandler(this.btnSpeakEnglish_Click);
            // 
            // cbWord
            // 
            this.cbWord.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbWord.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbWord.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbWord.Location = new System.Drawing.Point(14, 47);
            this.cbWord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbWord.Name = "cbWord";
            this.cbWord.Size = new System.Drawing.Size(339, 851);
            this.cbWord.TabIndex = 2;
            this.cbWord.SelectedIndexChanged += new System.EventHandler(this.cbWord_SelectedIndexChanged);
            // 
            // btnSearchImage
            // 
            this.btnSearchImage.BackgroundImage = global::Từ_điển.Properties.Resources.tải_xuống__1_;
            this.btnSearchImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchImage.Location = new System.Drawing.Point(361, 95);
            this.btnSearchImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchImage.Name = "btnSearchImage";
            this.btnSearchImage.Size = new System.Drawing.Size(35, 39);
            this.btnSearchImage.TabIndex = 3;
            this.btnSearchImage.UseVisualStyleBackColor = true;
            this.btnSearchImage.Click += new System.EventHandler(this.btnSearchImage_Click);
            // 
            // rTxbExplan
            // 
            this.rTxbExplan.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rTxbExplan.Location = new System.Drawing.Point(402, 48);
            this.rTxbExplan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rTxbExplan.Name = "rTxbExplan";
            this.rTxbExplan.Size = new System.Drawing.Size(706, 846);
            this.rTxbExplan.TabIndex = 6;
            this.rTxbExplan.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmbLanguage,
            this.âmThanhToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1122, 37);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.Items.AddRange(new object[] {
            "Anh-Việt",
            "Việt-Anh"});
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(136, 33);
            this.cmbLanguage.Click += new System.EventHandler(this.cbLanguage_SelectedIndexChanged);
            // 
            // âmThanhToolStripMenuItem
            // 
            this.âmThanhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.âmThanhToolStripMenuItem.Name = "âmThanhToolStripMenuItem";
            this.âmThanhToolStripMenuItem.Size = new System.Drawing.Size(80, 33);
            this.âmThanhToolStripMenuItem.Text = "Sound";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmbVolume});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.toolStripMenuItem1.Text = "Volume";
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
            this.cmbVolume.Size = new System.Drawing.Size(121, 33);
            this.cmbVolume.SelectedIndexChanged += new System.EventHandler(this.cmbVolume_SelectedIndexChanged);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmbSpeed});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(270, 34);
            this.toolStripMenuItem2.Text = "Speed";
            // 
            // cmbSpeed
            // 
            this.cmbSpeed.Items.AddRange(new object[] {
            "-2 ",
            "-1 ",
            "0",
            "1",
            "2"});
            this.cmbSpeed.Name = "cmbSpeed";
            this.cmbSpeed.Size = new System.Drawing.Size(121, 33);
            this.cmbSpeed.SelectedIndexChanged += new System.EventHandler(this.cmbSpeed_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 904);
            this.Controls.Add(this.rTxbExplan);
            this.Controls.Add(this.btnSearchImage);
            this.Controls.Add(this.btnSpeakEnglish);
            this.Controls.Add(this.cbWord);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Dictionary";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSpeakEnglish;
        private System.Windows.Forms.ComboBox cbWord;
        private System.Windows.Forms.Button btnSearchImage;
        private System.Windows.Forms.RichTextBox rTxbExplan;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripComboBox cmbLanguage;
        private System.Windows.Forms.ToolStripMenuItem âmThanhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripComboBox cmbVolume;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripComboBox cmbSpeed;
    }
   
}

