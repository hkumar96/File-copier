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

namespace Copier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string path;
            string[] files, dirs;
            folderBrowserDialog1.ShowDialog();
            path = folderBrowserDialog1.SelectedPath;
            files = Directory.GetFiles(path+@"\");
            dirs = Directory.GetDirectories(path + @"\");
            comboBox1.Items.Clear();
            foreach (string name in dirs)
            {
                comboBox1.Items.Add(Path.GetFileName(name));
            }
            foreach (string name in files)
            {
                comboBox1.Items.Add(Path.GetFileName(name));
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string path;
            string[] files, dirs;
            folderBrowserDialog1.ShowDialog();
            path = folderBrowserDialog1.SelectedPath;
            files = Directory.GetFiles(path + @"\");
            dirs = Directory.GetDirectories(path + @"\");
            comboBox2.Items.Clear();
            foreach (string name in dirs)
            {
                comboBox2.Items.Add(Path.GetFileName(name));
            }
            foreach (string name in files)
            {
                comboBox2.Items.Add(Path.GetFileName(name));
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            for (int i=0;i<comboBox1.Items.Count;i++)
            {
                if (!comboBox2.Items.Contains(comboBox1.Items[i].ToString()))
                    comboBox3.Items.Add(comboBox1.Items[i]);
            }
        }
    }
}
