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
namespace DoAnTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //string filename = textBox1.Text;
            //string filePath = @"{1}" + filename;

            //string[] lines;
            //string str;

            //if (System.IO.File.Exists(filePath))
            //{
            //    //lines = System.IO.File.ReadAllLines(filePath);
            //    //for (int i = 0; i < lines.Length; i++)
            //    //{
            //    //    Console.WriteLine("Line {0}: {1}", i, lines[i]);
            //    //}
            //    //Console.WriteLine();

            //    //str = System.IO.File.ReadAllText(filePath);
            //    //Console.WriteLine("String: {0}", str);
            //    StreamReader read = new StreamReader(textBox1.Text);
            //    textBox2.Text = read.ReadToEnd();
            //    read.Close();
            //}
            //else
            //{
            //    Console.WriteLine("File does not exist");
            //}
            //if (textBox1.Text == null)
            //    MessageBox.Show("Không để trống tên file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            try
            {
                StreamReader read = new StreamReader(textBox1.Text);
                textBox2.Text = read.ReadToEnd();
                string text = read.ReadToEnd();
                richTextBox1.Text = text;
                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Stream mysteam;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((mysteam = openFileDialog.OpenFile()) != null)
                {
                    string fileName = openFileDialog.FileName;
                    MessageBox.Show(fileName);
                    textBox1.Text = fileName;

                    //textBox1.Text = fileName;

                    //string fileText = File.ReadAllText(fileName);
                    ////richTextBox1.Text = fileText;
                    //textBox1.Text = fileText;
                }
            }
        }
    }
}
