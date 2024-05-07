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
    public partial class FrmStatistic : Form
    {
        public FrmStatistic()
        {
            InitializeComponent();
        }

        //This is sql connection name 
        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-6JPMHUC\\SQLSERVERFIRST;Initial Catalog=WorkerDatabase;Integrated Security=True");

        private void FrmStatistic_Load(object sender, EventArgs e)
        {

            //Total Person Counter
            connect.Open();
            SqlCommand command1 = new SqlCommand("Select Count(*) From Table_Persons",connect);
            SqlDataReader dr1= command1.ExecuteReader();
            while (dr1.Read())
            {
                LblTotalPer.Text = dr1[0].ToString();
            }
            connect.Close();


            //Count for Statu
            connect.Open();
            SqlCommand command2 = new SqlCommand("Select Count(*) From Table_Persons where PerStatu=1",connect);
            SqlDataReader dr2= command2.ExecuteReader();
            while (dr2.Read())
            {
                LblMarried.Text = dr2[0].ToString();

            }
            connect.Close();

            //Count for Statu
            connect.Open();
            SqlCommand command3 = new SqlCommand("Select Count(*) From Table_Persons where PerStatu=0", connect);
            SqlDataReader dr3= command3.ExecuteReader();
            while (dr3.Read())
            {
                LblSingle.Text = dr3[0].ToString();
            }
            connect.Close();

            //Count City

            connect.Open();
            SqlCommand command4 = new SqlCommand("Select Count(distinct(PerCity)) From Table_Persons", connect);
            SqlDataReader dr4= command4.ExecuteReader();
            while (dr4.Read())
            {
                LblCity.Text = dr4[0].ToString();
            }
            connect.Close();


            //Total Salary

            connect.Open();
            SqlCommand command5 = new SqlCommand("Select Sum(PerSalary) From Table_Persons", connect);
            SqlDataReader dr5 = command5.ExecuteReader();
            while (dr5.Read())
            {
                LblTotalSalary.Text = dr5[0].ToString();
            }
            connect.Close();

            //Avg Salary 
            connect.Open();
            SqlCommand command6 = new SqlCommand("Select Avg(PerSalary) From Table_Persons", connect);
            SqlDataReader dr6 = command6.ExecuteReader();
            while (dr6.Read())
            {
                LblAvgSalary.Text = dr6[0].ToString();
            }
            connect.Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
