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
    
    }
}
