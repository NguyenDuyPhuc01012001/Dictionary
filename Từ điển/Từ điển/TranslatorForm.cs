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
        Dictionary<string, string> Language = new Dictionary<string, string>();
        public TranslatorForm()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();

            cmbDest.SelectedItem = "Vietnamese";
            cmbSource.SelectedItem = "English";
        }

        private void txbSource_TextChanged(object sender, EventArgs e)
        {

            button1_Click(sender, e);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txbSource.Text != null)
            {
                string strTranslatedText = null;
                try
                {
                    TranslatorService.LanguageServiceClient client = new TranslatorService.LanguageServiceClient();
                    client = new TranslatorService.LanguageServiceClient();
                    strTranslatedText = client.Translate("6CE9C85A41571C050C379F60DA173D286384E0F2", txbSource.Text, LanguageEnumToIdentifier(cmbSource), LanguageEnumToIdentifier(cmbDest));
                    txbDestination.Text = strTranslatedText;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        #region Private methods

        /// <summary>
        /// Converts a language to its identifier.
        /// </summary>
        /// <param name="language">The language."</param>
        /// <returns>The identifier or <see cref="string.Empty"/> if none.</returns>
        private string LanguageEnumToIdentifier(ComboBox comboBox)
        {
            string mode = "";

            //try
            //{
            //    if (comboBox.SelectedItem.ToString() != null)
            Language.TryGetValue("English", out mode);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            return mode;
        }

        /// <summary>
        /// Ensures the translator has been initialized.
        /// </summary>
        private void Initialized(ComboBox comboBox)
        {
            foreach (KeyValuePair<string, string> item in Language)
            {
                comboBox.Items.Add(item.Key.ToString());
                //MessageBox.Show(item.Key.ToString());
            }

            //MessageBox.Show("s");
        }

        #endregion

        private void Translator_Load(object sender, EventArgs e)
        {
            Language.Add("Afrikaans", "af");
            Language.Add("Albanian", "sq");
            Language.Add("Arabic", "ar");
            Language.Add("Armenian", "hy");
            Language.Add("Azerbaijani", "az");
            Language.Add("Basque", "eu");
            Language.Add("Belarusian", "be");
            Language.Add("Bengali", "bn");
            Language.Add("Bulgarian", "bg");
            Language.Add("Catalan", "ca");
            Language.Add("Chinese", "zh-CN");
            Language.Add("Croatian", "hr");
            Language.Add("Czech", "cs");
            Language.Add("Danish", "da");
            Language.Add("Dutch", "nl");
            Language.Add("English", "en");
            Language.Add("Esperanto", "eo");
            Language.Add("Estonian", "et");
            Language.Add("Filipino", "tl");
            Language.Add("Finnish", "fi");
            Language.Add("French", "fr");
            Language.Add("Galician", "gl");
            Language.Add("German", "de");
            Language.Add("Georgian", "ka");
            Language.Add("Greek", "el");
            Language.Add("Haitian Creole", "ht");
            Language.Add("Hebrew", "iw");
            Language.Add("Hindi", "hi");
            Language.Add("Hungarian", "hu");
            Language.Add("Icelandic", "is");
            Language.Add("Indonesian", "id");
            Language.Add("Irish", "ga");
            Language.Add("Italian", "it");
            Language.Add("Japanese", "ja");
            Language.Add("Korean", "ko");
            Language.Add("Lao", "lo");
            Language.Add("Latin", "la");
            Language.Add("Latvian", "lv");
            Language.Add("Lithuanian", "lt");
            Language.Add("Macedonian", "mk");
            Language.Add("Malay", "ms");
            Language.Add("Maltese", "mt");
            Language.Add("Norwegian", "no");
            Language.Add("Persian", "fa");
            Language.Add("Polish", "pl");
            Language.Add("Portuguese", "pt");
            Language.Add("Romanian", "ro");
            Language.Add("Russian", "ru");
            Language.Add("Serbian", "sr");
            Language.Add("Slovak", "sk");
            Language.Add("Slovenian", "sl");
            Language.Add("Spanish", "es");
            Language.Add("Swahili", "sw");
            Language.Add("Swedish", "sv");
            Language.Add("Tamil", "ta");
            Language.Add("Telugu", "te");
            Language.Add("Thai", "th");
            Language.Add("Turkish", "tr");
            Language.Add("Ukrainian", "uk");
            Language.Add("Urdu", "ur");
            Language.Add("Vietnamese", "vi");
            Language.Add("Welsh", "cy");
            Language.Add("Yiddish", "yi");
        }

        private void cmbSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSource.Text != null)
                button1_Click(sender, e);
        }

        private void cmbDest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSource.Text != null)
                button1_Click(sender, e);
        }
    }
}
