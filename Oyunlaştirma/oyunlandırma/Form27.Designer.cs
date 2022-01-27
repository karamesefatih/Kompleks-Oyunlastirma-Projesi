
namespace oyunlandırma
{
    partial class Form27
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.satışBilgileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oyunlaştırmaDataSet = new oyunlandırma.OyunlaştırmaDataSet();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.satış_BilgileriTableAdapter = new oyunlandırma.OyunlaştırmaDataSetTableAdapters.Satış_BilgileriTableAdapter();
            this.kimlikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünTipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stoktan_mı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stok_Adet_geçmiş = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stok_Puanı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satışBilgileriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oyunlaştırmaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(68, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "DOSYA YOLU";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(514, 22);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(62, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 57);
            this.button1.TabIndex = 2;
            this.button1.Text = "dosyayı bul";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Location = new System.Drawing.Point(62, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(369, 56);
            this.button2.TabIndex = 3;
            this.button2.Text = "örnek excel dosyası al";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGray;
            this.button3.Location = new System.Drawing.Point(817, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 59);
            this.button3.TabIndex = 6;
            this.button3.Text = "ana menü";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(926, 253);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(693, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 29);
            this.label2.TabIndex = 8;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1110, 599);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 42);
            this.button4.TabIndex = 9;
            this.button4.Text = "onayla";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(669, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(399, 29);
            this.label3.TabIndex = 10;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kimlikDataGridViewTextBoxColumn,
            this.Tarih,
            this.adSoyadDataGridViewTextBoxColumn,
            this.ürünKoduDataGridViewTextBoxColumn,
            this.ürünTipiDataGridViewTextBoxColumn,
            this.Stoktan_mı,
            this.fiyatDataGridViewTextBoxColumn,
            this.Adet,
            this.Stok_Adet_geçmiş,
            this.Stok_Puanı});
            this.dataGridView1.DataSource = this.satışBilgileriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(72, 295);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1061, 314);
            this.dataGridView1.TabIndex = 5;
            // 
            // satışBilgileriBindingSource
            // 
            this.satışBilgileriBindingSource.DataMember = "Satış_Bilgileri";
            this.satışBilgileriBindingSource.DataSource = this.oyunlaştırmaDataSet;
            // 
            // oyunlaştırmaDataSet
            // 
            this.oyunlaştırmaDataSet.DataSetName = "OyunlaştırmaDataSet";
            this.oyunlaştırmaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // satış_BilgileriTableAdapter
            // 
            this.satış_BilgileriTableAdapter.ClearBeforeFill = true;
            // 
            // kimlikDataGridViewTextBoxColumn
            // 
            this.kimlikDataGridViewTextBoxColumn.DataPropertyName = "Kimlik";
            this.kimlikDataGridViewTextBoxColumn.HeaderText = "Kimlik";
            this.kimlikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kimlikDataGridViewTextBoxColumn.Name = "kimlikDataGridViewTextBoxColumn";
            this.kimlikDataGridViewTextBoxColumn.ReadOnly = true;
            this.kimlikDataGridViewTextBoxColumn.Width = 125;
            // 
            // Tarih
            // 
            this.Tarih.DataPropertyName = "Tarih";
            this.Tarih.HeaderText = "Tarih";
            this.Tarih.MinimumWidth = 6;
            this.Tarih.Name = "Tarih";
            this.Tarih.Width = 125;
            // 
            // adSoyadDataGridViewTextBoxColumn
            // 
            this.adSoyadDataGridViewTextBoxColumn.DataPropertyName = "Ad_Soyad";
            this.adSoyadDataGridViewTextBoxColumn.HeaderText = "Ad_Soyad";
            this.adSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adSoyadDataGridViewTextBoxColumn.Name = "adSoyadDataGridViewTextBoxColumn";
            this.adSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // ürünKoduDataGridViewTextBoxColumn
            // 
            this.ürünKoduDataGridViewTextBoxColumn.DataPropertyName = "Ürün_Kodu";
            this.ürünKoduDataGridViewTextBoxColumn.HeaderText = "Ürün_Kodu";
            this.ürünKoduDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ürünKoduDataGridViewTextBoxColumn.Name = "ürünKoduDataGridViewTextBoxColumn";
            this.ürünKoduDataGridViewTextBoxColumn.Width = 125;
            // 
            // ürünTipiDataGridViewTextBoxColumn
            // 
            this.ürünTipiDataGridViewTextBoxColumn.DataPropertyName = "Ürün_Tipi";
            this.ürünTipiDataGridViewTextBoxColumn.HeaderText = "Ürün_Tipi";
            this.ürünTipiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ürünTipiDataGridViewTextBoxColumn.Name = "ürünTipiDataGridViewTextBoxColumn";
            this.ürünTipiDataGridViewTextBoxColumn.Width = 125;
            // 
            // Stoktan_mı
            // 
            this.Stoktan_mı.DataPropertyName = "Stoktan_mı";
            this.Stoktan_mı.HeaderText = "Stoktan_mı";
            this.Stoktan_mı.MinimumWidth = 6;
            this.Stoktan_mı.Name = "Stoktan_mı";
            this.Stoktan_mı.Width = 125;
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            this.fiyatDataGridViewTextBoxColumn.Width = 125;
            // 
            // Adet
            // 
            this.Adet.DataPropertyName = "Adet";
            this.Adet.HeaderText = "Adet";
            this.Adet.MinimumWidth = 6;
            this.Adet.Name = "Adet";
            this.Adet.Width = 125;
            // 
            // Stok_Adet_geçmiş
            // 
            this.Stok_Adet_geçmiş.DataPropertyName = "Stok_Adet_geçmiş";
            this.Stok_Adet_geçmiş.HeaderText = "Stok_Adet_geçmiş";
            this.Stok_Adet_geçmiş.MinimumWidth = 6;
            this.Stok_Adet_geçmiş.Name = "Stok_Adet_geçmiş";
            this.Stok_Adet_geçmiş.Width = 125;
            // 
            // Stok_Puanı
            // 
            this.Stok_Puanı.DataPropertyName = "Stok_Puanı";
            this.Stok_Puanı.HeaderText = "Stok_Puanı";
            this.Stok_Puanı.MinimumWidth = 6;
            this.Stok_Puanı.Name = "Stok_Puanı";
            this.Stok_Puanı.Width = 125;
            // 
            // Form27
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form27";
            this.Text = "Form27";
            this.Load += new System.EventHandler(this.Form27_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satışBilgileriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oyunlaştırmaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private OyunlaştırmaDataSet oyunlaştırmaDataSet;
        private System.Windows.Forms.BindingSource satışBilgileriBindingSource;
        private OyunlaştırmaDataSetTableAdapters.Satış_BilgileriTableAdapter satış_BilgileriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kendiStoğundanMıSattıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn belirtilenSüredeMiSattıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satışTipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kimlikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn adSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünTipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stoktan_mı;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stok_Adet_geçmiş;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stok_Puanı;
    }
}