using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomAttributeOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad = textBox1.Text;
            ogrenci.Soyad = textBox2.Text;
            ogrenci.Bolum = textBox3.Text;

            if (ZorunlulukKontrolu.bilgileriDogrula(ogrenci))
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            
        }
    }
}
