using System;


namespace VendaProduto
{
    class ProdutoUsado : Produto
    {
        public DateTime Fabricacao { get; set; }

        public ProdutoUsado(string nome, double preco, DateTime fabricacao) : base(nome, preco)
        {
            Fabricacao = fabricacao;
        }
       
        public override string Etiqueta()
        {
            return Nome + " (Usado)" + " R$" + Preco.ToString("F2") + " (Data de fabricacao: " + Fabricacao.ToShortDateString() + ")";
        }
    }
}
