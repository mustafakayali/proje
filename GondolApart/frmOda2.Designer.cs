namespace GondolApart
{
    partial class frmOda2
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
            this.btn_icecekler = new System.Windows.Forms.Button();
            this.barDataSet = new GondolApart.BarDataSet();
            this.oda2AdisyonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oda2AdisyonTableAdapter = new GondolApart.BarDataSetTableAdapters.Oda2AdisyonTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oda2AdisyonBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.barDataSet1 = new GondolApart.BarDataSet();
            this.btn_Yiyecekler = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtToplam = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.barDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oda2AdisyonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oda2AdisyonBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_icecekler
            // 
            this.btn_icecekler.BackgroundImage = global::GondolApart.Properties.Resources.drinks;
            this.btn_icecekler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_icecekler.Location = new System.Drawing.Point(12, 12);
            this.btn_icecekler.Name = "btn_icecekler";
            this.btn_icecekler.Size = new System.Drawing.Size(304, 213);
            this.btn_icecekler.TabIndex = 5;
            this.btn_icecekler.UseVisualStyleBackColor = true;
            this.btn_icecekler.Click += new System.EventHandler(this.btn_icecekler_Click);
            // 
            // barDataSet
            // 
            this.barDataSet.DataSetName = "BarDataSet";
            this.barDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oda2AdisyonBindingSource
            // 
            this.oda2AdisyonBindingSource.DataMember = "Oda2Adisyon";
            this.oda2AdisyonBindingSource.DataSource = this.barDataSet;
            // 
            // oda2AdisyonTableAdapter
            // 
            this.oda2AdisyonTableAdapter.ClearBeforeFill = true;
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
            this.ıdDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.oda2AdisyonBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(337, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 411);
            this.dataGridView1.TabIndex = 9;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
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
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            // 
            // oda2AdisyonBindingSource1
            // 
            this.oda2AdisyonBindingSource1.DataMember = "Oda2Adisyon";
            this.oda2AdisyonBindingSource1.DataSource = this.barDataSet1;
            // 
            // barDataSet1
            // 
            this.barDataSet1.DataSetName = "BarDataSet";
            this.barDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Yiyecekler
            // 
            this.btn_Yiyecekler.BackgroundImage = global::GondolApart.Properties.Resources.foods;
            this.btn_Yiyecekler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Yiyecekler.Location = new System.Drawing.Point(12, 247);
            this.btn_Yiyecekler.Name = "btn_Yiyecekler";
            this.btn_Yiyecekler.Size = new System.Drawing.Size(304, 213);
            this.btn_Yiyecekler.TabIndex = 14;
            this.btn_Yiyecekler.UseVisualStyleBackColor = true;
            this.btn_Yiyecekler.Click += new System.EventHandler(this.btn_Yiyecekler_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(832, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 39);
            this.label2.TabIndex = 17;
            this.label2.Text = "TL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(344, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 39);
            this.label1.TabIndex = 16;
            this.label1.Text = "Genel Toplam";
            // 
            // txtToplam
            // 
            this.txtToplam.BackColor = System.Drawing.Color.SeaGreen;
            this.txtToplam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplam.Location = new System.Drawing.Point(625, 441);
            this.txtToplam.Name = "txtToplam";
            this.txtToplam.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtToplam.Size = new System.Drawing.Size(167, 40);
            this.txtToplam.TabIndex = 15;
            this.txtToplam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmOda2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtToplam);
            this.Controls.Add(this.btn_Yiyecekler);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_icecekler);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmOda2";
            this.Text = "Room2 // Oda2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmOda2_Activated);
            this.Deactivate += new System.EventHandler(this.frmOda2_Deactivate);
            this.Load += new System.EventHandler(this.frmOda2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oda2AdisyonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oda2AdisyonBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_icecekler;
        private BarDataSet barDataSet;
        private System.Windows.Forms.BindingSource oda2AdisyonBindingSource;
        private BarDataSetTableAdapters.Oda2AdisyonTableAdapter oda2AdisyonTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BarDataSet barDataSet1;
        private System.Windows.Forms.BindingSource oda2AdisyonBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Yiyecekler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtToplam;
    }
}