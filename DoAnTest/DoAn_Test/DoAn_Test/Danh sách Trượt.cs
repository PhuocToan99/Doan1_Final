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
    public partial class frmStudentFail : Form
    {
        public frmStudentFail()
        {
            InitializeComponent();
        }
        LinkListFullInfo F = null;
        List<string> datas = new List<string>();
        private void FrmStudentFail_Load(object sender, EventArgs e)
        {
            LinkListFullInfo temp = new LinkListFullInfo();
            //F = temp.loadfullInfo(F);
            F = temp.setStTruot(F);
            F = F.MergeSortFail(F);
            datas = F.change(F);
            foreach (string s in datas)
            {
                textBox1.Text = string.Join(Environment.NewLine, datas);
            }
            using (StreamWriter sw = new StreamWriter("Danhsachhocsinhtruot.txt"))
            {

                foreach (string s in datas)
                {
                    sw.WriteLine(s);
                }
            }
            btnFileout.Enabled = true;
        }

        private void BtnFileout_Click(object sender, EventArgs e)
        {
            frmShowInFile frm = new frmShowInFile();
            frm.source = "Danhsachhocsinhtruot.txt";
            frm.Show();
        }
    }
}
