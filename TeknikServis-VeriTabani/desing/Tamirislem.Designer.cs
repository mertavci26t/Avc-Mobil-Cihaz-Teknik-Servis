namespace TeknikServis_VeriTabani
{
    partial class Tamirislem
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
            this.tmi_tarih = new System.Windows.Forms.DateTimePicker();
            this.ti_iptal = new System.Windows.Forms.Button();
            this.ti_ekle = new System.Windows.Forms.Button();
            this.tmi_acıklama = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tp_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ti_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tmi_fiyat = new System.Windows.Forms.NumericUpDown();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.talepgetir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tmi_fiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tmi_tarih
            // 
            this.tmi_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tmi_tarih.Location = new System.Drawing.Point(319, 130);
            this.tmi_tarih.Name = "tmi_tarih";
            this.tmi_tarih.Size = new System.Drawing.Size(220, 27);
            this.tmi_tarih.TabIndex = 40;
            // 
            // ti_iptal
            // 
            this.ti_iptal.Location = new System.Drawing.Point(507, 335);
            this.ti_iptal.Name = "ti_iptal";
            this.ti_iptal.Size = new System.Drawing.Size(114, 49);
            this.ti_iptal.TabIndex = 38;
            this.ti_iptal.Text = "İptal";
            this.ti_iptal.UseVisualStyleBackColor = true;
            this.ti_iptal.Click += new System.EventHandler(this.ti_iptal_Click);
            // 
            // ti_ekle
            // 
            this.ti_ekle.Location = new System.Drawing.Point(248, 335);
            this.ti_ekle.Name = "ti_ekle";
            this.ti_ekle.Size = new System.Drawing.Size(102, 49);
            this.ti_ekle.TabIndex = 37;
            this.ti_ekle.Text = "Ekle";
            this.ti_ekle.UseVisualStyleBackColor = true;
            this.ti_ekle.Click += new System.EventHandler(this.ti_ekle_Click);
            // 
            // tmi_acıklama
            // 
            this.tmi_acıklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tmi_acıklama.Location = new System.Drawing.Point(248, 202);
            this.tmi_acıklama.Multiline = true;
            this.tmi_acıklama.Name = "tmi_acıklama";
            this.tmi_acıklama.Size = new System.Drawing.Size(373, 114);
            this.tmi_acıklama.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(243, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 29);
            this.label7.TabIndex = 27;
            this.label7.Text = "Yapılan İşlem";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(243, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 29);
            this.label6.TabIndex = 28;
            this.label6.Text = "Tarih";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(240, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 29);
            this.label5.TabIndex = 29;
            this.label5.Text = "Üçret";
            // 
            // tp_id
            // 
            this.tp_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tp_id.Location = new System.Drawing.Point(316, 47);
            this.tp_id.Name = "tp_id";
            this.tp_id.Size = new System.Drawing.Size(220, 36);
            this.tp_id.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(215, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 31;
            this.label2.Text = "TalepID";
            // 
            // ti_id
            // 
            this.ti_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ti_id.Location = new System.Drawing.Point(316, 5);
            this.ti_id.Name = "ti_id";
            this.ti_id.ReadOnly = true;
            this.ti_id.Size = new System.Drawing.Size(220, 36);
            this.ti_id.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(273, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "ID";
            // 
            // tmi_fiyat
            // 
            this.tmi_fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tmi_fiyat.Location = new System.Drawing.Point(319, 90);
            this.tmi_fiyat.Maximum = new decimal(new int[] {
            64000,
            0,
            0,
            0});
            this.tmi_fiyat.Name = "tmi_fiyat";
            this.tmi_fiyat.Size = new System.Drawing.Size(220, 28);
            this.tmi_fiyat.TabIndex = 41;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // talepgetir
            // 
            this.talepgetir.Image = global::TeknikServis_VeriTabani.Properties.Resources.icons8_find_32;
            this.talepgetir.Location = new System.Drawing.Point(542, 47);
            this.talepgetir.Name = "talepgetir";
            this.talepgetir.Size = new System.Drawing.Size(43, 36);
            this.talepgetir.TabIndex = 42;
            this.talepgetir.UseVisualStyleBackColor = true;
            this.talepgetir.Click += new System.EventHandler(this.talepgetir_Click);
            // 
            // Tamirislem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 490);
            this.Controls.Add(this.talepgetir);
            this.Controls.Add(this.tmi_fiyat);
            this.Controls.Add(this.tmi_tarih);
            this.Controls.Add(this.ti_iptal);
            this.Controls.Add(this.ti_ekle);
            this.Controls.Add(this.tmi_acıklama);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tp_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ti_id);
            this.Controls.Add(this.label1);
            this.Name = "Tamirislem";
            this.Text = "Tamirislem";
            this.Load += new System.EventHandler(this.Tamirislem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tmi_fiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker tmi_tarih;
        private System.Windows.Forms.Button ti_iptal;
        private System.Windows.Forms.Button ti_ekle;
        private System.Windows.Forms.TextBox tmi_acıklama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tp_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ti_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown tmi_fiyat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button talepgetir;
    }
}