using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_Test
{
    public partial class frmThủ_Khoa : Form
    {
        public frmThủ_Khoa()
        {
            InitializeComponent();
        }
        LinkListFullInfo F = null;
        List<string> datas = new List<string>();
        private void Thủ_Khoa_Load(object sender, EventArgs e)
        {
            LinkListFullInfo temp = new LinkListFullInfo();
            F = temp.setStGioi(F);
            F = F.MergeSort(F);
            temp = F;
            double max = temp.totalScore;
            int count = 0;
            datas = changedatas(F,max,ref count);

            foreach (string s in datas)
            {
                textBox1.Text = string.Join(Environment.NewLine, datas);
            }
            using (StreamWriter sw = new StreamWriter("Danhsachthukhoa.txt"))
            {

                foreach (string s in datas)
                {
                    sw.WriteLine(s);
                }
            }
        }
        private List<string> changedatas(LinkListFullInfo F, double max, ref int count)
        {
            List<string> lines = new List<string>();
            LinkListFullInfo p = F;
            string date = string.Format("{0:dd/MM/yyyy}", p.birthdate);
            while (p != null)
            {
                if (p.totalScore == max)
                {
                    lines.Add(tab(p.ID.ToString(), 3) + tab(p.lastName, 15) + tab(p.name, 10) + p.sex + "  " + tab(date, 12) + "  " + tab(p.mathScore.ToString(), 3) + tab(p.literatureScore.ToString(), 2) + tab(p.englishScore.ToString(), 2) + tab(p.totalScore.ToString(), 2) + " " + tab(p.rank, 3) + " " + p.type);
                    count++;
                }
                p = p.Next;
            }
            return lines;

        }
        public static string tab(string s, int w)
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

        private void BtnFileout_Click(object sender, EventArgs e)
        {
            frmShowInFile frm = new frmShowInFile();
            frm.source = "Danhsachthukhoa.txt";
            frm.Show();
        }
    }
}
