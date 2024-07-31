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
    public partial class termoForm : Form
    {
        public termoForm()
        {
            InitializeComponent();
        }

        #region Değişkenler ve Tanımlamalar

        #endregion

        #region Kullanıcı Tanımlı Olaylar

        #endregion

        #region Nesne Tanımlı Olaylar
        private void vsbSicaklik_Scroll(object sender, ScrollEventArgs e)
        {
            double Fahreint = Convert.ToDouble(200.0 - vsbSicaklik.Value);
            double Centigrade = (5.0 / 9.0) * (Fahreint - 32.0);
            lblFahrenheint.Text = Fahreint.ToString();
            lblCentigrade.Text = Centigrade.ToString("#.##");
        }

        private void termoForm_Load(object sender, EventArgs e)
        {
            //double Fahreint = Convert.ToDouble(200.0 - vsbSicaklik.Value);
            //double Centigrade = (5.0 / 9.0) * (Fahreint - 32.0);
            lblFahrenheint.Text = (Convert.ToDouble(200.0 - vsbSicaklik.Value)).ToString();
            lblCentigrade.Text = ((5.0 / 9.0) * (Convert.ToDouble(lblFahrenheint.Text) - 32.0)).ToString();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
