using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
