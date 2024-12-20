namespace Petrol
{
    partial class yakitTalepleriForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMiktar = new System.Windows.Forms.TextBox();
            this.dataGridViewTalepler = new System.Windows.Forms.DataGridView();
            this.talepidtxt = new System.Windows.Forms.TextBox();
            this.Gönderbutton = new System.Windows.Forms.Button();
            this.Reddetbutton = new System.Windows.Forms.Button();
            this.listelebuton = new System.Windows.Forms.Button();
            this.yakıttürütxt = new System.Windows.Forms.TextBox();
            this.şubetxt = new System.Windows.Forms.TextBox();
            this.tarihtxt = new System.Windows.Forms.TextBox();
            this.petrolSatisSistemiDataSet5 = new Petrol.PetrolSatisSistemiDataSet5();
            this.yakitTalepleriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yakitTalepleriTableAdapter = new Petrol.PetrolSatisSistemiDataSet5TableAdapters.YakitTalepleriTableAdapter();
            this.taleplerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yakitTuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TalepSilButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTalepler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolSatisSistemiDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakitTalepleriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yakıt Türü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Miktar ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tarih ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şube Seçin:";
            // 
            // textBoxMiktar
            // 
            this.textBoxMiktar.Location = new System.Drawing.Point(209, 190);
            this.textBoxMiktar.Name = "textBoxMiktar";
            this.textBoxMiktar.Size = new System.Drawing.Size(100, 22);
            this.textBoxMiktar.TabIndex = 5;
            // 
            // dataGridViewTalepler
            // 
            this.dataGridViewTalepler.AutoGenerateColumns = false;
            this.dataGridViewTalepler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTalepler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taleplerIDDataGridViewTextBoxColumn,
            this.subeIDDataGridViewTextBoxColumn,
            this.yakitTuruDataGridViewTextBoxColumn,
            this.miktarDataGridViewTextBoxColumn,
            this.durumDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn});
            this.dataGridViewTalepler.DataSource = this.yakitTalepleriBindingSource;
            this.dataGridViewTalepler.Location = new System.Drawing.Point(483, 62);
            this.dataGridViewTalepler.Name = "dataGridViewTalepler";
            this.dataGridViewTalepler.RowHeadersWidth = 51;
            this.dataGridViewTalepler.RowTemplate.Height = 24;
            this.dataGridViewTalepler.Size = new System.Drawing.Size(872, 231);
            this.dataGridViewTalepler.TabIndex = 7;
            // 
            // talepidtxt
            // 
            this.talepidtxt.Location = new System.Drawing.Point(209, 96);
            this.talepidtxt.Name = "talepidtxt";
            this.talepidtxt.Size = new System.Drawing.Size(100, 22);
            this.talepidtxt.TabIndex = 9;
            // 
            // Gönderbutton
            // 
            this.Gönderbutton.Location = new System.Drawing.Point(153, 360);
            this.Gönderbutton.Name = "Gönderbutton";
            this.Gönderbutton.Size = new System.Drawing.Size(75, 23);
            this.Gönderbutton.TabIndex = 10;
            this.Gönderbutton.Text = "Gönder";
            this.Gönderbutton.UseVisualStyleBackColor = true;
            this.Gönderbutton.Click += new System.EventHandler(this.Gönderbutton_Click);
            // 
            // Reddetbutton
            // 
            this.Reddetbutton.Location = new System.Drawing.Point(293, 360);
            this.Reddetbutton.Name = "Reddetbutton";
            this.Reddetbutton.Size = new System.Drawing.Size(75, 23);
            this.Reddetbutton.TabIndex = 11;
            this.Reddetbutton.Text = "Reddet";
            this.Reddetbutton.UseVisualStyleBackColor = true;
            this.Reddetbutton.Click += new System.EventHandler(this.Reddetbutton_Click);
            // 
            // listelebuton
            // 
            this.listelebuton.Location = new System.Drawing.Point(334, 96);
            this.listelebuton.Name = "listelebuton";
            this.listelebuton.Size = new System.Drawing.Size(75, 23);
            this.listelebuton.TabIndex = 12;
            this.listelebuton.Text = "Listele";
            this.listelebuton.UseVisualStyleBackColor = true;
            this.listelebuton.Click += new System.EventHandler(this.listelebuton_Click);
            // 
            // yakıttürütxt
            // 
            this.yakıttürütxt.Location = new System.Drawing.Point(209, 139);
            this.yakıttürütxt.Name = "yakıttürütxt";
            this.yakıttürütxt.Size = new System.Drawing.Size(100, 22);
            this.yakıttürütxt.TabIndex = 13;
            // 
            // şubetxt
            // 
            this.şubetxt.Location = new System.Drawing.Point(209, 297);
            this.şubetxt.Name = "şubetxt";
            this.şubetxt.Size = new System.Drawing.Size(100, 22);
            this.şubetxt.TabIndex = 14;
            // 
            // tarihtxt
            // 
            this.tarihtxt.Location = new System.Drawing.Point(209, 245);
            this.tarihtxt.Name = "tarihtxt";
            this.tarihtxt.Size = new System.Drawing.Size(100, 22);
            this.tarihtxt.TabIndex = 15;
            // 
            // petrolSatisSistemiDataSet5
            // 
            this.petrolSatisSistemiDataSet5.DataSetName = "PetrolSatisSistemiDataSet5";
            this.petrolSatisSistemiDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yakitTalepleriBindingSource
            // 
            this.yakitTalepleriBindingSource.DataMember = "YakitTalepleri";
            this.yakitTalepleriBindingSource.DataSource = this.petrolSatisSistemiDataSet5;
            // 
            // yakitTalepleriTableAdapter
            // 
            this.yakitTalepleriTableAdapter.ClearBeforeFill = true;
            // 
            // taleplerIDDataGridViewTextBoxColumn
            // 
            this.taleplerIDDataGridViewTextBoxColumn.DataPropertyName = "TaleplerID";
            this.taleplerIDDataGridViewTextBoxColumn.HeaderText = "TaleplerID";
            this.taleplerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.taleplerIDDataGridViewTextBoxColumn.Name = "taleplerIDDataGridViewTextBoxColumn";
            this.taleplerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.taleplerIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // subeIDDataGridViewTextBoxColumn
            // 
            this.subeIDDataGridViewTextBoxColumn.DataPropertyName = "SubeID";
            this.subeIDDataGridViewTextBoxColumn.HeaderText = "SubeID";
            this.subeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subeIDDataGridViewTextBoxColumn.Name = "subeIDDataGridViewTextBoxColumn";
            this.subeIDDataGridViewTextBoxColumn.Width = 125;
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
            // durumDataGridViewTextBoxColumn
            // 
            this.durumDataGridViewTextBoxColumn.DataPropertyName = "Durum";
            this.durumDataGridViewTextBoxColumn.HeaderText = "Durum";
            this.durumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.durumDataGridViewTextBoxColumn.Name = "durumDataGridViewTextBoxColumn";
            this.durumDataGridViewTextBoxColumn.Width = 125;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // TalepSilButton
            // 
            this.TalepSilButton.Location = new System.Drawing.Point(845, 300);
            this.TalepSilButton.Name = "TalepSilButton";
            this.TalepSilButton.Size = new System.Drawing.Size(183, 23);
            this.TalepSilButton.TabIndex = 16;
            this.TalepSilButton.Text = "Talebi Veri Tabanından Sil";
            this.TalepSilButton.UseVisualStyleBackColor = true;
            this.TalepSilButton.Click += new System.EventHandler(this.TalepSilButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "TaleplerID";
            // 
            // yakitTalepleriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 527);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TalepSilButton);
            this.Controls.Add(this.tarihtxt);
            this.Controls.Add(this.şubetxt);
            this.Controls.Add(this.yakıttürütxt);
            this.Controls.Add(this.listelebuton);
            this.Controls.Add(this.Reddetbutton);
            this.Controls.Add(this.Gönderbutton);
            this.Controls.Add(this.talepidtxt);
            this.Controls.Add(this.dataGridViewTalepler);
            this.Controls.Add(this.textBoxMiktar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "yakitTalepleriForm";
            this.Text = "yakitTalepleriForm";
            this.Load += new System.EventHandler(this.yakitTalepleriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTalepler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolSatisSistemiDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakitTalepleriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMiktar;
        private System.Windows.Forms.DataGridView dataGridViewTalepler;
        private System.Windows.Forms.TextBox talepidtxt;
        private System.Windows.Forms.Button Gönderbutton;
        private System.Windows.Forms.Button Reddetbutton;
        private System.Windows.Forms.Button listelebuton;
        private System.Windows.Forms.TextBox yakıttürütxt;
        private System.Windows.Forms.TextBox şubetxt;
        private System.Windows.Forms.TextBox tarihtxt;
        private PetrolSatisSistemiDataSet5 petrolSatisSistemiDataSet5;
        private System.Windows.Forms.BindingSource yakitTalepleriBindingSource;
        private PetrolSatisSistemiDataSet5TableAdapters.YakitTalepleriTableAdapter yakitTalepleriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn taleplerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yakitTuruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button TalepSilButton;
        private System.Windows.Forms.Label label5;
    }
}