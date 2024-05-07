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

namespace Person_SavingwithSql
{
    public partial class FrmSignin : Form
    {

        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-6JPMHUC\\SQLSERVERFIRST;Initial Catalog=WorkerDatabase;Integrated Security=True");

        public FrmSignin()
        {
            InitializeComponent();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command1 = new SqlCommand("Select * From Tbl_AdminPanel where UserName=@p1 and Password=@p2", connect);
            command1.Parameters.AddWithValue("@p1", TxtUserName.Text);
            command1.Parameters.AddWithValue("@P2", TxtPassword.Text);
            SqlDataReader reader= command1.ExecuteReader();
            if (reader.Read()) {
                FrmMain frmMain = new FrmMain();
                frmMain.Show();
                this.Hide();



            }
            else
            {
                MessageBox.Show("Wrong Password or Username");
            }


            connect.Close();

        }
    }
}
