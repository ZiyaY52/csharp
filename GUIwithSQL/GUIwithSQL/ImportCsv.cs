using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIwithSQL
{
    public partial class ImportCsv : Form
    {
        public ImportCsv()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txtPath.Text = openFileDialog1.FileName;
            DataTable dt = new DataTable();
            string[] satirlar = new string[] { };
            try
            {
            satirlar = System.IO.File.ReadAllLines(txtPath.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Select a file!");
            }
            
                if (satirlar.Length > 0)
                {
                    //ilk satır başlık satırımız
                    string ilkSatir = satirlar[0];
                    string[] basliklar = ilkSatir.Split(';');
                    foreach (string baslik in basliklar)
                    {
                        dt.Columns.Add(new DataColumn(baslik));
                    }
                    //Veriler için kodlarımız
                    for (int i = 1; i < satirlar.Length; i++)
                    {
                        string[] veriler = satirlar[i].Split(';');
                        DataRow dr = dt.NewRow();
                        int columnIndex = 0;
                        foreach (string veri in basliklar)
                        {
                            dr[veri] = veriler[columnIndex++];
                        }
                        dt.Rows.Add(dr);
                    }
                }

            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
