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
using TeknikServis_VeriTabani.desing;

namespace TeknikServis_VeriTabani
{
    public partial class Tamirislem : Form
    {
        
        
        public tamirislem tamirislem {  get; set; } 
        public calisanlar calisanlar { get; set; }
        public tamirtalep tamirtalep { get; set; }




        public Tamirislem()
        {
            InitializeComponent();
        }

        private void ti_ekle_Click(object sender, EventArgs e)
        {

            if (!ErrorControl(tmi_acıklama)) return;
            if (!ErrorControl(tmi_fiyat)) return;
            tamirislem.tamirtalepID = tamirtalep.ID;
            tamirislem.tmi_fiyat = (double)tmi_fiyat.Value;
            tamirislem.tmi_tarih = tmi_tarih.Value;
            tamirislem.tmi_islem = tmi_acıklama.Text;


            DialogResult = DialogResult.OK;
        }

        private void ti_iptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Tamirislem_Load(object sender, EventArgs e)
        {
            ti_id.Text = tamirislem.ToString();
      
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

        private void talepgetir_Click(object sender, EventArgs e)
        {
            talepsecme frm = new talepsecme();
            if (frm.ShowDialog() == DialogResult.OK)
            {

                tamirtalep = frm.tamirtalep;
                tp_id.Text = tamirtalep.ID.ToString();

            }
        }

    }
}
