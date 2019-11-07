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
    public partial class frmResult : Form
    {
        public frmResult()
        {
            InitializeComponent();
        }
        LinkListFullInfo F = new LinkListFullInfo();
        List<string> datas;
        List<string> output;
        private void Báo_Điểm_Load(object sender, EventArgs e)
        {
            F = F.loadfullInfo(F);
            datas = Change(F);
            foreach (string s in datas)
            {
                textBox1.Text = string.Join(Environment.NewLine, datas);
            }
            output = ChangeFile(F);
            using (StreamWriter sw = new StreamWriter("BaoDiem.txt"))
            {

                foreach (string s in output)
                {
                    sw.WriteLine(s);
                }
            }
        }
        private static string Tab1(string s, int w)
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
        private List<string> Change(LinkListFullInfo F)
        {
            List<string> lines = new List<string>();
            LinkListFullInfo p = F;
            string string1, string2, string3;
            p = p.Next.Next;
            while (p != null)
            {
                if (p.Next != null && p.Next.Next != null)
                {
                    string1 = gender(p.sex);
                    string2 = gender(p.Next.sex);
                    string3 = gender(p.Next.Next.sex);
                    lines.Add(Tab1("GIAY BAO DIEM", 45) + Tab1("GIAY BAO DIEM", 45) + Tab1("GIAY BAO DIEM", 45));
                    lines.Add(Tab1("So bao danh:" + p.ID, 50) + Tab1("So bao danh:" + p.Next.ID, 50) + Tab1("So bao danh:" + p.Next.Next.ID, 50));
                    lines.Add(Tab1((string1 + p.lastName + p.name), 50) + Tab1((string2 + p.Next.lastName + p.Next.name), 50) + Tab1((string3 + p.Next.Next.lastName + p.Next.Next.name), 50));
                    lines.Add(Tab1("Toan:" + p.mathScore, 50) + Tab1("Toan:" + p.Next.mathScore, 50) + Tab1("Toan:" + p.Next.Next.mathScore, 50));
                    lines.Add(Tab1("Van:" + p.literatureScore, 50) + Tab1("Van:" + p.Next.literatureScore, 50) + Tab1("Van:" + p.Next.Next.literatureScore, 50));
                    lines.Add(Tab1("Anh van:" + p.englishScore, 45) + Tab1("Anh van:" + p.Next.englishScore, 45) + Tab1("Anh van:" + p.Next.Next.englishScore, 45));
                    lines.Add(Tab1("Tong diem:" + F.totalScore, 45) + Tab1("Tong diem:" + F.Next.totalScore, 45) + Tab1("Tong diem:" + F.Next.Next.totalScore, 45));
                    lines.Add(Tab1("Xep loai:" + F.rank, 50) + Tab1("Xep loai:" + F.Next.rank, 50) + Tab1("Xep loai:" + F.Next.Next.rank, 50) + Environment.NewLine);
                }
                if (p.Next != null && p.Next.Next == null)
                {
                    string1 = gender(p.sex);
                    string2 = gender(p.Next.sex);
                    lines.Add(Tab1("GIAY BAO DIEM", 45) + Tab1("GIAY BAO DIEM", 45));
                    lines.Add(Tab1("So bao danh:" + p.ID, 50) + Tab1("So bao danh:" + p.Next.ID, 50));
                    lines.Add(Tab1((string1 + p.lastName + p.name), 50) + Tab1((string2 + p.Next.lastName + p.Next.name), 50));
                    lines.Add(Tab1("Toan:" + p.mathScore, 50) + Tab1("Toan:" + p.Next.mathScore, 50));
                    lines.Add(Tab1("Van:" + p.literatureScore, 50) + Tab1("Van:" + p.Next.literatureScore, 50));
                    lines.Add(Tab1("Anh van:" + p.englishScore, 45) + Tab1("Anh van:" + p.Next.englishScore, 45));
                    lines.Add(Tab1("Tong diem:" + F.totalScore, 45) + Tab1("Tong diem:" + F.Next.totalScore, 45));
                    lines.Add(Tab1("Xep loai:" + F.rank, 50) + Tab1("Xep loai:" + F.Next.rank, 50) + Environment.NewLine);
                }
                if (p.Next.Next == null && p.Next == null)
                {
                    string1 = gender(p.sex);
                    lines.Add(Tab1("GIAY BAO DIEM", 45));
                    lines.Add(Tab1("So bao danh:" + p.ID, 50));
                    lines.Add(Tab1(string1 + p.lastName + p.name, 50));
                    lines.Add(Tab1("Toan:" + p.mathScore, 50));
                    lines.Add(Tab1("Van:" + p.literatureScore, 50));
                    lines.Add(Tab1("Anh van:" + p.englishScore, 45));
                    lines.Add(Tab1("Tong diem:" + F.totalScore, 45));
                    lines.Add(Tab1("Xep loai:" + F.rank, 50) + Environment.NewLine);
                }
                p = p.Next.Next;
            }
            return lines;

        }
        private List<string> ChangeFile(LinkListFullInfo F)
        {
            List<string> lines = new List<string>();
            LinkListFullInfo p = F;
            string string1, string2, string3;
            p = p.Next.Next;
            while (p != null)
            {
                string date = string.Format("{0:dd/MM/yyyy}", p.birthdate);



                //lines.Add(string.Format("{0,-35}{1,-35}{2,-35}","GIAY BAO DIEM", "GIAY BAO DIEM", "GIAY BAO DIEM") + Environment.NewLine);
                if (p.Next != null && p.Next.Next != null)
                {
                    string1 = gender(p.sex);
                    string2 = gender(p.Next.sex);
                    string3 = gender(p.Next.Next.sex);
                    lines.Add(Tab1("GIAY BAO DIEM", 45) + Tab1("GIAY BAO DIEM", 45) + Tab1("GIAY BAO DIEM", 45));
                    lines.Add(Tab1("So bao danh:" + p.ID, 50) + Tab1("So bao danh:" + p.Next.ID, 50) + Tab1("So bao danh:" + p.Next.Next.ID, 50));
                    lines.Add(Tab1((string1 + p.lastName + p.name), 45) + Tab1((string2 + p.Next.lastName + p.Next.name), 45) + Tab1((string3 + p.Next.Next.lastName + p.Next.Next.name), 0));
                    lines.Add(Tab1("Toan:" + p.mathScore, 45) + Tab1("Toan:" + p.Next.mathScore, 50) + Tab1("Toan:" + p.Next.Next.mathScore, 0));
                    lines.Add(Tab1("Van:" + p.literatureScore, 50) + Tab1("Van:" + p.Next.literatureScore, 50) + Tab1("Van:" + p.Next.Next.literatureScore, 50));
                    lines.Add(Tab1("Anh van:" + p.englishScore, 45) + Tab1("Anh van:" + p.Next.englishScore, 45) + Tab1("Anh van:" + p.Next.Next.englishScore, 45));
                    lines.Add(Tab1("Tong diem:" + F.totalScore, 45) + Tab1("Tong diem:" + F.Next.totalScore, 45) + Tab1("Tong diem:" + F.Next.Next.totalScore, 45));
                    lines.Add(Tab1("Xep loai:" + F.rank, 45) + Tab1("Xep loai:" + F.Next.rank, 50) + Tab1("Xep loai:" + F.Next.Next.rank, 40) + Environment.NewLine);
                }
                if (p.Next != null && p.Next.Next == null)
                {
                    string1 = gender(p.sex);
                    string2 = gender(p.Next.sex);
                    lines.Add(Tab1("GIAY BAO DIEM", 45) + Tab1("GIAY BAO DIEM", 45));
                    lines.Add(Tab1("So bao danh:" + p.ID, 50) + Tab1("So bao danh:" + p.Next.ID, 50));
                    lines.Add(Tab1((string1 + p.lastName + p.name), 45) + Tab1((string2 + p.Next.lastName + p.Next.name), 45));
                    lines.Add(Tab1("Toan:" + p.mathScore, 45) + Tab1("Toan:" + p.Next.mathScore, 0));
                    lines.Add(Tab1("Van:" + p.literatureScore, 50) + Tab1("Van:" + p.Next.literatureScore, 50));
                    lines.Add(Tab1("Anh van:" + p.englishScore, 45) + Tab1("Anh van:" + p.Next.englishScore, 45));
                    lines.Add(Tab1("Tong diem:" + F.totalScore, 45) + Tab1("Tong diem:" + F.Next.totalScore, 45));
                    lines.Add(Tab1("Xep loai:" + F.rank, 45) + Tab1("Xep loai:" + F.Next.rank, 45) + Environment.NewLine);
                }
                if (p.Next.Next == null && p.Next == null)
                {
                    string1 = gender(p.sex);
                    lines.Add(Tab1("GIAY BAO DIEM", 45));
                    lines.Add(Tab1("So bao danh:" + p.ID, 50));
                    lines.Add(Tab1(string1 + p.lastName + p.name, 45));
                    lines.Add(Tab1("Toan:" + p.mathScore, 0));
                    lines.Add(Tab1("Van:" + p.literatureScore, 50));
                    lines.Add(Tab1("Anh van:" + p.englishScore, 45));
                    lines.Add(Tab1("Tong diem:" + F.totalScore, 45));
                    lines.Add(Tab1("Xep loai:" + F.rank, 45) + Environment.NewLine);
                }
                p = p.Next.Next;
            }
            return lines;

        }
        private string gender(string sex)
        {
            if (sex == "Nam") return "Anh:";
            else return "Chi:";

        }

        private void BtnFileout_Click(object sender, EventArgs e)
        {
            frmShowInFile frm = new frmShowInFile();
            frm.source = "BaoDiem.txt";
            frm.Show();
        }
    }
}
