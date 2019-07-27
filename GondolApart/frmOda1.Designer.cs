namespace GondolApart
{
    partial class frmOda1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.etiket1 = new System.Windows.Forms.Label();
            this.txtSecilen = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oda1AdisyonBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.barDataSet = new GondolApart.BarDataSet();
            this.txtToplam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.oda1AdisyonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.icecekler_TablosuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.icecekler_TablosuTableAdapter = new GondolApart.BarDataSetTableAdapters.Icecekler_TablosuTableAdapter();
            this.tableAdapterManager = new GondolApart.BarDataSetTableAdapters.TableAdapterManager();
            this.ıceceklerTablosuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ıceceklerTablosuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.oda1AdisyonTableAdapter = new GondolApart.BarDataSetTableAdapters.Oda1AdisyonTableAdapter();
            this.oda1AdisyonBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.oda1AdisyonBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.oda1AdisyonBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_CreditCard = new System.Windows.Forms.Button();
            this.btn_Market = new System.Windows.Forms.Button();
            this.btn_Yiyecekler = new System.Windows.Forms.Button();
            this.btnKasa = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btn_icecekler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oda1AdisyonBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oda1AdisyonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icecekler_TablosuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıceceklerTablosuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıceceklerTablosuBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oda1AdisyonBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oda1AdisyonBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oda1AdisyonBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // etiket1
            // 
            this.etiket1.AutoSize = true;
            this.etiket1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.etiket1.Location = new System.Drawing.Point(1307, 9);
            this.etiket1.Name = "etiket1";
            this.etiket1.Size = new System.Drawing.Size(51, 18);
            this.etiket1.TabIndex = 0;
            this.etiket1.Text = "Oda1";
            // 
            // txtSecilen
            // 
            this.txtSecilen.Location = new System.Drawing.Point(1159, 4);
            this.txtSecilen.Name = "txtSecilen";
            this.txtSecilen.ReadOnly = true;
            this.txtSecilen.Size = new System.Drawing.Size(129, 20);
            this.txtSecilen.TabIndex = 7;
            this.txtSecilen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adDataGridViewTextBoxColumn,
            this.adetDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn,
            this.ıdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.oda1AdisyonBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(333, 9);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 596);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adetDataGridViewTextBoxColumn
            // 
            this.adetDataGridViewTextBoxColumn.DataPropertyName = "Adet";
            this.adetDataGridViewTextBoxColumn.HeaderText = "Adet";
            this.adetDataGridViewTextBoxColumn.Name = "adetDataGridViewTextBoxColumn";
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id No";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oda1AdisyonBindingSource4
            // 
            this.oda1AdisyonBindingSource4.DataMember = "Oda1Adisyon";
            this.oda1AdisyonBindingSource4.DataSource = this.barDataSet;
            // 
            // barDataSet
            // 
            this.barDataSet.DataSetName = "BarDataSet";
            this.barDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtToplam
            // 
            this.txtToplam.BackColor = System.Drawing.Color.SeaGreen;
            this.txtToplam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplam.Location = new System.Drawing.Point(613, 608);
            this.txtToplam.Name = "txtToplam";
            this.txtToplam.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtToplam.Size = new System.Drawing.Size(167, 40);
            this.txtToplam.TabIndex = 9;
            this.txtToplam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtToplam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtToplam_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(332, 608);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Genel Toplam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(820, 608);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 39);
            this.label2.TabIndex = 11;
            this.label2.Text = "TL";
            // 
            // oda1AdisyonBindingSource
            // 
            this.oda1AdisyonBindingSource.DataMember = "Oda1Adisyon";
            this.oda1AdisyonBindingSource.DataSource = this.barDataSet;
            // 
            // icecekler_TablosuBindingSource
            // 
            this.icecekler_TablosuBindingSource.DataMember = "Icecekler_Tablosu";
            this.icecekler_TablosuBindingSource.DataSource = this.barDataSet;
            // 
            // icecekler_TablosuTableAdapter
            // 
            this.icecekler_TablosuTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GunSonuKasaCreditCardTableAdapter = null;
            this.tableAdapterManager.GunSonuKasaKrediKartiTableAdapter = null;
            this.tableAdapterManager.GunSonuKasaTableAdapter = null;
            this.tableAdapterManager.Icecekler_TablosuTableAdapter = this.icecekler_TablosuTableAdapter;
            this.tableAdapterManager.Oda1AdisyonTableAdapter = null;
            this.tableAdapterManager.Oda2AdisyonTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GondolApart.BarDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Yiyecekler_TablosuTableAdapter = null;
            // 
            // ıceceklerTablosuBindingSource
            // 
            this.ıceceklerTablosuBindingSource.DataMember = "Icecekler_Tablosu";
            this.ıceceklerTablosuBindingSource.DataSource = this.barDataSet;
            // 
            // ıceceklerTablosuBindingSource1
            // 
            this.ıceceklerTablosuBindingSource1.DataMember = "Icecekler_Tablosu";
            this.ıceceklerTablosuBindingSource1.DataSource = this.barDataSet;
            // 
            // oda1AdisyonTableAdapter
            // 
            this.oda1AdisyonTableAdapter.ClearBeforeFill = true;
            // 
            // oda1AdisyonBindingSource1
            // 
            this.oda1AdisyonBindingSource1.DataMember = "Oda1Adisyon";
            this.oda1AdisyonBindingSource1.DataSource = this.barDataSet;
            // 
            // oda1AdisyonBindingSource2
            // 
            this.oda1AdisyonBindingSource2.DataMember = "Oda1Adisyon";
            this.oda1AdisyonBindingSource2.DataSource = this.barDataSet;
            // 
            // oda1AdisyonBindingSource3
            // 
            this.oda1AdisyonBindingSource3.DataMember = "Oda1Adisyon";
            this.oda1AdisyonBindingSource3.DataSource = this.barDataSet;
            // 
            // btn_CreditCard
            // 
            this.btn_CreditCard.BackgroundImage = global::GondolApart.Properties.Resources.creditCard;
            this.btn_CreditCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_CreditCard.Location = new System.Drawing.Point(1057, 259);
            this.btn_CreditCard.Name = "btn_CreditCard";
            this.btn_CreditCard.Size = new System.Drawing.Size(129, 123);
            this.btn_CreditCard.TabIndex = 15;
            this.btn_CreditCard.UseVisualStyleBackColor = true;
            this.btn_CreditCard.Click += new System.EventHandler(this.btn_CreditCard_Click);
            // 
            // btn_Market
            // 
            this.btn_Market.BackgroundImage = global::GondolApart.Properties.Resources.market;
            this.btn_Market.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Market.Location = new System.Drawing.Point(896, 9);
            this.btn_Market.Name = "btn_Market";
            this.btn_Market.Size = new System.Drawing.Size(304, 213);
            this.btn_Market.TabIndex = 14;
            this.btn_Market.UseVisualStyleBackColor = true;
            // 
            // btn_Yiyecekler
            // 
            this.btn_Yiyecekler.BackgroundImage = global::GondolApart.Properties.Resources.foods;
            this.btn_Yiyecekler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Yiyecekler.Location = new System.Drawing.Point(12, 259);
            this.btn_Yiyecekler.Name = "btn_Yiyecekler";
            this.btn_Yiyecekler.Size = new System.Drawing.Size(304, 213);
            this.btn_Yiyecekler.TabIndex = 13;
            this.btn_Yiyecekler.UseVisualStyleBackColor = true;
            this.btn_Yiyecekler.Click += new System.EventHandler(this.btn_Yiyecekler_Click);
            // 
            // btnKasa
            // 
            this.btnKasa.BackgroundImage = global::GondolApart.Properties.Resources.cash;
            this.btnKasa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKasa.Location = new System.Drawing.Point(1229, 259);
            this.btnKasa.Name = "btnKasa";
            this.btnKasa.Size = new System.Drawing.Size(129, 123);
            this.btnKasa.TabIndex = 12;
            this.btnKasa.UseVisualStyleBackColor = true;
            this.btnKasa.Click += new System.EventHandler(this.btnKasa_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImage = global::GondolApart.Properties.Resources.sil;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.Location = new System.Drawing.Point(883, 259);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(129, 123);
            this.btnSil.TabIndex = 6;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btn_icecekler
            // 
            this.btn_icecekler.BackgroundImage = global::GondolApart.Properties.Resources.drinks;
            this.btn_icecekler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_icecekler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_icecekler.Location = new System.Drawing.Point(12, 9);
            this.btn_icecekler.Name = "btn_icecekler";
            this.btn_icecekler.Size = new System.Drawing.Size(304, 213);
            this.btn_icecekler.TabIndex = 4;
            this.btn_icecekler.UseVisualStyleBackColor = true;
            this.btn_icecekler.Click += new System.EventHandler(this.btn_icecekler_Click);
            // 
            // frmOda1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1370, 735);
            this.Controls.Add(this.btn_CreditCard);
            this.Controls.Add(this.btn_Market);
            this.Controls.Add(this.btn_Yiyecekler);
            this.Controls.Add(this.btnKasa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtToplam);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSecilen);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btn_icecekler);
            this.Controls.Add(this.etiket1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOda1";
            this.Text = "Room 1 // Oda1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmOda1_Activated);
            this.Deactivate += new System.EventHandler(this.frmOda1_Deactivate);
            this.Load += new System.EventHandler(this.frmOda1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oda1AdisyonBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oda1AdisyonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icecekler_TablosuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıceceklerTablosuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıceceklerTablosuBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oda1AdisyonBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oda1AdisyonBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oda1AdisyonBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label etiket1;
        private BarDataSet barDataSet;
        private System.Windows.Forms.BindingSource icecekler_TablosuBindingSource;
        private BarDataSetTableAdapters.Icecekler_TablosuTableAdapter icecekler_TablosuTableAdapter;
        private BarDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource ıceceklerTablosuBindingSource;
        private System.Windows.Forms.BindingSource ıceceklerTablosuBindingSource1;
        private System.Windows.Forms.Button btn_icecekler;
        private System.Windows.Forms.BindingSource oda1AdisyonBindingSource;
        private BarDataSetTableAdapters.Oda1AdisyonTableAdapter oda1AdisyonTableAdapter;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtSecilen;
        private System.Windows.Forms.BindingSource oda1AdisyonBindingSource1;
        private System.Windows.Forms.BindingSource oda1AdisyonBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource oda1AdisyonBindingSource3;
        private System.Windows.Forms.TextBox txtToplam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnKasa;
        private System.Windows.Forms.BindingSource oda1AdisyonBindingSource4;
        private System.Windows.Forms.Button btn_Yiyecekler;
        private System.Windows.Forms.Button btn_Market;
        private System.Windows.Forms.Button btn_CreditCard;
    }
}