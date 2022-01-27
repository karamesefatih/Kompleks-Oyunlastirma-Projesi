
namespace oyunlandırma
{
    partial class Form46
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Kimlik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünkoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satıcıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddiaSüreciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kazancDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddialıStokSatışBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oyunlaştırmaDataSet = new oyunlandırma.OyunlaştırmaDataSet();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.İddialı_Stok_SatışTableAdapter = new oyunlandırma.OyunlaştırmaDataSetTableAdapters.İddialı_Stok_SatışTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iddialıStokSatışBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oyunlaştırmaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 839);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(204, 766);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 24);
            this.label10.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 766);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Eleman Sayısı:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(35, 705);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(346, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(35, 652);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(346, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 599);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(346, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(22, 273);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(379, 22);
            this.textBox3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "KAZANCI";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "ÜRÜN KODU";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(19, 45);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(382, 96);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(19, 217);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(382, 22);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "İDDİA SÜRECİ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 165);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(382, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "SATICI";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1131, 48);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 59);
            this.button4.TabIndex = 4;
            this.button4.Text = "ANA MENÜ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kimlik,
            this.ürünkoduDataGridViewTextBoxColumn,
            this.satıcıDataGridViewTextBoxColumn,
            this.iddiaSüreciDataGridViewTextBoxColumn,
            this.kazancDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.iddialıStokSatışBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(456, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(761, 466);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // ürünkoduDataGridViewTextBoxColumn
            // 
            this.ürünkoduDataGridViewTextBoxColumn.DataPropertyName = "Ürün_kodu";
            this.ürünkoduDataGridViewTextBoxColumn.HeaderText = "Ürün_kodu";
            this.ürünkoduDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ürünkoduDataGridViewTextBoxColumn.Name = "ürünkoduDataGridViewTextBoxColumn";
            this.ürünkoduDataGridViewTextBoxColumn.Width = 125;
            // 
            // satıcıDataGridViewTextBoxColumn
            // 
            this.satıcıDataGridViewTextBoxColumn.DataPropertyName = "Satıcı";
            this.satıcıDataGridViewTextBoxColumn.HeaderText = "Satıcı";
            this.satıcıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.satıcıDataGridViewTextBoxColumn.Name = "satıcıDataGridViewTextBoxColumn";
            this.satıcıDataGridViewTextBoxColumn.Width = 125;
            // 
            // iddiaSüreciDataGridViewTextBoxColumn
            // 
            this.iddiaSüreciDataGridViewTextBoxColumn.DataPropertyName = "İddia_Süreci";
            this.iddiaSüreciDataGridViewTextBoxColumn.HeaderText = "İddia_Süreci";
            this.iddiaSüreciDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iddiaSüreciDataGridViewTextBoxColumn.Name = "iddiaSüreciDataGridViewTextBoxColumn";
            this.iddiaSüreciDataGridViewTextBoxColumn.Width = 125;
            // 
            // kazancDataGridViewTextBoxColumn
            // 
            this.kazancDataGridViewTextBoxColumn.DataPropertyName = "Kazanc";
            this.kazancDataGridViewTextBoxColumn.HeaderText = "Kazanc";
            this.kazancDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kazancDataGridViewTextBoxColumn.Name = "kazancDataGridViewTextBoxColumn";
            this.kazancDataGridViewTextBoxColumn.Width = 125;
            // 
            // iddialıStokSatışBindingSource
            // 
            this.iddialıStokSatışBindingSource.DataMember = "İddialı_Stok_Satış";
            this.iddialıStokSatışBindingSource.DataSource = this.oyunlaştırmaDataSet;
            // 
            // oyunlaştırmaDataSet
            // 
            this.oyunlaştırmaDataSet.DataSetName = "OyunlaştırmaDataSet";
            this.oyunlaştırmaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1012, 48);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 59);
            this.button5.TabIndex = 6;
            this.button5.Text = "EXCEL YÜKLE";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // İddialı_Stok_SatışTableAdapter
            // 
            this.İddialı_Stok_SatışTableAdapter.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LightGray;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(491, 48);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(165, 72);
            this.button6.TabIndex = 7;
            this.button6.Text = "Satış Yapanlar Yönetici Kontrol";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(810, 48);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(98, 59);
            this.button7.TabIndex = 8;
            this.button7.Text = "TÜM VERİLERİ SİL";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form46
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 853);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form46";
            this.Text = "Form46";
            this.Load += new System.EventHandler(this.Form46_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iddialıStokSatışBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oyunlaştırmaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button5;
        private OyunlaştırmaDataSet oyunlaştırmaDataSet;
        private System.Windows.Forms.BindingSource iddialıStokSatışBindingSource;
        private OyunlaştırmaDataSetTableAdapters.İddialı_Stok_SatışTableAdapter İddialı_Stok_SatışTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kimlik;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünkoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satıcıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddiaSüreciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kazancDataGridViewTextBoxColumn;
        public System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}