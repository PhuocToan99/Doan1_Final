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
    public partial class frmDelete : Form
    {
        public frmDelete()
        {
            InitializeComponent();
        }
        public int id_delete;
        LinkListStudent F = null;
        LinkListScore sc = new LinkListScore();
        List<string> datas = new List<string>();
        List<string> datas1 = new List<string>();
        private void BtnInput_Click(object sender, EventArgs e)
        {
            id_delete = Convert.ToInt32(txtInput.Text);
            LinkListStudent temp = new LinkListStudent();
            F = temp.loadListStudent(F);
            LinkListScore tempsc = new LinkListScore();
            sc = tempsc.loadListScore(sc);
            F = Deletestudent(F, id_delete);
            sc = Deletescore(sc, id_delete);
            datas = F.changest(F);
            datas1 = sc.changesc(sc);
            foreach (string s in datas)
            {
                txtShowStudent.Text = string.Join(Environment.NewLine, datas);
            }
            foreach (string s in datas1)
            {
                    txtShowScore.Text = string.Join(Environment.NewLine, datas1);
            }
        }
        private LinkListStudent Deletestudent(LinkListStudent st, int ID)
        {
            LinkListStudent L = null;
            LinkListStudent temp = new LinkListStudent();
            while (st != null && st.ID < ID)
            {
                LinkListStudent k = new LinkListStudent { ID = st.ID, name = st.name, lastName = st.lastName, sex = st.sex, birthDate = st.birthDate, type = st.type };
                temp.addst(ref L, k);
                st = st.Next;
            }
            temp = st.Next;
            while (temp != null)
            {
                LinkListStudent k = new LinkListStudent { ID = (temp.ID) - 1, name = temp.name, lastName = temp.lastName, sex = temp.sex, birthDate = temp.birthDate, type = temp.type };
                temp.addst(ref L, k);
                temp = temp.Next;
            }
            return L;
        }
        private LinkListScore Deletescore(LinkListScore sc, int ID)
        {
            LinkListScore L = null;
            LinkListScore temp = new LinkListScore();
            while (sc != null && sc.id < ID)
            {
                LinkListScore k = new LinkListScore { id = sc.id, mathScore = sc.mathScore, literatureScore = sc.literatureScore, englishScore = sc.englishScore };
                temp.addS(ref L, k);
                sc = sc.Next;
            }
            temp = sc.Next;
            while (temp != null)
            {
                LinkListScore k = new LinkListScore { id = (temp.id) - 1, mathScore = temp.mathScore, literatureScore = temp.literatureScore, englishScore = temp.englishScore };
                temp.addS(ref L, k);
                temp = temp.Next;
            }
            return L;
        }

        private void FrmDelete_Load(object sender, EventArgs e)
        {
            LinkListStudent temp = new LinkListStudent();
            F = temp.loadListStudent(F);
            LinkListScore tempsc = new LinkListScore();
            sc = tempsc.loadListScore(sc);
            datas = F.changest(F);
            datas1 = sc.changesc(sc);
            foreach (string s in datas)
            {
                txtShowStudent.Text = string.Join(Environment.NewLine, datas);
            }
            foreach (string s in datas1)
            {
                txtShowScore.Text = string.Join(Environment.NewLine, datas1);

            }
        }
    }
}
