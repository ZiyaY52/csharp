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
    public partial class log : Form
    {
        public log()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBElektrikDepartmaniDataSet.isBittiMi' table. You can move, or remove it, as needed.
            this.isBittiMiTableAdapter.Fill(this.dBElektrikDepartmaniDataSet.isBittiMi);
            this.isBittiMiDataGridView.Sort(this.isBittiMiDataGridView.Columns["dataGridViewTextBoxColumn3"], ListSortDirection.Ascending);
            
        }

        private void isBittiMiDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.isBittiMiTableAdapter.FillBy(this.dBElektrikDepartmaniDataSet.isBittiMi);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.isBittiMiTableAdapter.FillBy1(this.dBElektrikDepartmaniDataSet.isBittiMi);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void isBittiMiDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
