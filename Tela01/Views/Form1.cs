using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;


namespace Tela01
{
    public partial class Form1 : Form
    {
        //Declaração da variavel contador
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            atualizar();
            atualizar2();
        }

        private void Time_Elapsed(object sender, ElapsedEventArgs e)
        {
            atualizar();
            atualizar2();
        }

        //Atualizar a grid 01
        private void atualizar()
        {
            DataTable tabela = new DataTable();
           gv_pedidospendentes.DataSource = tabela;
            PedidosDao.BuscarProdutos(tabela);
        }

        //Atualizar a grid 02
        private void atualizar2()
        {
            DataTable tabela3 = new DataTable();
            gv_pedidosexecutados.DataSource = tabela3;
            PedidosDao.PedidosEfetuados(tabela3);
        }

        //timer para atualizar automaticamente

        private void timer1_Tick(object sender, EventArgs e)
        {
                 Task.Delay(5000);
            atualizar();
            atualizar2();
        }

        //Pedidos efetuados
        private void PedidosEfetuados()
        {
            DataTable tabela = new DataTable();
            gv_pedidosexecutados.DataSource = tabela;
            PedidosDao.PedidosEfetuados(tabela);
        }

        //Código para os botões
        private void Pedidospendentes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (gv_pedidospendentes.Columns[e.ColumnIndex] == gv_pedidospendentes.Columns["Status"])
            {
                
                DataTable tabela = new DataTable();
                gv_pedidosexecutados.DataSource = tabela;
                ProdutosModel prod = new ProdutosModel();
                prod.Id = gv_pedidospendentes.CurrentRow.Cells[2].Value.ToString();
                PedidosDao.BAtualizar(tabela, prod.Id);
                DataTable tabela2 = new DataTable();
                gv_pedidosexecutados.DataSource = tabela2;
                PedidosDao.PedidosEfetuados(tabela2);
            }
            else if (gv_pedidospendentes.Columns[e.ColumnIndex] == gv_pedidospendentes.Columns["inf"])
            {
                DataTable tabela3 = new DataTable();
                gv_informacoes.DataSource = tabela3;
                ProdutosModel prod = new ProdutosModel();
                prod.Id = gv_pedidospendentes.CurrentRow.Cells[2].Value.ToString();
                PedidosDao.Informacoes(tabela3, prod.Id);
            }
        }
    }
}
