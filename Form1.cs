using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace öğrencibilgisistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" ||
        textBox2.Text == "" ||
        textBox3.Text == "" ||
        comboBox1.Text == "" ||
        textBox5.Text == "" ||
        textBox6.Text == "")
            {
                MessageBox.Show("Tüm alanları doldurun!");
                return;
            }

            int vize = Convert.ToInt32(textBox5.Text);
            int final = Convert.ToInt32(textBox6.Text);

            double ortalama = (vize * 0.4) + (final * 0.6);

            textBox7.Text = ortalama.ToString();

            string bilgi =
                "Ad Soyad: " + textBox1.Text +
                " | Numara: " + textBox2.Text +
                " | Bölüm: " + textBox3.Text +
                " | Ders: " + comboBox1.Text +
                " | Ortalama: " + ortalama;

            listBox1.Items.Add(bilgi);

            MessageBox.Show("Öğrenci bilgisi eklendi.");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;
            textBox5.Clear();
            textBox6.Clear();


            listBox1.Items.Clear();
        }
    }
}
