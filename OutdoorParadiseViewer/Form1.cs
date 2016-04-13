using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutdoorParadiseViewer
{
    public partial class Form1 : Form
    {
        static private SqlConnection connectionPChin = new SqlConnection(@"Data Source=localhost\SambaPOS3;Initial Catalog=OutdoorParadise;User ID=PChin;Password=123;MultipleActiveResultSets=true");
        static private SqlConnection connectionTestManager = new SqlConnection(@"Data Source=localhost\SambaPOS3;Initial Catalog=OutdoorParadise;User ID=TestManager;Password=123;MultipleActiveResultSets=true");
        static private SqlConnection connectionTestHRM = new SqlConnection(@"Data Source=localhost\SambaPOS3;Initial Catalog=OutdoorParadise;User ID=TestHRM;Password=123;MultipleActiveResultSets=true");
        static private SqlConnection connectionAdmin = new SqlConnection(@"Data Source=localhost\SambaPOS3;Initial Catalog=OutdoorParadise;User ID=OP;Password=123;MultipleActiveResultSets=true");
        static public SqlConnection currentConnection;

        public Form1()
        {
            InitializeComponent();


            List<select> selectList = new List<select>();

            selectList.Add(new select() { Text = "SELECT * FROM Employee", Value = "SELECT * FROM Employee" });
            selectList.Add(new select() { Text = "SELECT * FROM Order", Value = "SELECT * FROM Order_" });
            selectList.Add(new select() { Text = "SELECT * FROM Customer", Value = "SELECT * FROM Customer" });
            selectList.Add(new select() { Text = "PChin View", Value = "SELECT * FROM EmployeeMe" });
            selectList.Add(new select() { Text = "TestManager View", Value = "SELECT* FROM EmployeeTeam" });
            selectList.Add(new select() { Text = "SELECT * FROM Trip_order", Value = "SELECT* FROM Trip_order" });
            

            comboBox1.DataSource = selectList;
            comboBox1.DisplayMember = "Text";
        }


        private void btnPChin_Click(object sender, EventArgs e)
        {
            checkConnection();
            if (Functions.Connect(connectionPChin))
            {
                labelStatus.Text = "Status: Connected as PChin!";
                currentConnection = connectionPChin;
            }
            else
            {
                labelStatus.Text = "Status: Connection Failed.";
            }
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            checkConnection();
            if (Functions.Connect(connectionTestManager))
            {
                labelStatus.Text = "Status: Connected as TestManager!";
                currentConnection = connectionTestManager;
            }
            else
            {
                labelStatus.Text = "Status: Connection Failed.";
            }
        }

        private void btnHRM_Click(object sender, EventArgs e)
        {
            checkConnection();
            if (Functions.Connect(connectionTestHRM))
            {
                labelStatus.Text = "Status: Connected as TestHRM!";
                currentConnection = connectionTestHRM;
            }
            else
            {
                labelStatus.Text = "Status: Connection Failed.";
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            checkConnection();
            if (Functions.Connect(connectionAdmin))
            {
                labelStatus.Text = "Status: Connected as Admin!";
                currentConnection = connectionAdmin;
            }
            else
            {
                labelStatus.Text = "Status: Connection Failed.";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            select sl1 = comboBox1.SelectedItem as select;
            tBQuery.Text = sl1.Value;
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            Functions.Execute(this.dataGridView1, tBQuery.Text, currentConnection);

        }
        private void checkConnection()
        {
            if (currentConnection != null)
            {
                labelStatus.Text = "Closing connection";
                Functions.Disconnect();
            }
        }

        private void btnPChin_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(currentConnection != null)
            {
                Functions.Disconnect();
            }
            if (Functions.Connect(connectionAdmin))
            {
                labelStatus.Text = "Status: Connected as Admin!";
                currentConnection = connectionAdmin;
            }
            else
            {
                labelStatus.Text = "Status: Connection Failed.";
            }
            Form2 TripForm = new Form2();
            TripForm.Show();
        }
    }

    
        
}
