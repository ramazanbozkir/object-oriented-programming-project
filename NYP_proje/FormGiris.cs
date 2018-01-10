using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NYP_proje
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        public bool KimlikNoKontrol(ulong tc)
        {
            bool sonuc = false;
            if (tc / Math.Pow(10, 10) <= 1 || tc / Math.Pow(10, 10) >=10 )
                MessageBox.Show("Hatalı kimlik numarası girdiniz..");
            else if(tc % 2 != 0)
                MessageBox.Show("Hatalı kimlik numarası girdiniz..");
            else
                sonuc = true;
            return sonuc;
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                KasaGorevlisi k = new KasaGorevlisi();
                k.KimlikNo = Convert.ToUInt64(txtKimlikNo.Text);
               
                if(KimlikNoKontrol(k.KimlikNo)==true)
                {
                    Terminal t = new Terminal(k.KimlikNo);
                    FrmGiris formgiris = new FrmGiris();
                    formgiris.Close();
                    this.Hide();
                    FrmTerminal formterminal = new FrmTerminal();
                    formterminal.Show();

                }
            }
            catch (Exception hatamesaji)
            {
                MessageBox.Show(hatamesaji.Message.ToString());
                throw;
            }
            
        }
    }
}
