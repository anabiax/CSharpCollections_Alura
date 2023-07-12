namespace CSharpCollections
{
    public class Aula : IComparable
    {
        private string titulo;
        private int duracao;
        public string Titulo { get; set; }
        public int Duracao { get; set; }

        public Aula(string titulo, int duracao)
        {
            this.titulo = titulo;
            this.duracao = duracao;
        }

        // sobreescreve o método da classe object(default)
        public override string ToString()
        {
            return $"[titulo: {titulo}, duracao: {duracao} minutos]";
        }

        // implementa a interface necessária p/ o método Sort(ordenar em ordem alfabética)
        public int CompareTo(object obj)
        {
            Aula that = obj as Aula;
            return titulo.CompareTo(that.titulo);
        }
    }
}