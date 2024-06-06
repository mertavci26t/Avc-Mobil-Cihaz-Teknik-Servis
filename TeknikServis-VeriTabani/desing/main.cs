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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
         
        }

        private void musekle_Click(object sender, EventArgs e)
        {
            musteriekle Musteriekle = new musteriekle()
            {
                //kontrol et
                musteri = new musteri() { ID = Guid.NewGuid() },

            };
            var sonuc = Musteriekle.ShowDialog();   

            if(sonuc == DialogResult.OK)
            {
               bool i= Logic.musekle(Musteriekle.musteri);
            

                if(i) {

                   DataSet mg= Logic.musterigor("");
                    dataGridView3.DataSource = mg.Tables[0];
                }
            }
            

        }


        private void musara_Click(object sender, EventArgs e)
        {
            DataSet mg = Logic.musterigor(toolStripTextBox3.Text);
            dataGridView3.DataSource = mg.Tables[0];

        }

        private void musduz_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = dataGridView3.SelectedRows[0];

            musteriekle Musteriekle = new musteriekle()
            {
                gnc = true,
                //kontrol et
                musteri = new musteri() { 
                
                    ID= Guid.Parse(row.Cells[0].Value.ToString()),
                    mus_ad = row.Cells[1].Value.ToString(),
                    mus_soyad = row.Cells[2].Value.ToString(),
                    mus_tel =row.Cells[3].Value.ToString(),
                    mus_mail = row.Cells[4].Value.ToString(),
                    mus_adres = row.Cells[5].Value.ToString(),


                },



        };
            var sonuc = Musteriekle.ShowDialog();

            if (sonuc == DialogResult.OK)
            {
                bool i = Logic.musguncelle(Musteriekle.musteri);


                if (i)
                {

                    DataSet mg = Logic.musterigor("");
                    dataGridView3.DataSource = mg.Tables[0];
                }
            }

            DataSet mg1 = Logic.musterigor("");
            dataGridView3.DataSource = mg1.Tables[0];

        }

        private void mussil_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = dataGridView3.SelectedRows[0];

            var ID = row.Cells[0].Value.ToString();
            var karar = MessageBox.Show("Silmek iştediğine EMİN MİSİN ?","Silmek", MessageBoxButtons.OKCancel);
            if (karar == DialogResult.OK) {

                bool a = Logic.musterisil(ID);
            
            }

            DataSet mg = Logic.musterigor("");
            dataGridView3.DataSource = mg.Tables[0];

        }

        ////calisanlar

        private void calduz_Click(object sender, EventArgs e)
        {
            DataGridViewRow row1 = dataGridView4.SelectedRows[0];

            calekle calekle = new calekle()
            {
                gnc = true,
                //kontrol et
                calisanlar = new calisanlar()
                {

                    ID = Guid.Parse(row1.Cells[0].Value.ToString()),
                    cal_ad = row1.Cells[1].Value.ToString(),
                    cal_soyad = row1.Cells[2].Value.ToString(),
                    cal_tel = row1.Cells[3].Value.ToString(),
                    cal_mail = row1.Cells[4].Value.ToString(),
                    cal_adres = row1.Cells[5].Value.ToString(),


                },


            };
            var sonuc = calekle.ShowDialog();

            if (sonuc == DialogResult.OK)
            {
                bool i = Logic.calguncelle(calekle.calisanlar);


                if (i)
                {

                    DataSet mg = Logic.calgor("");
                    dataGridView4.DataSource = mg.Tables[0];
                }
            }
            DataSet mg1 = Logic.calgor("");
            dataGridView4.DataSource = mg1.Tables[0];
        }

        private void calekle_Click(object sender, EventArgs e)
        {
            calekle calekle = new calekle()
            {
                //kontrol et
                calisanlar = new calisanlar() { ID = Guid.NewGuid() },

            };
            var sonuc = calekle.ShowDialog();

            if (sonuc == DialogResult.OK)
            {
                bool i = Logic.calekle(calekle.calisanlar);


                if (i)
                {

                    DataSet mg = Logic.calgor("");
                    dataGridView4.DataSource = mg.Tables[0];
                }
            }
            DataSet mg2 = Logic.calgor("");
            dataGridView4.DataSource = mg2.Tables[0];
        }

        private void calsil_Click(object sender, EventArgs e)
        {

            DataGridViewRow row1 = dataGridView4.SelectedRows[0];

            var ID = row1.Cells[0].Value.ToString();
            var karar = MessageBox.Show("Silmek iştediğine EMİN MİSİN ?", "Silmek", MessageBoxButtons.OKCancel);
            if (karar == DialogResult.OK)
            {

                bool a = Logic.calsil(ID);

            }

            DataSet mg = Logic.calgor("");
            dataGridView4.DataSource = mg.Tables[0];

        }

        private void calara_Click(object sender, EventArgs e)
        {
            DataSet mg = Logic.calgor(toolStripTextBox4.Text);
            dataGridView4.DataSource = mg.Tables[0];
        }

        private void TaliEkle_Click(object sender, EventArgs e)
        {
            Tamirislem tamirislem = new Tamirislem()
            {
                tamirislem = new tamirislem()
                {
                    ID = Guid.NewGuid()
                }

            };

            if (tamirislem.ShowDialog() == DialogResult.OK)
            {

                  bool i = Logic.tiekle(tamirislem.tamirislem);
            }


            DataSet tg = Logic.talepislemgor("");
            dataGridView1.DataSource = tg.Tables[0];

        }
        
        private void tolekle_Click(object sender, EventArgs e)
        {
            
            Tamirtalep tamirs = new Tamirtalep()
            {
                tamirtalep = new tamirtalep()
                {
                    ID = Guid.NewGuid()
                }

            };


            if(tamirs.ShowDialog() == DialogResult.OK)
            {
                bool i = Logic.ttalepekle(tamirs.tamirtalep);
            }
            DataSet tg = Logic.taleplerigor("");
            dataGridView2.DataSource = tg.Tables[0];
        }

        private void tolsil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];

            var ID = row.Cells[0].Value.ToString();
            var karar = MessageBox.Show("Silmek iştediğine EMİN MİSİN ?", "Silmek", MessageBoxButtons.OKCancel);
            if (karar == DialogResult.OK)
            {

                bool a = Logic.tamirtalepsil(ID);

            }

            DataSet tg = Logic.taleplerigor("");
            dataGridView2.DataSource = tg.Tables[0];
        }


        //private
        private void tolara_Click(object sender, EventArgs e)
        {
            DataSet tg1 = Logic.taleplerigor(toolStripTextBox2.Text);
            dataGridView2.DataSource = tg1.Tables[0];
            veritopla();


        }

        private void TaliSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            var ID = row.Cells[0].Value.ToString();
            var karar = MessageBox.Show("Silmek iştediğine EMİN MİSİN ?", "Silmek", MessageBoxButtons.OKCancel);
            if (karar == DialogResult.OK)
            {

                bool a = Logic.talisil(ID);

            }

            DataSet tg = Logic.talepislemgor("");
            dataGridView1.DataSource = tg.Tables[0];
        }

        //private
        public void TaliAra_Click(object sender, EventArgs e)
        {
            DataSet tg = Logic.talepislemgor(toolStripTextBox1.Text);
            dataGridView1.DataSource = tg.Tables[0];
            veritopla();
            veritopla2();


        }


        public void veritopla()
         {
            string[] values = new string[dataGridView1.Rows.Count];


             for (int i = 0; i < dataGridView1.Rows.Count; i++)
             {
                 DataGridViewRow row = dataGridView1.Rows[i];
                 if (row.Cells[1].Value != null)
                 {
                     values[i] = row.Cells[1].Value.ToString();
                 }
             }
       

        
            for (int j = 0; j < dataGridView2.Rows.Count; j++)
            {
                DataGridViewRow row1 = dataGridView2.Rows[j];
                foreach (string value in values)
                {
                    if (row1.Cells[0].Value != null && row1.Cells[0].Value.ToString() == value)
                    {
                        row1.DefaultCellStyle.BackColor = Color.LightBlue;
                        break;
                    }
                    else {

                        row1.DefaultCellStyle.BackColor = Color.LightPink;
                    }
                }
            }
        }

        public void veritopla2()
        {
            string[] values = new string[dataGridView1.Rows.Count];


            for (int i = 0; i < dataGridView5.Rows.Count; i++)
            {
                DataGridViewRow row = dataGridView5.Rows[i];
                if (row.Cells[6].Value != null)
                {
                    values[i] = row.Cells[6].Value.ToString();
                }
            }



            for (int j = 0; j < dataGridView1.Rows.Count; j++)
            {
                DataGridViewRow row1 = dataGridView1.Rows[j];
                foreach (string value in values)
                {
                    if (row1.Cells[0].Value != null && row1.Cells[0].Value.ToString() == value)
                    {
                        row1.DefaultCellStyle.BackColor = Color.LightBlue;
                        break;
                    }
                    else
                    {

                        row1.DefaultCellStyle.BackColor = Color.LightPink;
                    }
                }
            }
        }

        private void main_Load(object sender, EventArgs e)
        {
            DataSet tg = Logic.talepislemgor(toolStripTextBox1.Text);
            dataGridView1.DataSource = tg.Tables[0];
            veritopla();
            DataSet tg2 = Logic.teslimetlerigor(toolStripTextBox5.Text);
            dataGridView5.DataSource = tg2.Tables[0];
            veritopla2();


        }

        private void teslimet_Click(object sender, EventArgs e)
        {
            teslimet teslimets = new teslimet()
            {
                teslimet1 = new teslimet1()
                {
                    ID = Guid.NewGuid()
                }

            };
            if (teslimets.ShowDialog() == DialogResult.OK)
            {
                bool i = Logic.teslimetlg(teslimets.teslimet1);
            }
       
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            DataSet tg2 = Logic.teslimetlerigor(toolStripTextBox5.Text);
            dataGridView5.DataSource = tg2.Tables[0];
        }
    }
}
