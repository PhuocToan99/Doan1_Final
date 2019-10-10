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

      
    }
}
