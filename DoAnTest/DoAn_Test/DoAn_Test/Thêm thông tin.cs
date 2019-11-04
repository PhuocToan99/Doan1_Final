using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_Test
{
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }
        LinkListStudent F = null;
        LinkListScore sc = new LinkListScore();
        List<string> datas = new List<string>();
        private void BtnAddFront_Click(object sender, EventArgs e)
        {
            LinkListStudent temp = new LinkListStudent();
            F = temp.loadListStudent(F);
            LinkListStudent p = new LinkListStudent();
            int ID = Convert.ToInt32(txtID.Text);
            string lastName = txtLastName.Text;
            string name = txtName.Text;
            string sex = txtSex.Text;
            int type = Convert.ToInt32(txtType.Text);
            DateTime birthDate1 = dateTimePicker1.Value;

            LinkListStudent L = null;
            while (F != null && F.ID < ID)
            {
                LinkListStudent k = new LinkListStudent { ID = F.ID, name = F.name, lastName = F.lastName, sex = F.sex, birthDate = F.birthDate, type = F.type };
                temp.addst(ref L, k);
                F = F.Next;
            }
            //temp.addst(ref L, F);
            temp.addStudent1(p, ID, lastName, name, sex, birthDate1, type);
            temp.addst(ref L, p);
            while (F != null)
            {
                LinkListStudent k = new LinkListStudent { ID = F.ID + 1, name = F.name, lastName = F.lastName, sex = F.sex, birthDate = F.birthDate, type = F.type };
                temp.addst(ref L, k);
                F = F.Next;
            }

            LinkListScore tempsc = new LinkListScore();
            sc = tempsc.loadListScore(sc);
            LinkListScore P = new LinkListScore();
            int id = Convert.ToInt32(txtID.Text);
            double mathScore = Convert.ToDouble(txtMathScore.Text);
            double literatureScore = Convert.ToDouble(txtLiteratureScore.Text);
            double englishScore = Convert.ToDouble(txtEnglishScore.Text);
            LinkListScore Lsc = null;
            while (sc != null && sc.id < id)
            {
                LinkListScore k = new LinkListScore { id = sc.id, mathScore = sc.mathScore, literatureScore = sc.literatureScore, englishScore = sc.englishScore };
                sc.addS(ref Lsc, k);
                sc = sc.Next;
            }
            //temp.addst(ref L, F);
            sc.addScore(P, id, mathScore, literatureScore, englishScore);
            sc.addS(ref Lsc, P);
            while (sc != null)
            {
                LinkListScore k = new LinkListScore { id = (sc.id) + 1, mathScore = sc.mathScore, literatureScore = sc.literatureScore, englishScore = sc.englishScore };
                sc.addS(ref Lsc, k);
                sc = sc.Next;
            }
            datas = Change(L, Lsc);
            foreach (string s in datas)
            {
                txtShow.Text = string.Join(Environment.NewLine, datas);
            }
        }
        private static List<string> Change(LinkListStudent s, LinkListScore sc)
        {
            List<string> lines = new List<string>();
            LinkListScore p = sc;
            LinkListStudent k = s;
            while (p != null && k != null)
            {
                if (p.mathScore == 0 && p.literatureScore == 0 && p.englishScore == 0)
                {
                    k = k.Next;
                    continue;
                }
                string date = string.Format("{0:dd/MM/yyyy}", k.birthDate);
                lines.Add(Tab(p.id.ToString(), 3) + Tab(k.lastName, 15) + Tab(k.name, 10) + Tab(k.sex, 3) + Tab(date, 12) + Tab(p.mathScore.ToString(), 2) + Tab(p.literatureScore.ToString(), 2) + Tab(p.englishScore.ToString(), 2));
                p = p.Next;
                k = k.Next;
            }
            return lines;
        }
        private static string Tab(string s, int w)
        {
            //w is the desired width
            int stringwidth = s.Length;
            int i;
            string resultstring = s;

            for (i = 0; i <= (w - stringwidth) / 8; i++)
            {
                resultstring = resultstring + "\t";
            }
            return resultstring;
        }

        private void BtnInsertAfter_Click(object sender, EventArgs e)
        {
            LinkListStudent temp = new LinkListStudent();
            F = temp.loadListStudent(F);
            LinkListStudent p = new LinkListStudent();
            int ID = Convert.ToInt32(txtID.Text);
            string lastName = txtLastName.Text;
            string name = txtName.Text;
            string sex = txtSex.Text;
            int type = Convert.ToInt32(txtType.Text);
            DateTime birthDate1 = dateTimePicker1.Value;

            LinkListStudent L = null;
            while (F != null && F.ID <= ID)
            {
                LinkListStudent k = new LinkListStudent { ID = F.ID, name = F.name, lastName = F.lastName, sex = F.sex, birthDate = F.birthDate, type = F.type };
                temp.addst(ref L, k);
                F = F.Next;
            }
            //temp.addst(ref L, F);
            temp.addStudent1(p, ID + 1, lastName, name, sex, birthDate1, type);
            temp.addst(ref L, p);
            while (F != null)
            {
                LinkListStudent k = new LinkListStudent { ID = F.ID + 1, name = F.name, lastName = F.lastName, sex = F.sex, birthDate = F.birthDate, type = F.type };
                temp.addst(ref L, k);
                F = F.Next;
            }

            LinkListScore tempsc = new LinkListScore();
            sc = tempsc.loadListScore(sc);
            LinkListScore P = new LinkListScore();
            int id = Convert.ToInt32(txtID.Text);
            double mathScore = Convert.ToDouble(txtMathScore.Text);
            double literatureScore = Convert.ToDouble(txtLiteratureScore.Text);
            double englishScore = Convert.ToDouble(txtEnglishScore.Text);
            LinkListScore Lsc = null;
            while (sc != null && sc.id <= id)
            {
                LinkListScore k = new LinkListScore { id = sc.id, mathScore = sc.mathScore, literatureScore = sc.literatureScore, englishScore = sc.englishScore };
                sc.addS(ref Lsc, k);
                sc = sc.Next;
            }
            //temp.addst(ref L, F);
            sc.addScore(P, id + 1, mathScore, literatureScore, englishScore);
            sc.addS(ref Lsc, P);
            while (sc != null)
            {
                LinkListScore k = new LinkListScore { id = (sc.id) + 1, mathScore = sc.mathScore, literatureScore = sc.literatureScore, englishScore = sc.englishScore };
                sc.addS(ref Lsc, k);
                sc = sc.Next;
            }
            datas = Change(L, Lsc);
            foreach (string s in datas)
            {
                txtShow.Text = string.Join(Environment.NewLine, datas);
            }
        }
    }
}
