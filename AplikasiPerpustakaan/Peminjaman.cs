using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiPerpustakaan
{
    public partial class Peminjaman : Form
    {
        public Peminjaman()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void peminjaman_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            }

        private void perminjaman_SelectedIndexChanged(object sender, EventArgs e)
     
        {
            string value = perminjaman.SelectedItem.ToString();
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

        private void id_SelectedIndexChanged(object sender, EventArgs e)
        {
        string value = id.SelectedItem.ToString();
            if (value == "11438")
            {
                nama.Text = "ACHMAD FAJRI ROBBANI";
                alamat.Text = "A";
            }
            else if (value == "11452")
            {
                nama.Text = "AFRICHATUL QULUBIYAH";
                alamat.Text = "B";
            }
            else if (value == "11453")
            {
                nama.Text = "AGHISNA AULADAH";
                alamat.Text = "C";
            }
            else if (value == "11511")
            {
                nama.Text = "ARYA PUTRA ARDIANSYAH";
                alamat.Text = "D";
            }
            else if (value == "11527")
            {
                nama.Text = "AZZAM AHMAD ZAIN";
                alamat.Text = "E";
            }
            else if (value == "11558")
            {
                nama.Text = "DEVIE NALIVA APRILIANI";
                alamat.Text = "F";
            }
            else if (value == "11567")
            {
                nama.Text = "DIEN DZIKRINA FAJRIE";
                alamat.Text = "G";
            }
            else if (value == "11611")
            {
                nama.Text = "GALUH HAYYUNING EKA";
                alamat.Text = "H";
            }
            else if (value == "11655")
            {
                nama.Text = "KHURNIA DWI RAKHMA";
                alamat.Text = "I";
            }
            else if (value == "11657")
            {
                nama.Text = "KIANDRA WINDA RAHMA";
                alamat.Text = "J";
            }
            else if (value == "11660")
            {
                nama.Text = "LAILATUL UMI NADHIROH";
                alamat.Text = "K";
            }
            else if (value == "11679")
            {
                nama.Text = "M IVAN ZAKARIA";
                alamat.Text = "L";
            }
            else if (value == "11703")
            {
                nama.Text = "MAULIL AYU MASRUROH";
                alamat.Text = "M";
            }
            else if (value == "11766")
            {
                nama.Text = "MOHAMMAD WAHYU RIDHO AL MAJID";
                alamat.Text = "N";
            }
            else if (value == "11793")
            {
                nama.Text = "MUH REZA ALZAM PUTRA EFRIADI";
                alamat.Text = "O";
            }
            else if (value == "11803")
            {
                nama.Text = "MUHAMMAD ALFIN FREDO";
                alamat.Text = "P";
            }
            else if (value == "11873")
            {
                nama.Text = "MUHAMMAD GHOZALI";
                alamat.Text = "Q";
            }
            else if (value == "11845")
            {
                nama.Text = "MUHAMMAD IVAN RIFANSYAH";
                alamat.Text = "R";
            }
            else if (value == "11869")
            {
                nama.Text = "MUHAMMAD RIFKY RAMDHANI";
                alamat.Text = "S";
            }
            else if (value == "11874")
            {
                nama.Text = "M RIZQI HILAL RAMADHAN";
                alamat.Text = "T";
            }
            else if (value == "11878")
            {
                nama.Text = "MUHAMMAD SYABAN HIDAYATULLAH";
                alamat.Text = "U";
            }
            else if (value == "11913")
            {
                nama.Text = "NABILA RIZKY AYU PRATISTA";
                alamat.Text = "V";
            }
            else if (value == "11915")
            {
                nama.Text = "NADHIRA RAHMALIA PUTRI";
                alamat.Text = "W";
            }
            else if (value == "11917")
            {
                nama.Text = "NADIA SYAHARANI AZ ZAHRA";
                alamat.Text = "X";
            }
            else if (value == "11928")
            {
                nama.Text = "NAILA SAFIRA SALSABILA";
                alamat.Text = "Y";
            }
            else if (value == "11929")
            {
                nama.Text = "NAISYILA SALSA KIRANIA";
                alamat.Text = "Z";
            }
            else if (value == "11945")
            {
                nama.Text = "NEYLA SALSABILA";
                alamat.Text = "A2";
            }
            else if (value == "11949")
            {
                nama.Text = "NIHAD BARKAH RAMADHAN";
                alamat.Text = "B2";
            }
            else if (value == "11953")
            {
                nama.Text = "NIKMATUL KHOIROH";
                alamat.Text = "C2";
            }
            else if (value == "11961")
            {
                nama.Text = "NUR FAUZA";
                alamat.Text = "D2";
            }
            else if (value == "11990")
            {
                nama.Text = "RAFA QISTHI CARISSA PUTRI";
                alamat.Text = "E2";
            }
            else if (value == "12003")
            {
                nama.Text = "RANIA AMALIA SYARIFAH";
                alamat.Text = "F2";
            }
            else if (value == "12032")
            {
                nama.Text = "SAFINATUL MAULIDYAH";
                alamat.Text = "G2";
            }
            else if (value == "12037")
            {
                nama.Text = "SALSABELA AZRILIYAH";
                alamat.Text = "H2";
            }
            else if (value == "12051")
            {
                nama.Text = "SILVA ANDRE REYSTHA";
                alamat.Text = "I2";
            }
            else if (value == "12058")
            {
                nama.Text = "SOFI MARIATUL MAULIDIA";
                alamat.Text = "J2";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            perminjaman.Text = "";
            judulbuku.Text = "";
            jenisbuku.Text = "";
            tahunterbit.Text = "";
            stokbuku.Text = "";
            id.Text = "";
            nama.Text = "";
            alamat.Text = "";
            pinjam.Text = "";
            jumlahhari.Text = "";
            kembali.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string n = perminjaman.Text;
            string a = judulbuku.Text;
            string i = jenisbuku.Text;
            string s = tahunterbit.Text;
            string y = stokbuku.Text;
            string i2 = id.Text;
            string l = nama.Text;
            string a2 = jk.Text;
            string s2 = pinjam.Text;
            string a3 = jumlahhari.Text;
            string l2 = kembali.Text;
            string s3 = perpanjanghari.Text;

            dataGridView2.Rows.Add(n, a, i, s, y, i2, l, a2, s2, a3, l2, s3);

            if (perminjaman.Text.Trim() == "" || judulbuku.Text.Trim() == "" || jenisbuku.Text.Trim() == "" || tahunterbit.Text.Trim() == "" || stokbuku.Text.Trim() == "" || id.Text.Trim() == "" || nama.Text.Trim() == "" || jk.Text.Trim() == "" || pinjam.Text.Trim() == "" || jumlahhari.Text.Trim() == "" || kembali.Text.Trim() == "" || perpanjanghari.Text.Trim() == "" );
        }
    }
}
