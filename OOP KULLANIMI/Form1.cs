using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_KULLANIMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            OTOMOBİL oto = new OTOMOBİL();
            oto.marka = "BMW";
            oto.model = "İ8";
            oto.mmodelyılı = 2023;
            oto.renk = "KOYU MAVİ";
            oto.vitestipi = "OTOMATİK";
           // string marka = oto.markagetir();
            label6.Text = oto.marka.ToString();
            label7.Text = oto.model.ToString();
            label8.Text = oto.mmodelyılı.ToString();
            label9.Text = oto.renk.ToString();
            label10.Text=oto.vitestipi.ToString();
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
}
