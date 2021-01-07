using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Từ_điển
{
    public partial class PopularWords : Form
    {
        bool IsToeic = false;
        bool IsToefl = false;
        bool IsIelts = false;
        bool IsOxford = false;
        bool IsIrrVerbs = false;

        public PopularWords()
        {
            InitializeComponent();

            cboWord.DisplayMember = "Key";

            cboWord.Hide();
            btnAfter.Hide();
            btnBefore.Hide();
            picExample.Hide();
            txtMeaning.Hide();
            dvwIrrVerbs.Hide();
        }

        /// <summary>
        /// Load picture form file 
        /// </summary>
        private void LoadPicture()
        {
            Image img = null;
            try
            {
                string filename = null;
                string name = cboWord.Text.ToString().Split('/')[0];
                if (name.EndsWith(" N"))
                    name = name.Substring(0, name.Length - 2);
                if (IsToeic)
                    filename = @"TOEIC\" + name + ".jpg";
                if (IsToefl)
                    filename = @"TOEFL\" + name + ".jpg";
                if (IsIelts)
                    filename = @"IELTS\" + name + ".jpg";
                if (IsOxford)
                    filename = @"OXFORD\" + name + ".jpg";
                img = Image.FromFile(filename);
            }
            catch (FileNotFoundException)
            {
                img = Properties.Resources.Help;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                picExample.Image = img;
            }
        }

        private void LoadData(string Path, ComboBox comboBox)
        {
            cboWord.Items.Clear();
            new Thread(
                () =>
                {
                    ;
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
                }
                )
            { IsBackground = true }.Start();
        }

        /// <summary>
        /// Search word in comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboWord.SelectedItem != null)
                {
                    if (cboWord.SelectedIndex == 0)
                        btnBefore.Hide();
                    else
                        btnBefore.Show();
                    if (cboWord.SelectedIndex == cboWord.Items.Count - 1)
                        btnAfter.Hide();
                    else
                        btnAfter.Show();
                    txtMeaning.Text = cboWord.SelectedItem.ToString();

                    LoadPicture();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Show previous word
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBefore_Click(object sender, EventArgs e)
        {
            try
            {
                cboWord.SelectedIndex = cboWord.SelectedIndex - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Show next word
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAfter_Click(object sender, EventArgs e)
        {
            try
            {
                cboWord.SelectedIndex = cboWord.SelectedIndex + 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Load 600 words TOEIC to comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnToeic_Click(object sender, EventArgs e)
        {
            try
            {
                IsToeic = !IsToeic;
                if (IsToeic)
                {
                    LoadData("TOEIC.txt", cboWord);

                    #region Show
                    cboWord.Show();
                    btnAfter.Show();
                    btnBefore.Show();
                    picExample.Show();
                    txtMeaning.Show();
                    #endregion

                    #region Another btn change to false
                    IsOxford = false;
                    IsToefl = false;
                    IsIrrVerbs = false;
                    IsIelts = false;
                    #endregion

                    dvwIrrVerbs.Hide();
                }
                else
                {
                    cboWord.Hide();
                    btnAfter.Hide();
                    btnBefore.Hide();
                    picExample.Hide();
                    txtMeaning.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        /// <summary>
        /// Load 900 words TOEFL to comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnToefl_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            IsToefl = !IsToefl;
            if (IsToefl)
            {
                LoadData("TOEFL.txt", cboWord);

                #region Show
                cboWord.Show();
                btnAfter.Show();
                btnBefore.Show();
                picExample.Show();
                txtMeaning.Show();
                #endregion

                #region Another btn change to false
                IsOxford = false;
                IsToeic = false;
                IsIrrVerbs = false;
                IsIelts = false;
                #endregion

                dvwIrrVerbs.Hide();
            }
            else
            {
                cboWord.Hide();
                btnAfter.Hide();
                btnBefore.Hide();
                picExample.Hide();
                txtMeaning.Hide();
            }
        }

        /// <summary>
        /// Load 900 words IELTS to comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIelts_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            IsIelts = !IsIelts;
            if (IsIelts)
            {
                LoadData("IELTS.txt", cboWord);

                #region Show
                cboWord.Show();
                btnAfter.Show();
                btnBefore.Show();
                picExample.Show();
                txtMeaning.Show();
                #endregion

                #region Another btn change to false
                IsOxford = false;
                IsToeic = false;
                IsIrrVerbs = false;
                IsToefl = false;
                #endregion

                dvwIrrVerbs.Hide();
            }
            else
            {
                cboWord.Hide();
                btnAfter.Hide();
                btnBefore.Hide();
                picExample.Hide();
                txtMeaning.Hide();
            }
        }

        /// <summary>
        /// Load 3000 words OXFORD to comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOxford_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            IsOxford = !IsOxford;
            if (IsOxford)
            {
                LoadData("OXFORD.txt", cboWord);

                #region Show
                cboWord.Show();
                btnAfter.Show();
                btnBefore.Show();
                picExample.Show();
                txtMeaning.Show();
                #endregion

                #region Another btn change to false
                IsIelts = false;
                IsToeic = false;
                IsIrrVerbs = false;
                IsToefl = false;
                #endregion

                dvwIrrVerbs.Hide();
            }
            else
            {
                cboWord.Hide();
                btnAfter.Hide();
                btnBefore.Hide();
                picExample.Hide();
                txtMeaning.Hide();
            }
        }

        /// <summary>
        /// Show irregular verbs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIrrVerbs_Click(object sender, EventArgs e)
        {
            try
            {
                IsIrrVerbs = !IsIrrVerbs;
                if (IsIrrVerbs)
                {
                    dvwIrrVerbs.Show();
                    LoadDataToDvwIrrVerbs("BQT_en.txt", dvwIrrVerbs);
                    #region Hide others method
                    cboWord.Hide();
                    btnAfter.Hide();
                    btnBefore.Hide();
                    picExample.Hide();
                    txtMeaning.Hide();
                    #endregion
                }
                else
                {
                    dvwIrrVerbs.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void LoadDataToDvwIrrVerbs(string Path, DataGridView dataGrid)
        {
            new Thread(
                () =>
                {
                    try
                    {
                        //dataGrid.PerformLayout();
                        string line = "";

                        //tạo 1 đối tượng luồng đọc để đọc file 
                        StreamReader streamReader = new StreamReader(Path);
                        //mỗi lần đọc 1 dòng trên file text và nếu đọc được sẽ lưu vào chuỗi line
                        while ((line = streamReader.ReadLine()) != null)
                        {
                            string baseWord = line;
                            string Vp = streamReader.ReadLine();
                            string Vpp = streamReader.ReadLine();
                            string def = streamReader.ReadLine();

                            while ((line = streamReader.ReadLine()) != null)
                            {
                                if (line == "")
                                    break;
                                def += Environment.NewLine + line;
                            }
                            dataGrid.Rows.Add(baseWord, Vp, Vpp, def);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                )
            { IsBackground = true }.Start();
        }
    }
}