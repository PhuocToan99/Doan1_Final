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
        LinkListScore L = null;
        private void FrmScore_Load_1(object sender, EventArgs e)
        {
            L=load(L);
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
            #region
            //List<Score> scores = new List<Score>();
            //string filePath = @"DiemThi.txt";
            //List<string> lines = File.ReadAllLines(filePath).ToList();
            //char[] c = new char[] { ' ' };
            //List<string> datas = new List<string>();
            //for (int i = 0; i < lines.Count; i++)
            //{
            //    if (i >= 9) datas.Add(lines[i]);
            //}
            //foreach (var data in datas)
            //{

            //    string[] entries = data.Split(c, StringSplitOptions.RemoveEmptyEntries);
            //    Score score = new Score();
            //    //score.id = entries[0];
            //    //score.mathScore = Convert.ToDouble(entries[1]);
            //    //score.literatureScore = Convert.ToDouble(entries[2]);
            //    //score.englishScore = Convert.ToDouble(entries[3]);

            //    //Ghi nho cai nay
            //    for (int i = 0; i < entries.Length; i++)
            //    {
            //        score.id = entries[i];
            //        score.mathScore = Convert.ToDouble(entries[i + 1]);
            //        score.literatureScore = Convert.ToDouble(entries[i + 2]);
            //        score.englishScore = Convert.ToDouble(entries[i + 3]);
            //        break;
            //    }
            //    scores.Add(score);
            //}
            //string id = txtID.Text;
            //foreach (Score a in scores)
            //{
            //    if (a.id == id)
            //    {
            //        lbID.Text = a.id;
            //        lbMath.Text = a.mathScore.ToString();
            //        lbLiterature.Text = a.literatureScore.ToString();
            //        lbEnglish.Text = a.englishScore.ToString();
            //        break;
            //    }
            //}
            #endregion
            find(L);
        }
        private LinkListScore load(LinkListScore L)
        {
            string filePath = @"DiemThi.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();
            char[] c = new char[] { ' ' };
            List<string> datas = new List<string>();
            int id = 0;
            double mathScore = 0, literatureScore = 0, englishScore = 0;
            for (int i = 0; i < lines.Count; i++)
            {
                if (i >= 9) datas.Add(lines[i]);
            }
            foreach (var data in datas)
            {

                string[] entries = data.Split(c, StringSplitOptions.RemoveEmptyEntries);
                LinkListScore p = new LinkListScore();
                //score.id = entries[0];
                //score.mathScore = Convert.ToDouble(entries[1]);
                //score.literatureScore = Convert.ToDouble(entries[2]);
                //score.englishScore = Convert.ToDouble(entries[3]);

                //Ghi nho cai nay
                for (int i = 0; i < entries.Length; i++)
                {
                    id = Convert.ToInt32(entries[i]);
                    mathScore = Convert.ToDouble(entries[i + 1]);
                    literatureScore = Convert.ToDouble(entries[i + 2]);
                    englishScore = Convert.ToDouble(entries[i + 3]);
                    break;
                }
                addScore(p, id, mathScore, literatureScore, englishScore);
                addS(ref L, p);
            }
            return L;
        }
        private Boolean addScore(LinkListScore p, int ID, double mathScore, double literatureScore, double englishScore)
        {
            p.id = ID;
            p.mathScore = mathScore;
            p.literatureScore = literatureScore;
            p.englishScore = englishScore;
            return true;
        }
        private static void addS(ref LinkListScore L, LinkListScore p)
        {
            if (L == null) L = p;
            else
            {
                LinkListScore q = L;
                while (q.Next != null) q = q.Next;
                q.Next = p;
            }
        }
        private void find(LinkListScore L)
        {
            int id = Convert.ToInt32(txtID.Text);
            LinkListScore p = L;
            while (p != null)
            {
                if (p.id == id)
                {
                    lbID.Text = p.id.ToString();
                    lbMath.Text = p.mathScore.ToString();
                    lbLiterature.Text = p.literatureScore.ToString();
                    lbEnglish.Text = p.englishScore.ToString();
                    break;
                }
                else p = p.Next;
            }
            if (p == null) MessageBox.Show("Error,please check input", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            //if ()
            //    MessageBox.Show("Plesase choose option", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if(rbFull.Checked == true)
            {
                frmFullInfo frm = new frmFullInfo();
                frm.Show();
            }
            if (rdbStudentRankList.Checked == true)
            {
                frmStudentRankList frm = new frmStudentRankList();
                frm.Show();
            }
            if (rdbStudentFail.Checked == true)
            {
                frmStudentFail frm = new frmStudentFail();
                frm.Show();
            }
            if (rdbThukhoa.Checked == true)
            {
                frmThủ_Khoa frm = new frmThủ_Khoa();
                frm.Show();
            }
            if (rdbType.Checked == true)
            {
                frmType frm = new frmType();
                frm.Show();
            }
        }
    }
}
