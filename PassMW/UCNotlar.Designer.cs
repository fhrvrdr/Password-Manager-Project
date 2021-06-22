
namespace PassMW
{
    partial class UCNotlar
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCNotlar));
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.dtgNot = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreliNotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblNotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBPassMWDataSet1 = new PassMW.DBPassMWDataSet1();
            this.txtNot = new System.Windows.Forms.RichTextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnGoster = new System.Windows.Forms.Button();
            this.txtNotAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tblNotTableAdapter = new PassMW.DBPassMWDataSet1TableAdapters.tblNotTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPassMWDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(758, 158);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(123, 42);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.White;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnTemizle.Location = new System.Drawing.Point(629, 160);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(123, 40);
            this.btnTemizle.TabIndex = 14;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // dtgNot
            // 
            this.dtgNot.AllowDrop = true;
            this.dtgNot.AllowUserToAddRows = false;
            this.dtgNot.AllowUserToDeleteRows = false;
            this.dtgNot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgNot.AutoGenerateColumns = false;
            this.dtgNot.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgNot.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtgNot.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgNot.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dtgNot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNot.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.notAdiDataGridViewTextBoxColumn,
            this.sifreliNotDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn});
            this.dtgNot.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dtgNot.DataSource = this.tblNotBindingSource;
            this.dtgNot.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgNot.Location = new System.Drawing.Point(26, 226);
            this.dtgNot.MultiSelect = false;
            this.dtgNot.Name = "dtgNot";
            this.dtgNot.ReadOnly = true;
            this.dtgNot.RowHeadersWidth = 51;
            this.dtgNot.RowTemplate.Height = 24;
            this.dtgNot.Size = new System.Drawing.Size(430, 203);
            this.dtgNot.TabIndex = 15;
            this.dtgNot.TabStop = false;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıDDataGridViewTextBoxColumn.Visible = false;
            // 
            // notAdiDataGridViewTextBoxColumn
            // 
            this.notAdiDataGridViewTextBoxColumn.DataPropertyName = "NotAdi";
            this.notAdiDataGridViewTextBoxColumn.HeaderText = "Not Adı";
            this.notAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notAdiDataGridViewTextBoxColumn.Name = "notAdiDataGridViewTextBoxColumn";
            this.notAdiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sifreliNotDataGridViewTextBoxColumn
            // 
            this.sifreliNotDataGridViewTextBoxColumn.DataPropertyName = "SifreliNot";
            this.sifreliNotDataGridViewTextBoxColumn.HeaderText = "Not";
            this.sifreliNotDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sifreliNotDataGridViewTextBoxColumn.Name = "sifreliNotDataGridViewTextBoxColumn";
            this.sifreliNotDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // tblNotBindingSource
            // 
            this.tblNotBindingSource.DataMember = "tblNot";
            this.tblNotBindingSource.DataSource = this.dBPassMWDataSet1;
            // 
            // dBPassMWDataSet1
            // 
            this.dBPassMWDataSet1.DataSetName = "DBPassMWDataSet1";
            this.dBPassMWDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNot
            // 
            this.txtNot.Location = new System.Drawing.Point(523, 226);
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(424, 203);
            this.txtNot.TabIndex = 16;
            this.txtNot.Text = "";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(247, 161);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 39);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnGoster
            // 
            this.btnGoster.BackColor = System.Drawing.Color.White;
            this.btnGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoster.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnGoster.Location = new System.Drawing.Point(102, 160);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(123, 40);
            this.btnGoster.TabIndex = 18;
            this.btnGoster.Text = "Göster";
            this.btnGoster.UseVisualStyleBackColor = false;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // txtNotAdi
            // 
            this.txtNotAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtNotAdi.Location = new System.Drawing.Point(703, 113);
            this.txtNotAdi.Name = "txtNotAdi";
            this.txtNotAdi.Size = new System.Drawing.Size(205, 28);
            this.txtNotAdi.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.Location = new System.Drawing.Point(625, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Not Adı";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(435, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // tblNotTableAdapter
            // 
            this.tblNotTableAdapter.ClearBeforeFill = true;
            // 
            // UCNotlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNotAdi);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtNot);
            this.Controls.Add(this.dtgNot);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnKaydet);
            this.Name = "UCNotlar";
            this.Size = new System.Drawing.Size(971, 449);
            ((System.ComponentModel.ISupportInitialize)(this.dtgNot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPassMWDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.DataGridView dtgNot;
        private System.Windows.Forms.RichTextBox txtNot;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.TextBox txtNotAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource tblNotBindingSource;
        private DBPassMWDataSet1 dBPassMWDataSet1;
        private DBPassMWDataSet1TableAdapters.tblNotTableAdapter tblNotTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreliNotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
    }
}
