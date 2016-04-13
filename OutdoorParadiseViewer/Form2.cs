using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OutdoorParadiseViewer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            populateComboBox1();
            populateComboBox2();
        }

        private void populateComboBox1()
        {
            String query = "SELECT CU.Name + ' ' +  CU.Last_name AS 'Consumer', C.Customer_code FROM Consumer C INNER JOIN Customer CU ON C.Customer_code = CU.Customer_code";
            Functions.loadDataComboBox(this.comboBoxConsumer, query, Form1.currentConnection, "Customer_code", "Consumer");
        }

        private void populateComboBox2()
        {
            String query = "SELECT ID, Name FROM Trip";
            Functions.loadDataComboBox(this.comboBoxTrip, query, Form1.currentConnection, "ID", "Name");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Consumer = comboBoxConsumer.SelectedValue.ToString();
            String Trip = comboBoxTrip.SelectedValue.ToString();
            Boolean Excursion = checkBox1.Checked;

            Debug.WriteLine("Consumer: " + Consumer + " Trip: " + Trip + " Excursion checked: " + Excursion);

            Functions.InsertTrip(Consumer, Trip, Excursion, Form1.currentConnection);
        }
    }
}
