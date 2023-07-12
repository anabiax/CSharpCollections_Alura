

using ListaSomenteLeitura;

namespace CSharpCollections
{
    class Program
    {
        public static void Main(string[] args)
        {
            Curso csharpColecoes = new Curso("C# Collections", "Marca");
            csharpColecoes.Adiciona(new Aula("Trabalhando com listas", 21));
            Imprimir(csharpColecoes.Aulas);

            // adicionar 2 aulas
            csharpColecoes.Adiciona(new Aula("Criando uma aula.", 20));
            csharpColecoes.Adiciona(new Aula("Modelando colecoes", 19));
            Imprimir(csharpColecoes.Aulas);

            // copia da lista anterior em um - qnd crio uma nova instancia a lista inicializa vazia, entao foi passado dentro do construtor um dado ja existente
            List<Aula> aulasCopiadas = new List<Aula>(csharpColecoes.Aulas);
            aulasCopiadas.Sort();   // ordenar em ordem alfabetica
            System.Console.WriteLine(csharpColecoes.TempoTotal);  // totaliza o tempo dos cursos

            // p/ imprimir os detalhes do curso tem que invocar o metodo ToString p/ a classe Curso
            System.Console.WriteLine(csharpColecoes);
        
        }

        private static void Imprimir(IList<Aula> aulas)
        {
            Console.Clear();
            foreach(Aula aula in aulas) // pegar cada uma das aulas e imprimir no console
            {
                System.Console.WriteLine(aula);
            }
        }
    }
}