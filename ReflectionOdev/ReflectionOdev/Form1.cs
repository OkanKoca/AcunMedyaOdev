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

namespace ReflectionOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde çalışacak kodlar
            string rootPath = @"C:\Users\Lenovo\Desktop\ACUNMEDYA\ödevler\ReflectionOdev\ReflectionOdev\Folders";
            ListClasses(rootPath);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListClasses(string rootPath)
        {
            listBox1.Items.Clear();
            string[] directories = Directory.GetDirectories(rootPath);

            foreach (string dir in directories)
            {
                string folderName = Path.GetFileName(dir);
                listBox1.Items.Add("📁 " + folderName);

                string[] csFiles = Directory.GetFiles(dir, "*.cs");
                foreach (string file in csFiles)
                {
                    string[] lines = File.ReadAllLines(file);
                    foreach (string line in lines)
                    {
                        if (line.Trim().Contains("class"))
                        {
                            // Sadece class satırını alır, class ismini ayıklar
                            string[] words = line.Trim().Split(' ');
                            int index = Array.IndexOf(words, "class");
                            if (index >= 0 && index < words.Length - 1)
                            {
                                string className = words[index + 1];
                                listBox1.Items.Add("   📄 " + className);
                            }
                        }
                    }
                }
            }
        }

    }
}
