using System;
using System.Collections.Generic;

namespace Aula26Interfaces
{
    public class Carrinho : ICarrinho
    {
        List<Produto> carrinho = new List<Produto>();
        public float ValorTotal { get; set; }
        public void Alterar(int _codigo, Produto _produto)
        {
            carrinho.Find(j => j.Codigo == _codigo).Nome = _produto.Nome;
            carrinho.Find(j => j.Codigo == _codigo).Preco = _produto.Preco;
        }

        public void Excluir(Produto _produto)
        {
            carrinho.Remove(_produto);
        }

        public void Incluir(Produto _produto)
        {
            carrinho.Add(_produto);
        }

        public void Ler()
        {
            foreach(Produto item in carrinho){
                Console.WriteLine($"R$ {item.Preco} - {item.Nome}");
            };
        }

        public void MostrarTotal()
        {
               foreach(Produto item in carrinho)
            {
                ValorTotal += item.Preco;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Valor total dos itens {ValorTotal}");
            Console.ResetColor();
        }
    }
}