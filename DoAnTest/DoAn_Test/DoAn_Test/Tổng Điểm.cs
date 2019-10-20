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
    public partial class frmFullInfo : Form
    {
        public frmFullInfo()
        {
            InitializeComponent();
        }
        LinkListFullInfo F = null;

        private void FrmFullInfo_Load(object sender, EventArgs e)
        {
            LinkListFullInfo temp = new LinkListFullInfo();
           F=temp.loadfullInfo(F);
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            LinkListFullInfo p = F;
            while (p != null)
            {
                if (p.ID == id)
                {
                    lbLastName.Text = p.lastName;
                    lbName.Text = p.name;
                    if (p.sex == true)
                    {
                        lbSex.Text = "Nam";
                    }
                    else
                    {
                        lbSex.Text = "Nữ";
                    }
                    lbAge.Text = p.age.ToString();
                    lbType.Text = p.type.ToString();
                    lbMath.Text = p.mathScore.ToString();
                    lbLiterature.Text = p.literatureScore.ToString();
                    lbEnglish.Text = p.englishScore.ToString();
                    lbminScore.Text = p.minScore.ToString();
                    lbtotalScore.Text = p.totalScore.ToString();
                    lbRank.Text = p.rank;
                    break;
                }
                else p = p.Next;
            }
            if (p == null) MessageBox.Show("Error,please check input", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
        }
    }
}
