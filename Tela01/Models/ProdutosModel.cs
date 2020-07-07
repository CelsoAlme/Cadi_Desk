using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela01
{
    class ProdutosModel
    {
        string id;
        string produto;

       
        public string Produto { get => produto; set => produto = value; }
        public string Id { get => id; set => id = value; }
    }
}
