using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            this.comboBoxConsumer.DisplayMember = "FullName";
            this.comboBoxConsumer.ValueMember = "your field";
            this.comboBoxConsumer.DataSource = OutdoorParadiseDataSet.Tables["tEmployee"];
        }

        private void populateComboBox2()
        {
            throw new NotImplementedException();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
