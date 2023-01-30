using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_KULLANIMI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OTOMOBİL OTOO = new OTOMOBİL();
            OTOO.marka = "AUDİ";
            OTOO.model = "RS7";
            OTOO.mmodelyılı = 2020;
            OTOO.renk = "SİYAH";
            OTOO.vitestipi = "MANUEL";

            label6.Text = OTOO.marka.ToString();
            label7.Text = OTOO.model.ToString();
            label8.Text = OTOO.mmodelyılı.ToString();
            label9.Text = OTOO.renk.ToString();
            label10.Text = OTOO.vitestipi.ToString();
        }
    }
}
