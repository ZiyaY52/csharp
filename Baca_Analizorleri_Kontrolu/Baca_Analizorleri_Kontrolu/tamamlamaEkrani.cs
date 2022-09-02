using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Baca_Analizorleri_Kontrolu
{
    
    public partial class tamamlamaEkrani : Form
    {

        public string conString = "Data Source=DESKTOP-A4E0SUU\\ZYDB;Initial Catalog=DBElektrikDepartmani;Integrated Security=True";
            
        public static tamamlamaEkrani instance;
        public tamamlamaEkrani()
        {
            InitializeComponent();
            instance = this;
        }
        public tamamlamaEkrani(string isadi)
        {
            InitializeComponent();
            instance = this;
            txtIsAdi.Text = isadi;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaMenu.instance.radioButton2.Checked = false;
            AnaMenu.instance.radioButton1.Checked = true;
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (isimsoyisimComboBox.Text != "")
            {
                SqlCommand cmd = new SqlCommand(("insert into isBittiMi (isadi, isimsoyisim,tarih,sicilno,bitti,aciklama) VALUES(@isadi,@isimsoyisim,@tarih,@sicilno,@bitti,@aciklama)"), con);
                cmd.Parameters.AddWithValue("@isadi", AnaMenu.instance.label1.Text);
                cmd.Parameters.AddWithValue("@isimsoyisim", isimsoyisimComboBox.Text);
                cmd.Parameters.AddWithValue("@tarih", DateTime.Now);
                cmd.Parameters.AddWithValue("@sicilno", txtSicilNo.Text);
                cmd.Parameters.AddWithValue("@bitti", 1);
                cmd.Parameters.AddWithValue("@aciklama", txtAciklama.Text);
                int i = cmd.ExecuteNonQuery();

                con.Close();

                if (i != 0)
                {
                    MessageBox.Show("Bilgiler Kaydedildi!");
                    this.Hide();

                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("İstenilen parametreleri giriniz.");
            }
        }

        private void kisilerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kisilerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBElektrikDepartmaniDataSet);

        }

        private void tamamlamaEkrani_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBElektrikDepartmaniDataSet.Kisiler' table. You can move, or remove it, as needed.
            this.kisilerTableAdapter.Fill(this.dBElektrikDepartmaniDataSet.Kisiler);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.kisilerTableAdapter.FillBy(this.dBElektrikDepartmaniDataSet.Kisiler);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            

        }

        private void isimsoyisimComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            
            SqlCommand cmd = new SqlCommand(("SELECT sicilno FROM Kisiler WHERE (isimsoyisim = @isimsoyisim)"), con);
            cmd.Parameters.AddWithValue("@isimsoyisim", isimsoyisimComboBox.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
               {
                  txtSicilNo.Text = dr.GetValue(0).ToString();

               }
            con.Close();
        }

        private void sicilnoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
