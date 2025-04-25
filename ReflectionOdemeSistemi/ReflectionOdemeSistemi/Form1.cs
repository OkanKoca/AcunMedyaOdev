using ReflectionOdemeSistemi.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReflectionOdemeSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            string rootPath = @"C:\Users\Lenovo\Desktop\ACUNMEDYA\ödevler\ReflectionOdemeSistemi\ReflectionOdemeSistemi";
            List<string> odemeYontemleri = odemeYontemleriniListele(rootPath);
            foreach(string odemeYontemi in odemeYontemleri)
            {
                comboBox1.Items.Add(odemeYontemi);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox1.Text, out decimal tutar))
            {
                string rootPath = @"C:\Users\Lenovo\Desktop\ACUNMEDYA\ödevler\ReflectionOdemeSistemi\ReflectionOdemeSistemi";
                var instance = odemeYontemiBul(rootPath, comboBox1.SelectedItem.ToString());
                string sonuc = instance.Ode(tutar);
                label4.Text = sonuc;
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir ödeme yöntemi ve tutar giriniz.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private List<string> odemeYontemleriniListele(string rootPath)
        {
            List<string> odemeYontemleri = new List<string>();
            string[] directories = Directory.GetDirectories(rootPath);

            foreach(string dir in directories)
            {
                string[] files = Directory.GetFiles(dir, "*.cs");
                foreach (string file in files)
                {
                    string[] lines = File.ReadAllLines(file);

                    foreach(string line in lines)
                    {
                        if (line.Contains("class") && line.Contains("IOdemeYontemi"))
                        {
                            string[] words = line.Split(' ');
                            int index = Array.IndexOf(words, "class");
                            string className = words[index + 1];
                            odemeYontemleri.Add(className);
                        }
                    }
                }
            }
            return odemeYontemleri;
        }

        private IOdemeYontemi odemeYontemiBul(string rootPath, string odemeYontemi)
        {
            odemeYontemi = odemeYontemi.Trim(' ');
            string[] directories = Directory.GetDirectories(rootPath);

            foreach (string dir in directories)
            {
                string[] files = Directory.GetFiles(dir, "*.cs");
                foreach (string file in files)
                {
                    string[] lines = File.ReadAllLines(file);

                    foreach (string line in lines)
                    {
                        if (line.Contains("class") && line.Contains("IOdemeYontemi") && line.Contains(odemeYontemi))
                        {
                            string[] words = line.Split(' ');
                            int index = Array.IndexOf(words, "class");
                            string className = words[index + 1];

                            string namespaceName = Path.GetFileName(dir);

                            string fullClassName = $"ReflectionOdemeSistemi.{namespaceName}.{className}";

                            Type type = Type.GetType(fullClassName);
                            if (type != null && typeof(IOdemeYontemi).IsAssignableFrom(type))
                            {
                                return (IOdemeYontemi)Activator.CreateInstance(type);
                            }

                        }
                    }
                }
            }
            return null;
        }
    }
}
