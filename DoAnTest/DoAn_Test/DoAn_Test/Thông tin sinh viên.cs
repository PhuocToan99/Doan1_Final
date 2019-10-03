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

        private void BtnFind_Click(object sender, EventArgs e)
        {
            List<Student> students = new List<Student>();
            string filePath = @"DanhSach.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();
            char[] c = new char[] { ' ' };
            List<string> datas = new List<string>();
            Boolean re, flag;
            for (int i = 0; i < lines.Count; i++)
            {
                if (i >= 12) datas.Add(lines[i]);
            }
            foreach (var data in datas)
            {
                //string[] entries = data.Split(c, StringSplitOptions.RemoveEmptyEntries);
                Student student = new Student();
                //f.Seek(pos, SeekOrigin.Current);
                //Ghi nho cai nay

                student.ID = Convert.ToInt32(data.Substring(0, 11));
                student.lastName = data.Substring(11, 15);
                student.name = data.Substring(26, 7);
                re = Boolean.TryParse(data.Substring(34, 2), out flag);
                student.sex = re;
                //char[] date = data.Substring(35, 10).ToCharArray();
                string date = data.Substring(35, 10);

                student.birthDate = DateTime.Parse(date);
                //student.birthDate = entries[i + 6];
                student.type = Convert.ToInt32(data.Substring(46, 1));


                students.Add(student);
            }
            int id = Convert.ToInt32(txtID.Text);
            foreach (Student a in students)
            {
                if (a.ID == id)
                {
                    lbLastName.Text = a.lastName;
                    lbName.Text = a.name;
                    if (a.sex == true)
                    {
                        lbSex.Text = "Nam";
                    }
                    else
                    {
                        lbSex.Text = "Nữ";
                    }
                    string date = string.Format("{0:dd/MM/yyyy}", a.birthDate);
                    lbBirthDate.Text = date;
                    lbType.Text = a.type.ToString();
                    break;
                }
            }
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
