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
        public bool sex { get; set; }
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
            Boolean sex;
            DateTime birthDate;
            Boolean re, flag;
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
                re = Boolean.TryParse(data.Substring(34, 2), out flag);
                sex = re;
                //char[] date = data.Substring(35, 10).ToCharArray();
                string date = data.Substring(35, 10);

                birthDate = DateTime.Parse(date);
                //student.birthDate = entries[i + 6];
                type = Convert.ToInt32(data.Substring(46, 1));
                addStudent(p, ID, lastName, name, sex, birthDate, type);
                addst(ref L, p);
                //students.Add(student);

            }
            return L;
        }

        public Boolean addStudent(LinkListStudent p, int ID, string lastName, string name, Boolean sex, DateTime birthDate, int type)
        {
            p.ID = ID;
            p.lastName = lastName;
            p.name = name;
            p.sex = sex;
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

    }
}
