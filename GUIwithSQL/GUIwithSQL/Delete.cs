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
    public partial class Delete : Form
    {
        public string conString = "Data Source=DESKTOP-A4E0SUU\\ZYDB;Initial Catalog=TestDB;Integrated Security=True";

        public Delete()
        {
            InitializeComponent();
        }

        private void workerInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
           
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDBDataSet.WorkerInfo' table. You can move, or remove it, as needed.
          

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand(("DELETE FROM WorkerInfo WHERE (WorkerID = @WorkerID)"), con);
            cmd.Parameters.AddWithValue("@WorkerID", txtID.Text);
            
            int i = cmd.ExecuteNonQuery();

            con.Close();

            if (i != 0)
            {
                MessageBox.Show("Data Deleted!");
                this.Hide();

            }
        }
    }
}
