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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Control.CheckForIllegalCrossThreadCalls = false;

            label1.Show();
            pictureBox1.Show();
            LoadData("av.txt", cbWord, true);
            LoadData("va.txt", cbTu, false);
            LoadData("History.txt", cmbHistory, false);
            label1.Hide();
            pictureBox1.Hide();

            cbWord.DisplayMember = "Key";   //set display of cbWord
            cmbHistory.DisplayMember = "Key";
            cmbLike.DisplayMember = "Key";
            cbTu.DisplayMember = "Key";   //set display of cbWord
            cmbLanguage.SelectedIndex = 0;  //set language
            cmbSpeed.SelectedItem = "0";    //set speed
            cmbVolume.SelectedItem = "80";  //set volume

            //btnLike.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent
            btnLike.FlatAppearance.BorderSize = 0;
            btn1.FlatAppearance.BorderSize = 0;
            btn2.FlatAppearance.BorderSize = 0;
            btn3.FlatAppearance.BorderSize = 0;
            btn4.FlatAppearance.BorderSize = 0;
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.White, Color.Blue, 90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        #region Speak
        SpeechSynthesizer voice = new SpeechSynthesizer();

        private void btnSpeakEnglish_Click(object sender, EventArgs e)
        {
            voice.SpeakAsync(cbWord.Text);
        }

        private void cmbVolume_SelectedIndexChanged(object sender, EventArgs e)
        {
            voice.Volume = int.Parse(cmbVolume.SelectedItem.ToString());
        }

        private void cmbSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            voice.Rate = int.Parse(cmbSpeed.SelectedItem.ToString());
        }
        #endregion

        #region Search
        private void SelectedIndexChanged(ComboBox comboBox)
        {
            if (comboBox.SelectedItem != null)
            {
                rTxbExplan.Text = comboBox.SelectedItem.ToString();
                if (cmbHistory.Items.Count > 0)
                    ReverseCombobox(cmbHistory);
                cmbHistory.Items.Add(comboBox.SelectedItem);
                ReverseCombobox(cmbHistory);
                LoadHightLightData("HightLight.txt");
            }
            i = false;
        }

        private void Search(object sender, EventArgs e)
        {
            if (cmbLanguage.SelectedIndex.ToString() == "0")
                SelectedIndexChanged(cbWord);
            if (cmbLanguage.SelectedIndex.ToString() == "1")
                SelectedIndexChanged(cbTu);
        }

        private void FindWord(object sender, EventArgs e)
        {
            if (cmbLanguage.SelectedIndex.ToString() == "0")
                FindWordInCb(cbWord);
            if (cmbLanguage.SelectedIndex.ToString() == "1")
                FindWordInCb(cbTu);
        }

        private void FindWordInCb(ComboBox comboBox)
        {
            //int i = comboBox.FindString(txbSearch.Text);
            //if (i > 0)
            //{
            //    comboBox.SelectedIndex = i;
            //    if (!cmbSearch.Items.Contains(comboBox.SelectedItem))
            //    {
            //        if (cmbSearch.Items.Count > 0)
            //            ReverseCombobox(cmbSearch);
            //        cmbSearch.Items.Add(comboBox.SelectedItem);
            //        ReverseCombobox(cmbSearch);
            //    }
            //}
            //else
            //    rTxbExplan.Text = "Không tìm thấy từ";
        }
        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            rTxbExplan.Text = cmbHistory.SelectedItem.ToString();
            LoadHightLightData("HightLight.txt");
            //txbSearch.Text = cmbSearch.Text;
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
                        string errorMsg = string.Format("An error has occured in {0}. \nException:\n{1}", "cbWord", ex.Message);
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
                        string errorMsg = string.Format("An error has occured in {0}. \nException:\n{1}", "cbWord", ex.Message);
                        MessageBox.Show(errorMsg, "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
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
                catch { }
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
            //Output(cbWord,"av.txt");
            //Output(cbTu, "va.txt");
            Output(cmbHistory, "History.txt");
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
            //if (cmbLanguage.SelectedIndex.ToString() == "2")
            //{
            //    cbWord.Items.Clear();
            //    LoadData("3000.txt");
            //    btnSpeakEnglish.Enabled = true;
            //}
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

        bool i = false;
        private void btnLike_Click(object sender, EventArgs e)
        {
            i = !i;
            Bitmap bitmap;
            if (i)
            {
                bitmap = (Bitmap)Image.FromFile("Like.png");
                if (cmbLanguage.SelectedIndex.ToString() == "0")
                    Like(cbWord);
                if (cmbLanguage.SelectedIndex.ToString() == "1")
                    Like(cbTu);

            }
            else
            {
                bitmap = (Bitmap)Image.FromFile("NotLike.png");
                if (cmbLanguage.SelectedIndex.ToString() == "0")
                    Dislike(cbWord);
                if (cmbLanguage.SelectedIndex.ToString() == "1")
                    Dislike(cbTu);
            }
            btnLike.BackgroundImage = bitmap;
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            cmbHistory.Hide();
            cmbLike.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            btnHistory.Show();
            cmbLike.Hide();
        }

        private void Like(ComboBox comboBox)
        {
            if (comboBox.SelectedItem != null)
            {
                if (cmbLike.Items.Count > 0)
                    ReverseCombobox(cmbLike);
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
    }
}