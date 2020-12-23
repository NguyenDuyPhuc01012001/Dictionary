
namespace Từ_điển
{
    partial class TranslatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TranslatorForm));
            this.txbDestination = new System.Windows.Forms.TextBox();
            this.txbSource = new System.Windows.Forms.TextBox();
            this.cmbDest = new System.Windows.Forms.ComboBox();
            this.cmbSource = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbDestination
            // 
            this.txbDestination.Location = new System.Drawing.Point(636, 77);
            this.txbDestination.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbDestination.Multiline = true;
            this.txbDestination.Name = "txbDestination";
            this.txbDestination.ReadOnly = true;
            this.txbDestination.Size = new System.Drawing.Size(470, 354);
            this.txbDestination.TabIndex = 0;
            // 
            // txbSource
            // 
            this.txbSource.Location = new System.Drawing.Point(13, 77);
            this.txbSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbSource.Multiline = true;
            this.txbSource.Name = "txbSource";
            this.txbSource.Size = new System.Drawing.Size(470, 354);
            this.txbSource.TabIndex = 1;
            this.txbSource.TextChanged += new System.EventHandler(this.txbSource_TextChanged);
            // 
            // cmbDest
            // 
            this.cmbDest.FormattingEnabled = true;
            this.cmbDest.Items.AddRange(new object[] {
            "Afrikaans",
            "Albanian",
            "Arabic",
            "Armenian",
            "Azerbaijani",
            "Basque",
            "Belarusian",
            "Bengali",
            "Bulgarian",
            "Catalan",
            "Chinese",
            "Croatian",
            "Czech",
            "Danish",
            "Dutch",
            "English",
            "Esperanto",
            "Estonian",
            "Filipino",
            "Finnish",
            "French",
            "Galician",
            "German",
            "Georgian",
            "Greek",
            "Haitian Creole",
            "Hebrew",
            "Hindi",
            "Hungarian",
            "Icelandic",
            "Indonesian",
            "Irish",
            "Italian",
            "Japanese",
            "Korean",
            "Lao",
            "Latin",
            "Latvian",
            "Lithuanian",
            "Macedonian",
            "Malay",
            "Maltese",
            "Norwegian",
            "Persian",
            "Polish",
            "Portuguese",
            "Romanian",
            "Russian",
            "Serbian",
            "Slovak",
            "Slovenian",
            "Spanish",
            "Swahili",
            "Swedish",
            "Tamil",
            "Telugu",
            "Thai",
            "Turkish",
            "Ukrainian",
            "Urdu",
            "Vietnamese",
            "Welsh",
            "Yiddish"});
            this.cmbDest.Location = new System.Drawing.Point(636, 14);
            this.cmbDest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDest.Name = "cmbDest";
            this.cmbDest.Size = new System.Drawing.Size(230, 33);
            this.cmbDest.TabIndex = 2;
            this.cmbDest.SelectedIndexChanged += new System.EventHandler(this.cmbDest_SelectedIndexChanged);
            // 
            // cmbSource
            // 
            this.cmbSource.FormattingEnabled = true;
            this.cmbSource.Items.AddRange(new object[] {
            "Afrikaans",
            "Albanian",
            "Arabic",
            "Armenian",
            "Azerbaijani",
            "Basque",
            "Belarusian",
            "Bengali",
            "Bulgarian",
            "Catalan",
            "Chinese",
            "Croatian",
            "Czech",
            "Danish",
            "Dutch",
            "English",
            "Esperanto",
            "Estonian",
            "Filipino",
            "Finnish",
            "French",
            "Galician",
            "German",
            "Georgian",
            "Greek",
            "Haitian Creole",
            "Hebrew",
            "Hindi",
            "Hungarian",
            "Icelandic",
            "Indonesian",
            "Irish",
            "Italian",
            "Japanese",
            "Korean",
            "Lao",
            "Latin",
            "Latvian",
            "Lithuanian",
            "Macedonian",
            "Malay",
            "Maltese",
            "Norwegian",
            "Persian",
            "Polish",
            "Portuguese",
            "Romanian",
            "Russian",
            "Serbian",
            "Slovak",
            "Slovenian",
            "Spanish",
            "Swahili",
            "Swedish",
            "Tamil",
            "Telugu",
            "Thai",
            "Turkish",
            "Ukrainian",
            "Urdu",
            "Vietnamese",
            "Welsh",
            "Yiddish"});
            this.cmbSource.Location = new System.Drawing.Point(13, 14);
            this.cmbSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSource.Name = "cmbSource";
            this.cmbSource.Size = new System.Drawing.Size(230, 33);
            this.cmbSource.TabIndex = 3;
            this.cmbSource.SelectedIndexChanged += new System.EventHandler(this.cmbSource_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(503, 77);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TranslatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 448);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbSource);
            this.Controls.Add(this.cmbDest);
            this.Controls.Add(this.txbSource);
            this.Controls.Add(this.txbDestination);
            this.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TranslatorForm";
            this.Text = "TranslatorForm";
            this.Load += new System.EventHandler(this.Translator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbDestination;
        private System.Windows.Forms.TextBox txbSource;
        private System.Windows.Forms.ComboBox cmbDest;
        private System.Windows.Forms.ComboBox cmbSource;
        private System.Windows.Forms.Button button1;
    }
}