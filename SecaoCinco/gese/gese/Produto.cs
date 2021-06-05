using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace gese {
    class Produto {

        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }
       //permite fazer apenas modificações selecionadas
        public Produto() {// incluir para poder utilizar construtores vazios, sintaxe diferentew
            //e com entradas desejadas
        }
        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;// padrão da linguagem c# para atributo privative
            Preco = preco;
            Quantidade = quantidade;
        }
        public string Nome {
            get { return _nome; }
            set {
                if (value!= null && value.Length > 1) {
                    // o Length é uma atributo do string
                    //value vai equivaler a nome como entrada, escopo do construtor
                    _nome = value;
                }
            }
        }




        public double  ValorTotalEmEstoque() {
             { return Preco * Quantidade; }
        }
        /*
        public string GetNome() {
            return _nome;
        }
        public void SetNome(string nome) {
            if (nome != null && nome.Length > 1) {
                // o Length é uma atributo do string
                _nome = nome;
            }
        }
        
        public double GetPreco() {//apenas mostrar o preço sem alterar
            return _preco;
        }
        public int GetQuantidade() {
            return _quantidade;
        }
        public int SetQuantidade() {
            return _quantidade;
        }*/

        
        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }
        public override string ToString() {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

