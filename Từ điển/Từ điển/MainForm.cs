using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Từ_điển
{
    public partial class MainForm : Form
    {
        bool IsShowCmbLike = false;
        bool IsShowCmbHistory = false;
        bool IsShowIrrVerb = false;

        public MainForm()
        {
            InitializeComponent();

            Control.CheckForIllegalCrossThreadCalls = false;

            #region LoadData
            LoadData("AnhViet.txt", cbWord, true);
            LoadData("VietAnh.txt", cbTu, false);
            LoadData("History.txt", cmbHistory, false);
            LoadData("Favorite.txt", cmbLike, false);            
            #endregion

            #region Init
            cbWord.DisplayMember = "Key";   //set display of cbWord
            cmbHistory.DisplayMember = "Key";
            cmbLike.DisplayMember = "Key";
            cbTu.DisplayMember = "Key";   //set display of cbWord
            cmbLanguage.SelectedIndex = 0;  //set language
            //cmbSpeed.SelectedItem = "0";    //set speed
            //cmbVolume.SelectedItem = "80";  //set volume

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

        #region Speak
        SpeechSynthesizer voice = new SpeechSynthesizer();

        private void btnSpeakEnglish_Click(object sender, EventArgs e)
        {
            voice.SpeakAsync(cbWord.Text);
        }

        private void cmbVolume_SelectedIndexChanged(object sender, EventArgs e)
        {
            //voice.Volume = int.Parse(cmbVolume.SelectedItem.ToString());
        }

        private void cmbSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            //voice.Rate = int.Parse(cmbSpeed.SelectedItem.ToString());
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
                    label1.Show();
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
                                //if (line.StartsWith("-"))
                                //    word.Explanation += "     ";
                                //if (line.StartsWith("VD:"))
                                //    word.Explanation += "          ";
                                //if (line.StartsWith("Ex:"))
                                //    word.Explanation += "          ";
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
                        label1.Hide();
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
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
                return;
            }
            //Output(cbWord,"AnhViet.txt");
            //Output(cbTu, "VietAnh.txt");
            Output(cmbHistory, "History.txt");
            Output(cmbLike, "Favorite.txt");
            voice.SpeakAsyncCancelAll();
        }

        private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLanguage.SelectedIndex.ToString() == "0")
            {
                cbWord.Show();
                cbTu.Hide();
                cbWord.Text = "";
                btnSpeakEnglish.Enabled = true;
            }
            if (cmbLanguage.SelectedIndex.ToString() == "1")
            {
                cbTu.Show();
                cbWord.Hide();
                cbTu.Text = "";
                btnSpeakEnglish.Enabled = false;
            }
        }

        private void Output(ComboBox comboBox, string FilePath)
        {
            FileStream fs = new FileStream(FilePath, FileMode.Create);
            StreamWriter writer = new StreamWriter(fs, Encoding.UTF8);
            //for (int j = 0; j < dgvInfo.Rows.Count; j++)
            //{
            //    writer.WriteLine(dgvInfo.Rows[j].Cells[0].Value);
            //    writer.WriteLine(dgvInfo.Rows[j].Cells[1].Value);
            //    writer.WriteLine(dgvInfo.Rows[j].Cells[2].Value);
            //    writer.WriteLine(dgvInfo.Rows[j].Cells[3].Value);
            //    writer.WriteLine(dgvInfo.Rows[j].Cells[4].Value);
            //    writer.WriteLine();
            //}
            //cbWord.Items
            foreach (var item in comboBox.Items)
            {
                writer.WriteLine(item);
                //writer.WriteLine();
            }
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
                if(cmbLike.Items.Contains(comboBox.SelectedItem))
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
            //Dictionary
            Process.Start("https://www.dictionary.com/browse/" + cbWord.Text);
            //TheFreeDict
            Process.Start("https://www.thefreedictionary.com/" + cbWord.Text);
            //UrbanDictionary
            Process.Start("https://www.urbandictionary.com/define.php?term=" + cbWord.Text);
            //OneLook
            Process.Start("https://www.onelook.com/?w=" + cbWord.Text+"&ls=a" );
            //Merriam-Webster
            Process.Start("https://www.merriam-webster.com/dictionary/" + cbWord.Text);
            //Oxford Dictionaries
            Process.Start("https://www.oxfordlearnersdictionaries.com/definition/english/" + cbWord.Text +"? q=" + cbWord.Text);
            //Dictionary Cambridge
            Process.Start("https://dictionary.cambridge.org/dictionary/english/" + cbWord.Text);
            //LongMan
            Process.Start("https://www.ldoceonline.com/dictionary/" + cbWord.Text);
        }
    }
}