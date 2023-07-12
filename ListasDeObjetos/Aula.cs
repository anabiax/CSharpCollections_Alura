namespace CSharpCollections
{
    public class Aula : IComparable
    {
        public string Titulo { get; set; }
        public int Duracao { get; set; }

        public Aula(string titulo, int duracao)
        {
            Titulo = titulo;
            Duracao = duracao;
        }

        // sobreescreve o metodo da classe object(default) p/ que ele imprima oq eu quero
        public override string ToString()
        {
            return $"[titulo: {Titulo}, tempo: {Duracao} minutos]";
        }

        // implementa a interface necessaria p/ o metodo Sort(ordenar em ordem alfabetica os elementos)
        public int CompareTo(object? obj)
        {
            // variavel temporaria
            Aula that = obj as Aula;        // converte p/ Aula a fim de ter acesso ao Titulo da classe
            return Titulo.CompareTo(that.Titulo);
        }
    }
}