namespace CSharpCollections
{
    class Program
    {
        public static void Main(string[] args)
        {
            // SETS = CONJUNTOS -> são + performáticos (direciona + rapidamente p/ o local no qual o elemento será posicionado)
            // 2 propriedades do set: 
                //1. nao permite duplicidade - 2 elementos iguais n permanecerao dentro de um conjunto
                //2. os elementos nao sao mantidos em ordem especifica

                                        // HashSet é um tipo específico do .NET
            ISet<string> alunos = new HashSet<string>();
            alunos.Add("Ana");
            alunos.Add("Livia");
            alunos.Add("Soraia");

            System.Console.WriteLine(alunos);
            System.Console.WriteLine(string.Join(", ", alunos));

            System.Console.WriteLine("Simara");
            System.Console.WriteLine("Amanda");
            System.Console.WriteLine("Nathalia");
            System.Console.WriteLine(string.Join(", ", alunos));
            
            // conjunto nao garante em qual elemento vai ser reposicionado -> no caso Maiara ocupou o exato lugar da Nathalia
            alunos.Remove("Nathalia");
            alunos.Add("Maiara");
            System.Console.WriteLine(string.Join(", ", alunos));

            // ao tentar adicionar elemento que ja existe ele simplesmente ignora
            alunos.Add("Maiara");
            System.Console.WriteLine(string.Join(", ", alunos));

            // criar nova lista para conseguir ordenar de forma alfabética
            List<string> alunosEmLista = new List<string>(alunos);
            alunosEmLista.Sort();
            System.Console.WriteLine(string.Join(", ", alunosEmLista));

        }
    }
}