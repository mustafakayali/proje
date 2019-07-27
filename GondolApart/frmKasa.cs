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
    public partial class frmKasa : Form
    {
        public frmKasa()
        {
            InitializeComponent();
        }

        public SqlCeConnection baglanti = new SqlCeConnection(@"Data Source=|DataDirectory|\Bar.sdf");
        public SqlCeConnection baglanti2 = new SqlCeConnection(@"Data Source=|DataDirectory|\Bar.sdf");

        public void geneltoplam()
        {
            SqlCeCommand islem = new SqlCeCommand("SELECT SUM(Tutar) from GunSonuKasa", baglanti);
            baglanti.Open(); // Bağlantıyı açıyoruz // Sorguyu komuta atıyoruz            
            islem.ExecuteNonQuery(); // Komutu çalıştırıyoruz
            object result = islem.ExecuteScalar();
            txtToplam.Text = Convert.ToString(result);
            txtToplam.Text = string.Format("{0:0.##}", result);
            baglanti.Close(); // Bağlantıyı mutlaka kapatıyoruz
        }

        public void KrediKartiToplam()
        {
            SqlCeCommand islemKrediKarti = new SqlCeCommand("SELECT SUM(Tutar) from GunSonuKasaKrediKarti", baglanti2);
            baglanti2.Open(); // Bağlantıyı açıyoruz // Sorguyu komuta atıyoruz            
            islemKrediKarti.ExecuteNonQuery();
            object result2 = islemKrediKarti.ExecuteScalar();
            txtCreditToplam.Text = Convert.ToString(result2);
            txtCreditToplam.Text = string.Format("{0:0.##}", result2);
            baglanti2.Close(); // Bağlantıyı mutlaka kapatıyoruz

        }


        private void frmKasa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'barDataSet1.GunSonuKasaKrediKarti' table. You can move, or remove it, as needed.
            this.gunSonuKasaKrediKartiTableAdapter.Fill(this.barDataSet1.GunSonuKasaKrediKarti);
            
            this.gunSonuKasaCreditCardTableAdapter.Fill(this.barDataSet1.GunSonuKasaCreditCard);    
            this.gunSonuKasaTableAdapter.Fill(this.barDataSet.GunSonuKasa);

            this.dataGridView1.DefaultCellStyle.NullValue = "no entry";
            this.dataGridView2.DefaultCellStyle.NullValue = "no entry";

            //this.dataGridView1.Columns[2].DefaultCellStyle.Format = "N2";
            dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Ascending);
            dataGridView2.Sort(dataGridView2.Columns[3], ListSortDirection.Ascending);
            geneltoplam();
            KrediKartiToplam();
           
            
            

        }
    }
}
