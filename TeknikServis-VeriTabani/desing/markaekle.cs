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
    public partial class markaekle : Form
    {


        public marka marka { get; set; }
        public markaekle()
        {
            InitializeComponent();
        }

        private void MarEkle_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(mar_ad)) return;

            marka.mar_ismi = mar_ad.Text;

            DialogResult = DialogResult.OK;

        }

        private void Mariptal_Click(object sender, EventArgs e)
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
            return true;
        }

        }
    }
