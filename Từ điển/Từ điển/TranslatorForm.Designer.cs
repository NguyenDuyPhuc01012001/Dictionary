
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TranslatorForm));
            this.txbDestination = new System.Windows.Forms.TextBox();
            this.txbSource = new System.Windows.Forms.TextBox();
            this.cmbDest = new System.Windows.Forms.ComboBox();
            this.cmbSource = new System.Windows.Forms.ComboBox();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnSpeak = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbDestination
            // 
            this.txbDestination.Location = new System.Drawing.Point(399, 114);
            this.txbDestination.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbDestination.Multiline = true;
            this.txbDestination.Name = "txbDestination";
            this.txbDestination.ReadOnly = true;
            this.txbDestination.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbDestination.Size = new System.Drawing.Size(340, 200);
            this.txbDestination.TabIndex = 0;
            // 
            // txbSource
            // 
            this.txbSource.Location = new System.Drawing.Point(13, 114);
            this.txbSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbSource.Multiline = true;
            this.txbSource.Name = "txbSource";
            this.txbSource.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbSource.Size = new System.Drawing.Size(340, 200);
            this.txbSource.TabIndex = 1;
            this.txbSource.TextChanged += new System.EventHandler(this.txbSource_TextChanged);
            // 
            // cmbDest
            // 
            this.cmbDest.FormattingEnabled = true;
            this.cmbDest.IntegralHeight = false;
            this.cmbDest.Location = new System.Drawing.Point(399, 46);
            this.cmbDest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDest.Name = "cmbDest";
            this.cmbDest.Size = new System.Drawing.Size(190, 33);
            this.cmbDest.TabIndex = 2;
            this.cmbDest.SelectedIndexChanged += new System.EventHandler(this.cmbDest_SelectedIndexChanged);
            // 
            // cmbSource
            // 
            this.cmbSource.FormattingEnabled = true;
            this.cmbSource.IntegralHeight = false;
            this.cmbSource.Location = new System.Drawing.Point(160, 46);
            this.cmbSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSource.Name = "cmbSource";
            this.cmbSource.Size = new System.Drawing.Size(193, 33);
            this.cmbSource.TabIndex = 3;
            this.cmbSource.SelectedIndexChanged += new System.EventHandler(this.cmbSource_SelectedIndexChanged);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 20;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.Animated = true;
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaControlBox1.ControlBoxTheme = Guna.UI.WinForms.FormControlBoxTheme.Custom;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(699, 12);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.Tomato;
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 30);
            this.gunaControlBox1.TabIndex = 6;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(493, 264);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(20, 20);
            this.webBrowser1.TabIndex = 7;
            // 
            // btnSpeak
            // 
            this.btnSpeak.AutoEllipsis = true;
            this.btnSpeak.BackColor = System.Drawing.SystemColors.Control;
            this.btnSpeak.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSpeak.BackgroundImage")));
            this.btnSpeak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSpeak.Location = new System.Drawing.Point(709, 114);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(30, 30);
            this.btnSpeak.TabIndex = 8;
            this.btnSpeak.UseVisualStyleBackColor = false;
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.BackColor = System.Drawing.Color.Transparent;
            this.btnSwitch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSwitch.BackgroundImage")));
            this.btnSwitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitch.Location = new System.Drawing.Point(361, 46);
            this.btnSwitch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(30, 30);
            this.btnSwitch.TabIndex = 4;
            this.btnSwitch.UseVisualStyleBackColor = false;
            this.btnSwitch.Click += new System.EventHandler(this.button1_Click);
            // 
            // TranslatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(756, 344);
            this.Controls.Add(this.btnSpeak);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.cmbSource);
            this.Controls.Add(this.cmbDest);
            this.Controls.Add(this.txbSource);
            this.Controls.Add(this.txbDestination);
            this.Controls.Add(this.webBrowser1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TranslatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button btnSwitch;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnSpeak;
    }
}