namespace GondolApart
{
    partial class frmFiyatGuncelle
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatTLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıceceklerTablosuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barDataSet = new GondolApart.BarDataSet();
            this.icecekler_TablosuTableAdapter = new GondolApart.BarDataSetTableAdapters.Icecekler_TablosuTableAdapter();
            this.btn_Icecekleri_Guncelle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.yiyeceklerTablosuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yiyecekler_TablosuTableAdapter = new GondolApart.BarDataSetTableAdapters.Yiyecekler_TablosuTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Yiyecekleri_Guncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıceceklerTablosuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yiyeceklerTablosuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adDataGridViewTextBoxColumn,
            this.fiyatTLDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ıceceklerTablosuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(245, 377);
            this.dataGridView1.TabIndex = 0;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // fiyatTLDataGridViewTextBoxColumn
            // 
            this.fiyatTLDataGridViewTextBoxColumn.DataPropertyName = "Fiyat TL";
            this.fiyatTLDataGridViewTextBoxColumn.HeaderText = "Fiyat TL";
            this.fiyatTLDataGridViewTextBoxColumn.Name = "fiyatTLDataGridViewTextBoxColumn";
            // 
            // ıceceklerTablosuBindingSource
            // 
            this.ıceceklerTablosuBindingSource.DataMember = "Icecekler_Tablosu";
            this.ıceceklerTablosuBindingSource.DataSource = this.barDataSet;
            // 
            // barDataSet
            // 
            this.barDataSet.DataSetName = "BarDataSet";
            this.barDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // icecekler_TablosuTableAdapter
            // 
            this.icecekler_TablosuTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Icecekleri_Guncelle
            // 
            this.btn_Icecekleri_Guncelle.BackColor = System.Drawing.Color.SlateGray;
            this.btn_Icecekleri_Guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Icecekleri_Guncelle.Location = new System.Drawing.Point(26, 421);
            this.btn_Icecekleri_Guncelle.Name = "btn_Icecekleri_Guncelle";
            this.btn_Icecekleri_Guncelle.Size = new System.Drawing.Size(245, 70);
            this.btn_Icecekleri_Guncelle.TabIndex = 1;
            this.btn_Icecekleri_Guncelle.Text = "İçecekleri Güncelle";
            this.btn_Icecekleri_Guncelle.UseVisualStyleBackColor = false;
            this.btn_Icecekleri_Guncelle.Click += new System.EventHandler(this.btn_Icecekleri_Guncelle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btn_Icecekleri_Guncelle);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 497);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İçecekleri Güncelle";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox2.Controls.Add(this.btn_Yiyecekleri_Guncelle);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(474, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 497);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Fiyat});
            this.dataGridView2.DataSource = this.yiyeceklerTablosuBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(22, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(245, 377);
            this.dataGridView2.TabIndex = 2;
            // 
            // yiyeceklerTablosuBindingSource
            // 
            this.yiyeceklerTablosuBindingSource.DataMember = "Yiyecekler_Tablosu";
            this.yiyeceklerTablosuBindingSource.DataSource = this.barDataSet;
            // 
            // yiyecekler_TablosuTableAdapter
            // 
            this.yiyecekler_TablosuTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Ad";
            this.dataGridViewTextBoxColumn1.HeaderText = "Ad";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Fiyat
            // 
            this.Fiyat.DataPropertyName = "Fiyat";
            this.Fiyat.HeaderText = "Fiyat";
            this.Fiyat.Name = "Fiyat";
            // 
            // btn_Yiyecekleri_Guncelle
            // 
            this.btn_Yiyecekleri_Guncelle.BackColor = System.Drawing.Color.SlateGray;
            this.btn_Yiyecekleri_Guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Yiyecekleri_Guncelle.Location = new System.Drawing.Point(22, 421);
            this.btn_Yiyecekleri_Guncelle.Name = "btn_Yiyecekleri_Guncelle";
            this.btn_Yiyecekleri_Guncelle.Size = new System.Drawing.Size(245, 70);
            this.btn_Yiyecekleri_Guncelle.TabIndex = 2;
            this.btn_Yiyecekleri_Guncelle.Text = "Yiyecekleri Güncelle";
            this.btn_Yiyecekleri_Guncelle.UseVisualStyleBackColor = false;
            this.btn_Yiyecekleri_Guncelle.Click += new System.EventHandler(this.btn_Yiyecekleri_Guncelle_Click);
            // 
            // frmFiyatGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmFiyatGuncelle";
            this.Text = "frmFiyatGuncelle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFiyatGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıceceklerTablosuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yiyeceklerTablosuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BarDataSet barDataSet;
        private System.Windows.Forms.BindingSource ıceceklerTablosuBindingSource;
        private BarDataSetTableAdapters.Icecekler_TablosuTableAdapter icecekler_TablosuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatTLDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Icecekleri_Guncelle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource yiyeceklerTablosuBindingSource;
        private BarDataSetTableAdapters.Yiyecekler_TablosuTableAdapter yiyecekler_TablosuTableAdapter;
        private System.Windows.Forms.Button btn_Yiyecekleri_Guncelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fiyat;
    }
}