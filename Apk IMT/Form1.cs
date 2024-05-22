using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apk_IMT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            double tinggi, berat, imt;
            string ket1, ket2, ket3;
            string nama = txtNama.Text;
            ket1 = "Berat badan anda normal";
            ket2 = "Underweight, anda perlu menaikkan berat badan anda";
            ket3 = "Overweight, anda perlu menurunkan berat badan anda";
            tinggi = Convert.ToDouble(txtTinggibadan.Text) / 100;
            berat = Convert.ToDouble(txtBeratbadan.Text);
            imt = berat / (tinggi * tinggi);
            if (imt >= 18 && imt <= 21)
            {
                MessageBox.Show("IMT anda adalah " + nama + " " + imt + ket1);
            }
            else if (imt <= 18)
            {
                MessageBox.Show("IMT anda adalah " + nama + " " + imt + ket2);
            }
            else
            {
                MessageBox.Show("IMT anda adalah " + nama + " " + imt + ket3);
            }
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            txtNama.Text = " ";
            txtUsia.Text = " ";
            txtBeratbadan.Text = " ";
            txtTinggibadan.Text = " ";
            comboBox1.Text = " ";
        }
    }
}
        
    

