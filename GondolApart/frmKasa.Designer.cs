namespace GondolApart
{
    partial class frmKasa
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
            this.odaAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunSonuKasaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barDataSet = new GondolApart.BarDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.OdaAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutarDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunSonuKasaKrediKartiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barDataSet1 = new GondolApart.BarDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtToplam = new System.Windows.Forms.TextBox();
            this.txtCreditToplam = new System.Windows.Forms.TextBox();
            this.gunSonuKasaCreditCardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gunSonuKasaTableAdapter = new GondolApart.BarDataSetTableAdapters.GunSonuKasaTableAdapter();
            this.gunSonuKasaCreditCardTableAdapter = new GondolApart.BarDataSetTableAdapters.GunSonuKasaCreditCardTableAdapter();
            this.gunSonuKasaKrediKartiTableAdapter = new GondolApart.BarDataSetTableAdapters.GunSonuKasaKrediKartiTableAdapter();
            this.btn_Z_Raporu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunSonuKasaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunSonuKasaKrediKartiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunSonuKasaCreditCardBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.odaAdiDataGridViewTextBoxColumn,
            this.tutarDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn,
            this.ıdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gunSonuKasaBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(503, 416);
            this.dataGridView1.TabIndex = 0;
            // 
            // odaAdiDataGridViewTextBoxColumn
            // 
            this.odaAdiDataGridViewTextBoxColumn.DataPropertyName = "OdaAdi";
            this.odaAdiDataGridViewTextBoxColumn.HeaderText = "OdaAdi";
            this.odaAdiDataGridViewTextBoxColumn.Name = "odaAdiDataGridViewTextBoxColumn";
            // 
            // tutarDataGridViewTextBoxColumn
            // 
            this.tutarDataGridViewTextBoxColumn.DataPropertyName = "Tutar";
            this.tutarDataGridViewTextBoxColumn.HeaderText = "Tutar";
            this.tutarDataGridViewTextBoxColumn.Name = "tutarDataGridViewTextBoxColumn";
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
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gunSonuKasaBindingSource
            // 
            this.gunSonuKasaBindingSource.DataMember = "GunSonuKasa";
            this.gunSonuKasaBindingSource.DataSource = this.barDataSet;
            // 
            // barDataSet
            // 
            this.barDataSet.DataSetName = "BarDataSet";
            this.barDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 416);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Location = new System.Drawing.Point(652, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(503, 416);
            this.panel2.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OdaAdi,
            this.tutarDataGridViewTextBoxColumn1,
            this.tarihDataGridViewTextBoxColumn1,
            this.ıdDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.gunSonuKasaKrediKartiBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(503, 416);
            this.dataGridView2.TabIndex = 0;
            // 
            // OdaAdi
            // 
            this.OdaAdi.DataPropertyName = "OdaAdi";
            this.OdaAdi.HeaderText = "OdaAdi";
            this.OdaAdi.Name = "OdaAdi";
            // 
            // tutarDataGridViewTextBoxColumn1
            // 
            this.tutarDataGridViewTextBoxColumn1.DataPropertyName = "Tutar";
            this.tutarDataGridViewTextBoxColumn1.HeaderText = "Tutar";
            this.tutarDataGridViewTextBoxColumn1.Name = "tutarDataGridViewTextBoxColumn1";
            // 
            // tarihDataGridViewTextBoxColumn1
            // 
            this.tarihDataGridViewTextBoxColumn1.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn1.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn1.Name = "tarihDataGridViewTextBoxColumn1";
            // 
            // ıdDataGridViewTextBoxColumn1
            // 
            this.ıdDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn1.Name = "ıdDataGridViewTextBoxColumn1";
            this.ıdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // gunSonuKasaKrediKartiBindingSource
            // 
            this.gunSonuKasaKrediKartiBindingSource.DataMember = "GunSonuKasaKrediKarti";
            this.gunSonuKasaKrediKartiBindingSource.DataSource = this.barDataSet1;
            // 
            // barDataSet1
            // 
            this.barDataSet1.DataSetName = "BarDataSet";
            this.barDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kasadaki Para Miktarı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(655, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kredi Kartı ile Çekilen Miktar";
            // 
            // txtToplam
            // 
            this.txtToplam.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtToplam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplam.Location = new System.Drawing.Point(415, 68);
            this.txtToplam.Name = "txtToplam";
            this.txtToplam.ReadOnly = true;
            this.txtToplam.Size = new System.Drawing.Size(100, 38);
            this.txtToplam.TabIndex = 4;
            this.txtToplam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCreditToplam
            // 
            this.txtCreditToplam.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtCreditToplam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCreditToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCreditToplam.Location = new System.Drawing.Point(1055, 68);
            this.txtCreditToplam.Name = "txtCreditToplam";
            this.txtCreditToplam.ReadOnly = true;
            this.txtCreditToplam.Size = new System.Drawing.Size(100, 38);
            this.txtCreditToplam.TabIndex = 4;
            this.txtCreditToplam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunSonuKasaCreditCardBindingSource
            // 
            this.gunSonuKasaCreditCardBindingSource.DataMember = "GunSonuKasaCreditCard";
            this.gunSonuKasaCreditCardBindingSource.DataSource = this.barDataSet1;
            // 
            // gunSonuKasaTableAdapter
            // 
            this.gunSonuKasaTableAdapter.ClearBeforeFill = true;
            // 
            // gunSonuKasaCreditCardTableAdapter
            // 
            this.gunSonuKasaCreditCardTableAdapter.ClearBeforeFill = true;
            // 
            // gunSonuKasaKrediKartiTableAdapter
            // 
            this.gunSonuKasaKrediKartiTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Z_Raporu
            // 
            this.btn_Z_Raporu.Location = new System.Drawing.Point(467, 545);
            this.btn_Z_Raporu.Name = "btn_Z_Raporu";
            this.btn_Z_Raporu.Size = new System.Drawing.Size(285, 48);
            this.btn_Z_Raporu.TabIndex = 5;
            this.btn_Z_Raporu.Text = "Z Raporu";
            this.btn_Z_Raporu.UseVisualStyleBackColor = true;
            // 
            // frmKasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 605);
            this.Controls.Add(this.btn_Z_Raporu);
            this.Controls.Add(this.txtCreditToplam);
            this.Controls.Add(this.txtToplam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmKasa";
            this.Text = "frmKasa";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKasa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunSonuKasaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunSonuKasaKrediKartiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunSonuKasaCreditCardBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BarDataSet barDataSet;
        private System.Windows.Forms.BindingSource gunSonuKasaBindingSource;
        private BarDataSetTableAdapters.GunSonuKasaTableAdapter gunSonuKasaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private BarDataSet barDataSet1;
        private System.Windows.Forms.BindingSource gunSonuKasaCreditCardBindingSource;
        private BarDataSetTableAdapters.GunSonuKasaCreditCardTableAdapter gunSonuKasaCreditCardTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtToplam;
        private System.Windows.Forms.TextBox txtCreditToplam;
        private System.Windows.Forms.BindingSource gunSonuKasaKrediKartiBindingSource;
        private BarDataSetTableAdapters.GunSonuKasaKrediKartiTableAdapter gunSonuKasaKrediKartiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn OdaAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutarDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btn_Z_Raporu;
    }
}