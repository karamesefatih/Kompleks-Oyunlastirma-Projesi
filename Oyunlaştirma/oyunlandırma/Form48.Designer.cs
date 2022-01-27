
namespace oyunlandırma
{
    partial class Form48
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form48));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iddialıStokSatışBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oyunlaştırmaDataSet = new oyunlandırma.OyunlaştırmaDataSet();
            this.İddialı_Stok_SatışTableAdapter = new oyunlandırma.OyunlaştırmaDataSetTableAdapters.İddialı_Stok_SatışTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Kimlik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünkoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satıcıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddiaSüreciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kazancDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iddialıStokSatışBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oyunlaştırmaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(1094, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 71);
            this.button1.TabIndex = 0;
            this.button1.Text = "ANA MENÜ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kimlik,
            this.ürünkoduDataGridViewTextBoxColumn,
            this.satıcıDataGridViewTextBoxColumn,
            this.iddiaSüreciDataGridViewTextBoxColumn,
            this.kazancDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.iddialıStokSatışBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.Lavender;
            this.dataGridView1.Location = new System.Drawing.Point(56, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(788, 416);
            this.dataGridView1.TabIndex = 1;
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
            // İddialı_Stok_SatışTableAdapter
            // 
            this.İddialı_Stok_SatışTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(862, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(729, 624);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 82);
            this.button2.TabIndex = 4;
            this.button2.Text = "Sattım";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(925, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Crimson;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(52, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(947, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Belirtilen sürede satabileceğiniz ürünü seçip \"Sattım\" butonuna tıklayarak iddiad" +
    "a bulunabilirsiniz.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(506, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
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
            this.iddiaSüreciDataGridViewTextBoxColumn.HeaderText = "İddia Son Tarihi";
            this.iddiaSüreciDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iddiaSüreciDataGridViewTextBoxColumn.Name = "iddiaSüreciDataGridViewTextBoxColumn";
            this.iddiaSüreciDataGridViewTextBoxColumn.Width = 150;
            // 
            // kazancDataGridViewTextBoxColumn
            // 
            this.kazancDataGridViewTextBoxColumn.DataPropertyName = "Kazanc";
            this.kazancDataGridViewTextBoxColumn.HeaderText = "Kazanç";
            this.kazancDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kazancDataGridViewTextBoxColumn.Name = "kazancDataGridViewTextBoxColumn";
            this.kazancDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form48
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1282, 853);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form48";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form48";
            this.Load += new System.EventHandler(this.Form48_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iddialıStokSatışBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oyunlaştırmaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private OyunlaştırmaDataSet oyunlaştırmaDataSet;
        private System.Windows.Forms.BindingSource iddialıStokSatışBindingSource;
        private OyunlaştırmaDataSetTableAdapters.İddialı_Stok_SatışTableAdapter İddialı_Stok_SatışTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kimlik;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünkoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satıcıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddiaSüreciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kazancDataGridViewTextBoxColumn;
    }
}