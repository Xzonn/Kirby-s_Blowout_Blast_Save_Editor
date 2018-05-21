using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KBB_Save_Editor
{
    public partial class KBB_Save_Editor : Form
    {

        public KBB_Save_Editor()
        {
            InitializeComponent();
        }

        public class Data
        {
            public static byte[] data;
            public static int length;
            public static byte GetData(int n)
            {
                return Data.data[n];
            }
            public static Int32 GetInt32Data(int n)
            {
                int i;
                Int32 value = 0;
                for (i = 3; i > -1; i--)
                {
                    value <<= 8;
                    value += Data.data[n + i];
                }
                return value;
            }
            public static void SetData(int n, byte val)
            {
                Data.data[n] = val;
            }
            public static void SetInt32Data(int n, Int32 value)
            {
                int i;
                for (i = 0; i < 4; i++)
                {
                    Data.data[n + i] = (byte)(value % 256);
                    value >>= 8;
                }
            }
        }

        private void OpenFile(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName == "") return;

            FileInfo fi = new FileInfo(openFileDialog.FileName);

            if (fi.Length != 1736)
            {
                MessageBox.Show("存档文件大小错误。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            byte[] buff = new byte[fi.Length];

            FileStream fs = fi.OpenRead();
            fs.Read(buff, 0, Convert.ToInt32(fs.Length));
            Data.data = buff;
            Data.length = (int)fi.Length;

            fs.Close();

            int i;
            for (i = 0; i < 5; i++)
            {
                amiiboBox.SetItemChecked(i, Data.GetData(7 + 2 * i) != 0);
            }

            statusLabel.Text = Path.GetFileName(openFileDialog.FileName) + " 已打开。";
            saveItem.Enabled = true;
            levelGroup.Enabled = true;
            amiiboGroup.Enabled = true;

            ReadLevelData();
        }

        private void SaveFile(object sender, EventArgs e)
        {
            WriteLevelData();
            WriteAmiiboData();

            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName == "") return;
            
            if (File.Exists(saveFileDialog.FileName))
            {
                File.Delete(saveFileDialog.FileName);
            }

            FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.CreateNew);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(Data.data, 0, Data.length);

            bw.Close();
            fs.Close();

            MessageBox.Show("保存文件成功。", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AboutClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Xzonn/Kirby-s_Blowout_Blast_Save_Editor");
        }

        private void LevelChange(object sender, EventArgs e)
        {
            levelBox.Focus();
            WriteLevelData();
            ReadLevelData();
            lastLevelLabel.Text = levelBox.Text;
        }

        private void ScoreChange(object sender, EventArgs e)
        {
            int score1 = Convert.ToInt32(scoreBox1.Value);
            int score2 = Convert.ToInt32(scoreBox2.Value);
            int score3 = Convert.ToInt32(scoreBox3.Value);

            if (score1 < score2 || score2 < score3)
            {
                MessageBox.Show("请输入合理的得分。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ((NumericUpDown)sender).Focus();
            }
        }

        private void ReadLevelData()
        {
            string level = levelBox.Text;
            int pos = (level[0] - '0' + 5 * (level.Length > 3 ? 1 : 0)) * 156 + (level[2] - '0') * 28 - 144;
            scoreBox1.Value = Convert.ToDecimal(Data.GetInt32Data(pos));
            scoreBox2.Value = Convert.ToDecimal(Data.GetInt32Data(pos + 4));
            scoreBox3.Value = Convert.ToDecimal(Data.GetInt32Data(pos + 8));
            trophyBox.Text = (string)trophyBox.Items[3 - Data.GetData(pos + 12)];
        }

        private void WriteLevelData()
        {
            int score1 = Convert.ToInt32(scoreBox1.Value);
            int score2 = Convert.ToInt32(scoreBox2.Value);
            int score3 = Convert.ToInt32(scoreBox3.Value);

            if (score1 >= score2 && score2 >= score3)
            {
                string lastLevel = lastLevelLabel.Text;
                int lastPos = (lastLevel[0] - '0' + 5 * (lastLevel.Length > 3 ? 1 : 0)) * 156 + (lastLevel[2] - '0') * 28 - 144;
                Data.SetInt32Data(lastPos, score1);
                Data.SetInt32Data(lastPos + 4, score2);
                Data.SetInt32Data(lastPos + 8, score3);
                Data.SetData(lastPos + 12, (byte)(3 - trophyBox.SelectedIndex));
            }
        }

        private void WriteAmiiboData()
        {
            int i;
            for (i = 0; i < 5; i++)
            {
                Data.SetData(7 + 2 * i, amiiboBox.GetItemChecked(i) ? (byte)1 : (byte)0);
            }
        }
    }
}
