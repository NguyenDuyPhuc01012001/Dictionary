using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Net.Http;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Từ_điển
{
    public partial class MainForm : Form
    {
        bool IsShowCmbLike = false;
        bool IsShowCmbHistory = false;
        bool IsShowIrrVerb = false;
        bool IsShowToolStripSetting = false;

        public MainForm()
        {
            InitializeComponent();

            Control.CheckForIllegalCrossThreadCalls = false;
        }

        #region Speak
        SpeechSynthesizer voice = new SpeechSynthesizer();

        private void btnSpeakEnglish_Click(object sender, EventArgs e)
        {
            if (cmbLanguage.SelectedIndex == 0)
            {
                voice.SpeakAsync(cbWord.Text);
                return;
            }
            if (cmbLanguage.SelectedIndex == 1)
            {
                String payload = cbTu.Text;
                if (payload.Length < 5)
                    payload = "    " + payload;
                try
                {
                    String result = Task.Run(async () =>
                    {
                        HttpClient client = new HttpClient();
                        client.DefaultRequestHeaders.Add("api-key", "IyNOVYUO3CGiRTMKzP1empfmrk3dSXfE");
                        client.DefaultRequestHeaders.Add("speed", "-1");
                        client.DefaultRequestHeaders.Add("voice", "linhsan");
                        client.DefaultRequestHeaders.Add("callback_url", "");
                        var response = await client.PostAsync("https://api.fpt.ai/hmi/tts/v5", new StringContent(payload));
                        return await response.Content.ReadAsStringAsync();
                    }).GetAwaiter().GetResult();

                    var json = JsonConvert.DeserializeObject<SpeechJSon.root>(result);
                    SpeechJSon.root output = json;

                    string url = string.Format("{0}", output.async);

                    WindowsMediaPlayer sound = new WindowsMediaPlayer();
                    sound.URL = url;
                    sound.controls.play();
                }
                catch (System.Net.Http.HttpRequestException)
                {
                    MessageBox.Show("Hãy kết nối mạng trước khi sử dụng tính năng này.");
                }
            }
        }
        #endregion

        #region Search
        private void SelectedIndexChanged(ComboBox comboBox)
        {
            btnLike.BackgroundImage = Properties.Resources.NotLike;

            if (comboBox.SelectedItem != null)
            {
                rTxbExplan.Text = comboBox.SelectedItem.ToString();
                if (cmbHistory.Items.Count > 0)
                    ReverseCombobox(cmbHistory);
                if (cmbHistory.Items.Contains(comboBox.SelectedItem))
                    cmbHistory.Items.Remove(comboBox.SelectedItem);
                cmbHistory.Items.Add(comboBox.SelectedItem);
                ReverseCombobox(cmbHistory);
                LoadHightLightData("HightLight.txt");
            }

            for (int i = 0; i < cmbLike.Items.Count; i++)
            {

                String substringCmBLike = cmbLike.Items[i].ToString().Split('\r')[0];
                String substringComboBox = comboBox.Text.Split('\r')[0];

                if (substringCmBLike == substringComboBox)
                {
                    btnLike.BackgroundImage = Properties.Resources.Like;
                    cmbLike.Text = substringComboBox;

                }
            }
        }

        private void Search(object sender, EventArgs e)
        {
            if (cmbLanguage.SelectedIndex.ToString() == "0")
                SelectedIndexChanged(cbWord);
            if (cmbLanguage.SelectedIndex.ToString() == "1")
                SelectedIndexChanged(cbTu);
        }

        private void cmbHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            rTxbExplan.Text = cmbHistory.SelectedItem.ToString();
            LoadHightLightData("HightLight.txt");
        }

        private void btnSearchImage_Click(object sender, EventArgs e)
        {
            Process.Start("https://google.com.vn/search?q=" + cbWord.Text + "&tbm=isch");
        }
        #endregion

        #region Format
        private void LoadData(string Path, ComboBox comboBox, bool IsLoading)
        {
            new Thread(
                () =>
                {
                    lblLoading.Show();
                    pictureBox1.Show();
                    try
                    {
                        string line = "";

                        //tạo 1 đối tượng luồng đọc để đọc file 
                        StreamReader streamReader = new StreamReader(Path);
                        //mỗi lần đọc 1 dòng trên file text và nếu đọc được sẽ lưu vào chuỗi line
                        while ((line = streamReader.ReadLine()) != null)
                        {
                            DictionaryData word = new DictionaryData();

                            word.Key = line;
                            //đọc thêm dòng để lấy nghĩa
                            while ((line = streamReader.ReadLine()) != null)
                            {
                                if (line == "")
                                    break;
                                word.Explanation += line + "\r\n";
                            }
                            comboBox.Items.Add(word);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    if (IsLoading)
                    {
                        lblLoading.Hide();
                        pictureBox1.Hide();
                        MessageBox.Show("Dữ liệu đã được tải lên thành công ✓", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    }
                }
                )
            { IsBackground = true }.Start();
        }

        private void LoadHightLightData(string Path)
        {
            new Thread(
                () =>
                {
                    try
                    {
                        string line = "", start, end;
                        int ColorX, ColorY, ColorZ;
                        //tạo 1 đối tượng luồng đọc để đọc file 
                        StreamReader streamReader = new StreamReader(Path);
                        //mỗi lần đọc 1 dòng trên file text và nếu đọc được sẽ lưu vào chuỗi line
                        while ((line = streamReader.ReadLine()) != null)
                        {
                            start = line;
                            end = streamReader.ReadLine();
                            if (end == @"\n")
                                end = "\n";
                            ColorX = int.Parse(streamReader.ReadLine());
                            ColorY = int.Parse(streamReader.ReadLine());
                            ColorZ = int.Parse(streamReader.ReadLine());
                            HighlightPhrase(rTxbExplan, start, end, Color.FromArgb(ColorX, ColorY, ColorZ));
                            streamReader.ReadLine();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    }
                }
                )
            { IsBackground = true }.Start();
        }

        static void HighlightPhrase(RichTextBox box, string begin, string end, Color color)
        {
            string s = box.Text;
            for (int ix = 0; ix < s.Length;)
            {
                int jx = s.IndexOf(begin, ix);
                if (jx < 0)
                    break;
                int kx = s.IndexOf(end, jx);
                if (kx < 0)
                    kx = jx;
                box.SelectionStart = jx;
                box.SelectionLength = kx - jx;
                box.SelectionColor = color;
                ix = kx + 1;
            }
        }

        private void ReverseCombobox(ComboBox combo)
        {
            List<DictionaryData> dictionaries = new List<DictionaryData>();
            int max = cmbHistory.Items.Count;

            foreach (DictionaryData item in cmbHistory.Items)
            {
                dictionaries.Add(item);
            }
            dictionaries.Reverse();
            cmbHistory.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                if (i > max)
                    return;
                try
                {
                    cmbHistory.Items.Add(dictionaries[i]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        #endregion

        #region Like
        private void btnLike_Click(object sender, EventArgs e)
        {
            if (ImageCompareArray((Bitmap)btnLike.BackgroundImage, Properties.Resources.NotLike))
            {
                if (cmbLanguage.SelectedIndex.ToString() == "0")
                    Like(cbWord);
                if (cmbLanguage.SelectedIndex.ToString() == "1")
                    Like(cbTu);
                btnLike.BackgroundImage = Properties.Resources.Like;
            }
            else
                if (ImageCompareArray((Bitmap)btnLike.BackgroundImage, Properties.Resources.Like))
            {
                if (cmbLanguage.SelectedIndex.ToString() == "0")
                    Dislike(cbWord);
                if (cmbLanguage.SelectedIndex.ToString() == "1")
                    Dislike(cbTu);
                btnLike.BackgroundImage = Properties.Resources.NotLike;
            }
        }

        private bool ImageCompareArray(Bitmap firstImage, Bitmap secondImage)
        {
            bool flag = true;
            string firstPixel;
            string secondPixel;

            if (firstImage.Width == secondImage.Width && firstImage.Height == secondImage.Height)
            {
                for (int i = 100; i < 200; i++)
                {
                    for (int j = 100; j < 200; j++)
                    {
                        firstPixel = firstImage.GetPixel(i, j).ToString();
                        secondPixel = secondImage.GetPixel(i, j).ToString();
                        if (firstPixel != secondPixel)
                        {
                            flag = false;
                            break;
                        }
                    }
                }

                if (flag)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            IsShowCmbLike = !IsShowCmbLike;
            if (IsShowCmbLike)
            {
                cmbLike.Show();
                cmbLanguage.Hide();
                cmbHistory.Hide();
                IsShowCmbHistory = false;
            }
            else
            {
                cmbLike.Hide();
                cmbLanguage.Show();
            }
        }

        #endregion

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (toolStripCmbLanguage.SelectedItem == "Vietnamese")
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                {
                    e.Cancel = true;
                    return;
                }
            }
            else
            {
                if (MessageBox.Show("Do you want to exit?", "Notification", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                {
                    e.Cancel = true;
                    return;
                }
            }
            Output(cmbHistory, "History.txt");
            Output(cmbLike, "Favorite.txt");
            voice.SpeakAsyncCancelAll();
        }

        private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLanguage.SelectedIndex == 0)
            {
                cbWord.Show();
                cbTu.Hide();
                cbWord.Text = "";
            }
            else
            {
                cbTu.Show();
                cbWord.Hide();
                cbTu.Text = "";
            }
        }

        private void Output(ComboBox comboBox, string FilePath)
        {
            FileStream fs = new FileStream(FilePath, FileMode.Create);
            StreamWriter writer = new StreamWriter(fs, Encoding.UTF8);
            foreach (var item in comboBox.Items)
                writer.WriteLine(item);
            writer.Flush();
            fs.Close();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            IsShowCmbHistory = !IsShowCmbHistory;
            if (IsShowCmbHistory)
            {
                cmbHistory.Show();
                cmbLanguage.Hide();
                cmbLike.Hide();
                IsShowCmbLike = false;
            }
            else
            {
                cmbHistory.Hide();
                cmbLanguage.Show();
            }
        }

        private void Like(ComboBox comboBox)
        {
            if (comboBox.SelectedItem != null)
            {
                if (cmbLike.Items.Count > 0)
                    ReverseCombobox(cmbLike);
                if (cmbLike.Items.Contains(comboBox.SelectedItem))
                    cmbLike.Items.Remove(comboBox.SelectedItem);
                cmbLike.Items.Add(comboBox.SelectedItem);
                ReverseCombobox(cmbLike);
            }
        }

        private void Dislike(ComboBox comboBox)
        {
            if (comboBox.SelectedItem != null)
            {
                if (cmbLike.Items.Contains(comboBox.SelectedItem))
                {
                    cmbLike.Items.Remove(comboBox.SelectedItem);
                }
            }
        }

        private void btnHDSD_Click(object sender, EventArgs e)
        {
            string line = "";
            string HDSD = "";
            //tạo 1 đối tượng luồng đọc để đọc file 
            StreamReader streamReader = new StreamReader("HDSD.txt");
            while ((line = streamReader.ReadLine()) != null)
            {
                HDSD += line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    if (line == "")
                        break;
                    HDSD += "\r\n" + line;
                }
                HDSD += "\r\n";
            }
            rTxbExplan.Text = HDSD;
        }

        private void btnIrrVerbs_Click(object sender, EventArgs e)
        {
            PopularWords popularWords = new PopularWords();
            popularWords.Show();
        }

        private void btnTranslator_Click(object sender, EventArgs e)
        {
            TranslatorForm form = new TranslatorForm();
            form.Show();
        }

        private void cmbLike_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnLike.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Like));
            rTxbExplan.Text = cmbLike.SelectedItem.ToString();
            LoadHightLightData("HightLight.txt");
        }

        private void btnSearchOnline_Click(object sender, EventArgs e)
        {
            if (cmbOnline.SelectedItem == "vdict")
            {
                if (cmbLanguage.SelectedIndex == 0)
                    Process.Start("https://vdict.com/" + cbWord.Text + ",1,0,0.html");
                else
                    Process.Start("https://vdict.com/" + cbTu.Text + ",2,0,0.html");
            }
            if (cmbOnline.SelectedItem == "soha")
            {
                if (cmbLanguage.SelectedIndex == 0)
                    Process.Start("http://tratu.soha.vn/dict/en_vn/" + cbWord.Text);
                else
                    Process.Start("http://tratu.soha.vn/dict/vn_en/" + cbTu.Text);
            }
            if (cmbOnline.SelectedItem == "vndic")
            {
                if (cmbLanguage.SelectedIndex == 0)
                    Process.Start("http://3.vndic.net/index.php?word=" + cbWord.Text + "&dict=en_vi");
                else
                    Process.Start("http://3.vndic.net/index.php?word=" + cbTu.Text + "&dict=vi_en");
            }
            if (cmbOnline.SelectedItem == "Oxford")
            {
                if (cmbLanguage.SelectedIndex == 0)
                    Process.Start("https://www.oxfordlearnersdictionaries.com/definition/english/" + cbWord.Text + "? q=" + cbWord.Text);
                else
                    MessageBox.Show("Ngôn ngữ không hỗ trợ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (cmbOnline.SelectedItem == "laban")
            {
                if (cmbLanguage.SelectedIndex == 0)
                    Process.Start("https://dict.laban.vn/find?type=1&query=" + cbWord.Text);
                else
                    Process.Start("https://dict.laban.vn/find?type=2&query=" + cbTu.Text);
            }
            if (cmbOnline.SelectedItem == "Cambridge")
            {
                if (cmbLanguage.SelectedIndex == 0)
                    Process.Start("https://dictionary.cambridge.org/dictionary/english/" + cbWord.Text);
                else
                    MessageBox.Show("Ngôn ngữ không hỗ trợ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            #region LoadData
            LoadData("AnhViet.txt", cbWord, true);
            LoadData("VietAnh.txt", cbTu, false);
            LoadData("History.txt", cmbHistory, false);
            LoadData("Favorite.txt", cmbLike, false);
            foreach (FontFamily font in FontFamily.Families)
                toolStripCmbFont.Items.Add(font.Name);
            #endregion

            #region Init
            cbWord.DisplayMember = "Key";                       //set display of cbWord
            cmbHistory.DisplayMember = "Key";                   //set display of cbHistory
            cmbLike.DisplayMember = "Key";                      //set display of cbLike
            cbTu.DisplayMember = "Key";                         //set display of cbTu
            cmbLanguage.SelectedIndex = 0;                      //set language
            toolStripCmbFont.SelectedItem = "Times New Romans"; //set font
            toolStripCmbSize.Text = "13";                       //set size    
            toolStripCmbLanguage.SelectedIndex = 0;             //set language
            cmbOnline.SelectedIndex = 0;                        //set online dictionary

            cmbLike.Hide();
            cmbHistory.Hide();
            #endregion

            #region InvisibleBorder
            btnLike.FlatAppearance.BorderSize = 0;
            btnSearchImage.FlatAppearance.BorderSize = 0;
            btnSpeakEnglish.FlatAppearance.BorderSize = 0;
            btnSearchOnline.FlatAppearance.BorderSize = 0;
            #endregion

            #region Setting Panel
            Pnl1.Location = new Point(0, 0);
            Pnl1.Height = this.Height;
            Pnl2.Location = new Point(Pnl1.Width, 0);
            Pnl2.Width = this.Width - Pnl1.Width;
            Pnl2.Height = this.Height;
            #endregion  
        }

        private void toolStripCmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmbLanguage.SelectedIndex;

            if (toolStripCmbLanguage.SelectedItem == "Vietnamese")
            {
                btnFavorite.Text = "Từ yêu thích";
                btnHistory.Text = "Lịch sử tra từ";
                btnHDSD.Text = "Hướng dẫn dùng";
                btnTranslator.Text = "Dịch văn bản";
                btnPop.Text = "Từ phổ biến";
                toolStripCmbLanguage.Text = "Tiếng Việt";
                cmbLanguage.Items.Clear();
                cmbLanguage.Items.Add("Anh - Việt");
                cmbLanguage.Items.Add("Việt - Anh");
                cmbLanguage.SelectedIndex = index;
                lblLoading.Text = "Đang tải dữ liệu. Vui lòng chờ!";
            }
            else
            {
                btnFavorite.Text = "Favorite";
                btnHistory.Text = "History";
                btnHDSD.Text = "How to use ?";
                btnTranslator.Text = "Translator";
                btnPop.Text = "Popular Words";
                toolStripCmbLanguage.Text = "English";
                cmbLanguage.Items.Clear();
                cmbLanguage.Items.Add("Eng - Vie");
                cmbLanguage.Items.Add("Vie - Eng");
                cmbLanguage.SelectedIndex = index;
                lblLoading.Text = "Loading data. Please wait!";
            }
        }

        private void ChangeFontSize(object sender, EventArgs e)
        {
            try
            {
                if (toolStripCmbFont.Text != "" && toolStripCmbSize.Text != "")
                {
                    rTxbExplan.Font = new Font(toolStripCmbFont.Text, int.Parse(toolStripCmbSize.Text));
                    LoadHightLightData("HightLight.txt");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}