using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ryTermoMetreMulti
{
    public partial class anaForm : Form
    {
        public anaForm()
        {
            InitializeComponent();
        }

        #region Değişkenler ve Tanımlamalar

        #endregion

        #region Kullanıcı Tanımlı Olaylar

        #endregion

        #region Nesne Tanımlı Olaylar

        private void chbOnay_CheckedChanged(object sender, EventArgs e)
        {
            btnTermo.Enabled = chbOnay.Checked;
            btnKapat.Enabled = !chbOnay.Checked;
        }

        private void anaForm_Load(object sender, EventArgs e)
        {
            btnTermo.Enabled = false;
        }

        private void btnTermo_Click(object sender, EventArgs e)
        {
            termoForm yeniFrm = new termoForm();
            yeniFrm.Show();
            chbOnay.Checked = false;
            btnKapat.Enabled = !chbOnay.Checked;
            btnTermo.Enabled = chbOnay.Checked;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Uygulama \n Sonlandırılsın mı?", "Çıkış Onayı",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Application.Exit();
        }
        #endregion
    }
}
