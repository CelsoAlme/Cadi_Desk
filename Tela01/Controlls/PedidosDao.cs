using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tela01
{
    public class PedidosDao
    {
      
        //Buscar os produtos dos pedidos
        public static void BuscarProdutos(DataTable entrada)
        {
            SqlConnection conn = Conexao.ObterConexao();
           // select* from Orders where OrderStatus = 2
            SqlCommand comando = new SqlCommand("select o.OrderId as Pedido, " +
                                                "FORMAT(o.OrderDate , N'hh:mm tt')as Hora," +
                                                "o.TableId as Mesa," +
                                                " od.Quantity as Quantidade," +
                                                " p.Name as Produto" +
                                                " from Orders as o" +
                                                " join OrderItems as od " +
                                                "on od.OrderId = o.OrderId " +
                                                "join Products as p" +
                                                " on p.Id = od.ProductId " +
                                                "where o.OrderStatus = 2 " +
                                                "order by o.OrderDate", conn);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            adaptador.Fill(entrada);
            try
            {
                int i = comando.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
            finally
            {
                Conexao.FecharConexao();
            }
        }

        //Atualizar o OrderStatus para 3 "finalizado"
        public static void BAtualizar(DataTable entrada, string Id) 
        {
            int pedido = Convert.ToInt16(Id.ToString());

            SqlConnection conn = Conexao.ObterConexao();
            SqlCommand comando = new SqlCommand ("Update Orders set OrderStatus = 3 " +
                                                 "where OrderStatus = 2 and OrderId ='"+pedido+"';",conn);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            adaptador.Fill(entrada);
            try
            {
                int i = comando.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
            finally
            {
                Conexao.FecharConexao();
            }
        }

        //Select de pedidos efetuados para a grid 2
        public static void PedidosEfetuados(DataTable entrada)
        {
            SqlConnection conn = Conexao.ObterConexao();
            SqlCommand comando = new SqlCommand("select o.OrderId as Pedido," +
                                                " FORMAT(o.OrderDate , N'hh:mm tt')as Data," +
                                                " o.TableId as Mesa," +
                                                " od.Quantity as Quantidade," +
                                                " p.Name as Produto" +
                                                " from Orders as o " +
                                                "join OrderItems as od  " +
                                                "on od.OrderId = o.OrderId " +
                                                "join Products as p " +
                                                "on p.Id = od.ProductId " +
                                                "where o.OrderStatus = 3 order by o.OrderDate", conn);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            adaptador.Fill(entrada);
            try
            {
                int i = comando.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
            finally
            {
                Conexao.FecharConexao();
            }
        }

        //Select para informações dos produtos dos pedidos
        public static void Informacoes(DataTable entrada, String Id)
        {
            int informacoes = Convert.ToInt16(Id.ToString());
            SqlConnection conn = Conexao.ObterConexao();
            SqlCommand comando = new SqlCommand("select od.OrderId as Pedido," +
                                                "oi.Quantity as Quantidade," +
                                                "op.Description as Opções, " +
                                                "ad.Description as Adicional "+
                                                "from Orders as od " +
                                                "join OrderItems as oi " +
                                                "on oi.OrderId = od.OrderId " +
                                                "join Options as op on op.Id = oi.OptionsId " +
                                                "join Additionals as ad " +
                                                "on ad.Id = oi.AdditionalId "+
                                                "where oi.OrderId = '" +informacoes+"';", conn);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            adaptador.Fill(entrada);
            try
            {
                int i = comando.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
            finally
            {
                Conexao.FecharConexao();
            }
        }



    }
}