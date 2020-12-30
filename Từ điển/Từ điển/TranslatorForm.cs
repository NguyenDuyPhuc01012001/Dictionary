using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Từ_điển
{
    public partial class TranslatorForm : Form
    {
        #region Fields
        /// <summary>
        /// The URL used to speak the translation.
        /// </summary>
        private string _translationSpeakUrl;
        #endregion
        public TranslatorForm()
        {
            InitializeComponent();

            btnSwitch.FlatAppearance.BorderSize = 0;
        }

        private void txbSource_TextChanged(object sender, EventArgs e)
        {
            Translate();
        }

        private void Translate()
        {
            Translator t = new Translator();

            this.txbDestination.Text = string.Empty;
            this.txbDestination.Update();
            this._translationSpeakUrl = null;

            // Translate the text
            try
            {
                this.Cursor = Cursors.WaitCursor;
                this.txbDestination.Text = t.Translate(this.txbSource.Text.Trim(), (string)this.cmbSource.SelectedItem, (string)this.cmbDest.SelectedItem);
                if (t.Error == null)
                {
                    this.txbDestination.Update();
                    this._translationSpeakUrl = t.TranslationSpeechUrl;
                }
                else
                {
                    MessageBox.Show(t.Error.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string source = cmbDest.SelectedItem.ToString();
            string dest = cmbSource.SelectedItem.ToString();
            txbSource.Text = txbDestination.Text;
            cmbSource.SelectedItem = source;
            cmbDest.SelectedItem = dest;            
            //Translate();
        }

        #region Private methods


        #endregion

        private void Translator_Load(object sender, EventArgs e)
        {
            this.cmbSource.Items.AddRange(Translator.Languages.ToArray());
            this.cmbDest.Items.AddRange(Translator.Languages.ToArray());
            this.cmbSource.SelectedItem = "English";
            this.cmbDest.SelectedItem = "French";
        }

        private void cmbSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSource.Text != null)
                Translate();
        }

        private void cmbDest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSource.Text != null)
                Translate();
        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this._translationSpeakUrl))
                this.webBrowser1.Navigate(this._translationSpeakUrl);
        }
    }
}