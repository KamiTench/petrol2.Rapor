namespace Petrol
{
    partial class AnaDepoYonetimiForm
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
            this.txtRezervID = new System.Windows.Forms.TextBox();
            this.txtYakitTuru = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.txtMinimumSeviye = new System.Windows.Forms.TextBox();
            this.txtSonGuncellemeTarihi = new System.Windows.Forms.TextBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnYeniYakitEkle = new System.Windows.Forms.Button();
            this.dataGridViewAnaRezerv = new System.Windows.Forms.DataGridView();
            this.rezervIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yakitTuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minimumSeviyeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sonGuncellemeTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anaRezervBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petrolSatisSistemiDataSet6 = new Petrol.PetrolSatisSistemiDataSet6();
            this.lblDurum = new System.Windows.Forms.Label();
            this.anaRezervTableAdapter = new Petrol.PetrolSatisSistemiDataSet6TableAdapters.AnaRezervTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnaRezerv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anaRezervBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolSatisSistemiDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRezervID
            // 
            this.txtRezervID.Location = new System.Drawing.Point(186, 83);
            this.txtRezervID.Name = "txtRezervID";
            this.txtRezervID.Size = new System.Drawing.Size(100, 22);
            this.txtRezervID.TabIndex = 0;
            // 
            // txtYakitTuru
            // 
            this.txtYakitTuru.Location = new System.Drawing.Point(186, 172);
            this.txtYakitTuru.Name = "txtYakitTuru";
            this.txtYakitTuru.Size = new System.Drawing.Size(100, 22);
            this.txtYakitTuru.TabIndex = 1;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(186, 212);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(100, 22);
            this.txtMiktar.TabIndex = 2;
            // 
            // txtMinimumSeviye
            // 
            this.txtMinimumSeviye.Location = new System.Drawing.Point(186, 252);
            this.txtMinimumSeviye.Name = "txtMinimumSeviye";
            this.txtMinimumSeviye.Size = new System.Drawing.Size(100, 22);
            this.txtMinimumSeviye.TabIndex = 3;
            // 
            // txtSonGuncellemeTarihi
            // 
            this.txtSonGuncellemeTarihi.Location = new System.Drawing.Point(24, 12);
            this.txtSonGuncellemeTarihi.Name = "txtSonGuncellemeTarihi";
            this.txtSonGuncellemeTarihi.Size = new System.Drawing.Size(163, 22);
            this.txtSonGuncellemeTarihi.TabIndex = 4;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(313, 82);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 23);
            this.btnListele.TabIndex = 5;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(186, 295);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(100, 33);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnYeniYakitEkle
            // 
            this.btnYeniYakitEkle.Location = new System.Drawing.Point(105, 365);
            this.btnYeniYakitEkle.Name = "btnYeniYakitEkle";
            this.btnYeniYakitEkle.Size = new System.Drawing.Size(105, 23);
            this.btnYeniYakitEkle.TabIndex = 7;
            this.btnYeniYakitEkle.Text = "Yeni Yakıt Ekle";
            this.btnYeniYakitEkle.UseVisualStyleBackColor = true;
            this.btnYeniYakitEkle.Click += new System.EventHandler(this.btnYeniYakitEkle_Click);
            // 
            // dataGridViewAnaRezerv
            // 
            this.dataGridViewAnaRezerv.AutoGenerateColumns = false;
            this.dataGridViewAnaRezerv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnaRezerv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rezervIDDataGridViewTextBoxColumn,
            this.yakitTuruDataGridViewTextBoxColumn,
            this.miktarDataGridViewTextBoxColumn,
            this.minimumSeviyeDataGridViewTextBoxColumn,
            this.sonGuncellemeTarihiDataGridViewTextBoxColumn,
            this.durumDataGridViewTextBoxColumn});
            this.dataGridViewAnaRezerv.DataSource = this.anaRezervBindingSource;
            this.dataGridViewAnaRezerv.Location = new System.Drawing.Point(444, 83);
            this.dataGridViewAnaRezerv.Name = "dataGridViewAnaRezerv";
            this.dataGridViewAnaRezerv.RowHeadersWidth = 51;
            this.dataGridViewAnaRezerv.RowTemplate.Height = 24;
            this.dataGridViewAnaRezerv.Size = new System.Drawing.Size(721, 263);
            this.dataGridViewAnaRezerv.TabIndex = 9;
            // 
            // rezervIDDataGridViewTextBoxColumn
            // 
            this.rezervIDDataGridViewTextBoxColumn.DataPropertyName = "RezervID";
            this.rezervIDDataGridViewTextBoxColumn.HeaderText = "RezervID";
            this.rezervIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rezervIDDataGridViewTextBoxColumn.Name = "rezervIDDataGridViewTextBoxColumn";
            this.rezervIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.rezervIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // yakitTuruDataGridViewTextBoxColumn
            // 
            this.yakitTuruDataGridViewTextBoxColumn.DataPropertyName = "YakitTuru";
            this.yakitTuruDataGridViewTextBoxColumn.HeaderText = "YakitTuru";
            this.yakitTuruDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yakitTuruDataGridViewTextBoxColumn.Name = "yakitTuruDataGridViewTextBoxColumn";
            this.yakitTuruDataGridViewTextBoxColumn.Width = 125;
            // 
            // miktarDataGridViewTextBoxColumn
            // 
            this.miktarDataGridViewTextBoxColumn.DataPropertyName = "Miktar";
            this.miktarDataGridViewTextBoxColumn.HeaderText = "Miktar";
            this.miktarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.miktarDataGridViewTextBoxColumn.Name = "miktarDataGridViewTextBoxColumn";
            this.miktarDataGridViewTextBoxColumn.Width = 125;
            // 
            // minimumSeviyeDataGridViewTextBoxColumn
            // 
            this.minimumSeviyeDataGridViewTextBoxColumn.DataPropertyName = "MinimumSeviye";
            this.minimumSeviyeDataGridViewTextBoxColumn.HeaderText = "MinimumSeviye";
            this.minimumSeviyeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.minimumSeviyeDataGridViewTextBoxColumn.Name = "minimumSeviyeDataGridViewTextBoxColumn";
            this.minimumSeviyeDataGridViewTextBoxColumn.Width = 125;
            // 
            // sonGuncellemeTarihiDataGridViewTextBoxColumn
            // 
            this.sonGuncellemeTarihiDataGridViewTextBoxColumn.DataPropertyName = "SonGuncellemeTarihi";
            this.sonGuncellemeTarihiDataGridViewTextBoxColumn.HeaderText = "SonGuncellemeTarihi";
            this.sonGuncellemeTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sonGuncellemeTarihiDataGridViewTextBoxColumn.Name = "sonGuncellemeTarihiDataGridViewTextBoxColumn";
            this.sonGuncellemeTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // durumDataGridViewTextBoxColumn
            // 
            this.durumDataGridViewTextBoxColumn.DataPropertyName = "Durum";
            this.durumDataGridViewTextBoxColumn.HeaderText = "Durum";
            this.durumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.durumDataGridViewTextBoxColumn.Name = "durumDataGridViewTextBoxColumn";
            this.durumDataGridViewTextBoxColumn.Width = 125;
            // 
            // anaRezervBindingSource
            // 
            this.anaRezervBindingSource.DataMember = "AnaRezerv";
            this.anaRezervBindingSource.DataSource = this.petrolSatisSistemiDataSet6;
            // 
            // petrolSatisSistemiDataSet6
            // 
            this.petrolSatisSistemiDataSet6.DataSetName = "PetrolSatisSistemiDataSet6";
            this.petrolSatisSistemiDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(498, 12);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(44, 16);
            this.lblDurum.TabIndex = 10;
            this.lblDurum.Text = "label1";
            this.lblDurum.Click += new System.EventHandler(this.lblDurum_Click);
            // 
            // anaRezervTableAdapter
            // 
            this.anaRezervTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Yakıtı Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AnaDepoYonetimiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.dataGridViewAnaRezerv);
            this.Controls.Add(this.btnYeniYakitEkle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.txtSonGuncellemeTarihi);
            this.Controls.Add(this.txtMinimumSeviye);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.txtYakitTuru);
            this.Controls.Add(this.txtRezervID);
            this.Name = "AnaDepoYonetimiForm";
            this.Text = "AnaDepoYonetimiForm";
            this.Load += new System.EventHandler(this.AnaDepoYonetimiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnaRezerv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anaRezervBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolSatisSistemiDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRezervID;
        private System.Windows.Forms.TextBox txtYakitTuru;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.TextBox txtMinimumSeviye;
        private System.Windows.Forms.TextBox txtSonGuncellemeTarihi;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnYeniYakitEkle;
        private System.Windows.Forms.DataGridView dataGridViewAnaRezerv;
        private System.Windows.Forms.Label lblDurum;
        private PetrolSatisSistemiDataSet6 petrolSatisSistemiDataSet6;
        private System.Windows.Forms.BindingSource anaRezervBindingSource;
        private PetrolSatisSistemiDataSet6TableAdapters.AnaRezervTableAdapter anaRezervTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezervIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yakitTuruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minimumSeviyeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sonGuncellemeTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durumDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}