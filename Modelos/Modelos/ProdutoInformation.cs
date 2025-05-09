﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ProdutoInformation
    {
        private int _codigo;
        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        private string _descricao;
        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }
        private decimal _preco;
        public decimal Preco
        {
            get { return _preco; }
            set { _preco = value; }
        }
        private int _estoque;
        public int Estoque
        {
            get { return _estoque; }
            set { _estoque = value; }
        }
    }
}
