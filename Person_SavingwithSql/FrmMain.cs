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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        //This is sql connection name 
        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-6JPMHUC\\SQLSERVERFIRST;Initial Catalog=WorkerDatabase;Integrated Security=True");



        void cleaning()
        {
            TxtId.Text = "";
            TxtJob.Text = "";
            TxtName.Text= "";
            TxtSurname.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            MskSalary.Text = "";
            CmbCity.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'workerDatabaseDataSet.Table_Persons' table. You can move, or remove it, as needed.
           

        }

       
        private void BtnList_Click(object sender, EventArgs e)
        {
            this.table_PersonsTableAdapter.Fill(this.workerDatabaseDataSet.Table_Persons);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("insert into Table_Persons(PerName,PerSurname,PerCity,PerSalary,PerJob,PerStatu) values(@p1,@p2,@p3,@p4,@p5,@p6)",connect);
            command.Parameters.AddWithValue("@p1", TxtName.Text);
            command.Parameters.AddWithValue("@p2",TxtSurname.Text);
            command.Parameters.AddWithValue("@p3", CmbCity.Text);
            command.Parameters.AddWithValue("@p4", MskSalary.Text);
            command.Parameters.AddWithValue("@p5", TxtJob.Text);
            command.Parameters.AddWithValue("@p6", label8.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Person Added");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "True";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text="False";
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            connect.Open();
            //Update Table_Name Set Blank1=@r(the character of "r" dont have to be word , u can add word)1,Blank2=@r2...
            SqlCommand deleteit = new SqlCommand("Delete From Table_Persons Where PerId=@k1",connect);
            deleteit.Parameters.AddWithValue("@k1",TxtId.Text);
            deleteit.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Connection Deleted");
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            cleaning();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int chooseone = dataGridView1.SelectedCells[0].RowIndex;
            TxtId.Text = dataGridView1.Rows[chooseone].Cells[0].Value.ToString();
            TxtName.Text = dataGridView1.Rows[chooseone].Cells[1].Value.ToString();
            TxtSurname.Text= dataGridView1.Rows[chooseone].Cells[2].Value.ToString();
            MskSalary.Text= dataGridView1.Rows[chooseone].Cells[4].Value.ToString();
            CmbCity.Text= dataGridView1.Rows[chooseone].Cells[3].Value.ToString();
            TxtJob.Text= dataGridView1.Rows[chooseone].Cells[6].Value.ToString();
            
            label8.Text= dataGridView1.Rows[chooseone].Cells[5].Value.ToString();
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {
                radioButton2.Checked = false;
                radioButton1.Checked= true;
                
            }
            if (label8.Text == "False") {
                radioButton1.Checked = false;
                radioButton2.Checked = true;

            }
        }

        private void BtnUpodate_Click(object sender, EventArgs e)
        {

            //Update Table_Name Set Blank1=@r(the character of "r" dont have to be word , u can add word)1,Blank2=@r2...
            connect.Open();
            SqlCommand updating=new SqlCommand("Update Table_Persons Set PerName=@a1,PerSurname=@a2,PerCity=@a3,PerSalary=@a4,PerStatu=@a5,PerJob=@a6 where PerId=@a7",connect);
            updating.Parameters.AddWithValue("@a1",TxtName.Text);
            updating.Parameters.AddWithValue("@a2", TxtSurname.Text);
            updating.Parameters.AddWithValue("@a3",CmbCity.Text);
            updating.Parameters.AddWithValue("@a4",MskSalary.Text);
            updating.Parameters.AddWithValue("@a5", label8.Text);
            updating.Parameters.AddWithValue("@a6",TxtJob.Text);
            updating.Parameters.AddWithValue("@a7", TxtId.Text);
            updating.ExecuteNonQuery();
            MessageBox.Show("Person Updated");




            connect.Close();
        }

        private void BtnStatis_Click(object sender, EventArgs e)
        {
            FrmStatistic fs=new FrmStatistic();
            fs.Show();
        }

        private void BtnGraph_Click(object sender, EventArgs e)
        {
            FrmGraph frg=new FrmGraph();
            frg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmReports frm1= new FrmReports();
            frm1.Show();

        }
    }
}
