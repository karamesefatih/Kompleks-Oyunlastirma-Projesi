
namespace oyunlandırma
{
    partial class Form31
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
            this.kullanıcılarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oyunlaştırmaDataSet = new oyunlandırma.OyunlaştırmaDataSet();
            this.soruBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database3DataSet = new oyunlandırma.Database3DataSet();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.soruTableAdapter = new oyunlandırma.Database3DataSetTableAdapters.soruTableAdapter();
            this.kullanıcılarTableAdapter = new oyunlandırma.OyunlaştırmaDataSetTableAdapters.KullanıcılarTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Kimlik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad_Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Şifre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rütbe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanıcılarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oyunlaştırmaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soruBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.Kimlik,
            this.Ad_Soyad,
            this.Şifre,
            this.Rütbe});
            this.dataGridView1.DataSource = this.kullanıcılarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(71, 318);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1021, 314);
            this.dataGridView1.TabIndex = 5;
            // 
            // kullanıcılarBindingSource
            // 
            this.kullanıcılarBindingSource.DataMember = "Kullanıcılar";
            this.kullanıcılarBindingSource.DataSource = this.oyunlaştırmaDataSet;
            // 
            // oyunlaştırmaDataSet
            // 
            this.oyunlaştırmaDataSet.DataSetName = "OyunlaştırmaDataSet";
            this.oyunlaştırmaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // soruBindingSource
            // 
            this.soruBindingSource.DataMember = "soru";
            this.soruBindingSource.DataSource = this.database3DataSet;
            // 
            // database3DataSet
            // 
            this.database3DataSet.DataSetName = "Database3DataSet";
            this.database3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // soruTableAdapter
            // 
            this.soruTableAdapter.ClearBeforeFill = true;
            // 
            // kullanıcılarTableAdapter
            // 
            this.kullanıcılarTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            // Şifre
            // 
            this.Şifre.DataPropertyName = "Şifre";
            this.Şifre.HeaderText = "Şifre";
            this.Şifre.MinimumWidth = 6;
            this.Şifre.Name = "Şifre";
            this.Şifre.Width = 125;
            // 
            // Rütbe
            // 
            this.Rütbe.DataPropertyName = "Rütbe";
            this.Rütbe.HeaderText = "Rütbe";
            this.Rütbe.MinimumWidth = 6;
            this.Rütbe.Name = "Rütbe";
            this.Rütbe.Width = 125;
            // 
            // Form31
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
            this.Name = "Form31";
            this.Text = "Form31";
            this.Load += new System.EventHandler(this.Form31_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanıcılarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oyunlaştırmaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soruBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private OyunlaştırmaDataSet oyunlaştırmaDataSet;
        private System.Windows.Forms.BindingSource kullanıcılarBindingSource;
        private OyunlaştırmaDataSetTableAdapters.KullanıcılarTableAdapter kullanıcılarTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kimlik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad_Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Şifre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rütbe;
    }
}