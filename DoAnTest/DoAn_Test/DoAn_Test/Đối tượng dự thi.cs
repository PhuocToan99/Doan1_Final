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
    public partial class frmType : Form
    {
        public frmType()
        {
            InitializeComponent();
        }
        LinkListFullInfo F = null;
        int count1 = 0, count2 = 0;
        double percent1 = 0, percent2 = 0;

        private void BtnFileout_Click(object sender, EventArgs e)
        {
            frmShowInFile frm = new frmShowInFile();
            frm.source = "DanhSachTheoDoituongDuThi.txt";
            frm.Show();
        }

        List<string> datas = new List<string>();
        List<string> output = new List<string>();
        private void BtnShow_Click(object sender, EventArgs e)
        {
            int type = Convert.ToInt32(textBox2.Text);
            LinkListFullInfo p = new LinkListFullInfo();
            F = p.loadfullInfo(F);
            count1 = p.total(F, type);
            count2 = p.count(F, type);
            percent1 = Math.Round(percent1, 2);
            percent2 = 100 - percent1;
            percent2 = Math.Round(percent2, 2);
            label6.Text = count1.ToString();
            label12.Text = count2.ToString();
            string out1 = String.Format("{0:0.00}", percent1);
            string out2 = String.Format("{0:0.00}", percent2);
            label11.Text = out1+"%";
            label10.Text = out2+"%";
            int result = count1 - count2;
            label9.Text = result.ToString();
            F = null;
            F = p.loadStudentType(F, type);
            datas = p.change(F);
            foreach (string s in datas)
            {
                textBox1.Text = string.Join(Environment.NewLine, datas);
            }
            using (StreamWriter sw = new StreamWriter("DanhSachTheoDoituongDuThi.txt"))
            {

                foreach (string s in datas)
                {
                    sw.WriteLine(s);
                }
            }

            btnFileout.Enabled = true;
        }
    }
}
