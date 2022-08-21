using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace AccessC
{
    class ConectThisAccessWorker
    {
        public static string Connectic = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Q.mdb;";
        OleDbConnection myConnection;
        public void OpenConnectic()
        {
            myConnection = new OleDbConnection(Connectic);
            myConnection.Open();
        }
        public string Select(string query)
        {
            OleDbDataReader result;
            string resultstring = "";
            try
            {
                OleDbCommand command = new OleDbCommand(query, myConnection);
                result = command.ExecuteReader();
                while (result.Read())
                {
                    for (int i = 0; i < result.FieldCount; i++)
                        resultstring += (result[i].ToString() + " ");
                }
                
            }
            catch (Exception error)
            {
                resultstring = "";
                MessageBox.Show("Возникла ошибка при выполнении операции");
                MessageBox.Show(error.ToString());
            }
            return resultstring;
        }
        public void InsertAndDeleteAndUpdate(string query)
        {
            try
            {
                OleDbCommand command = new OleDbCommand(query, myConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Операция выполнена успешно");
            }
            catch (Exception errorr)
            {
                MessageBox.Show("Возникла ошибка при выполнении операции");
                MessageBox.Show(errorr.ToString());
            }
        }
        public DataTable fill(string query)
        {
            using(OleDbConnection conn = new OleDbConnection(Connectic)) {

                OleDbCommand comm = new OleDbCommand(query, conn);
                DataTable table = new DataTable();
                OleDbDataAdapter adapter = new OleDbDataAdapter(comm);
                adapter.Fill(table);
                return table;

                } 
        }
        public void Close()
        {
            myConnection.Close();
        }
    }
}
