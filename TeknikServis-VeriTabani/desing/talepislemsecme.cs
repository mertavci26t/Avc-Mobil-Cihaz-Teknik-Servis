using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis_VeriTabani.desing
{
    public partial class talepislemsecme : Form
    {
        public tamirislem tamirislem { get; set; }
        public talepislemsecme()
        {
            InitializeComponent();
        }

  

        private void talepislemsecme_Load(object sender, EventArgs e)
        {
            DataSet tg = Logic.talepislemgor("");
            dataGridView1.DataSource = tg.Tables[0];
        }

        private void tisgetir_Click(object sender, EventArgs e)
        {
            DataSet tg = Logic.talepislemgor("");
            dataGridView1.DataSource = tg.Tables[0];
        }

        private void tistamam_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            tamirislem = new tamirislem();


            tamirislem.ID = Guid.Parse(row.Cells[0].Value.ToString());
            tamirislem.tamirtalepID = Guid.Parse(row.Cells[1].Value.ToString());
            tamirislem.tmi_tarih = (DateTime)row.Cells[2].Value;
            tamirislem.tmi_islem = row.Cells[3].Value.ToString();
            tamirislem.tmi_fiyat =  (float) row.Cells[4].Value;
            
            DialogResult = DialogResult.OK;
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
