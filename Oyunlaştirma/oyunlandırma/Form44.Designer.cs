
namespace oyunlandırma
{
    partial class Form44
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
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kimlikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.şifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rütbeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanıcılarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oyunlaştırmaDataSet = new oyunlandırma.OyunlaştırmaDataSet();
            this.kullanıcılarTableAdapter = new oyunlandırma.OyunlaştırmaDataSetTableAdapters.KullanıcılarTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanıcılarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oyunlaştırmaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 79);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kimlikDataGridViewTextBoxColumn,
            this.adSoyadDataGridViewTextBoxColumn,
            this.şifreDataGridViewTextBoxColumn,
            this.rütbeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kullanıcılarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(562, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(429, 282);
            this.dataGridView1.TabIndex = 1;
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
            // adSoyadDataGridViewTextBoxColumn
            // 
            this.adSoyadDataGridViewTextBoxColumn.DataPropertyName = "Ad_Soyad";
            this.adSoyadDataGridViewTextBoxColumn.HeaderText = "Ad_Soyad";
            this.adSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adSoyadDataGridViewTextBoxColumn.Name = "adSoyadDataGridViewTextBoxColumn";
            this.adSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // şifreDataGridViewTextBoxColumn
            // 
            this.şifreDataGridViewTextBoxColumn.DataPropertyName = "Şifre";
            this.şifreDataGridViewTextBoxColumn.HeaderText = "Şifre";
            this.şifreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.şifreDataGridViewTextBoxColumn.Name = "şifreDataGridViewTextBoxColumn";
            this.şifreDataGridViewTextBoxColumn.Width = 125;
            // 
            // rütbeDataGridViewTextBoxColumn
            // 
            this.rütbeDataGridViewTextBoxColumn.DataPropertyName = "Rütbe";
            this.rütbeDataGridViewTextBoxColumn.HeaderText = "Rütbe";
            this.rütbeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rütbeDataGridViewTextBoxColumn.Name = "rütbeDataGridViewTextBoxColumn";
            this.rütbeDataGridViewTextBoxColumn.Width = 125;
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
            // kullanıcılarTableAdapter
            // 
            this.kullanıcılarTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(47, 150);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(303, 324);
            this.listBox1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(410, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // Form44
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 648);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form44";
            this.Text = "Form44";
            this.Load += new System.EventHandler(this.Form44_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanıcılarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oyunlaştırmaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private OyunlaştırmaDataSet oyunlaştırmaDataSet;
        private System.Windows.Forms.BindingSource kullanıcılarBindingSource;
        private OyunlaştırmaDataSetTableAdapters.KullanıcılarTableAdapter kullanıcılarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kimlikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn şifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rütbeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}