using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis_VeriTabani.desing
{
    public partial class talepsecme : Form
    {
        public  tamirtalep tamirtalep {  get; set; }  
        musteri musteri { get; set; }   
        public talepsecme()
        {
            InitializeComponent();
        }

        private void tamam_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            tamirtalep = new tamirtalep()
            {
                
            ID = Guid.Parse(row.Cells[0].Value.ToString()),
            musteriID = Guid.Parse(row.Cells[1].Value.ToString()),
            tm_model = row.Cells[2].Value.ToString(),
            tm_tarih = DateTime.Parse(row.Cells[3].Value.ToString()),
            tm_islem = row.Cells[4].Value.ToString(),
               
            };

            DialogResult = DialogResult.OK;

        }

        private void talepsecme_Load(object sender, EventArgs e)
        {
            DataSet mg = Logic.taleplerigor("");
            dataGridView1.DataSource = mg.Tables[0];
        }

        private void taleplerigetir_Click(object sender, EventArgs e)
        {
            DataSet mg = Logic.taleplerigor("");
            dataGridView1.DataSource = mg.Tables[0];
        }
    }
}
