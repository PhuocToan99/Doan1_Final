using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DoAn_Test
{
    class LinkListStudent
    {
        public int ID { get; set; }
        public string lastName { get; set; }
        public string name { get; set; }
        public string sex { get; set; }
        public DateTime birthDate { get; set; }
        //public string birthDate { get; set; }
        public int type { get; set; }
        public LinkListStudent Next;

        public LinkListStudent()
        {
            ID = type = 0;
            lastName = name = String.Empty;
            Next = null;
        }
        public LinkListStudent loadListStudent(LinkListStudent L)
        {
            List<string> lines = File.ReadAllLines("DanhSach.txt").ToList();
            List<string> datas = new List<string>();

            int ID, type;
            string lastName, name;
            DateTime birthDate;
            string re;
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
                addst(ref L, p);
                //students.Add(student);

            }
            return L;
        }

        public Boolean addStudent(LinkListStudent p, int ID, string lastName, string name, int sex, DateTime birthDate, int type)
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
        public void addst(ref LinkListStudent L, LinkListStudent p)
        {
            if (L == null) L = p;
            else
            {
                LinkListStudent q = L;
                while (q.Next != null) q = q.Next;
                q.Next = p;
            }
        }
        public Boolean addStudent1(LinkListStudent p, int ID, string lastName, string name, string sex, DateTime birthDate, int type)
        {
            p.ID = ID;
            p.lastName = lastName;
            p.name = name;
            p.sex = sex;
            p.birthDate = birthDate;
            p.type = type;
            return true;
        }
        public List<string> changest(LinkListStudent F)
        {
            List<string> lines = new List<string>();
            LinkListStudent p = F;
            string date = string.Format("{0:dd/MM/yyyy}", p.birthDate);
            while (p != null)
            {
                lines.Add(tabst(p.ID.ToString(), 3) + tabst(p.lastName, 15) + tabst(p.name, 10) + tabst(p.sex, 3) + tabst(date, 12) + p.type);
                p = p.Next;
            }
            return lines;

        }
        public static string tabst(string s, int w)
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
