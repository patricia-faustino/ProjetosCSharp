using System;
using System.Globalization;
namespace segundoproblemaclasse {
    class Produto {
        private string _nome;
        private double _preco;
        private int _quantidade;// padrão do private usar _
        
        public Produto() {
            
        }

        public Produto(string nome, double preco, int quantidade){
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
            // essa linha é redundante, pois por padrão o valor desse atributo já é considerado zero
        }
    
            // construtores comecam com letra minuscula. obriga o programador a entrar com os dados
            // o construtor padrão fica proibido, podendo ser permitido, se e 
            //somente se, for criado um novo construtor com o parenteses vazio e permitindo a 
            //sintaxe alternativa

        public string GetNome() {
            return _nome;
        }

        public void SetNome(string nome) {
            if(nome != null && nome.Length > 1) {
                //Length é uma propriedade do string que permite contar os caracteres
                _nome = nome;

            }
            

        }
         
        public double ValorTotalEmEstoque() {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade) {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            _quantidade -= quantidade;
        }

        public override string ToString() {
            return _nome + ", $ " + _preco.ToString("F2", CultureInfo.InvariantCulture) +
              ", " + _quantidade + " unidades, Total: $ " +
              ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
