using Org.BouncyCastle.Utilities;
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
    public partial class teslimet : Form
    {

        public tamirislem tamirislem { get; set; }
        public tamirtalep tamirtalep { get; set; }
        public teslimet1 teslimet1 { get; set; }  
        public musteri musteri{ get; set; }


        public teslimet()
        {
            InitializeComponent();
        }

        private void teslimet_ekle_Click(object sender, EventArgs e)
        {
            teslimet1.tamirislemID = tamirislem.ID;
            teslimet1.musteriID = musteri.ID;
            teslimet1.teslimet_fiyat = (double)teslim_fiyat.Value;
            teslimet1.teslimet_tarih = teslim_tarih.Value;
            teslimet1.teslimet_odemeturu = comboBox1.Text.ToString();
            teslimet1.tmi_islem = teslim_acıklama.Text;
             

            DialogResult = DialogResult.OK;
        }

        private void ti_iptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void tamirislemgetir_Click(object sender, EventArgs e)
        {
                talepislemsecme frm1 = new talepislemsecme();

            if (frm1.ShowDialog() == DialogResult.OK) {


                tamirislem = frm1.tamirislem;

                ti_id.Text = frm1.tamirislem.ID.ToString();
                teslim_fiyat.Value = (decimal)frm1.tamirislem.tmi_fiyat;
                teslim_acıklama.Text = frm1.tamirislem.tmi_islem.ToString();
               // teslimet1.tamirtalepID = frm1.tamirislem.tamirtalepID;
            }
         
            }

        private void musterigetir_Click(object sender, EventArgs e)
        {
            musterisecme frm = new musterisecme();
            if (frm.ShowDialog() == DialogResult.OK)
            {

                musteri = frm.musteri;
                ti_musid.Text = musteri.ID.ToString();

            }
        }

        private void teslimet_Load(object sender, EventArgs e)
        {
            teslim_id.Text = teslimet1.ToString();
         
        }
    }
    }

