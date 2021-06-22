
namespace PassMW
{
    partial class UCAccount
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
            this.dtgAccounts = new System.Windows.Forms.DataGridView();
            this.tblAccBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBPassMWDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBPassMWDataSet = new PassMW.DBPassMWDataSet();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGoster = new System.Windows.Forms.Button();
            this.tbl_AccTableAdapter = new PassMW.DBPassMWDataSetTableAdapters.tbl_AccTableAdapter();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accUsernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accPassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPassMWDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPassMWDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgAccounts
            // 
            this.dtgAccounts.AllowDrop = true;
            this.dtgAccounts.AllowUserToAddRows = false;
            this.dtgAccounts.AllowUserToDeleteRows = false;
            this.dtgAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgAccounts.AutoGenerateColumns = false;
            this.dtgAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgAccounts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtgAccounts.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgAccounts.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dtgAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.accountTypeDataGridViewTextBoxColumn,
            this.accountNameDataGridViewTextBoxColumn,
            this.accUsernameDataGridViewTextBoxColumn,
            this.accPassDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn});
            this.dtgAccounts.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dtgAccounts.DataSource = this.tblAccBindingSource;
            this.dtgAccounts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgAccounts.Location = new System.Drawing.Point(40, 227);
            this.dtgAccounts.MultiSelect = false;
            this.dtgAccounts.Name = "dtgAccounts";
            this.dtgAccounts.ReadOnly = true;
            this.dtgAccounts.RowHeadersWidth = 51;
            this.dtgAccounts.RowTemplate.Height = 24;
            this.dtgAccounts.Size = new System.Drawing.Size(896, 214);
            this.dtgAccounts.TabIndex = 0;
            this.dtgAccounts.TabStop = false;
            // 
            // tblAccBindingSource
            // 
            this.tblAccBindingSource.DataMember = "tbl_Acc";
            this.tblAccBindingSource.DataSource = this.dBPassMWDataSetBindingSource;
            // 
            // dBPassMWDataSetBindingSource
            // 
            this.dBPassMWDataSetBindingSource.DataSource = this.dBPassMWDataSet;
            this.dBPassMWDataSetBindingSource.Position = 0;
            // 
            // dBPassMWDataSet
            // 
            this.dBPassMWDataSet.DataSetName = "DBPassMWDataSet";
            this.dBPassMWDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(572, 51);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(124, 51);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGoster
            // 
            this.btnGoster.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnGoster.ForeColor = System.Drawing.Color.White;
            this.btnGoster.Location = new System.Drawing.Point(312, 51);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(124, 51);
            this.btnGoster.TabIndex = 4;
            this.btnGoster.Text = "Göster";
            this.btnGoster.UseVisualStyleBackColor = false;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // tbl_AccTableAdapter
            // 
            this.tbl_AccTableAdapter.ClearBeforeFill = true;
            // 
            // txtKullanici
            // 
            this.txtKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtKullanici.Location = new System.Drawing.Point(251, 142);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(245, 28);
            this.txtKullanici.TabIndex = 5;
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtSifre.Location = new System.Drawing.Point(600, 142);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(262, 28);
            this.txtSifre.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.Location = new System.Drawing.Point(115, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.Location = new System.Drawing.Point(547, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Şifre";
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.White;
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnCopy.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnCopy.Location = new System.Drawing.Point(442, 51);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(124, 51);
            this.btnCopy.TabIndex = 9;
            this.btnCopy.Text = "Kopyala";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
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
            // accountTypeDataGridViewTextBoxColumn
            // 
            this.accountTypeDataGridViewTextBoxColumn.DataPropertyName = "AccountType";
            this.accountTypeDataGridViewTextBoxColumn.HeaderText = "Hesap Türü";
            this.accountTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.accountTypeDataGridViewTextBoxColumn.Name = "accountTypeDataGridViewTextBoxColumn";
            this.accountTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountNameDataGridViewTextBoxColumn
            // 
            this.accountNameDataGridViewTextBoxColumn.DataPropertyName = "AccountName";
            this.accountNameDataGridViewTextBoxColumn.HeaderText = "Hesap Adı";
            this.accountNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.accountNameDataGridViewTextBoxColumn.Name = "accountNameDataGridViewTextBoxColumn";
            this.accountNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accUsernameDataGridViewTextBoxColumn
            // 
            this.accUsernameDataGridViewTextBoxColumn.DataPropertyName = "AccUsername";
            this.accUsernameDataGridViewTextBoxColumn.HeaderText = "Kullanıcı Adı";
            this.accUsernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.accUsernameDataGridViewTextBoxColumn.Name = "accUsernameDataGridViewTextBoxColumn";
            this.accUsernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accPassDataGridViewTextBoxColumn
            // 
            this.accPassDataGridViewTextBoxColumn.DataPropertyName = "AccPass";
            this.accPassDataGridViewTextBoxColumn.HeaderText = "Şifre";
            this.accPassDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.accPassDataGridViewTextBoxColumn.Name = "accPassDataGridViewTextBoxColumn";
            this.accPassDataGridViewTextBoxColumn.ReadOnly = true;
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
            // UCAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dtgAccounts);
            this.Name = "UCAccount";
            this.Size = new System.Drawing.Size(970, 469);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPassMWDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPassMWDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dtgAccounts;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.BindingSource dBPassMWDataSetBindingSource;
        private DBPassMWDataSet dBPassMWDataSet;
        private System.Windows.Forms.BindingSource tblAccBindingSource;
        private DBPassMWDataSetTableAdapters.tbl_AccTableAdapter tbl_AccTableAdapter;
        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accUsernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accPassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
    }
}
