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
    public partial class Perpustakaan : Form
    {
        public Perpustakaan()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Peminjaman form = new Peminjaman();
            form.ShowDialog();
        }

        private void peminjaman_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = peminjaman.SelectedItem.ToString();
            if (value == "127393")
            {
                judulbuku.Text = "Kamus Bahasa Indonesia";
                jenisbuku.Text = "Pelajaran (Bahasa Indonesia)";
                tahunterbit.Text = "2013";
                stokbuku.Text = "8";
            }
            else if (value == "272929")
            {
                judulbuku.Text = "Kamus Bahasa Inggris";
                jenisbuku.Text = "Pelajaran (Bahasa Inggris)";
                tahunterbit.Text = "2019";
                stokbuku.Text = "10";
            }
            else if (value == "326393")
            {
                judulbuku.Text = "Kewarganegaraa";
                jenisbuku.Text = "Pelajaran (PPKn)";
                tahunterbit.Text = "2020";
                stokbuku.Text = "7";
            }
            else if (value == "462931")
            {
                judulbuku.Text = "Sistem Reproduksi Pada Hewan";
                jenisbuku.Text = "Pelajaran (IPA)";
                tahunterbit.Text = "2017";
                stokbuku.Text = "14";
            }
            else if (value == "573938")
            {
                judulbuku.Text = "Sosial dan Ekonomi";
                jenisbuku.Text = "Pelajaran (IPS)";
                tahunterbit.Text = "2018";
                stokbuku.Text = "15";
            }
            else if (value == "673912")
            {
                judulbuku.Text = "Pemrograman";
                jenisbuku.Text = "Pelajaran (Informatika)";
                tahunterbit.Text = "2018";
                stokbuku.Text = "19";
            }
            else if (value == "738279")
            {
                judulbuku.Text = "Rumus Matematika Lengkap";
                jenisbuku.Text = "Pelajaran (Matematika)";
                tahunterbit.Text = "2014";
                stokbuku.Text = "5";
            }
            else if (value == "873923")
            {
                judulbuku.Text = "Sejarah Dunia yang Disembunyikan";
                jenisbuku.Text = "Pelajaran (Sejarah)";
                tahunterbit.Text = "2016";
                stokbuku.Text = "1";
            }
            else if (value == "902839")
            {
                judulbuku.Text = "Seni Tradisional Indonesia";
                jenisbuku.Text = "Pelajaran (Seni)";
                tahunterbit.Text = "2015";
                stokbuku.Text = "15";
            }
            else if (value == "A-872930")
            {
                judulbuku.Text = "Birthdeath";
                jenisbuku.Text = "Fiksi, fantasi";
                tahunterbit.Text = "2021";
                stokbuku.Text = "12";
            }
            else if (value == "B-882928")
            {
                judulbuku.Text = "The Impostor's Among Us";
                jenisbuku.Text = "Fiksi, misteri";
                tahunterbit.Text = "2016";
                stokbuku.Text = "13";
            }
            else if (value == "C-772379")
            {
                judulbuku.Text = "The Culprit Of The Tragedy";
                jenisbuku.Text = "Fiksi, misteri";
                tahunterbit.Text = "2018";
                stokbuku.Text = "6";
            }
            else if (value == "D-652920")
            {
                judulbuku.Text = "Edelweiss";
                jenisbuku.Text = "Fiksi, fantasi";
                tahunterbit.Text = "2018";
                stokbuku.Text = "6";
            }
            else if (value == "E-472692")
            {
                judulbuku.Text = "Ghoul";
                jenisbuku.Text = "Fiksi, fantasi";
                tahunterbit.Text = "2016";
                stokbuku.Text = "13";
            }
            else if (value == "F-237190") 
            {
                judulbuku.Text = "Revenge";
                jenisbuku.Text = "Fiksi, misteri";
                tahunterbit.Text = "2012";
                stokbuku.Text = "9";
            }
            else if (value == "G-972719")
            {
                judulbuku.Text = "The Midnight Carnival";
                jenisbuku.Text = "Fiksi, fantasi";
                tahunterbit.Text = "2013";
                stokbuku.Text = "2";
            }
            else if (value == "H-873739")
            {
                judulbuku.Text = "Seven Wishes";
                jenisbuku.Text = "Fiksi, pertemanan";
                tahunterbit.Text = "2015";
                stokbuku.Text = "7";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = peminjaman.Text;
            string y = judulbuku.Text;
            string i = jenisbuku.Text;
            string l = tahunterbit.Text;
            string a = stokbuku.Text;

            dataGridView1.Rows.Add(s, y, i, l, a);

            if (peminjaman.Text.Trim() == "" || judulbuku.Text.Trim() == "" || jenisbuku.Text.Trim() == "" || tahunterbit.Text.Trim() == "" || stokbuku.Text.Trim() == "") ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            peminjaman.Text = "";
            judulbuku.Text = "";
            jenisbuku.Text = "";
            tahunterbit.Text = "";
            stokbuku.Text = "";
        }
    }
}
