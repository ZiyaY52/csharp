using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baca_Analizorleri_Kontrolu
{
    public partial class AnaMenu : Form
    {
        public static AnaMenu instance;
        public AnaMenu()
        {
            InitializeComponent();
            instance = this;
            label8.Text = DateTime.Now.ToLongDateString();
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
      
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
       
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            tamamlamaEkrani yeniEkran = new tamamlamaEkrani();
            

            if (radioButton3.Checked)
            {
                yeniEkran.ShowDialog();

            }
            if (radioButton4.Checked)
            {
                

            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tamamlamaEkrani yeniEkran = new tamamlamaEkrani();
           
            
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            tamamlamaEkrani yeniEkran = new tamamlamaEkrani();
            

            if (radioButton6.Checked)
            {
                yeniEkran.ShowDialog();

            }
            if (radioButton5.Checked)
            {
                

            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            tamamlamaEkrani yeniEkran = new tamamlamaEkrani();
           

            if (radioButton8.Checked)
            {
                yeniEkran.ShowDialog();

            }
            if (radioButton7.Checked)
            {
               

            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            tamamlamaEkrani yeniEkran = new tamamlamaEkrani();
            

            if (radioButton10.Checked)
            {
                yeniEkran.ShowDialog();

            }
            if (radioButton9.Checked)
            {
                

            }
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            tamamlamaEkrani yeniEkran = new tamamlamaEkrani();
            

            if (radioButton12.Checked)
            {
                yeniEkran.ShowDialog();

            }
            if (radioButton11.Checked)
            {
                

            }
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {
           
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            tamamlamaEkrani yeniEkran = new tamamlamaEkrani(label1.Text);

            yeniEkran.ShowDialog();

            if (radioButton13.Checked)
            {


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            log newlog = new log();
            newlog.ShowDialog();
        }
    }
}
