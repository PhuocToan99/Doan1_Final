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
    public partial class frmShowInFile : Form
    {
        public frmShowInFile()
        {
            InitializeComponent();
        }
        public string source;
        private void FrmShowInFile_Load(object sender, EventArgs e)
        {
        List<string> lines = File.ReadAllLines(source).ToList();
            foreach (string s in lines)
            {
                txtShow.Text = string.Join(Environment.NewLine, lines);
            }
        }
    }
}
