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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string filePath="";

        private void BtnStudentInfo_Click(object sender, EventArgs e)
        {
            filePath = "DanhSach.txt";
            frmStudent frm = new frmStudent();
            frm.Show();
        }

        private void BtnScore_Click(object sender, EventArgs e)
        {
            filePath = "DiemThi.txt";
            frmScore frm = new frmScore();
            frm.Show();
        }
    }
  
}
