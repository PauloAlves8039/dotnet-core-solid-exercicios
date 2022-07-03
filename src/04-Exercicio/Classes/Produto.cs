using _04_Exercicio.Interfaces;

namespace _04_Exercicio.Classes
{
    public abstract class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        protected IPromocao _promocao;

        public Produto(IPromocao promocao)
        {
            _promocao = promocao;
        }

        public decimal DescontoPromocao() 
        {
            return _promocao.Desconto();
        }

        public decimal PrecoVenda() 
        {
            return Preco - (Preco * DescontoPromocao());
        }
    }
}
