using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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

            cmbWord.DisplayMember = "Key";

            cmbWord.Hide();
            btnAfter.Hide();
            btnBefore.Hide();
            pictureBox1.Hide();
            txbMeaning.Hide();
            dgvIrrVerbs.Hide();
        }

        private void LoadPicture()
        {
            Image img=null;
            try
            {
                string filename = null;
                string name = cmbWord.Text.ToString().Split('/')[0];
                if (name.EndsWith(" N"))
                    name=name.Substring(0, name.Length - 2);
                MessageBox.Show(name);
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
                pictureBox1.Image = img;
            }
        }

        private void LoadData(string Path, ComboBox comboBox)
        {
            cmbWord.Items.Clear();
            new Thread(
                () =>
                {;
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
                        string errorMsg = string.Format("An error has occured in {0}. \nException:\n{1}", "cbWord", ex.Message);
                        MessageBox.Show(errorMsg, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                )
            { IsBackground = true }.Start();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbWord.SelectedItem != null)
            {
                if (cmbWord.SelectedIndex == 0)
                    btnBefore.Hide();
                else
                    btnBefore.Show();
                if (cmbWord.SelectedIndex == cmbWord.Items.Count-1)
                    btnAfter.Hide();
                else
                    btnAfter.Show();
                txbMeaning.Text = cmbWord.SelectedItem.ToString();
                LoadPicture();
            }
        }

        private void btnBefore_Click(object sender, EventArgs e)
        {
            try
            {
                cmbWord.SelectedIndex = cmbWord.SelectedIndex - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAfter_Click(object sender, EventArgs e)
        {
            try
            {
                cmbWord.SelectedIndex = cmbWord.SelectedIndex + 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnToeic_Click(object sender, EventArgs e)
        {
            IsToeic = !IsToeic;
            if (IsToeic)
            {
                LoadData("TOEIC.txt", cmbWord);

                #region Show
                cmbWord.Show();
                btnAfter.Show();
                btnBefore.Show();
                pictureBox1.Show();
                txbMeaning.Show();
                #endregion

                #region Another btn change to false
                IsOxford = false;
                IsToefl = false;
                IsIrrVerbs = false;
                IsIelts = false;
                #endregion

                dgvIrrVerbs.Hide();
            }
            else
            {
                cmbWord.Hide();
                btnAfter.Hide();
                btnBefore.Hide();
                pictureBox1.Hide();
                txbMeaning.Hide();
            }
        }

        private void btnToefl_Click(object sender, EventArgs e)
        {
            IsToefl = !IsToefl;
            if (IsToefl)
            {
                LoadData("TOEFL.txt", cmbWord);

                #region Show
                cmbWord.Show();
                btnAfter.Show();
                btnBefore.Show();
                pictureBox1.Show();
                txbMeaning.Show();
                #endregion

                #region Another btn change to false
                IsOxford = false;
                IsToeic = false;
                IsIrrVerbs = false;
                IsIelts = false;
                #endregion

                dgvIrrVerbs.Hide();
            }
            else
            {
                cmbWord.Hide();
                btnAfter.Hide();
                btnBefore.Hide();
                pictureBox1.Hide();
                txbMeaning.Hide();
            }
        }

        private void btnIelts_Click(object sender, EventArgs e)
        {
            IsIelts = !IsIelts;
            if (IsIelts)
            {
                LoadData("IELTS.txt", cmbWord);

                #region Show
                cmbWord.Show();
                btnAfter.Show();
                btnBefore.Show();
                pictureBox1.Show();
                txbMeaning.Show();
                #endregion

                #region Another btn change to false
                IsOxford = false;
                IsToeic = false;
                IsIrrVerbs = false;
                IsToefl = false;
                #endregion

                dgvIrrVerbs.Hide();
            }
            else
            {
                cmbWord.Hide();
                btnAfter.Hide();
                btnBefore.Hide();
                pictureBox1.Hide();
                txbMeaning.Hide();
            }
        }

        private void btnOxford_Click(object sender, EventArgs e)
        {
            IsOxford = !IsOxford;
            if (IsOxford)
            {
                LoadData("OXFORD.txt", cmbWord);

                #region Show
                cmbWord.Show();
                btnAfter.Show();
                btnBefore.Show();
                pictureBox1.Show();
                txbMeaning.Show();
                #endregion

                #region Another btn change to false
                IsIelts = false;
                IsToeic = false;
                IsIrrVerbs = false;
                IsToefl = false;
                #endregion

                dgvIrrVerbs.Hide();
            }
            else
            {
                cmbWord.Hide();
                btnAfter.Hide();
                btnBefore.Hide();
                pictureBox1.Hide();
                txbMeaning.Hide();
            }
        }

        private void btnIrrVerbs_Click(object sender, EventArgs e)
        {
            IsIrrVerbs = !IsIrrVerbs;
            if (IsIrrVerbs)
            {
                dgvIrrVerbs.Show();
                LoadDataToIrregularVerbs("BQT_en.txt", dgvIrrVerbs);
                cmbWord.Hide();
                btnAfter.Hide();
                btnBefore.Hide();
                pictureBox1.Hide();
                txbMeaning.Hide();
            }
            else
            {
                dgvIrrVerbs.Hide();
            }
        }

        private void LoadDataToIrregularVerbs(string Path, DataGridView dataGrid)
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
                                def += Environment.NewLine;
                                def += line;
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