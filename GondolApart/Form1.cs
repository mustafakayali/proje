using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GondolApart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'barDataSet1.Icecekler_Tablosu' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'barDataSet.Icecekler_Tablosu' table. You can move, or remove it, as needed.
            

        }

        private void btn_Oda1_Click(object sender, EventArgs e)
        {
            /*try
            {
                frmOda1 formac = new frmOda1();
                formac.ShowDialog();
            }
            catch (Exception)
            {

                MessageBox.Show("Oda1 açılırken hata oluştu","HATA");
            }*/
            frmOda1 formac = new frmOda1();
            formac.ShowDialog();

            
        
        }

        private void resim1_DoubleClick(object sender, EventArgs e)
        {
            frmKasa formac = new frmKasa();
            formac.ShowDialog();
            
        }

       /* private void btn_Guncelleme_Click(object sender, EventArgs e)
        {
            //frmFiyatGuncelleme formac = new frmFiyatGuncelleme();
            //formac.ShowDialog();
           
            // btn_IceceklerFiyatGuncelleme formac = new btn_IceceklerFiyatGuncelleme();
            //formac.ShowDialog();


        }
        */
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void btn_Guncelleme_Click(object sender, EventArgs e)
        {
            frmFiyatGuncelle formac = new frmFiyatGuncelle();
            formac.ShowDialog();
        }

        private void btn_Oda2_Click(object sender, EventArgs e)
        {
            frmOda2 formac = new frmOda2();
            formac.ShowDialog();
        }

       

       
    }
}
