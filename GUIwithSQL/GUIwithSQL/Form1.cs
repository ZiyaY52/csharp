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

namespace GUIwithSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }

        public string conString = "Data Source=DESKTOP-A4E0SUU\\ZYDB;Initial Catalog=TestDB;Integrated Security=True";
        int showbuttons_numberofclick = 0;
        private void customizeDesign()
        {
            subMenu.Visible = false;
        }

        private void workerInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.workerInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.testDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDBDataSet.WorkerInfo' table. You can move, or remove it, as needed.
            this.workerInfoTableAdapter.Fill(this.testDBDataSet.WorkerInfo);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Insert ins = new Insert();
            ins.ShowDialog();



            //MessageBox.Show("Button is pressed");
            //SqlConnection con = new SqlConnection(conString);
            //con.Open();
            //SqlCommand cmd = new SqlCommand(("insert into WorkerInfo (WorkerID, WorkerName,WorkerSurname,AddressofWorker,PhoneNum,SSN) VALUES(@WorkerID,@WorkerName,@WorkerSurname,@AddressofWorker,@PhoneNum,@SSN)"),con);
            //cmd.Parameters.AddWithValue("@WorkerID", workerIDNumericUpDown.Text);
            //cmd.Parameters.AddWithValue("@WorkerName", workerNameTextBox.Text);
            //cmd.Parameters.AddWithValue("@WorkerSurname", workerSurnameTextBox.Text);
            //cmd.Parameters.AddWithValue("@AddressofWorker", addressofWorkerTextBox.Text);
            //cmd.Parameters.AddWithValue("@PhoneNum", phoneNumTextBox.Text);
            //cmd.Parameters.AddWithValue("@SSN", sSNTextBox.Text);
            //con.Open();
            //int i = cmd.ExecuteNonQuery();

            //con.Close();

            //if (i != 0)
            //{
            //  MessageBox.Show("Data Saved");
            //}


            //for the second form i'll activate this
            //Form2 Check = new Form2(this);
            //Check.Show();
            //Hide();
        }

        private void workerIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void workerNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.workerInfoTableAdapter.FillBy(this.testDBDataSet.WorkerInfo);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void workerNameTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void workerSurnameTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void workerIDNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Delete del = new Delete();
            del.Owner = this;
            del.ShowDialog();
            this.Refresh();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Update upd = new Update();
            upd.Owner = this;
            upd.ShowDialog();
            this.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SendMail sendM = new SendMail();
            sendM.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ImportCsv Icsv = new ImportCsv();
            Icsv.ShowDialog();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            showbuttons_numberofclick++;

            if (showbuttons_numberofclick % 2 == 0)
            {
                subMenu.Visible = false;
            }
            if (showbuttons_numberofclick % 2 == 1)
            {
                subMenu.Visible = true;
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            SupportCaseEntry sce = new SupportCaseEntry();
            sce.ShowDialog();
        }
    }
}
