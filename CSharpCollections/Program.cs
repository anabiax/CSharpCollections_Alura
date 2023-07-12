namespace CSharpCollections
{
    class Program
    {
        public static void Main(string[] args)
        {
            string aulaIntro = "Introdução às coleções.";
            string aulaModelando = "Modelando a classe aula.";
            string aulaSets = "Trabalhando com conjuntos.";

            // array de strings
            /*
            string[] aulas = new string[]
            {
                aulaIntro, aulaModelando, aulaSets
            };
            */

            string[] aulaS = new string[3]; // declarando explicitamente que haverá 3 elementos
            aulaS[0] = aulaIntro;
            aulaS[1] = aulaModelando;
            aulaS[2] = aulaSets;

            Console.WriteLine(aulaS);
            Imprimir(aulaS);

            System.Console.WriteLine(aulaS[0]);
            System.Console.WriteLine(aulaS[aulaS.Length - 1]);  // último elemento do array

            aulaIntro = "opa";
            Imprimir(aulaS);

            aulaS[0] = "trabalhando com arrays";
            Imprimir(aulaS);

            // procurar a ocorrência da string que eu tô procurando
            System.Console.WriteLine($"A aula modelando está no índice: {Array.IndexOf(aulaS, aulaModelando)}");

            // procurar a última ocorrência do índice       // 1º onde está sendo procurado. 2º o índice a ser buscado
            System.Console.WriteLine(Array.LastIndexOf(aulaS, aulaModelando)); // Array é um método estático da classe Array

            Array.Reverse(aulaS);
            Imprimir(aulaS);

            Array.Resize(ref aulaS, 2);  // redimensiona o tamanho do array original
            Imprimir(aulaS);

            Array.Resize(ref aulaS, 3);
            Imprimir(aulaS);

            // acessando a última posição do meu array
            aulaS[aulaS.Length - 1] = "Conclusão da aula sobre arrays.";
            Imprimir(aulaS);

            // ordenação alfabética = age diretamente no array original
            Array.Sort(aulaS);
            Imprimir(aulaS);

            // copiar um array p/ outro
            string[] copia = new string[2];
            Array.Copy(aulaS, 1, copia, 0, 2);  // Índice inicial (1- 2ª posição). 0 -índice inicial do array de destino. 2 é a qnt de itens que vou copiar  
            System.Console.WriteLine($"O array 'cópia' armazena: {copia}");
            Imprimir(copia);

            string[] clone = aulaS.Clone() as string[]; // fazendo conversão do tipo objeto para string
            Imprimir(clone);

            Array.Clear(clone, 1, 2); // índice 1 e número de elementos que eu quero limpar, no caso 2
            Imprimir(clone);

        }

        private static void Imprimir(string[] aulaS)
        {
            /*
            foreach(var aula in aulaS)
            {
                System.Console.WriteLine(aula);
            }
            */

            // Para cada aula dentro de aulas imprima p/ mim o valor do index da variável aula -> p/ cada item imprima item

            // Essa possibilidade tem mais controle pq captura o avanço do índice. No entanto, é preciso saber os respectivos índices.
            for (int i = 0; i < aulaS.Length; i++)
            {
                System.Console.WriteLine(aulaS[i]);
            }
        }
    }
}