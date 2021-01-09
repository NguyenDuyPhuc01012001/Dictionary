using System;
using System.Linq;
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
            btnTranslate.FlatAppearance.BorderSize = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string source = cboDest.SelectedItem.ToString();
            string dest = cboSource.SelectedItem.ToString();
            txtSource.Text = txtDestination.Text;
            cboSource.SelectedItem = source;
            cboDest.SelectedItem = dest;
        }

        private void Translator_Load(object sender, EventArgs e)
        {
            try
            {
                this.cboSource.Items.AddRange(Translator.Languages.ToArray());
                this.cboDest.Items.AddRange(Translator.Languages.ToArray());
                this.cboSource.SelectedItem = "English";
                this.cboDest.SelectedItem = "Vietnamese";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }            
        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            try
            {
if (!string.IsNullOrEmpty(this._translationSpeakUrl))
                this.webBrowser1.Navigate(this._translationSpeakUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }            
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            Translator t = new Translator();

            this.txtDestination.Text = string.Empty;
            this.txtDestination.Update();
            this._translationSpeakUrl = null;

            // Translate the text
            try
            {
                this.Cursor = Cursors.WaitCursor;
                this.txtDestination.Text = t.Translate(this.txtSource.Text.Trim(), (string)this.cboSource.SelectedItem, (string)this.cboDest.SelectedItem);
                if (t.Error == null)
                {
                    this.txtDestination.Update();
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
    }
}