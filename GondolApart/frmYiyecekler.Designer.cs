namespace GondolApart
{
    partial class btn_IceceklerFiyatGuncelleme
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
            this.btnTamam = new System.Windows.Forms.Button();
            this.ıceceklerTablosuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.barDataSet1 = new GondolApart.BarDataSet();
            this.btnAzalt = new System.Windows.Forms.Button();
            this.btnArttir = new System.Windows.Forms.Button();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.ıceceklerTablosuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barDataSet = new GondolApart.BarDataSet();
            this.icecekler_TablosuTableAdapter = new GondolApart.BarDataSetTableAdapters.Icecekler_TablosuTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.txtSecilen = new System.Windows.Forms.TextBox();
            this.yiyeceklerTablosuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yiyecekler_TablosuTableAdapter = new GondolApart.BarDataSetTableAdapters.Yiyecekler_TablosuTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yiyeceklerTablosuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ıceceklerTablosuBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıceceklerTablosuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yiyeceklerTablosuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yiyeceklerTablosuBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTamam
            // 
            this.btnTamam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTamam.Location = new System.Drawing.Point(12, 328);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(260, 35);
            this.btnTamam.TabIndex = 12;
            this.btnTamam.Text = "Siparişi Geç";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // ıceceklerTablosuBindingSource1
            // 
            this.ıceceklerTablosuBindingSource1.DataMember = "Icecekler_Tablosu";
            this.ıceceklerTablosuBindingSource1.DataSource = this.barDataSet1;
            // 
            // barDataSet1
            // 
            this.barDataSet1.DataSetName = "BarDataSet";
            this.barDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAzalt
            // 
            this.btnAzalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAzalt.Location = new System.Drawing.Point(199, 288);
            this.btnAzalt.Name = "btnAzalt";
            this.btnAzalt.Size = new System.Drawing.Size(75, 34);
            this.btnAzalt.TabIndex = 11;
            this.btnAzalt.Text = "-";
            this.btnAzalt.UseVisualStyleBackColor = true;
            this.btnAzalt.Click += new System.EventHandler(this.btnAzalt_Click);
            // 
            // btnArttir
            // 
            this.btnArttir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnArttir.Location = new System.Drawing.Point(12, 285);
            this.btnArttir.Name = "btnArttir";
            this.btnArttir.Size = new System.Drawing.Size(75, 37);
            this.btnArttir.TabIndex = 10;
            this.btnArttir.Text = "+";
            this.btnArttir.UseVisualStyleBackColor = true;
            this.btnArttir.Click += new System.EventHandler(this.btnArttir_Click);
            // 
            // txtAdet
            // 
            this.txtAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdet.Location = new System.Drawing.Point(93, 294);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(100, 26);
            this.txtAdet.TabIndex = 9;
            this.txtAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(52, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Seçilen İçecek";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(79, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Birim Fiyatı";
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBirimFiyat.Location = new System.Drawing.Point(170, 258);
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Size = new System.Drawing.Size(100, 26);
            this.txtBirimFiyat.TabIndex = 14;
            // 
            // txtSecilen
            // 
            this.txtSecilen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSecilen.Location = new System.Drawing.Point(170, 232);
            this.txtSecilen.Name = "txtSecilen";
            this.txtSecilen.Size = new System.Drawing.Size(100, 26);
            this.txtSecilen.TabIndex = 1;
            // 
            // yiyeceklerTablosuBindingSource
            // 
            this.yiyeceklerTablosuBindingSource.DataMember = "Yiyecekler_Tablosu";
            this.yiyeceklerTablosuBindingSource.DataSource = this.barDataSet1;
            // 
            // yiyecekler_TablosuTableAdapter
            // 
            this.yiyecekler_TablosuTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.yiyeceklerTablosuBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(264, 214);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            // 
            // yiyeceklerTablosuBindingSource1
            // 
            this.yiyeceklerTablosuBindingSource1.DataMember = "Yiyecekler_Tablosu";
            this.yiyeceklerTablosuBindingSource1.DataSource = this.barDataSet1;
            // 
            // btn_IceceklerFiyatGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 367);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.btnAzalt);
            this.Controls.Add(this.btnArttir);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBirimFiyat);
            this.Controls.Add(this.txtSecilen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "btn_IceceklerFiyatGuncelleme";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmYiyecekler";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmYiyecekler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ıceceklerTablosuBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıceceklerTablosuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yiyeceklerTablosuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yiyeceklerTablosuBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.BindingSource ıceceklerTablosuBindingSource1;
        private BarDataSet barDataSet1;
        private System.Windows.Forms.Button btnAzalt;
        private System.Windows.Forms.Button btnArttir;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.BindingSource ıceceklerTablosuBindingSource;
        private BarDataSet barDataSet;
        private BarDataSetTableAdapters.Icecekler_TablosuTableAdapter icecekler_TablosuTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBirimFiyat;
        private System.Windows.Forms.TextBox txtSecilen;
        private System.Windows.Forms.BindingSource yiyeceklerTablosuBindingSource;
        private BarDataSetTableAdapters.Yiyecekler_TablosuTableAdapter yiyecekler_TablosuTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource yiyeceklerTablosuBindingSource1;
    }
}