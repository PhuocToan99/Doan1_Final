using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_Test
{
    class LinkListFullInfo
    {
        public int ID { get; set; }
        public string lastName { get; set; }
        public string name { get; set; }
        public string sex { get; set; }

        public DateTime birthdate { get; set; }
        public double mathScore { get; set; }
        public double literatureScore { get; set; }
        public double englishScore { get; set; }
        public double minScore { get; set; }
        public double totalScore { get; set; }
        public string rank { get; set; }
        public int type { get; set; }
        public LinkListFullInfo Next;
        
        public LinkListFullInfo()
        {
            ID = type = 0;
            lastName = name = rank = String.Empty;
            minScore = mathScore = literatureScore = englishScore = totalScore = 0;
            Next = null;
        }
        
        public LinkListFullInfo loadfullInfo(LinkListFullInfo F)
        {
            Console.OutputEncoding = Encoding.Unicode;
            LinkListStudent S = new LinkListStudent();
            S.loadListStudent(S);
            LinkListScore L = new LinkListScore();
            L.loadListScore(L);
            DateTime temp = DateTime.Now;
            int ID, type, dut;
            DateTime birthdate;
            string sex;
            string lastName, name, rank;
            double mathScore, literatureScore, englishScore, totalScore, minScore;
            while (S != null && L != null)
            {
                LinkListFullInfo p = new LinkListFullInfo();
                ID = S.ID;
                lastName = S.lastName;
                name = S.name;
                sex = S.sex;
                type = S.type;
                mathScore = L.mathScore;
                literatureScore = L.literatureScore;
                englishScore = L.englishScore;
                minScore = scoreMin(L.mathScore, L.literatureScore, L.englishScore);
                if (S.type == 1) dut = 2;
                else if (S.type == 2) dut = 1;
                else dut = 3;
                totalScore = L.mathScore + L.literatureScore + L.englishScore + dut;
                if (totalScore >= 24 && minScore >= 7) rank = "Giỏi";
                else if (totalScore >= 21 && minScore >= 6 && totalScore<24 && minScore<7) rank = "Khá";
                else if (totalScore >= 15 && minScore >= 4 && totalScore <21 && minScore<6) rank = "Trung Bình";
                else rank = "Trượt";
                birthdate = S.birthDate;
                addFullInfo(p, ID, lastName, name, sex,birthdate, mathScore, literatureScore, englishScore, minScore, totalScore, rank, type);
                addFull(ref F, p);
                S = S.Next;
                L = L.Next;
            }
            return F;
        }
        public double scoreMin(double a, double b, double c)
        {
            double min = a;
            if (min < b) min = b;
            if (min < c) min = c;
            return min;
        }
        public Boolean addFullInfo(LinkListFullInfo p, int ID, string lastName, string name, string sex, /*int age*/ DateTime birthdate, double mathScore, double literatureScore, double englishScore, double minScore, double totalScore, string rank, int type)
        {
            p.ID = ID;
            p.lastName = lastName;
            p.name = name;
            p.sex = sex;
            p.birthdate = birthdate;
            p.mathScore = mathScore;
            p.literatureScore = literatureScore;
            p.englishScore = englishScore;
            p.minScore = minScore;
            p.totalScore = totalScore;
            p.rank = rank;
            p.type = type;
            return true;
        }
        public static void addFull(ref LinkListFullInfo L, LinkListFullInfo p)
        {
            if (L == null) L = p;
            else
            {
                LinkListFullInfo q = L;
                while (q.Next != null) q = q.Next;
                q.Next = p;
            }
        }
        public LinkListFullInfo setStGioi(LinkListFullInfo F)
        {
            Console.OutputEncoding = Encoding.Unicode;
            LinkListStudent S = new LinkListStudent();
            S.loadListStudent(S);
            LinkListScore L = new LinkListScore();
            L.loadListScore(L);
            DateTime temp = DateTime.Now;
            int ID, type, dut;
            DateTime birthdate;
            string sex;
            string lastName, name, rank=null;
            double mathScore, literatureScore, englishScore, totalScore, minScore;
            while (S != null && L != null)
            {
                LinkListFullInfo p = new LinkListFullInfo();
                ID = S.ID;
                lastName = S.lastName;
                name = S.name;
                sex = S.sex;
                type = S.type;
                mathScore = L.mathScore;
                literatureScore = L.literatureScore;
                englishScore = L.englishScore;
                minScore = scoreMin(L.mathScore, L.literatureScore, L.englishScore);
                if (S.type == 1) dut = 2;
                else if (S.type == 2) dut = 1;
                else dut = 3;
                totalScore = L.mathScore + L.literatureScore + L.englishScore + dut;
                birthdate = S.birthDate;
                if (totalScore >= 24 && minScore >= 7)
                {
                    rank = "Giỏi";

                    addFullInfo(p, ID, lastName, name, sex, birthdate, mathScore, literatureScore, englishScore, minScore, totalScore, rank, type);
                    addFull(ref F, p);
                } 
                S = S.Next;
                L = L.Next;
            }
            return F;
        }
        #region
        public LinkListFullInfo setStKha(LinkListFullInfo F)
        {
            Console.OutputEncoding = Encoding.Unicode;
            LinkListStudent S = new LinkListStudent();
            S.loadListStudent(S);
            LinkListScore L = new LinkListScore();
            L.loadListScore(L);
            DateTime temp = DateTime.Now;
            int ID, type, dut;
            string sex;
            string lastName, name, rank = null;
            double mathScore, literatureScore, englishScore, totalScore, minScore;
            DateTime birthdate;
            while (S != null && L != null)
            {
                LinkListFullInfo p = new LinkListFullInfo();
                ID = S.ID;
                lastName = S.lastName;
                name = S.name;
                sex = S.sex;
                type = S.type;
                mathScore = L.mathScore;
                literatureScore = L.literatureScore;
                englishScore = L.englishScore;
                minScore = scoreMin(L.mathScore, L.literatureScore, L.englishScore);
                if (S.type == 1) dut = 2;
                else if (S.type == 2) dut = 1;
                else dut = 3;
                totalScore = L.mathScore + L.literatureScore + L.englishScore + dut;
                birthdate = S.birthDate;
                if (totalScore >= 21 && minScore >= 6 && totalScore<24 && minScore<7)
                {
                    rank = "Khá";
                    addFullInfo(p, ID, lastName, name, sex, birthdate, mathScore, literatureScore, englishScore, minScore, totalScore, rank, type);
                    addFull(ref F, p);
                }
                S = S.Next;
                L = L.Next;
            }
            return F;
        }
        public LinkListFullInfo Merge(LinkListFullInfo first, LinkListFullInfo second)
        {
            LinkListFullInfo result = null;
            if (first == null)
            {
                return second;
            }
            else if (second == null)
            {
                return first;
            }

            if (first.totalScore > second.totalScore)
            {
                if (first.rank == "Khá" && second.rank == "Giỏi")
                {
                    result = second;
                    result.Next = Merge(first, second.Next);
                }
                else
                {
                    result = first;
                    result.Next = Merge(first.Next, second);
                }
            }
            else
            {
                if (first.rank == "Giỏi" && second.rank == "Khá")
                {
                    result = first;
                    result.Next = Merge(first.Next, second);
                }
                else
                {
                    result = second;
                    result.Next = Merge(first, second.Next);
                }
            }

            return result;
        }
        #endregion
        #region
        //Sort->Nho cai nay
        public LinkListFullInfo MergeSort(LinkListFullInfo node)
        {
            if (node.Next == null)
            {
                return node;
            }

            var middle = GetMiddle(node);
            var nextToMiddle = middle.Next;
            middle.Next = null;
            node = MergeSort(node);
            nextToMiddle = MergeSort(nextToMiddle);
            var sortedLinkedList = Merge(node, nextToMiddle);
            return sortedLinkedList;
        }

        public LinkListFullInfo GetMiddle(LinkListFullInfo node)
        {
            if (node?.Next == null)
            {
                return node;
            }

            var fastPointer = node.Next;
            var slowPointer = node;
            while (fastPointer != null)
            {
                fastPointer = fastPointer.Next;
                if (fastPointer != null)
                {
                    fastPointer = fastPointer.Next;
                    slowPointer = slowPointer.Next;
                }
            }

            return slowPointer;
        }
        //Chia cot->Nho
        public static string tab(string s, int w)
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

    public List<string> change(LinkListFullInfo F)
        {
            List<string> lines=new List<string>();
            LinkListFullInfo p =F;
            string date = string.Format("{0:dd/MM/yyyy}", p.birthdate);
            while (p != null)
            {
                lines.Add(tab(p.ID.ToString(),3) + tab(p.lastName,15)  + tab(p.name,10) + tab(p.sex,3) + tab(date, 12) + "  " + tab(p.mathScore.ToString(),3) + tab(p.literatureScore.ToString(),2) + tab(p.englishScore.ToString(),2) + tab(p.totalScore.ToString(),2) + " " + tab(p.rank,3) + " " + p.type);
                p = p.Next;
            }
            return lines;

        }
        #endregion
       
        public LinkListFullInfo setStTruot(LinkListFullInfo F)
        {
            Console.OutputEncoding = Encoding.Unicode;
            LinkListStudent S = new LinkListStudent();
            S.loadListStudent(S);
            LinkListScore L = new LinkListScore();
            L.loadListScore(L);
            DateTime temp = DateTime.Now;
            int ID, type, dut;
            string sex;
            string lastName, name, rank = null;
            double mathScore, literatureScore, englishScore, totalScore, minScore;
            DateTime birthdate;
            while (S != null && L != null)
            {
                LinkListFullInfo p = new LinkListFullInfo();
                ID = S.ID;
                lastName = S.lastName;
                name = S.name;
                sex = S.sex;
                type = S.type;
                mathScore = L.mathScore;
                literatureScore = L.literatureScore;
                englishScore = L.englishScore;
                minScore = scoreMin(L.mathScore, L.literatureScore, L.englishScore);
                if (S.type == 1) dut = 2;
                else if (S.type == 2) dut = 1;
                else dut = 3;
                totalScore = L.mathScore + L.literatureScore + L.englishScore + dut;
                birthdate = S.birthDate;
                if (mathScore==0 || literatureScore==0 || englishScore == 0)
                {

                    S = S.Next;
                    L = L.Next;
                    continue;
                }
                if (totalScore < 15 || minScore < 4)
                {
                    rank = "Trượt";
                    addFullInfo(p, ID, lastName, name, sex, birthdate, mathScore, literatureScore, englishScore, minScore, totalScore, rank, type);
                    addFull(ref F, p);
                }
                

                S = S.Next;
                L = L.Next;
            }
            return F;
        }
        public LinkListFullInfo MergeFail(LinkListFullInfo first, LinkListFullInfo second)
        {
            LinkListFullInfo result = null;
            if (first == null)
            {
                return second;
            }
            else if (second == null)
            {
                return first;
            }
            if (first.type == second.type)
            {
                if (first.totalScore > second.totalScore)
                {
                    result = first;
                    result.Next = MergeFail(first.Next, second);
                }
                else
                {
                    result = second;
                    result.Next = MergeFail(first, second.Next);
                }
            }
            if (first.type < second.type)
            {
                result = first;
                result.Next = MergeFail(first.Next, second);
            }
            if (second.type < first.type)
            {
                result = second;
                result.Next = MergeFail(first, second.Next);
            }


            return result;
        }
        public LinkListFullInfo MergeSortFail(LinkListFullInfo node)
        {
            if (node.Next == null)
            {
                return node;
            }
            var middle = GetMiddle(node);
            var nextToMiddle = middle.Next;
            middle.Next = null;
            node = MergeSortFail(node);
            nextToMiddle = MergeSortFail(nextToMiddle);
            var sortedLinkedList = MergeFail(node, nextToMiddle);
            return sortedLinkedList;
        }
        public int count(LinkListFullInfo F, int type)
        {
            Console.OutputEncoding = Encoding.Unicode;
            LinkListStudent S = new LinkListStudent();
            S.loadListStudent(S);
            LinkListScore L = new LinkListScore();
            L.loadListScore(L);
            DateTime temp = DateTime.Now;
            int typeset, dut;
            DateTime birthdate;
            string rank = null;
            int count = 0;
            double mathScore, literatureScore, englishScore, totalScore, minScore;
            while (S != null && L != null)
            {
                typeset = S.type;
                mathScore = L.mathScore;
                literatureScore = L.literatureScore;
                englishScore = L.englishScore;
                minScore = scoreMin(L.mathScore, L.literatureScore, L.englishScore);
                if (S.type == 1) dut = 2;
                else if (S.type == 2) dut = 1;
                else dut = 3;
                totalScore = L.mathScore + L.literatureScore + L.englishScore + dut;
                birthdate = S.birthDate;
                if (mathScore == 0 || literatureScore == 0 || englishScore == 0)
                {

                    S = S.Next;
                    L = L.Next;
                    continue;
                }
                if (totalScore < 15 || minScore < 4)
                {
                    rank = "Trượt";
                    if (typeset == type)
                    {
                        count++;
                    }
                }


                S = S.Next;
                L = L.Next;
            }
            return count;
        }
        public int total(LinkListFullInfo F, int type)
        {
            int total = 0;
            LinkListFullInfo p = F;
            while (p != null)
            {
                if (p.type == type)
                {
                    total++;
                }
                p = p.Next;
            }
            return total;
        }
        public LinkListFullInfo loadStudentType(LinkListFullInfo F, int type)
        {
            Console.OutputEncoding = Encoding.Unicode;
            LinkListStudent S = new LinkListStudent();
            S.loadListStudent(S);
            LinkListScore L = new LinkListScore();
            L.loadListScore(L);
            DateTime temp = DateTime.Now;
            int ID, type1, dut;
            string sex;
            string lastName, name, rank = null;
            DateTime birthdate;
            double mathScore, literatureScore, englishScore, totalScore, minScore;
            while (S != null && L != null)
            {
                if (S.type != type)
                {
                    S = S.Next;
                    L = L.Next;
                    continue;
                }
                else
                {
                    LinkListFullInfo p = new LinkListFullInfo();
                    ID = S.ID;
                    lastName = S.lastName;
                    name = S.name;
                    sex = S.sex;
                    type1 = S.type;
                    mathScore = L.mathScore;
                    literatureScore = L.literatureScore;
                    englishScore = L.englishScore;
                    minScore = scoreMin(L.mathScore, L.literatureScore, L.englishScore);

                    if (S.type == 1) dut = 2;
                    else if (S.type == 2) dut = 1;
                    else dut = 3;
                    birthdate = S.birthDate;
                    totalScore = L.mathScore + L.literatureScore + L.englishScore + dut;
                    if (totalScore >= 24 && minScore >= 7) rank = "Giỏi";
                    if (totalScore >= 21 && totalScore < 24)
                    {
                        if ( minScore >= 6)
                            rank = "Khá";
                    }
                    if (totalScore >= 15 && totalScore < 21)
                    {
                        if (minScore >= 4)
                            rank = "Trung Bình";

                    }
                    if (totalScore < 15 || totalScore < 15 && minScore < 4 || minScore < 4) rank = "Trượt";
                    addFullInfo(p, ID, lastName, name, sex, birthdate, mathScore, literatureScore, englishScore, minScore, totalScore, rank, type);
                    addFull(ref F, p);

                }
                S = S.Next;
                L = L.Next;
            }
            return F;
        }
    }
}
