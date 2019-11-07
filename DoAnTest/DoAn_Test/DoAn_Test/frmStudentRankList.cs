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
    public partial class frmStudentRankList : Form
    {
        public frmStudentRankList()
        {
            InitializeComponent();
        }
        LinkListFullInfo F = null;
        LinkListFullInfo L = null;
        List<string> datas = new List<string>();
        List<string> datas1 = new List<string>();
        private void FrmStudentRankList_Load(object sender, EventArgs e)
        {
            LinkListFullInfo temp = new LinkListFullInfo();
            //F = temp.loadfullInfo(F);
            F=temp.setStGioi(F);
            F = F.MergeSort(F);

            L = temp.setStKha(L);
            L = L.MergeSort(L);

            datas = F.change(F);
            datas1 = L.change(L);
            datas.AddRange(datas1);
            foreach (string s in datas)
            {
                textBox1.Text = string.Join(Environment.NewLine, datas);
            }
            using (StreamWriter sw = new StreamWriter("Danhsachhocsinhkhagioi.txt"))
            {

                foreach (string s in datas)
                {
                    sw.WriteLine(s);
                }
            }
        }

        private void BtnFileout_Click(object sender, EventArgs e)
        {
            frmShowInFile frm = new frmShowInFile();
            frm.source = "Danhsachhocsinhkhagioi.txt";
            frm.Show();
        }
    }
}
