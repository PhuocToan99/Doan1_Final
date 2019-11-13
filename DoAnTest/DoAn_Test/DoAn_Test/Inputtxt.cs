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
    public partial class frmFile : Form
    {
        public frmFile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbtDanhsach.Checked == true)
            {
                loadDanhSach();
            }
            if (rbtDiem.Checked == true)
            {
                loadDiem();
            }
            if (rbtDoiTuong.Checked == true)
            {
                loadDoiTuong();
            }
        }
        private void loadDanhSach()
        {
            List<string> lines = File.ReadAllLines("DanhSach.txt").ToList();
            List<string> datas = new List<string>();


            string lastName, name, ID, type, gender;
            DateTime birthDate;
            string re;
            int flag;
            for (int i = 0; i < lines.Count; i++)
            {
                if (i >= 12)
                {
                    ID = lines[i].Substring(0, 11);
                    lastName = lines[i].Substring(11, 15);
                    name = lines[i].Substring(26, 7);
                    re = lines[i].Substring(34, 2);
                    string date = lines[i].Substring(35, 10);
                    type = lines[i].Substring(46, 1);
                    datas.Add(tab(ID, 3) + lastName + tab(name, 10) + tab(re, 1) + tab(date, 12) + type);
                    
                }
                else
                {
                    datas.Add(lines[i]);
                }
            }
            foreach (string s in datas)
            {
                txtShow.Text = string.Join(Environment.NewLine, datas);
            }

        }
        private void loadDiem()
        {
            string filePath = @"DiemThi.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();
            char[] c = new char[] { ' ' };
            List<string> datas = new List<string>();
            int id = 0;
            string mathScore, literatureScore, englishScore;
            for (int i = 0; i < lines.Count; i++)
            {
                if (i >= 9)
                {
                    string[] entries = lines[i].Split(c, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < entries.Length; j++)
                    {
                        id = Convert.ToInt32(entries[j]);
                        mathScore = entries[j + 1];
                        literatureScore = entries[j + 2];
                        englishScore = entries[j + 3];
                        datas.Add(tab(id.ToString(), 3) + tab(mathScore, 2) + tab(literatureScore, 2) + tab(englishScore, 2));
                        break;
                    }

                }
                else
                {
                    datas.Add(lines[i]);
                }
            }


            foreach (string s in datas)
            {
                txtShow.Text = string.Join(Environment.NewLine, datas);
            }
        }
        private void loadDoiTuong()
        {
            List<string> lines = File.ReadAllLines("ChiTietDT.txt").ToList();
            List<string> datas = new List<string>();
            string DoiTuongDT, DienGiaiDT, DiemUT;
            for (int i = 0; i < lines.Count; i++)
            {
                if (i >= 9)
                {
                    DoiTuongDT = lines[i].Substring(0, 3);
                    DienGiaiDT = lines[i].Substring(3, 50);
                    DiemUT = lines[i].Substring(53, 11);
                    datas.Add(tab(DoiTuongDT, 3) + tab(DienGiaiDT, 60) + tab(DiemUT, 11));
                }
                else
                {
                    datas.Add(lines[i]);
                }
            }


            foreach (string s in datas)
            {
                txtShow.Text = string.Join(Environment.NewLine, datas);
            }

        }
        private string tab(string s, int w)
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
    }
}
