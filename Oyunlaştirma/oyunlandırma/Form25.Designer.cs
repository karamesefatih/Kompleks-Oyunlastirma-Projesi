
namespace oyunlandırma
{
    partial class Form25
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
            this.satıcıBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oyunlaştırmaDataSet = new oyunlandırma.OyunlaştırmaDataSet();
            this.satBilgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database3DataSet = new oyunlandırma.Database3DataSet();
            this.soruBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.soruTableAdapter = new oyunlandırma.Database3DataSetTableAdapters.soruTableAdapter();
            this.satıcıBilgiTableAdapter = new oyunlandırma.OyunlaştırmaDataSetTableAdapters.SatıcıBilgiTableAdapter();
            this.Kimlik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad_Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aylıkHedefDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yıllıkHedefDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aylık_Ciro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yıllık_Ciro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AylıkHedefYüzdesi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YıllıkHedefYüzdesi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stok_Adedi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ÖzelPuanlıStokAdedi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aylıkstok_hedefi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokhedefyüzdesi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satıcıBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oyunlaştırmaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satBilgBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soruBindingSource)).BeginInit();
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
            this.button3.Location = new System.Drawing.Point(911, 18);
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(807, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 29);
            this.label2.TabIndex = 8;
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
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(805, 208);
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
            this.Kimlik,
            this.Ad_Soyad,
            this.aylıkHedefDataGridViewTextBoxColumn,
            this.yıllıkHedefDataGridViewTextBoxColumn,
            this.Aylık_Ciro,
            this.Yıllık_Ciro,
            this.AylıkHedefYüzdesi,
            this.YıllıkHedefYüzdesi,
            this.Stok_Adedi,
            this.ÖzelPuanlıStokAdedi,
            this.aylıkstok_hedefi,
            this.stokhedefyüzdesi});
            this.dataGridView1.DataSource = this.satıcıBilgiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(71, 318);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1021, 314);
            this.dataGridView1.TabIndex = 5;
            // 
            // satıcıBilgiBindingSource
            // 
            this.satıcıBilgiBindingSource.DataMember = "SatıcıBilgi";
            this.satıcıBilgiBindingSource.DataSource = this.oyunlaştırmaDataSet;
            // 
            // oyunlaştırmaDataSet
            // 
            this.oyunlaştırmaDataSet.DataSetName = "OyunlaştırmaDataSet";
            this.oyunlaştırmaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // satBilgBindingSource
            // 
            this.satBilgBindingSource.DataMember = "Sat_Bilg";
            this.satBilgBindingSource.DataSource = this.database3DataSet;
            // 
            // database3DataSet
            // 
            this.database3DataSet.DataSetName = "Database3DataSet";
            this.database3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // soruBindingSource
            // 
            this.soruBindingSource.DataMember = "soru";
            this.soruBindingSource.DataSource = this.database3DataSet;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // soruTableAdapter
            // 
            this.soruTableAdapter.ClearBeforeFill = true;
            // 
            // satıcıBilgiTableAdapter
            // 
            this.satıcıBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // Kimlik
            // 
            this.Kimlik.DataPropertyName = "Kimlik";
            this.Kimlik.HeaderText = "Kimlik";
            this.Kimlik.MinimumWidth = 6;
            this.Kimlik.Name = "Kimlik";
            this.Kimlik.ReadOnly = true;
            this.Kimlik.Width = 125;
            // 
            // Ad_Soyad
            // 
            this.Ad_Soyad.DataPropertyName = "Ad_Soyad";
            this.Ad_Soyad.HeaderText = "Ad_Soyad";
            this.Ad_Soyad.MinimumWidth = 6;
            this.Ad_Soyad.Name = "Ad_Soyad";
            this.Ad_Soyad.Width = 125;
            // 
            // aylıkHedefDataGridViewTextBoxColumn
            // 
            this.aylıkHedefDataGridViewTextBoxColumn.DataPropertyName = "Aylık_Hedef";
            this.aylıkHedefDataGridViewTextBoxColumn.HeaderText = "Aylık_Hedef";
            this.aylıkHedefDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aylıkHedefDataGridViewTextBoxColumn.Name = "aylıkHedefDataGridViewTextBoxColumn";
            this.aylıkHedefDataGridViewTextBoxColumn.Width = 125;
            // 
            // yıllıkHedefDataGridViewTextBoxColumn
            // 
            this.yıllıkHedefDataGridViewTextBoxColumn.DataPropertyName = "Yıllık_Hedef";
            this.yıllıkHedefDataGridViewTextBoxColumn.HeaderText = "Yıllık_Hedef";
            this.yıllıkHedefDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yıllıkHedefDataGridViewTextBoxColumn.Name = "yıllıkHedefDataGridViewTextBoxColumn";
            this.yıllıkHedefDataGridViewTextBoxColumn.Width = 125;
            // 
            // Aylık_Ciro
            // 
            this.Aylık_Ciro.DataPropertyName = "Aylık_Ciro";
            this.Aylık_Ciro.HeaderText = "Aylık_Ciro";
            this.Aylık_Ciro.MinimumWidth = 6;
            this.Aylık_Ciro.Name = "Aylık_Ciro";
            this.Aylık_Ciro.Width = 125;
            // 
            // Yıllık_Ciro
            // 
            this.Yıllık_Ciro.DataPropertyName = "Yıllık_Ciro";
            this.Yıllık_Ciro.HeaderText = "Yıllık_Ciro";
            this.Yıllık_Ciro.MinimumWidth = 6;
            this.Yıllık_Ciro.Name = "Yıllık_Ciro";
            this.Yıllık_Ciro.Width = 125;
            // 
            // AylıkHedefYüzdesi
            // 
            this.AylıkHedefYüzdesi.DataPropertyName = "AylıkHedefYüzdesi";
            this.AylıkHedefYüzdesi.HeaderText = "AylıkHedefYüzdesi";
            this.AylıkHedefYüzdesi.MinimumWidth = 6;
            this.AylıkHedefYüzdesi.Name = "AylıkHedefYüzdesi";
            this.AylıkHedefYüzdesi.Width = 125;
            // 
            // YıllıkHedefYüzdesi
            // 
            this.YıllıkHedefYüzdesi.DataPropertyName = "YıllıkHedefYüzdesi";
            this.YıllıkHedefYüzdesi.HeaderText = "YıllıkHedefYüzdesi";
            this.YıllıkHedefYüzdesi.MinimumWidth = 6;
            this.YıllıkHedefYüzdesi.Name = "YıllıkHedefYüzdesi";
            this.YıllıkHedefYüzdesi.Width = 125;
            // 
            // Stok_Adedi
            // 
            this.Stok_Adedi.DataPropertyName = "Stok_Adedi";
            this.Stok_Adedi.HeaderText = "Stok_Adedi";
            this.Stok_Adedi.MinimumWidth = 6;
            this.Stok_Adedi.Name = "Stok_Adedi";
            this.Stok_Adedi.Width = 125;
            // 
            // ÖzelPuanlıStokAdedi
            // 
            this.ÖzelPuanlıStokAdedi.DataPropertyName = "ÖzelPuanlıStokAdedi";
            this.ÖzelPuanlıStokAdedi.HeaderText = "ÖzelPuanlıStokAdedi";
            this.ÖzelPuanlıStokAdedi.MinimumWidth = 6;
            this.ÖzelPuanlıStokAdedi.Name = "ÖzelPuanlıStokAdedi";
            this.ÖzelPuanlıStokAdedi.Width = 125;
            // 
            // aylıkstok_hedefi
            // 
            this.aylıkstok_hedefi.DataPropertyName = "aylıkstok_hedefi";
            this.aylıkstok_hedefi.HeaderText = "aylıkstok_hedefi";
            this.aylıkstok_hedefi.MinimumWidth = 6;
            this.aylıkstok_hedefi.Name = "aylıkstok_hedefi";
            this.aylıkstok_hedefi.Width = 125;
            // 
            // stokhedefyüzdesi
            // 
            this.stokhedefyüzdesi.DataPropertyName = "stokhedefyüzdesi";
            this.stokhedefyüzdesi.HeaderText = "stokhedefyüzdesi";
            this.stokhedefyüzdesi.MinimumWidth = 6;
            this.stokhedefyüzdesi.Name = "stokhedefyüzdesi";
            this.stokhedefyüzdesi.Width = 125;
            // 
            // Form25
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
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
            this.Name = "Form25";
            this.Text = "Form25";
            this.Load += new System.EventHandler(this.Form25_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satıcıBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oyunlaştırmaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satBilgBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soruBindingSource)).EndInit();
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
        private Database3DataSet database3DataSet;
        private System.Windows.Forms.BindingSource soruBindingSource;
        private Database3DataSetTableAdapters.soruTableAdapter soruTableAdapter;
        private System.Windows.Forms.BindingSource satBilgBindingSource;
        private OyunlaştırmaDataSet oyunlaştırmaDataSet;
        private System.Windows.Forms.BindingSource satıcıBilgiBindingSource;
        private OyunlaştırmaDataSetTableAdapters.SatıcıBilgiTableAdapter satıcıBilgiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kimlik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad_Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn aylıkHedefDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yıllıkHedefDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aylık_Ciro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yıllık_Ciro;
        private System.Windows.Forms.DataGridViewTextBoxColumn AylıkHedefYüzdesi;
        private System.Windows.Forms.DataGridViewTextBoxColumn YıllıkHedefYüzdesi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stok_Adedi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ÖzelPuanlıStokAdedi;
        private System.Windows.Forms.DataGridViewTextBoxColumn aylıkstok_hedefi;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokhedefyüzdesi;
    }
}