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
    public partial class frmOda1 : Form
    {
        public frmOda1()
        {
            InitializeComponent();
        }

        public static string Odaadi = "Oda1";
        public static float nakit;
        public static float odeme_islemi;
        public static float nakit_toplam;
        

        public SqlCeConnection baglanti = new SqlCeConnection(@"Data Source=|DataDirectory|\Bar.sdf");
        public SqlCeConnection KasaBaglanti = new SqlCeConnection(@"Data Source=|DataDirectory|\Bar.sdf");

        public SqlCeConnection con;
        public SqlCeDataAdapter da;
        public DataSet ds;
        public SqlCeCommandBuilder cmdb;




        public void geneltoplam()
        {
            SqlCeCommand islem = new SqlCeCommand("SELECT SUM(Fiyat) from Oda1Adisyon", baglanti);


            baglanti.Open(); // Bağlantıyı açıyoruz // Sorguyu komuta atıyoruz            
            islem.ExecuteNonQuery(); // Komutu çalıştırıyoruz
            object result = islem.ExecuteScalar();
            txtToplam.Text = Convert.ToString(result);
            txtToplam.Text = string.Format("{0:0.##}", result);
            baglanti.Close(); // Bağlantıyı mutlaka kapatıyoruz
        }



        public void guncelleme()
        {
            con = new SqlCeConnection(@"Data Source=|DataDirectory|\Bar.sdf");
            con.Open();
            da = new SqlCeDataAdapter("Select * from Oda1Adisyon", con);
            cmdb = new SqlCeCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "Oda1Adisyon");
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }


        private void frmOda1_Load(object sender, EventArgs e)
        {
            FrmIcecekler.roomname = Odaadi;
            btn_IceceklerFiyatGuncelleme.roomname_yiyecekler = Odaadi;
            txtSecilen.Visible = false;

            this.oda1AdisyonTableAdapter.Fill(this.barDataSet.Oda1Adisyon);           

            this.dataGridView1.DefaultCellStyle.NullValue = "no entry";            
            this.dataGridView1.Columns[2].DefaultCellStyle.Format="N2";
            dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Ascending);

            geneltoplam();

            

    

        }

        private void icecekler_TablosuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.icecekler_TablosuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.barDataSet);

        }

        private void btn_icecekler_Click(object sender, EventArgs e)
        {
            FrmIcecekler formac = new FrmIcecekler();
            formac.ShowDialog();
        }

        private void frmOda1_Deactivate(object sender, EventArgs e)
        {
            this.oda1AdisyonTableAdapter.Fill(this.barDataSet.Oda1Adisyon);
        }

        private void frmOda1_Activated(object sender, EventArgs e)
        {
           
            

            this.oda1AdisyonTableAdapter.Fill(this.barDataSet.Oda1Adisyon);
            geneltoplam();
            //txtToplam.Text = frmCreditCard.COdeme.ToString();

            
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            txtSecilen.Text = row.Cells[0].Value.ToString();
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            txtSecilen.Text = row.Cells[0].Value.ToString();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                txtSecilen.Text = row.Cells[4].Value.ToString();
                
            }
            catch (Exception)
            {

                //MessageBox.Show("HATA","HUCRE SECMELISIN");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult silme_islemi = new DialogResult();
            silme_islemi = MessageBox.Show("Devam etmek istiyormusunuz ?  Id No:"+txtSecilen.Text.ToString(), "Uyarı", MessageBoxButtons.YesNo);
            if (silme_islemi == DialogResult.Yes)
            {
                if (txtSecilen.Text == "")
                {
                    MessageBox.Show("SEÇİM YAPMALISINIZ.", "VERI GIRIS HATASI");
                }

                else
                {

                    baglanti.Open();
                    SqlCeCommand komut = new SqlCeCommand("DELETE FROM Oda1Adisyon WHERE (Id)=@Id", baglanti);
                    komut.Parameters.AddWithValue("@Id", txtSecilen.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    this.oda1AdisyonTableAdapter.Fill(this.barDataSet.Oda1Adisyon);
                    txtSecilen.Text = "";
                    geneltoplam();
                    dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Ascending);
            }
            


           
            }

        }

        private void btnIndirim_Click(object sender, EventArgs e)
        {
            
            

        }

        private void btnKasa_Click(object sender, EventArgs e)
        {
            if (txtToplam.Text=="")
            {
                MessageBox.Show("Aktarılaracak para bulunmamaktadır. Kontrol Ediniz","HATA");
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
                SqlCeCommand komut2 = new SqlCeCommand("DELETE  FROM Oda1Adisyon", baglanti);

                komut2.ExecuteNonQuery();
                baglanti.Close();
                this.oda1AdisyonTableAdapter.Fill(this.barDataSet.Oda1Adisyon);

                geneltoplam();
                dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Ascending);
            }
            



        }

        private void btn_Yiyecekler_Click(object sender, EventArgs e)
        {
            btn_IceceklerFiyatGuncelleme formac = new btn_IceceklerFiyatGuncelleme();
            formac.ShowDialog();
        }

        private void btn_CreditCard_Click(object sender, EventArgs e)
        {
            frmCreditCard formac = new frmCreditCard();
            formac.ShowDialog();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            da.Update(ds, "Oda1Adisyon");

            MessageBox.Show("Kayıt güncellendi");
        }

        private void txtToplam_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)&&e.KeyChar !=',')
            {
                e.Handled = true;
            }

            if (e.KeyChar==',' &&(sender as TextBox).Text.IndexOf(',')>-1)
            {
                e.Handled = true;
            }
            
            //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void FrmOda1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
    }
}
