using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            object[] sehir = { "Isparta", "Burdur", "Antalya", "Ankara" };
            comboBox2.Items.AddRange(sehir);

            object[] cns = { "ERKEK", "KADIN" };
            comboBox1.Items.AddRange(cns);

            object[] MEB = {"İLK OKUL" ,"ORTA OKUL","LİSE","ÜNİVERSİTE","YÜKSEK LİSANS"};
            comboBox3.Items.AddRange(MEB);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add (textBox1.Text + " - " + textBox2.Text + " - "+ textBox3.Text + " - " + comboBox1.SelectedItem + " - " + comboBox2.SelectedItem + " - " + comboBox3.SelectedItem + " - ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
             listBox1.Items.RemoveAt(comboBox1.SelectedIndex);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
