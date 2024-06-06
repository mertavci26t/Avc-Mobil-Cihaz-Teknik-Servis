namespace TeknikServis_VeriTabani
{
    partial class markaekle
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
            this.mar_ad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mar_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Mariptal = new System.Windows.Forms.Button();
            this.MarEkle = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // mar_ad
            // 
            this.mar_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mar_ad.Location = new System.Drawing.Point(89, 65);
            this.mar_ad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mar_ad.Name = "mar_ad";
            this.mar_ad.Size = new System.Drawing.Size(166, 30);
            this.mar_ad.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(22, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marka";
            // 
            // mar_id
            // 
            this.mar_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mar_id.Location = new System.Drawing.Point(89, 31);
            this.mar_id.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mar_id.Name = "mar_id";
            this.mar_id.ReadOnly = true;
            this.mar_id.Size = new System.Drawing.Size(166, 30);
            this.mar_id.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(57, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // Mariptal
            // 
            this.Mariptal.Location = new System.Drawing.Point(169, 140);
            this.Mariptal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Mariptal.Name = "Mariptal";
            this.Mariptal.Size = new System.Drawing.Size(86, 40);
            this.Mariptal.TabIndex = 10;
            this.Mariptal.Text = "İptal";
            this.Mariptal.UseVisualStyleBackColor = true;
            this.Mariptal.Click += new System.EventHandler(this.Mariptal_Click);
            // 
            // MarEkle
            // 
            this.MarEkle.Location = new System.Drawing.Point(52, 140);
            this.MarEkle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MarEkle.Name = "MarEkle";
            this.MarEkle.Size = new System.Drawing.Size(76, 40);
            this.MarEkle.TabIndex = 9;
            this.MarEkle.Text = "Ekle";
            this.MarEkle.UseVisualStyleBackColor = true;
            this.MarEkle.Click += new System.EventHandler(this.MarEkle_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // markaekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(308, 241);
            this.Controls.Add(this.Mariptal);
            this.Controls.Add(this.MarEkle);
            this.Controls.Add(this.mar_ad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mar_id);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "markaekle";
            this.Text = "markaekle";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mar_ad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mar_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Mariptal;
        private System.Windows.Forms.Button MarEkle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}