namespace CSharpCollections
{
    class Program
    {
        public static void Main(string[] args)
        {
            Curso csharpColecoes = new Curso("C# coleções", "Marcelo Oliveira");
            csharpColecoes.Adiciona(new Aula("Trabalhando com listas.", 21));
            csharpColecoes.Adiciona(new Aula("Criando uma aula.", 20));
            csharpColecoes.Adiciona(new Aula("Modelando com coleções.", 24));

            Aluno aluno1 = new Aluno("Ana", 1234);
            Aluno aluno2 = new Aluno("Livia", 4321);
            Aluno aluno3 = new Aluno("Maiara", 2314);

            csharpColecoes.Matricula(aluno1);
            csharpColecoes.Matricula(aluno2);
            csharpColecoes.Matricula(aluno3);

            foreach(var aluno in csharpColecoes.Alunos)
            {
                System.Console.WriteLine(aluno);
            }

            System.Console.WriteLine($"O aluno1 {aluno1.Nome} está matriculado?");
            System.Console.WriteLine(csharpColecoes.EstaMatriculado(aluno1));

            Aluno tonini = new Aluno("Ana", 1234);
            System.Console.WriteLine($"Tonini {tonini} está matriculado?");
            System.Console.WriteLine(csharpColecoes.EstaMatriculado(tonini));

            System.Console.WriteLine(aluno1 == tonini); // tratam-se de instancias diferentes


            // Equals faz uma comparacao entre a instancia aluno1 e tonini p/ saber se os nomes sao iguais
            System.Console.WriteLine(aluno1.Equals(tonini));// retorna true

            //Console.Clear();

            System.Console.WriteLine($"Quem é o aluno cuja matricula é 2314?");
            Aluno aluno2314 = csharpColecoes.BuscaMatriculado(2314); // vai receber o resultado desse cara
            System.Console.WriteLine($"Aluno encontrado: {aluno2314}");

            // NOVA COLECAO: DICIONARIO
            // permite associar uma chave à um valor
                                // {matricula: valor}
            // a chave é única -> n permite adicionar dois elementos cuja chave é a mesma(estoura excecao)
            // o indexador pode adicionar ou substituir itens.

            System.Console.WriteLine($"Quem é o aluno 5618?");
            System.Console.WriteLine($"Aluno: {csharpColecoes.BuscaMatriculado(5618)}"); // null s/ estourar excecao

            // se eu chamar aqui direto o Matricula ja vai me estourar excecao de que a chave n pode ser duplicada
            // e se quisermos trocar o aluno que tem a mesma chave (p/ uma matricula ja existente)?
            Aluno fabio = new Aluno("Fabio", 4321);
            csharpColecoes.SubstituiAluno(fabio);
            System.Console.WriteLine($"Quem é o aluno cuja matricula é 4321 agr? {csharpColecoes.BuscaMatriculado(4321)}");

        }
    }
}