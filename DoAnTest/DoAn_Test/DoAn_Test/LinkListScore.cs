using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DoAn_Test
{
    class LinkListScore
    {
        public int id { get; set; }
        public double mathScore { get; set; }
        public double literatureScore { get; set; }
        public double englishScore { get; set; }
        public LinkListScore Next;
        public LinkListScore()
        {
            id = 0;
            mathScore = literatureScore = englishScore = 0;
            Next = null;
        }
         public LinkListScore loadListScore(LinkListScore L)
        {
            string filePath = @"DiemThi.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();
            char[] c = new char[] { ' ' };
            List<string> datas = new List<string>();
            int id = 0;
            double mathScore = 0, literatureScore = 0, englishScore = 0;
            for (int i = 0; i < lines.Count; i++)
            {
                if (i >= 9) datas.Add(lines[i]);
            }
            foreach (var data in datas)
            {

                string[] entries = data.Split(c, StringSplitOptions.RemoveEmptyEntries);
                LinkListScore p = new LinkListScore();
                //Ghi nho cai nay
                for (int i = 0; i < entries.Length; i++)
                {
                    id = Convert.ToInt32(entries[i]);
                    mathScore = Convert.ToDouble(entries[i + 1]);
                    literatureScore = Convert.ToDouble(entries[i + 2]);
                    englishScore = Convert.ToDouble(entries[i + 3]);
                    break;
                }
                addScore(p, id, mathScore, literatureScore, englishScore);
                addS(ref L, p);
            }
            return L;
        }
        public Boolean addScore(LinkListScore p, int ID, double mathScore, double literatureScore, double englishScore)
        {
            p.id = ID;
            p.mathScore = mathScore;
            p.literatureScore = literatureScore;
            p.englishScore = englishScore;
            return true;
        }
        public void addS(ref LinkListScore L, LinkListScore p)
        {
            if (L == null) L = p;
            else
            {
                LinkListScore q = L;
                while (q.Next != null) q = q.Next;
                q.Next = p;
            }
        }
        public List<string> changesc(LinkListScore F)
        {
            List<string> lines = new List<string>();
            LinkListScore p = F;
            //string date = string.Format("{0:dd/MM/yyyy}", p.birthDate);
            while (p != null)
            {

                lines.Add(tabsc(p.id.ToString(), 3) + tabsc(p.mathScore.ToString(), 2) + tabsc(p.literatureScore.ToString(), 2) + tabsc(p.englishScore.ToString(), 2));
                p = p.Next;
            }
            return lines;

        }
        public static string tabsc(string s, int w)
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
