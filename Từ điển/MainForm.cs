using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
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
        public MainForm()
        {
            InitializeComponent();

            Control.CheckForIllegalCrossThreadCalls = false;            
        }

        #region Speak
        SpeechSynthesizer voice = new SpeechSynthesizer();
        /// <summary>
        /// Speak word in combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpeak_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboLanguage.SelectedIndex == 0)
                {
                    voice.SpeakAsync(cboWord.Text);
                    return;
                }
                else
                {
                    String payload = cboTu.Text;
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
                        if (tstrCboLanguage.SelectedIndex==1)
                        {
                            MessageBox.Show("Hãy kết nối mạng trước khi sử dụng tính năng này.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (tstrCboLanguage.SelectedIndex == 0)
                        {
                            MessageBox.Show("Please make sure you are connected to the internet", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        #endregion

        #region Search
        /// <summary>
        /// Search word in comboBox
        /// </summary>
        /// <param name="comboBox"></param> comboBox is using
        private void SelectedIndexChanged(ComboBox comboBox)
        {
            try
            {
                btnLike.BackgroundImage = Properties.Resources.NotLike;

                if (comboBox.SelectedItem != null)
                {
                    rtxtExplan.Text = comboBox.SelectedItem.ToString();
                    if (cboHistory.Items.Count > 0)
                        ReverseCombobox(cboHistory);
                    cboHistory.Items.Add(comboBox.SelectedItem);
                    ReverseCombobox(cboHistory);
                    LoadHightLightData("HightLight.txt");

                    for (int i = 0; i < cboFavorite.Items.Count; i++)
                    {
                        String substringCboLike = cboFavorite.Items[i].ToString().Split('\r')[1];
                        String substringComboBox = comboBox.SelectedItem.ToString().Split('\r')[1];

                        if (substringCboLike == substringComboBox)
                        {
                            btnLike.BackgroundImage = Properties.Resources.Like;
                            cboFavorite.Text = substringComboBox;
                        }
                    }
                    int max = cboHistory.Items.Count;
                    for (int i = 1; i < max; i++)
                    {
                        String substringCboHistory = cboHistory.Items[i].ToString().Split('\r')[1];
                        String substringComboBox = comboBox.SelectedItem.ToString().Split('\r')[1];

                        if (substringCboHistory == substringComboBox)
                        {
                            cboHistory.Items.RemoveAt(i);
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Search(object sender, EventArgs e)
        {
            try
            {
                if (cboLanguage.SelectedIndex == 0)
                    SelectedIndexChanged(cboWord);
                else
                    SelectedIndexChanged(cboTu);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Open browser and go to Google Image to search picture
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchImage_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://google.com.vn/search?q=" + cboWord.Text + "&tbm=isch");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Open browser and go to website had selected to search word
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchOnline_Click(object sender, EventArgs e)
        {
            try
            {
                if (tstrCboOnline.SelectedIndex == 0)
                {
                    if (cboLanguage.SelectedIndex == 0)
                        Process.Start("https://vdict.com/" + cboWord.Text + ",1,0,0.html");
                    else
                        Process.Start("https://vdict.com/" + cboTu.Text + ",2,0,0.html");
                }
                if (tstrCboOnline.SelectedIndex == 1)
                {
                    if (cboLanguage.SelectedIndex == 0)
                        Process.Start("http://tratu.soha.vn/dict/en_vn/" + cboWord.Text);
                    else
                        Process.Start("http://tratu.soha.vn/dict/vn_en/" + cboTu.Text);
                }
                if (tstrCboOnline.SelectedIndex == 2)
                {
                    if (cboLanguage.SelectedIndex == 0)
                        Process.Start("http://3.vndic.net/index.php?word=" + cboWord.Text + "&dict=en_vi");
                    else
                        Process.Start("http://3.vndic.net/index.php?word=" + cboTu.Text + "&dict=vi_en");
                }
                if (tstrCboOnline.SelectedIndex == 3)
                {
                    if (cboLanguage.SelectedIndex == 0)
                        Process.Start("https://www.oxfordlearnersdictionaries.com/definition/english/" + cboWord.Text + "? q=" + cboWord.Text);
                    else
                           MessageBox.Show("Ngôn ngữ không hỗ trợ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                   
                }
                if (tstrCboOnline.SelectedIndex == 4)
                {
                    if (cboLanguage.SelectedIndex == 0)
                        Process.Start("https://dict.laban.vn/find?type=1&query=" + cboWord.Text);
                    else
                        Process.Start("https://dict.laban.vn/find?type=2&query=" + cboTu.Text);
                }
                if (tstrCboOnline.SelectedIndex == 5)
                {
                    if (cboLanguage.SelectedIndex == 0)
                        Process.Start("https://dictionary.cambridge.org/dictionary/english/" + cboWord.Text);
                    else
                        MessageBox.Show("Ngôn ngữ không hỗ trợ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region Format
        /// <summary>
        /// Make new thread to load data from file to comboBox
        /// </summary>
        /// <param name="Path"></param>Path of file
        /// <param name="comboBox"></param>comboBox want to fill item
        /// <param name="IsLoading"></param>If false then hide loading, use for loading biggest file
        private void LoadData(string Path, ComboBox comboBox, bool IsLoading)
        {
            new Thread(
                () =>
                {
                    lblLoading.Show();
                    picLoading.Show();
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
                        picLoading.Hide();
                        if (tstrCboLanguage.SelectedIndex==1)
                            MessageBox.Show("Dữ liệu đã được tải lên thành công ✓", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        if(tstrCboLanguage.SelectedIndex==0)
                            MessageBox.Show("Data has been loaded sucessfully ✓", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    }
                }
                )
            { IsBackground = true }.Start();
        }

        /// <summary>
        /// Make new thread to load file HightLight to hightlight speacial word
        /// </summary>
        /// <param name="HightLightPath"></param>Path of file hightlight
        private void LoadHightLightData(string HightLightPath)
        {
            new Thread(
                () =>
                {
                    try
                    {
                        string line = "", start, end;
                        int ColorX, ColorY, ColorZ;

                        //tạo 1 đối tượng luồng đọc để đọc file 
                        StreamReader streamReader = new StreamReader(HightLightPath);
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

                            HighlightPhrase(rtxtExplan, start, end, Color.FromArgb(ColorX, ColorY, ColorZ));
                            streamReader.ReadLine();
                        }
                    }
                    catch (Exception ex)
                    {
                        if (tstrCboLanguage.SelectedIndex ==0)
                            MessageBox.Show(ex.Message, "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        if(tstrCboLanguage.SelectedIndex==1)
                            MessageBox.Show(ex.Message, "Ứng dụng bị lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    }
                }
                )
            { IsBackground = true }.Start();
        }

        void HighlightPhrase(RichTextBox box, string begin, string end, Color color)
        {
            try
            {
string str = box.Text;

            for (int i = 0; i < str.Length;)
            {
                int indexOfBegin = str.IndexOf(begin, i);
                if (indexOfBegin < 0)
                    break;
                int indexOfEnd = str.IndexOf(end, indexOfBegin);
                if (indexOfEnd < 0)
                    indexOfEnd = indexOfBegin;

                box.SelectionStart = indexOfBegin;
                box.SelectionLength = indexOfEnd - indexOfBegin;
                box.SelectionColor = color;
                i = indexOfEnd + 1;
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }            
        }

        /// <summary>
        /// New word on top of comboBox
        /// </summary>
        /// <param name="comboBox"></param>comboBox want to reverse
        private void ReverseCombobox(ComboBox comboBox)
        {
            try
            {
                List<DictionaryData> dictionaries = new List<DictionaryData>();
                int maxItemsComboBox = cboHistory.Items.Count;
                int maximumItems = 100;

                foreach (DictionaryData item in cboHistory.Items)
                    dictionaries.Add(item);
                dictionaries.Reverse();

                cboHistory.Items.Clear();
                for (int i = 0; i < maximumItems; i++)
                {
                    if (i >= maxItemsComboBox)
                        return;
                    cboHistory.Items.Add(dictionaries[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Save file 
        /// </summary>
        /// <param name="comboBox"></param>comboBox want to save
        /// <param name="filePath"></param>Path of file
        private void Output(ComboBox comboBox, string filePath)
        {
            try
            {
                FileStream fs = new FileStream(filePath, FileMode.Create);
                StreamWriter writer = new StreamWriter(fs, Encoding.UTF8);
                foreach (var item in comboBox.Items)
                    writer.WriteLine(item);
                writer.Flush();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region Like
        private void btnLike_Click(object sender, EventArgs e)
        {
            if (ImageCompareArray((Bitmap)btnLike.BackgroundImage, Properties.Resources.NotLike))
            {
                if (cboLanguage.SelectedIndex.ToString() == "0")
                    Like(cboWord);
                if (cboLanguage.SelectedIndex.ToString() == "1")
                    Like(cboTu);
                btnLike.BackgroundImage = Properties.Resources.Like;
            }
            else
                if (ImageCompareArray((Bitmap)btnLike.BackgroundImage, Properties.Resources.Like))
            {
                if (cboLanguage.SelectedIndex.ToString() == "0")
                    Dislike(cboWord);
                if (cboLanguage.SelectedIndex.ToString() == "1")
                    Dislike(cboTu);
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


        private void Like(ComboBox comboBox)
        {
            if (comboBox.SelectedItem != null)
            {
                if (cboFavorite.Items.Count > 0)
                    ReverseCombobox(cboFavorite);
                if (cboFavorite.Items.Contains(comboBox.SelectedItem))
                    cboFavorite.Items.Remove(comboBox.SelectedItem);
                cboFavorite.Items.Add(comboBox.SelectedItem);
                ReverseCombobox(cboFavorite);
            }
        }

        private void Dislike(ComboBox comboBox)
        {
            if (comboBox.SelectedItem != null)
            {
                if (cboFavorite.Items.Contains(comboBox.SelectedItem))
                {
                    cboFavorite.Items.Remove(comboBox.SelectedItem);
                }
            }
        }

        #endregion

        #region MainForm
        private void MainForm_Load(object sender, EventArgs e)
        {
            #region LoadData
            try
            {
                LoadData("AnhViet.txt", cboWord, true);
                LoadData("VietAnh.txt", cboTu, false);
                LoadData("History.txt", cboHistory, false);
                LoadData("Favorite.txt", cboFavorite, false);
                foreach (FontFamily font in FontFamily.Families)
                    tstrCboFont.Items.Add(font.Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            #endregion

            #region Init
            cboWord.DisplayMember = "Key";                //set display of cbWord
            cboHistory.DisplayMember = "Key";             //set display of cbHistory
            cboFavorite.DisplayMember = "Key";            //set display of cbLike
            cboTu.DisplayMember = "Key";                  //set display of cbTu
            cboLanguage.SelectedIndex = 0;                //set language
            tstrCboFont.SelectedItem = "Times New Roman"; //set font
            tstrCboSize.SelectedItem = "14";              //set size    
            tstrCboLanguage.SelectedIndex = 0;            //set language
            tstrCboOnline.SelectedIndex = 0;              //set online dictionary

            cboFavorite.Hide();
            cboHistory.Hide();
            #endregion

            #region InvisibleBorder
            btnLike.FlatAppearance.BorderSize = 0;
            btnSearchImage.FlatAppearance.BorderSize = 0;
            btnSpeak.FlatAppearance.BorderSize = 0;
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (tstrCboLanguage.SelectedIndex == 1)
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
                Output(cboHistory, "History.txt");
                Output(cboFavorite, "Favorite.txt");
                voice.SpeakAsyncCancelAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Alt)
                {
                    if (e.KeyCode.Equals(Keys.X))
                    {
                        cboTu.Text = "";
                        cboWord.Text = "";
                    }
                    if (e.KeyCode.Equals(Keys.Z))
                    {
                        this.WindowState = FormWindowState.Minimized;
                    }
                }
                if (e.Control)
                {
                    if (e.KeyCode.Equals(Keys.Q))
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region Method
        bool IsShowCmbLike = false;
        bool IsShowCmbHistory = false;

        /// <summary>
        /// Change language to find word
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboLanguage.SelectedIndex == 0)
                {
                    cboWord.Show();
                    cboTu.Hide();
                    cboWord.Text = "";
                }
                else
                {
                    cboTu.Show();
                    cboWord.Hide();
                    cboTu.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Show word in comboBox like
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbLike_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                btnLike.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Like));
                rtxtExplan.Text = cboFavorite.SelectedItem.ToString();
                LoadHightLightData("HightLight.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Show word in comboBox history
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                rtxtExplan.Text = cboHistory.SelectedItem.ToString();
                LoadHightLightData("HightLight.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Show or hide comboBox history
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHistory_Click(object sender, EventArgs e)
        {
            try
            {
                IsShowCmbHistory = !IsShowCmbHistory;
                if (IsShowCmbHistory)
                {
                    cboHistory.Show();
                    cboLanguage.Hide();
                    cboFavorite.Hide();
                    IsShowCmbLike = false;
                }
                else
                {
                    cboHistory.Hide();
                    cboLanguage.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Show or hide comboBox like
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFavorite_Click(object sender, EventArgs e)
        {
            try
            {
                IsShowCmbLike = !IsShowCmbLike;
                if (IsShowCmbLike)
                {
                    cboFavorite.Show();
                    cboLanguage.Hide();
                    cboHistory.Hide();
                    IsShowCmbHistory = false;
                }
                else
                {
                    cboFavorite.Hide();
                    cboLanguage.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Load file to introduce how to use this dictionary
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHDSD_Click(object sender, EventArgs e)
        {
            try
            {
                string line = "";
                string HDSD = "";
                //tạo 1 đối tượng luồng đọc để đọc file 
                StreamReader streamReader = new StreamReader("HDSD.txt");
                while ((line = streamReader.ReadLine()) != null)
                {
                    HDSD += line ;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        if (line == "")
                        {
                            HDSD += "\r\n";
                            break;
                        }
                        HDSD += "\r\n" + line;
                    }
                    HDSD += "\r\n";
                }
                rtxtExplan.Text = HDSD;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Show form PopularWord
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPop_Click(object sender, EventArgs e)
        {
            try
            {
                PopularWords popularWords = new PopularWords(tstrCboLanguage.SelectedIndex);
                popularWords.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Show form Translator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTranslator_Click(object sender, EventArgs e)
        {
            try
            {
                TranslatorForm form = new TranslatorForm();
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region Toolstrip
        /// <summary>
        /// Change language display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripCmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int index = cboLanguage.SelectedIndex;

                if (tstrCboLanguage.SelectedIndex == 1)
                {
                    btnFavorite.Text = "Từ yêu thích";
                    btnHistory.Text = "Lịch sử tra từ";
                    btnHDSD.Text = "Hướng dẫn";
                    btnTranslator.Text = "Dịch văn bản";
                    btnPop.Text = "Từ phổ biến";
                    tstrCboLanguage.Text = "Tiếng Việt";
                    cboLanguage.Items.Clear();
                    cboLanguage.Items.Add("Anh - Việt");
                    cboLanguage.Items.Add("Việt - Anh");
                    cboLanguage.SelectedIndex = index;
                    lblLoading.Text = "Đang tải dữ liệu. Vui lòng chờ!";
                }
                else if(tstrCboLanguage.SelectedIndex==0)
                {
                    btnFavorite.Text = "Favorite";
                    btnHistory.Text = "History";
                    btnHDSD.Text = "How to use ?";
                    btnTranslator.Text = "Translator";
                    btnPop.Text = "Popular Words";
                    tstrCboLanguage.Text = "English";
                    cboLanguage.Items.Clear();
                    cboLanguage.Items.Add("Eng - Vie");
                    cboLanguage.Items.Add("Vie - Eng");
                    cboLanguage.SelectedIndex = index;
                    lblLoading.Text = "Loading data. Please wait!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ChangeFontSize(object sender, EventArgs e)
        {
            float emSize;
            try
            {
                float.TryParse(tstrCboSize.Text, out emSize);
                rtxtExplan.Font = new Font(tstrCboFont.Text, emSize);
            }
            catch (ArgumentException)
            {
                emSize = 13;
                rtxtExplan.Font = new Font(tstrCboFont.Text, emSize);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType().ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {                
                LoadHightLightData("HightLight.txt");
            }
        }
        #endregion
    }
}