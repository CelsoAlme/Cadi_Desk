using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela01
{
    class Conexao
    {
        private static string conexao = @"Data Source=13.90.44.28;Initial Catalog=CadiDb;Persist Security Info=True;User ID=Piloto;Password=cadi#2020";
        private static SqlConnection conn = null;

        public static SqlConnection ObterConexao()
        {
            conn = new SqlConnection(conexao);
            try
            {
                conn.Open();
            }
            catch (SqlException ex)
            {
                conn = null;
                Console.WriteLine("Não foi possível conectar: " + ex);
            }
            return conn;
        }

        public static void FecharConexao()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}