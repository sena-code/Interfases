namespace Aula26Interfaces
{
    public class Produto
    {
        public string Nome { get; set; }
        public int Codigo { get; set; }
        public float Preco { get; set; }
        public Produto(){

        }

        public Produto(string _nome, int _codigo, float _preco){

            this.Codigo = _codigo;
            this.Nome = _nome;
            this.Preco = _preco;
        }

    }
}