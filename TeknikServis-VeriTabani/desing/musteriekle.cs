using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis_VeriTabani
{



    public partial class musteriekle : Form
    {
        public musteri musteri {  get; set; }
        public bool gnc { get; set; } = false;
        public musteriekle()
        {
            InitializeComponent();
        }



        private void MEkle_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(m_ad)) return;
            if (!ErrorControl(m_soyad)) return;
            if (!ErrorControl(m_adres)) return;
            if (!ErrorControl(m_tel)) return;

            musteri.mus_ad = m_ad.Text;
            musteri.mus_soyad = m_soyad.Text;
            musteri.mus_tel = m_tel.Text;
            musteri.mus_mail = m_mail.Text;
            musteri.mus_adres = m_adres.Text;   
            DialogResult = DialogResult.OK; 
        }

        private void Miptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }



        private bool ErrorControl(Control a) {

            if (a is TextBox) {

                if (a.Text == "")
                {

                    errorProvider1.SetError(a, "Boş Bırakılamaz");
                    a.Focus();
                    return false;

                }

                else {
                    errorProvider1.SetError(a, "");
                    return true;
                
                }
           
                }

            if (a is  MaskedTextBox)
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

        private void musteriekle_Load(object sender, EventArgs e)
        {

            m_id.Text = musteri.ID.ToString();
            if (gnc)
            {



                m_ad.Text = musteri.mus_ad;
                m_soyad.Text = musteri.mus_soyad;
                m_tel.Text = musteri.mus_tel;
                m_mail.Text = musteri.mus_mail;
                m_adres.Text = musteri.mus_adres;

                /* musteri.mus_ad = m_ad.Text;
                 musteri.mus_soyad = m_soyad.Text;
                 musteri.mus_tel = m_tel.Text;
                 musteri.mus_mail = m_mail.Text;
                 musteri.mus_adres = m_adres.Text;*/
            }
            else {


            }
        }
    }
}
