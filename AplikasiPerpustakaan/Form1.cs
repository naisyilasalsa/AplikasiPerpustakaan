using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AplikasiPerpustakaan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( PwTb.Text == "username" || unameTb.Text == "")
            {
                MessageBox.Show("Missing Information");
                unameTb.Text = "";
                PwTb.Text = "";

            }
            else if (PwTb.Text == "syila" && unameTb.Text == "pplg")
            {
                Anggota obj = new Anggota();
                obj.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Wrong Username Or/And Password");
                unameTb.Text = "";
                PwTb.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

       

       

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked)
            {
                unameTb.UseSystemPasswordChar = false;




            }
            else
            {
                unameTb.UseSystemPasswordChar = true;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }
    

