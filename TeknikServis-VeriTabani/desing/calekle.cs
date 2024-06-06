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

namespace TeknikServis_VeriTabani
{
    public partial class calekle : Form
    {
        public bool gnc { get; set; } = false;
        public calisanlar calisanlar { get; set; }
        public calekle()
        {
            InitializeComponent();
        }

        private void CEkle_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(c_ad)) return;
            if (!ErrorControl(c_soyad)) return;
            if (!ErrorControl(c_adres)) return;
            if (!ErrorControl(c_tel)) return;

            calisanlar.cal_ad = c_ad.Text;
            calisanlar.cal_soyad = c_soyad.Text;
            calisanlar.cal_tel = c_tel.Text;
            calisanlar.cal_mail = c_mail.Text;  
            calisanlar.cal_adres = c_adres.Text;

            DialogResult = DialogResult.OK;
        }

        private void Ciptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
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

            if (a is MaskedTextBox)
            {

                if (!((MaskedTextBox)a).MaskFull)
                {

                    errorProvider1.SetError(a, "Hatalı Tel Bilgisi");
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

        private void calekle_Load(object sender, EventArgs e)
        {
            c_id.Text = calisanlar.ID.ToString();
   if (gnc)
   {



       c_ad.Text = calisanlar.cal_ad;
       c_soyad.Text = calisanlar.cal_soyad;
       c_tel.Text = calisanlar.cal_tel;
       c_mail.Text = calisanlar.cal_mail;
       c_adres.Text = calisanlar.cal_adres;

      
   }
   else
   {


   }
        }


    }
}
