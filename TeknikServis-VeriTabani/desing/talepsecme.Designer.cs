namespace TeknikServis_VeriTabani.desing
{
    partial class talepsecme
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
            this.taleplerigetir = new System.Windows.Forms.Button();
            this.tamam = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // taleplerigetir
            // 
            this.taleplerigetir.Location = new System.Drawing.Point(19, 378);
            this.taleplerigetir.Name = "taleplerigetir";
            this.taleplerigetir.Size = new System.Drawing.Size(134, 48);
            this.taleplerigetir.TabIndex = 5;
            this.taleplerigetir.Text = "Talepleri Getir";
            this.taleplerigetir.UseVisualStyleBackColor = true;
            this.taleplerigetir.Click += new System.EventHandler(this.taleplerigetir_Click);
            // 
            // tamam
            // 
            this.tamam.Location = new System.Drawing.Point(664, 378);
            this.tamam.Name = "tamam";
            this.tamam.Size = new System.Drawing.Size(117, 48);
            this.tamam.TabIndex = 4;
            this.tamam.Text = "Tamam";
            this.tamam.UseVisualStyleBackColor = true;
            this.tamam.Click += new System.EventHandler(this.tamam_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(762, 336);
            this.dataGridView1.TabIndex = 3;
            // 
            // talepsecme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 566);
            this.Controls.Add(this.taleplerigetir);
            this.Controls.Add(this.tamam);
            this.Controls.Add(this.dataGridView1);
            this.Name = "talepsecme";
            this.Text = "talepsecme";
            this.Load += new System.EventHandler(this.talepsecme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button taleplerigetir;
        private System.Windows.Forms.Button tamam;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}