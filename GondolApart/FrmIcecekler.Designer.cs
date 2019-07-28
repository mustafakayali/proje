namespace GondolApart
{
    partial class FrmIcecekler
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
            this.ıceceklerTablosuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.barDataSet1 = new GondolApart.BarDataSet();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.btnArttir = new System.Windows.Forms.Button();
            this.btnAzalt = new System.Windows.Forms.Button();
            this.btnTamam = new System.Windows.Forms.Button();
            this.ıceceklerTablosuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barDataSet = new GondolApart.BarDataSet();
            this.icecekler_TablosuTableAdapter = new GondolApart.BarDataSetTableAdapters.Icecekler_TablosuTableAdapter();
            this.txtSecilen = new System.Windows.Forms.TextBox();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıceceklerTablosuBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıceceklerTablosuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barDataSet)).BeginInit();
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
            this.dataGridView1.DataSource = this.ıceceklerTablosuBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(260, 374);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // txtAdet
            // 
            this.txtAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdet.Location = new System.Drawing.Point(93, 467);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(100, 26);
            this.txtAdet.TabIndex = 1;
            this.txtAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnArttir
            // 
            this.btnArttir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnArttir.Location = new System.Drawing.Point(12, 458);
            this.btnArttir.Name = "btnArttir";
            this.btnArttir.Size = new System.Drawing.Size(75, 37);
            this.btnArttir.TabIndex = 2;
            this.btnArttir.Text = "+";
            this.btnArttir.UseVisualStyleBackColor = true;
            this.btnArttir.Click += new System.EventHandler(this.btnArttir_Click);
            // 
            // btnAzalt
            // 
            this.btnAzalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAzalt.Location = new System.Drawing.Point(199, 461);
            this.btnAzalt.Name = "btnAzalt";
            this.btnAzalt.Size = new System.Drawing.Size(75, 34);
            this.btnAzalt.TabIndex = 3;
            this.btnAzalt.Text = "-";
            this.btnAzalt.UseVisualStyleBackColor = true;
            this.btnAzalt.Click += new System.EventHandler(this.btnAzalt_Click);
            // 
            // btnTamam
            // 
            this.btnTamam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTamam.Location = new System.Drawing.Point(12, 501);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(260, 35);
            this.btnTamam.TabIndex = 4;
            this.btnTamam.Text = "Siparişi Geç";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
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
            // txtSecilen
            // 
            this.txtSecilen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSecilen.Location = new System.Drawing.Point(130, 403);
            this.txtSecilen.Name = "txtSecilen";
            this.txtSecilen.Size = new System.Drawing.Size(140, 26);
            this.txtSecilen.TabIndex = 5;
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBirimFiyat.Location = new System.Drawing.Point(130, 432);
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Size = new System.Drawing.Size(140, 26);
            this.txtBirimFiyat.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Birim Fiyatı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Seçilen İçecek";
            // 
            // FrmIcecekler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(283, 606);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBirimFiyat);
            this.Controls.Add(this.txtSecilen);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.btnAzalt);
            this.Controls.Add(this.btnArttir);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmIcecekler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmIcecekler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmIcecekler_FormClosing);
            this.Load += new System.EventHandler(this.FrmIcecekler_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmIcecekler_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmIcecekler_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıceceklerTablosuBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıceceklerTablosuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Button btnArttir;
        private System.Windows.Forms.Button btnAzalt;
        private System.Windows.Forms.Button btnTamam;
        private BarDataSet barDataSet;
        private System.Windows.Forms.BindingSource ıceceklerTablosuBindingSource;
        private BarDataSetTableAdapters.Icecekler_TablosuTableAdapter icecekler_TablosuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatTLDataGridViewTextBoxColumn;
        private BarDataSet barDataSet1;
        private System.Windows.Forms.BindingSource ıceceklerTablosuBindingSource1;
        private System.Windows.Forms.TextBox txtSecilen;
        private System.Windows.Forms.TextBox txtBirimFiyat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}