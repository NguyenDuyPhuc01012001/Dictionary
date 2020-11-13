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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSpeakEnglish
            // 
            this.btnSpeakEnglish.BackColor = System.Drawing.SystemColors.Control;
            this.btnSpeakEnglish.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSpeakEnglish.BackgroundImage")));
            this.btnSpeakEnglish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSpeakEnglish.Location = new System.Drawing.Point(320, 59);
            this.btnSpeakEnglish.Name = "btnSpeakEnglish";
            this.btnSpeakEnglish.Size = new System.Drawing.Size(31, 31);
            this.btnSpeakEnglish.TabIndex = 2;
            this.btnSpeakEnglish.UseVisualStyleBackColor = false;
            // 
            // cbWord
            // 
            this.cbWord.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbWord.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbWord.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbWord.Location = new System.Drawing.Point(12, 61);
            this.cbWord.Name = "cbWord";
            this.cbWord.Size = new System.Drawing.Size(302, 658);
            this.cbWord.TabIndex = 2;
            this.cbWord.SelectedIndexChanged += new System.EventHandler(this.cbWord_SelectedIndexChanged);
            // 
            // btnSearchImage
            // 
            this.btnSearchImage.BackgroundImage = global::Từ_điển.Properties.Resources.tải_xuống__1_;
            this.btnSearchImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchImage.Location = new System.Drawing.Point(320, 96);
            this.btnSearchImage.Name = "btnSearchImage";
            this.btnSearchImage.Size = new System.Drawing.Size(31, 31);
            this.btnSearchImage.TabIndex = 3;
            this.btnSearchImage.UseVisualStyleBackColor = true;
            this.btnSearchImage.Click += new System.EventHandler(this.btnSearchImage_Click);
            // 
            // rTxbExplan
            // 
            this.rTxbExplan.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rTxbExplan.Location = new System.Drawing.Point(357, 61);
            this.rTxbExplan.Name = "rTxbExplan";
            this.rTxbExplan.Size = new System.Drawing.Size(628, 655);
            this.rTxbExplan.TabIndex = 6;
            this.rTxbExplan.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmbLanguage});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(997, 32);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.Items.AddRange(new object[] {
            "Anh-Việt",
            "Việt-Anh"});
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(121, 28);
            this.cmbLanguage.Click += new System.EventHandler(this.cbLanguage_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 723);
            this.Controls.Add(this.rTxbExplan);
            this.Controls.Add(this.btnSearchImage);
            this.Controls.Add(this.btnSpeakEnglish);
            this.Controls.Add(this.cbWord);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Dictionary";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
   
}

