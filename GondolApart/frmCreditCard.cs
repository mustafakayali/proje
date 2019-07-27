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
    public partial class frmCreditCard : Form
    {
        public frmCreditCard()
        {
            InitializeComponent();
        }

        public static float COdeme;

        public SqlCeConnection baglanti = new SqlCeConnection(@"Data Source=|DataDirectory|\Bar.sdf");
        public SqlCeConnection KasaBaglanti = new SqlCeConnection(@"Data Source=|DataDirectory|\Bar.sdf");

        private void button1_Click(object sender, EventArgs e)
        {
            txtUcret.Text = txtUcret.Text + 1;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUcret.Text = txtUcret.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtUcret.Text = txtUcret.Text + 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtUcret.Text = txtUcret.Text + 4;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtUcret.Text = txtUcret.Text + 5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtUcret.Text = txtUcret.Text + 6;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtUcret.Text = txtUcret.Text + 7;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtUcret.Text = txtUcret.Text + 8;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtUcret.Text = txtUcret.Text + 9;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            txtUcret.Clear();
        }

        private void btnSifir_Click(object sender, EventArgs e)
        {
            txtUcret.Text = txtUcret.Text + 0;
        }

        private void btnVirgul_Click(object sender, EventArgs e)
        {
            txtUcret.Text = txtUcret.Text + ",";
        }

        private void frmCreditCard_Load(object sender, EventArgs e)
        {

        }

        private void btn_cekim_Click(object sender, EventArgs e)
        {
            if (txtUcret.Text=="")
            {
                MessageBox.Show("Ücret Girmelisiniz","HATA");
            }
            else
            {
                KasaBaglanti.Open();
                SqlCeCommand komut = new SqlCeCommand("INSERT INTO GunSonuKasaKrediKArti (OdaAdi, Tutar, Tarih) VALUES  (@Ad,@Tutar,@Tarih)", KasaBaglanti);
                komut.Parameters.AddWithValue("@Ad", "Oda1");
                komut.Parameters.AddWithValue("@Tutar", txtUcret.Text);

                komut.Parameters.AddWithValue("@Tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Başarılı bir şekilde giriş yapıldı.", "Bilgilendirme Mesajı");

                KasaBaglanti.Close();

             





                txtUcret.Clear();
            }
            

            
            

            
            
        }
    }
}
