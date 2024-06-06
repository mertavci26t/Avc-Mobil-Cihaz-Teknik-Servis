namespace TeknikServis_VeriTabani.desing
{
    partial class teslimet
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
            this.teslim_fiyat = new System.Windows.Forms.NumericUpDown();
            this.teslim_tarih = new System.Windows.Forms.DateTimePicker();
            this.ti_iptal = new System.Windows.Forms.Button();
            this.teslimet_ekle = new System.Windows.Forms.Button();
            this.teslim_acıklama = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ti_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.teslim_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ti_musid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tamirislemgetir = new System.Windows.Forms.Button();
            this.musterigetir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.teslim_fiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // teslim_fiyat
            // 
            this.teslim_fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teslim_fiyat.Location = new System.Drawing.Point(160, 183);
            this.teslim_fiyat.Maximum = new decimal(new int[] {
            64000,
            0,
            0,
            0});
            this.teslim_fiyat.Name = "teslim_fiyat";
            this.teslim_fiyat.Size = new System.Drawing.Size(220, 28);
            this.teslim_fiyat.TabIndex = 54;
            // 
            // teslim_tarih
            // 
            this.teslim_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teslim_tarih.Location = new System.Drawing.Point(160, 224);
            this.teslim_tarih.Name = "teslim_tarih";
            this.teslim_tarih.Size = new System.Drawing.Size(220, 27);
            this.teslim_tarih.TabIndex = 53;
            // 
            // ti_iptal
            // 
            this.ti_iptal.Location = new System.Drawing.Point(295, 474);
            this.ti_iptal.Name = "ti_iptal";
            this.ti_iptal.Size = new System.Drawing.Size(114, 49);
            this.ti_iptal.TabIndex = 52;
            this.ti_iptal.Text = "İptal";
            this.ti_iptal.UseVisualStyleBackColor = true;
            this.ti_iptal.Click += new System.EventHandler(this.ti_iptal_Click);
            // 
            // teslimet_ekle
            // 
            this.teslimet_ekle.Location = new System.Drawing.Point(160, 474);
            this.teslimet_ekle.Name = "teslimet_ekle";
            this.teslimet_ekle.Size = new System.Drawing.Size(102, 49);
            this.teslimet_ekle.TabIndex = 51;
            this.teslimet_ekle.Text = "Ekle";
            this.teslimet_ekle.UseVisualStyleBackColor = true;
            this.teslimet_ekle.Click += new System.EventHandler(this.teslimet_ekle_Click);
            // 
            // teslim_acıklama
            // 
            this.teslim_acıklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teslim_acıklama.Location = new System.Drawing.Point(54, 340);
            this.teslim_acıklama.Multiline = true;
            this.teslim_acıklama.Name = "teslim_acıklama";
            this.teslim_acıklama.Size = new System.Drawing.Size(471, 114);
            this.teslim_acıklama.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(49, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 29);
            this.label7.TabIndex = 43;
            this.label7.Text = "Yapılmış İşlem";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(84, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 29);
            this.label6.TabIndex = 44;
            this.label6.Text = "Tarih";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(3, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 29);
            this.label5.TabIndex = 45;
            this.label5.Text = "Alınan Ücret";
            // 
            // ti_id
            // 
            this.ti_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ti_id.Location = new System.Drawing.Point(160, 55);
            this.ti_id.Name = "ti_id";
            this.ti_id.Size = new System.Drawing.Size(220, 36);
            this.ti_id.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(49, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 29);
            this.label2.TabIndex = 46;
            this.label2.Text = "İşlem ID";
            // 
            // teslim_id
            // 
            this.teslim_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teslim_id.Location = new System.Drawing.Point(160, 12);
            this.teslim_id.Name = "teslim_id";
            this.teslim_id.ReadOnly = true;
            this.teslim_id.Size = new System.Drawing.Size(220, 36);
            this.teslim_id.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(117, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 29);
            this.label1.TabIndex = 48;
            this.label1.Text = "ID";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı"});
            this.comboBox1.Location = new System.Drawing.Point(160, 257);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(220, 30);
            this.comboBox1.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(-5, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 29);
            this.label3.TabIndex = 57;
            this.label3.Text = "Ödeme Sekli";
            // 
            // ti_musid
            // 
            this.ti_musid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ti_musid.Location = new System.Drawing.Point(160, 136);
            this.ti_musid.Name = "ti_musid";
            this.ti_musid.Size = new System.Drawing.Size(220, 36);
            this.ti_musid.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(155, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 29);
            this.label4.TabIndex = 58;
            this.label4.Text = "Teslim Alan MusterID";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // tamirislemgetir
            // 
            this.tamirislemgetir.Image = global::TeknikServis_VeriTabani.Properties.Resources.icons8_find_32;
            this.tamirislemgetir.Location = new System.Drawing.Point(382, 55);
            this.tamirislemgetir.Name = "tamirislemgetir";
            this.tamirislemgetir.Size = new System.Drawing.Size(43, 36);
            this.tamirislemgetir.TabIndex = 55;
            this.tamirislemgetir.UseVisualStyleBackColor = true;
            this.tamirislemgetir.Click += new System.EventHandler(this.tamirislemgetir_Click);
            // 
            // musterigetir
            // 
            this.musterigetir.Image = global::TeknikServis_VeriTabani.Properties.Resources.icons8_find_32;
            this.musterigetir.Location = new System.Drawing.Point(382, 136);
            this.musterigetir.Name = "musterigetir";
            this.musterigetir.Size = new System.Drawing.Size(43, 36);
            this.musterigetir.TabIndex = 60;
            this.musterigetir.UseVisualStyleBackColor = true;
            this.musterigetir.Click += new System.EventHandler(this.musterigetir_Click);
            // 
            // teslimet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 547);
            this.Controls.Add(this.musterigetir);
            this.Controls.Add(this.ti_musid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tamirislemgetir);
            this.Controls.Add(this.teslim_fiyat);
            this.Controls.Add(this.teslim_tarih);
            this.Controls.Add(this.ti_iptal);
            this.Controls.Add(this.teslimet_ekle);
            this.Controls.Add(this.teslim_acıklama);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ti_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.teslim_id);
            this.Controls.Add(this.label1);
            this.Name = "teslimet";
            this.Text = "teslimet";
            this.Load += new System.EventHandler(this.teslimet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teslim_fiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tamirislemgetir;
        private System.Windows.Forms.NumericUpDown teslim_fiyat;
        private System.Windows.Forms.DateTimePicker teslim_tarih;
        private System.Windows.Forms.Button ti_iptal;
        private System.Windows.Forms.Button teslimet_ekle;
        private System.Windows.Forms.TextBox teslim_acıklama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ti_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox teslim_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ti_musid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button musterigetir;
    }
}