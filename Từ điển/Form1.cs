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
        }
        private void LoadData(string Path)
        {
            //Đa luồng
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
                            //\r và \n để xuống hàng
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

        private void btnSearchImage_Click(object sender, EventArgs e)
        {
            Process.Start("https://google.com.vn/search?q=" + cbWord.Text + "&tbm=isch");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData("anhviet.txt");

        }

        private void cbWord_SelectedIndexChanged(object sender, EventArgs e)
        {
            rTxbExplan.Text = cbWord.SelectedItem.ToString();
        }
    }
}
