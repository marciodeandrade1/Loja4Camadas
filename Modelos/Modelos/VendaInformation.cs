using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class VendaInformation
    {
        private int _codigo;
        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        private DateTime _dataVenda;
        public DateTime DataVenda
        {
            get { return _dataVenda; }
            set { _dataVenda = value; }
        }
        private decimal _valorTotal;
        public decimal ValorTotal
        {
            get { return _valorTotal; }
            set { _valorTotal = value; }
        }
        private List<ProdutoInformation> _produtos;
        public List<ProdutoInformation> Produtos
        {
            get { return _produtos; }
            set { _produtos = value; }
        }
    }
}
