using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data;

namespace OutdoorParadiseViewer
{
     
    static class Functions
    {
        static public SqlConnection currentConnection;
        static public Boolean Connect(SqlConnection paramSqlConnection)
        {
            try
            {
                currentConnection = paramSqlConnection;
                currentConnection.Open();

                return true;
            }
            catch(Exception e)
            {
                
                MessageBox.Show(e.ToString());
                return false;
            }
                 
        }

        static public void Disconnect()
        {
            currentConnection.Close();
        }

        static public void Execute(DataGridView paramdataGridView, String paramSQLCommand, SqlConnection paramConnection)
        {
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                SqlCommand ExecuteSQL = new SqlCommand(paramSQLCommand, paramConnection);
                Debug.WriteLine("SQL Query: " + paramSQLCommand);
                dataAdapter.SelectCommand = ExecuteSQL;

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                paramdataGridView.DataSource = dataTable;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        internal static void InsertTrip(String paramConsumer, String paramTrip, Boolean paramExcursion, SqlConnection paramConnection)
        {
            try
            {
                SqlCommand InsertTrip = new SqlCommand("INSERT INTO Trip_order VALUES(@Consumer, @Trip, @Excursion)", paramConnection);
                InsertTrip.Parameters.AddWithValue("@Consumer", paramConsumer);
                InsertTrip.Parameters.AddWithValue("@Trip", paramTrip);
                InsertTrip.Parameters.AddWithValue("@Excursion", paramExcursion);

                InsertTrip.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                Debug.WriteLine(e);
            }
        }

        static public void loadDataComboBox(ComboBox cmb, String paramSQLCommand, SqlConnection paramConnection, String paramValueMember, String paramDisplayMember)
        {
            try { 
            SqlCommand ExecuteSQL = new SqlCommand(paramSQLCommand, paramConnection);
            Debug.WriteLine("SQL Query: " + paramSQLCommand);

            SqlDataReader reader;
            reader = ExecuteSQL.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("", typeof(string));
            dt.Columns.Add("contactname", typeof(string));
            dt.Load(reader);

            cmb.ValueMember = paramValueMember;
            cmb.DisplayMember = paramDisplayMember;
            cmb.DataSource = dt;
            }
            catch(Exception e)
            {
                Debug.Write(e);
            }

        }


    }
}
