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
    public partial class FrmGraph : Form
    {
        public FrmGraph()
        {
            InitializeComponent();
        }

        //This is sql connection  
        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-6JPMHUC\\SQLSERVERFIRST;Initial Catalog=WorkerDatabase;Integrated Security=True");


        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void FrmGraph_Load(object sender, EventArgs e)
        {

            //Graph for Cities Counter
            connect.Open();
            SqlCommand command1 = new SqlCommand("Select PerCity,COUNT(*) From Table_Persons group by PerCity", connect);
            SqlDataReader dr1 = command1.ExecuteReader();
            while (dr1.Read())
            {
                chart1.Series["Cities"].Points.AddXY(dr1[0], dr1[1]);
            }
            connect.Close();


            //Graph 2 for Salaries
            connect.Open();
            SqlCommand command2 = new SqlCommand("Select PerJob,AVG(PerSalary) From Table_Persons group by PerJob", connect);
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["Salaries-and-Jobs"].Points.AddXY(dr2[0], dr2[1]);
            }
            connect.Close();
        }
    }
}
