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
        public SqlCeConnection KasaBaglanti = new SqlCeConnection(@"Data Source=|DataDirectory|\Bar.sdf");


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
            txtSecilen.Visible = false;

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
            geneltoplam();
        }

        private void btn_Yiyecekler_Click(object sender, EventArgs e)
        {
            btn_IceceklerFiyatGuncelleme formac = new btn_IceceklerFiyatGuncelleme();
            formac.ShowDialog();
        }



        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult silme_islemi = new DialogResult();
            silme_islemi = MessageBox.Show("Devam etmek istiyormusunuz ?  Id No:" + txtSecilen.Text.ToString(), "Uyarı", MessageBoxButtons.YesNo);
            if (silme_islemi == DialogResult.Yes)
            {
                if (txtSecilen.Text == "")
                {
                    MessageBox.Show("SEÇİM YAPMALISINIZ.", "VERI GIRIS HATASI");
                }

                else
                {

                    baglanti.Open();
                    SqlCeCommand komut = new SqlCeCommand("DELETE FROM Oda2Adisyon WHERE (Id)=@Id", baglanti);
                    komut.Parameters.AddWithValue("@Id", txtSecilen.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    this.oda2AdisyonTableAdapter.Fill(this.barDataSet.Oda2Adisyon);
                    txtSecilen.Text = "";
                    geneltoplam();
                    this.oda2AdisyonTableAdapter.Fill(this.barDataSet1.Oda2Adisyon);
                    dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Ascending);
                }
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                txtSecilen.Text = row.Cells[3].Value.ToString();

            }
            catch (Exception)
            {

                //MessageBox.Show("HATA","HUCRE SECMELISIN");
            }
        }

        private void BtnKasa_Click(object sender, EventArgs e)
        {
            if (txtToplam.Text == "")
            {
                MessageBox.Show("Aktarılaracak para bulunmamaktadır. Kontrol Ediniz", "HATA");
            }

            else
            {
                KasaBaglanti.Open();
                SqlCeCommand komut = new SqlCeCommand("INSERT INTO GunSonuKasa (OdaAdi,Tutar,Tarih) VALUES  (@Ad,@Tutar,@Tarih)", KasaBaglanti);
                komut.Parameters.AddWithValue("@Ad", etiket1.Text);
                komut.Parameters.AddWithValue("@Tutar", txtToplam.Text);

                komut.Parameters.AddWithValue("@Tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Başarılı bir şekilde giriş yapıldı.", "Bilgilendirme Mesajı");

                KasaBaglanti.Close();



                baglanti.Open();
                SqlCeCommand komut2 = new SqlCeCommand("DELETE  FROM Oda2Adisyon", baglanti);

                komut2.ExecuteNonQuery();
                baglanti.Close();
                this.oda2AdisyonTableAdapter.Fill(this.barDataSet.Oda2Adisyon);

                geneltoplam();
                dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Ascending);
                this.oda2AdisyonTableAdapter.Fill(this.barDataSet1.Oda2Adisyon);
            }
        }
    }
}
