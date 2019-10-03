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

namespace DoAn_Test
{
    public partial class frmScore : Form
    {
        public frmScore()
        {
            InitializeComponent();
        }
       
        private void FrmScore_Load(object sender, EventArgs e)
        {
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = "DiemThi.txt";
                StreamReader read = new StreamReader(filePath);
                txtShow.Text = read.ReadToEnd();
                string text = read.ReadToEnd();
                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            List<Score> scores = new List<Score>();
            string filePath = @"DiemThi.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();
            char[] c = new char[] { ' ' };
            List<string> datas = new List<string>();
            for (int i = 0; i < lines.Count; i++)
            {
                if (i >= 9) datas.Add(lines[i]);
            }
            foreach (var data in datas)
            {

                string[] entries = data.Split(c, StringSplitOptions.RemoveEmptyEntries);
                Score score = new Score();
                //score.id = entries[0];
                //score.mathScore = Convert.ToDouble(entries[1]);
                //score.literatureScore = Convert.ToDouble(entries[2]);
                //score.englishScore = Convert.ToDouble(entries[3]);

                //Ghi nho cai nay
                for (int i = 0; i < entries.Length; i++)
                {
                    score.id = entries[i];
                    score.mathScore = Convert.ToDouble(entries[i + 1]);
                    score.literatureScore = Convert.ToDouble(entries[i + 2]);
                    score.englishScore = Convert.ToDouble(entries[i + 3]);
                    break;
                }
                scores.Add(score);
            }
            string id = txtID.Text;
            foreach (Score a in scores)
            {
                if (a.id == id)
                {
                    lbID.Text = a.id;
                    lbMath.Text = a.mathScore.ToString();
                    lbLiterature.Text = a.literatureScore.ToString();
                    lbEnglish.Text = a.englishScore.ToString();
                    break;
                }
            }
        }
    }
}
