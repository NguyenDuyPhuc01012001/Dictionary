using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Speech.Synthesis;
using System.Threading;
using System.Windows.Forms;

namespace Từ_điển
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer voice = new SpeechSynthesizer();
        public Form1()
        {
            InitializeComponent();

            Control.CheckForIllegalCrossThreadCalls = false;

            cbWord.DisplayMember = "Key";   //set display of cbWord
            cmbLanguage.SelectedIndex = 0;  //set language
            cmbSpeed.SelectedItem = "0";    //set speed
            cmbVolume.SelectedItem = "80";  //set volume
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
                return;
            }
            voice.SpeakAsyncCancelAll();
            //dictionary.Serialize();
        }

        private void cbWord_SelectedIndexChanged(object sender, EventArgs e)
        {
            rTxbExplan.Text = cbWord.SelectedItem.ToString();
            HighlightPhrase(rTxbExplan, "*", "\n", Color.Green);
            HighlightPhrase(rTxbExplan, "VD:", "-->", Color.Red);
            HighlightPhrase(rTxbExplan, "Ex:", "-->", Color.Red);
            HighlightPhrase(rTxbExplan, "~", "\n", Color.Magenta);
        }

        private void btnSpeakEnglish_Click(object sender, EventArgs e)
        {
            voice.SpeakAsync(cbWord.Text);
        }

        private void btnSearchImage_Click(object sender, EventArgs e)
        {
            Process.Start("https://google.com.vn/search?q=" + cbWord.Text + "&tbm=isch");
        }

        private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLanguage.SelectedIndex.ToString() == "0")
            {
                LoadData("anhviet.txt");
                btnSpeakEnglish.Enabled = true;
            }
            if (cmbLanguage.SelectedIndex.ToString() == "1")
            {
                LoadData("vietanh.txt");
                btnSpeakEnglish.Enabled = false;
            }
        }

        private void cmbVolume_SelectedIndexChanged(object sender, EventArgs e)
        {
            voice.Volume = int.Parse(cmbVolume.SelectedItem.ToString());
        }

        private void cmbSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            voice.Rate = int.Parse(cmbSpeed.SelectedItem.ToString());
        }

        private void LoadData(string Path)
        {
            new Thread(
                () =>
                {
                    string line = "";
                    List<DictionaryData> words = new List<DictionaryData>();

                    //tạo 1 đối tượng luồng đọc để đọc file 
                    System.IO.StreamReader streamReader = new System.IO.StreamReader(Path);
                    //mỗi lần đọc 1 dòng trên file text và nếu đọc được sẽ lưu vào chuỗi line
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        DictionaryData word = new DictionaryData();

                        word.Key = line;
                        //đọc thêm 1 dòng nữa để lấy nghĩa
                        while ((line = streamReader.ReadLine()) != null)
                        {
                            if (line == "")
                                break;
                            if (line.StartsWith("-"))
                                word.Explanation += "     ";
                            if (line.StartsWith("VD:"))
                                word.Explanation += "          ";
                            if (line.StartsWith("Ex:"))
                                word.Explanation += "          ";
                            word.Explanation += line + "\r\n";

                        }
                        words.Add(word);
                    }
                    words.Sort();
                    //bỏ danh sách word vào source của combobox để hiển thị
                    cbWord.DataSource = words;
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
    }
}
