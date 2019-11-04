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
    public partial class frmStudent : Form
    {
        
        public frmStudent()
        {
            InitializeComponent();
        }
        LinkListStudent L = null;
        private void FrmStudent_Load(object sender, EventArgs e)
        {
            L=load(L);
        }

        private LinkListStudent load(LinkListStudent L)
        {
            List<string> lines = File.ReadAllLines("DanhSach.txt").ToList();
            List<string> datas = new List<string>();

            int ID, type;
            string lastName, name;
            Boolean sex;
            DateTime birthDate;
            String re;
            int flag;
            for (int i = 0; i < lines.Count; i++)
            {
                if (i >= 12) datas.Add(lines[i]);
            }

            foreach (var data in datas)
            {


                //Ghi nho cai nay
                LinkListStudent p = new LinkListStudent();
                ID = Convert.ToInt32(data.Substring(0, 11));
                lastName = data.Substring(11, 15);
                name = data.Substring(26, 7);
                re = data.Substring(34, 2);
                flag = Convert.ToInt32(re);
                //char[] date = data.Substring(35, 10).ToCharArray();
                string date = data.Substring(35, 10);

                birthDate = DateTime.Parse(date);
                //student.birthDate = entries[i + 6];
                type = Convert.ToInt32(data.Substring(46, 1));
                addStudent(p, ID, lastName, name, flag, birthDate, type);
                add(ref L, p);
                //students.Add(student);

            }
            return L;
        }

        private Boolean addStudent(LinkListStudent p, int ID, string lastName, string name, int sex, DateTime birthDate, int type)
        {
            p.ID = ID;
            p.lastName = lastName;
            p.name = name;
            string gender = String.Empty;
            if (sex == 1)
            {
                gender = "Nữ";
            }
            else
            {
                gender = "Nam";
            }
            p.sex = gender;
            p.birthDate = birthDate;
            p.type = type;
            return true;
        }
        private void add(ref LinkListStudent L, LinkListStudent p)
        {
            if (L == null) L = p;
            else
            {
                LinkListStudent q = L;
                while (q.Next != null) q = q.Next;
                q.Next = p;
            }
        }
        private void find(LinkListStudent L)
        {
            int id = Convert.ToInt32(txtID.Text);
            LinkListStudent p = L;
            while (p != null)
            {
                if (p.ID == id)
                {
                    lbLastName.Text = p.lastName;
                    lbName.Text = p.name;
                    //if (p.sex == true)
                    //{
                    //    lbSex.Text = "Nam";
                    //}
                    //else
                    //{
                    //    lbSex.Text = "Nữ";
                    //}
                    lbSex.Text = p.sex;
                    string date = string.Format("{0:dd/MM/yyyy}", p.birthDate);
                    lbBirthDate.Text = date;
                    lbType.Text = p.type.ToString();
                    break;
                }
                else p = p.Next;
            }
            if (p == null) MessageBox.Show("Error,please check input", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            #region
            //List<Student> students = new List<Student>();
            //string filePath = @"DanhSach.txt";
            //List<string> lines = File.ReadAllLines(filePath).ToList();
            //char[] c = new char[] { ' ' };
            //List<string> datas = new List<string>();
            //Boolean re, flag;
            //for (int i = 0; i < lines.Count; i++)
            //{
            //    if (i >= 12) datas.Add(lines[i]);
            //}
            //foreach (var data in datas)
            //{
            //    //string[] entries = data.Split(c, StringSplitOptions.RemoveEmptyEntries);
            //    Student student = new Student();
            //    //f.Seek(pos, SeekOrigin.Current);
            //    //Ghi nho cai nay

            //    student.ID = Convert.ToInt32(data.Substring(0, 11));
            //    student.lastName = data.Substring(11, 15);
            //    student.name = data.Substring(26, 7);
            //    re = Boolean.TryParse(data.Substring(34, 2), out flag);
            //    student.sex = re;
            //    //char[] date = data.Substring(35, 10).ToCharArray();
            //    string date = data.Substring(35, 10);

            //    student.birthDate = DateTime.Parse(date);
            //    //student.birthDate = entries[i + 6];
            //    student.type = Convert.ToInt32(data.Substring(46, 1));


            //    students.Add(student);
            //}
            //int id = Convert.ToInt32(txtID.Text);
            //foreach (Student a in students)
            //{
            //    if (a.ID == id)
            //    {
            //        lbLastName.Text = a.lastName;
            //        lbName.Text = a.name;
            //        if (a.sex == true)
            //        {
            //            lbSex.Text = "Nam";
            //        }
            //        else
            //        {
            //            lbSex.Text = "Nữ";
            //        }
            //        string date = string.Format("{0:dd/MM/yyyy}", a.birthDate);
            //        lbBirthDate.Text = date;
            //        lbType.Text = a.type.ToString();
            //        break;
            //    }
            //}
            #endregion
            find(L);
           
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = "DanhSach.txt";
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
    }
}
