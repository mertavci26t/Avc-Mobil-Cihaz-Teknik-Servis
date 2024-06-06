using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeknikServis_VeriTabani.desing;

namespace TeknikServis_VeriTabani
{
    public partial class Tamirtalep : Form
    {
        public Tamirtalep()
        {
            InitializeComponent();
        }

        public musteri musteri { get; set; }
        public tamirtalep tamirtalep { get; set; }

        private void Tekle_Click(object sender, EventArgs e)
        {

            if (!ErrorControl(t_model)) return;
            if (!ErrorControl(t_acıklama)) return;


            //////////

            /////////
            ///
            tamirtalep.musteriID = musteri.ID;
            tamirtalep.tm_model = t_model.Text;
            tamirtalep.tm_tarih = t_tarih.Value;
            tamirtalep.tm_islem = t_acıklama.Text;
            



            DialogResult = DialogResult.OK;

       
        }

            private void Tiptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void Tamirtalep_Load(object sender, EventArgs e)
        {
            t_id.Text = tamirtalep.ID.ToString();
        }
        private bool ErrorControl(Control a)
        {

            if (a is TextBox)
            {

                if (a.Text == "")
                {

                    errorProvider1.SetError(a, "Boş Bırakılamaz");
                    a.Focus();
                    return false;

                }

                else
                {
                    errorProvider1.SetError(a, "");
                    return true;

                }

            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            musterisecme frm = new musterisecme();
            if (frm.ShowDialog() == DialogResult.OK) {

                musteri = frm.musteri;
                t_mus.Text = musteri.ID.ToString(); 
            
            }
        }
    }
}
