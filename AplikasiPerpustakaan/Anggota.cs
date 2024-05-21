using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiPerpustakaan
{
    public partial class Anggota : Form
    {
        public Anggota()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Perpustakaan form = new Perpustakaan(); 
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string y = textBox2.Text;
            string i = textBox3.Text;
            string l = comboBox1.Text;
            string a = dateTimePicker1.Text;

            dataGridView1.Rows.Add(s, y, i, l, a);

            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || comboBox1.Text.Trim() == "" || dateTimePicker1.Text.Trim() == "") ;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            dateTimePicker1.Text = "";
        }
    }
}
