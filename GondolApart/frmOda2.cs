using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlServerCe;

namespace GondolApart
{
    public partial class frmOda2 : Form
    {
        public frmOda2()
        {
            InitializeComponent();
        }

        public static string Odaadi = "Oda2";

        public SqlCeConnection baglanti = new SqlCeConnection(@"Data Source=|DataDirectory|\Bar.sdf");


        public void geneltoplam()
        {
            SqlCeCommand islem = new SqlCeCommand("SELECT SUM(Fiyat) from Oda2Adisyon", baglanti);


            baglanti.Open(); // Bağlantıyı açıyoruz // Sorguyu komuta atıyoruz            
            islem.ExecuteNonQuery(); // Komutu çalıştırıyoruz
            object result = islem.ExecuteScalar();
            txtToplam.Text = Convert.ToString(result);
            txtToplam.Text = string.Format("{0:0.##}", result);
            baglanti.Close(); // Bağlantıyı mutlaka kapatıyoruz
        }

        private void btn_icecekler_Click(object sender, EventArgs e)
        {
            FrmIcecekler formac = new FrmIcecekler();
            formac.ShowDialog();
        }

        private void frmOda2_Load(object sender, EventArgs e)
        {
            
            
            // TODO: This line of code loads data into the 'barDataSet1.Oda2Adisyon' table. You can move, or remove it, as needed.
            this.oda2AdisyonTableAdapter.Fill(this.barDataSet1.Oda2Adisyon);

            this.dataGridView1.DefaultCellStyle.NullValue = "no entry";
            this.dataGridView1.Columns[2].DefaultCellStyle.Format = "N2";
            dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Ascending);
            
            FrmIcecekler.roomname = Odaadi;

            btn_IceceklerFiyatGuncelleme.roomname_yiyecekler = Odaadi;
            geneltoplam();
        }

        private void frmOda2_Deactivate(object sender, EventArgs e)
        {
            this.oda2AdisyonTableAdapter.Fill(this.barDataSet1.Oda2Adisyon);
        }

        private void frmOda2_Activated(object sender, EventArgs e)
        {
            this.oda2AdisyonTableAdapter.Fill(this.barDataSet1.Oda2Adisyon);
        }

        private void btn_Yiyecekler_Click(object sender, EventArgs e)
        {
            btn_IceceklerFiyatGuncelleme formac = new btn_IceceklerFiyatGuncelleme();
            formac.ShowDialog();
        }
    }
}
