using System;

namespace Aula26Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho carrinho = new Carrinho();
            Produto p1 = new Produto("Computado i5 9th", 2, 6000f);
            Produto p2 = new Produto("Monitor 144 Hz", 3, 3000f);
            Produto p3 = new Produto("Monitor 240 Hz", 4, 4000f);

            carrinho.Incluir(p1);
            carrinho.Incluir(p2);
            carrinho.Incluir(p3);

            carrinho.Ler();
            carrinho.MostrarTotal();
            
            

        }
    }
}
