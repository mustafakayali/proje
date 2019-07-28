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
    public partial class FrmIcecekler : Form
    {
        public FrmIcecekler()
        {
            InitializeComponent();
        }

        public int Adet = 1; // Seçilen adet bilgisi için integer
        public SqlCeConnection baglanti = new SqlCeConnection(@"Data Source=|DataDirectory|\Bar.sdf");

        public static string roomname;
        


        private void FrmIcecekler_Load(object sender, EventArgs e)
        {
            
            txtBirimFiyat.Text = null;
            txtSecilen.Text = "";
            this.icecekler_TablosuTableAdapter.Fill(this.barDataSet1.Icecekler_Tablosu);//datagride veriler geliyor.
           
            txtAdet.Text = Adet.ToString(); // Adet bilgisi default olarak geliyor.
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void btnArttir_Click(object sender, EventArgs e)
        {
            Adet = Adet + 1;
            txtAdet.Text = Adet.ToString();// değeri bir arttırıp textbox  a yazdırıyor.
        }

        private void btnAzalt_Click(object sender, EventArgs e)
        {
            Adet = Adet - 1;
            txtAdet.Text = Adet.ToString(); // değeri bir azaltıp textbox  a yazdırıyor.
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            
            if (txtSecilen.Text== ""||txtBirimFiyat.Text=="" )
            {
                MessageBox.Show("EKSIK VERI GIRISI BILGILERI KONTROL EDIN", "HATA");

            }
            else
            {
                float carpim;
                float num = float.Parse(txtAdet.Text);
                float num2 = float.Parse(txtBirimFiyat.Text);
                carpim = num * num2;


                carpim = (float)Math.Round(carpim * 100f) / 100f;


                baglanti.Open();

                if (roomname=="Oda1")
                {
                    // seçilen içecekler database e yazdırılıyor.
                    SqlCeCommand komut = new SqlCeCommand("INSERT INTO Oda1Adisyon (Ad,Adet,Fiyat,Tarih) VALUES  (@Ad,@Adet,@Fiyat,@Tarih)", baglanti);
                    komut.Parameters.AddWithValue("@Ad", txtSecilen.Text);
                    komut.Parameters.AddWithValue("@Adet", txtAdet.Text);
                    komut.Parameters.AddWithValue("@Fiyat", carpim);
                    komut.Parameters.AddWithValue("@Tarih", DateTime.Now.ToString());
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    txtAdet.Text = "1"; // default değere geri dönüyor.
                    MessageBox.Show("Başarılı bir şekilde giriş yapıldı.", "BILGILENDIRME MESAJI");
                }
                else if (roomname=="Oda2")
                {
                    SqlCeCommand komut2 = new SqlCeCommand("INSERT INTO Oda2Adisyon (Ad,Adet,Fiyat,Tarih) VALUES  (@Ad,@Adet,@Fiyat,@Tarih)", baglanti);
                    komut2.Parameters.AddWithValue("@Ad", txtSecilen.Text);
                    komut2.Parameters.AddWithValue("@Adet", txtAdet.Text);
                    komut2.Parameters.AddWithValue("@Fiyat", carpim);
                    komut2.Parameters.AddWithValue("@Tarih", DateTime.Now.ToString());
                    komut2.ExecuteNonQuery();
                    baglanti.Close();
                    txtAdet.Text = "1"; // default değere geri dönüyor.
                    MessageBox.Show("Başarılı bir şekilde giriş yapıldı.", "BILGILENDIRME MESAJI");
                    
                }

               

                

            }

            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                txtSecilen.Text = row.Cells[0].Value.ToString();
                txtBirimFiyat.Text = row.Cells[1].Value.ToString();
            }
            catch (Exception)
            {

                //MessageBox.Show("HATA","HUCRE SECMELISIN");
            }
            
        }

        private void FrmIcecekler_FormClosing(object sender, FormClosingEventArgs e)
        {
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmIcecekler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void FrmIcecekler_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
