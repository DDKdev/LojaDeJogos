using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LojaProdutosGeekBiblioteca.DataBases
{
    public class LocalDBClass
    {
        public string stringConn = "";
        public SqlConnection connDB;

        public LocalDBClass()
        {
            try
            {
                stringConn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\dnl_3\\OneDrive\\Documentos\\ProjetosGitHub\\LojaProdutosGeek\\LojaProdutosGeek\\LojaProdutosGeekBiblioteca\\FicharioCliente.mdf;Integrated Security=True";
                connDB = new SqlConnection(stringConn);
                connDB.Open();
            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
        }
        public string SQLCommand(string SQL)
        {
            try
            {
                var myCommand = new SqlCommand(SQL, connDB);
                myCommand.CommandTimeout = 0;
                var myReader = myCommand.ExecuteReader();
                return "";
            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
        }
        public DataTable SQLQuery(string SQL)
        {
            DataTable dt = new DataTable();
            try
            {
                var myCommand = new SqlCommand(SQL, connDB);
                myCommand.CommandTimeout = 0;
                var myReader = myCommand.ExecuteReader();
                dt.Load(myReader);

            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
            return dt;
        }
        public void Close()
        {
            connDB.Close();
        }
    }
}
