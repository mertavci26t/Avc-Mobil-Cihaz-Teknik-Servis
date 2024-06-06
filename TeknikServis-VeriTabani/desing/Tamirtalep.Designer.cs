namespace TeknikServis_VeriTabani
{
    partial class Tamirtalep
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
            this.Tiptal = new System.Windows.Forms.Button();
            this.Tekle = new System.Windows.Forms.Button();
            this.t_acıklama = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.t_mus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.t_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.t_model = new System.Windows.Forms.TextBox();
            this.t_tarih = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tiptal
            // 
            this.Tiptal.Location = new System.Drawing.Point(445, 375);
            this.Tiptal.Name = "Tiptal";
            this.Tiptal.Size = new System.Drawing.Size(114, 49);
            this.Tiptal.TabIndex = 24;
            this.Tiptal.Text = "İptal";
            this.Tiptal.UseVisualStyleBackColor = true;
            this.Tiptal.Click += new System.EventHandler(this.Tiptal_Click);
            // 
            // Tekle
            // 
            this.Tekle.Location = new System.Drawing.Point(186, 375);
            this.Tekle.Name = "Tekle";
            this.Tekle.Size = new System.Drawing.Size(102, 49);
            this.Tekle.TabIndex = 23;
            this.Tekle.Text = "Ekle";
            this.Tekle.UseVisualStyleBackColor = true;
            this.Tekle.Click += new System.EventHandler(this.Tekle_Click);
            // 
            // t_acıklama
            // 
            this.t_acıklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.t_acıklama.Location = new System.Drawing.Point(186, 235);
            this.t_acıklama.Multiline = true;
            this.t_acıklama.Name = "t_acıklama";
            this.t_acıklama.Size = new System.Drawing.Size(373, 114);
            this.t_acıklama.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(181, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = "Açıklama";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(181, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tarih";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(169, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Model";
            // 
            // t_mus
            // 
            this.t_mus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.t_mus.Location = new System.Drawing.Point(256, 68);
            this.t_mus.Name = "t_mus";
            this.t_mus.Size = new System.Drawing.Size(220, 36);
            this.t_mus.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(123, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Müşteri ID";
            // 
            // t_id
            // 
            this.t_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.t_id.Location = new System.Drawing.Point(256, 26);
            this.t_id.Name = "t_id";
            this.t_id.ReadOnly = true;
            this.t_id.Size = new System.Drawing.Size(220, 36);
            this.t_id.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(213, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "ID";
            // 
            // t_model
            // 
            this.t_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.t_model.Location = new System.Drawing.Point(257, 111);
            this.t_model.Name = "t_model";
            this.t_model.Size = new System.Drawing.Size(220, 36);
            this.t_model.TabIndex = 25;
            // 
            // t_tarih
            // 
            this.t_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.t_tarih.Location = new System.Drawing.Point(257, 156);
            this.t_tarih.Name = "t_tarih";
            this.t_tarih.Size = new System.Drawing.Size(220, 27);
            this.t_tarih.TabIndex = 26;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Image = global::TeknikServis_VeriTabani.Properties.Resources.icons8_find_user_female_48;
            this.button1.Location = new System.Drawing.Point(493, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 45);
            this.button1.TabIndex = 27;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tamirtalep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 647);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t_tarih);
            this.Controls.Add(this.t_model);
            this.Controls.Add(this.Tiptal);
            this.Controls.Add(this.Tekle);
            this.Controls.Add(this.t_acıklama);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.t_mus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t_id);
            this.Controls.Add(this.label1);
            this.Name = "Tamirtalep";
            this.Text = "Tamir";
            this.Load += new System.EventHandler(this.Tamirtalep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Tiptal;
        private System.Windows.Forms.Button Tekle;
        private System.Windows.Forms.TextBox t_acıklama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox t_mus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_model;
        private System.Windows.Forms.DateTimePicker t_tarih;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
    }
}