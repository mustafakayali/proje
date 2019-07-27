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
    public partial class frmFiyatGuncelle : Form
    {
        public frmFiyatGuncelle()
        {
            InitializeComponent();
        }

        
        SqlCeConnection con;
        SqlCeDataAdapter da;
        DataSet ds;
        SqlCeCommandBuilder cmdb;

        SqlCeConnection con2;
        SqlCeDataAdapter da2;
        DataSet ds2;
        SqlCeCommandBuilder cmdb2;



        private void frmFiyatGuncelle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'barDataSet.Yiyecekler_Tablosu' table. You can move, or remove it, as needed.
            this.yiyecekler_TablosuTableAdapter.Fill(this.barDataSet.Yiyecekler_Tablosu);
            // TODO: This line of code loads data into the 'barDataSet.Icecekler_Tablosu' table. You can move, or remove it, as needed.
           // this.icecekler_TablosuTableAdapter.Fill(this.barDataSet.Icecekler_Tablosu);
           
          ;

            
            con = new SqlCeConnection(@"Data Source=|DataDirectory|\Bar.sdf");
            con.Open();
            da = new SqlCeDataAdapter("Select * from Icecekler_Tablosu", con);
            cmdb = new SqlCeCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "Icecekler_Tablosu");
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();


            con2 = new SqlCeConnection(@"Data Source=|DataDirectory|\Bar.sdf");
            con2.Open();
            da2 = new SqlCeDataAdapter("Select * from Yiyecekler_Tablosu", con2);
            cmdb2 = new SqlCeCommandBuilder(da2);
            ds2 = new DataSet();
            da2.Fill(ds2, "Yiyecekler_Tablosu");
            dataGridView2.DataSource = ds2.Tables[0];
            con2.Close();






        }

        private void btn_Icecekleri_Guncelle_Click(object sender, EventArgs e)
        {
            da.Update(ds, "Icecekler_Tablosu");
            MessageBox.Show("Kayıt güncellendi");
        }

        private void btn_Yiyecekleri_Guncelle_Click(object sender, EventArgs e)
        {
            da2.Update(ds2, "Yiyecekler_Tablosu");
            MessageBox.Show("Kayıt güncellendi");
        }
    }
}
