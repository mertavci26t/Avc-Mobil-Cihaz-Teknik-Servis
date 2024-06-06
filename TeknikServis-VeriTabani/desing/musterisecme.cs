using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis_VeriTabani.desing
{
    public partial class musterisecme : Form
    {
        public musterisecme()
        {
            InitializeComponent();
        }

        public musteri musteri { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            

                musteri = new musteri()
                {

                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    mus_ad = row.Cells[1].Value.ToString(),
                    mus_soyad = row.Cells[2].Value.ToString(),
                    mus_tel = row.Cells[3].Value.ToString(),
                    mus_mail = row.Cells[4].Value.ToString(),
                    mus_adres = row.Cells[5].Value.ToString(),
                };

                DialogResult = DialogResult.OK;

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
          //  DataGridViewRow row = dataGridView1.SelectedRows[0];
            DataSet mg = Logic.musterigor("");
            dataGridView1.DataSource = mg.Tables[0];

            
        }

        private void musterisecme_Load(object sender, EventArgs e)
        {
            DataSet mg = Logic.musterigor("");
            dataGridView1.DataSource = mg.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
