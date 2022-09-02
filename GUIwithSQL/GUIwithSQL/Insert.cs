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
    public partial class Insert : Form
    {
        public Insert()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=DESKTOP-A4E0SUU\\ZYDB;Initial Catalog=TestDB;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            // INSERT COMMANDDA AYNI WORKER ID VARSA PRIMARY KEY COLLISION
            // OLUP ERROR DÖNDÜRÜYOR
            // AYNI NUMARAYI GÜNCELLEMEK IÇIN IF YERINE YENI UPDATE BUTTON

            SqlConnection con = new SqlConnection(conString);
            con.Open();

            SqlCommand cmd2 = new SqlCommand(("insert into loginsystem (username, pw, email) VALUES (@username, @pw, @email)"), con);
            SqlCommand cmd = new SqlCommand(("insert into WorkerInfo (WorkerName,WorkerSurname,AddressofWorker,PhoneNum,SSN,loginid) VALUES(@WorkerName,@WorkerSurname,@AddressofWorker,@PhoneNum,@SSN,(SELECT TOP 1 loginid FROM loginsystem ORDER BY[loginid] DESC))"), con);
            cmd2.Parameters.AddWithValue("@username", txtUserName.Text);
            cmd2.Parameters.AddWithValue("@pw", txtPw.Text);
            cmd2.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@WorkerName", txtWorkerName.Text);
            cmd.Parameters.AddWithValue("@WorkerSurname", txtWorkerSurname.Text);
            cmd.Parameters.AddWithValue("@AddressofWorker", txtWorkerAddress.Text);
            cmd.Parameters.AddWithValue("@PhoneNum", txtPhoneNum.Text);
            cmd.Parameters.AddWithValue("@SSN", txtSNN.Text);
            

            //DATABASE DEĞİŞİKLİĞİ OLDUĞUNUN KONTROLÜ
            int j = cmd2.ExecuteNonQuery();
            int i = cmd.ExecuteNonQuery();

            con.Close();

            if (i != 0 && j != 0)
            {
                MessageBox.Show("Data Saved");
                this.Hide();
            }

            //for the second form i'll activate this
            //Form2 Check = new Form2(this);
            //Check.Show();
            //Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWorkerName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
