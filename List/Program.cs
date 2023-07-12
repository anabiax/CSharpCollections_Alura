namespace List
{
    class Program
    {
        public static void Main(string[] args)
        {
            string aulaIntro = "Introducao às colecoes";
            string aulaModelando = "Modelando a classe aula";
            string aulaSets = "Trabalhando com conjuntos";

            // o tipo que esta lista irá conter
            /*
            List<string> aulas = new List<string>    // nova instancia de uma string
            {
                aulaIntro, aulaModelando, aulaSets
            };
            */

            // aqui n define os elementos iniciais
            List<string> aulas = new List<string>();
            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);
            Imprimir(aulas);

            System.Console.WriteLine($"A primeira aula é: {aulas[0]}");
            System.Console.WriteLine($"A primeira aula é: {aulas.First()}");

            System.Console.WriteLine($"A ultima aula é: {aulas[aulas.Count -1]}");  // Count é pareável com List
            System.Console.WriteLine($"A ultima aula é: {aulas.Last()}");

            aulas[0] = "trabalhando com listas";
            Imprimir(aulas);

            System.Console.WriteLine($"A primeira aula 'trabalhando' é: {aulas.First(aula => aula.Contains("trabalhando"))}");
            System.Console.WriteLine($"A última aula trabalhando é: {aulas.Last(aula => aula.Contains("trabalhando"))}");
        
            System.Console.WriteLine($"A aula 'conclusao' é: {aulas.FirstOrDefault(aula => aula.Contains("Conclusao"))}");  // substitui por nulo caso n encontre
        
            aulas.Reverse();
            Imprimir(aulas);

            aulas.RemoveAt(aulas.Count -1); // ultimo elemento da lista
            Imprimir(aulas);

            aulas.Add("conclusao da aula");
            aulas.Sort();
            Imprimir(aulas);

                                                        // obtem os dois ultimos elementos da lista de aulas. Começo no penultimo e vou ate o ultimo
            List<string> copia = aulas.GetRange(aulas.Count -2, 2);
            Imprimir(aulas);

            // obtem lista a partir de aulas via construtor
            List<string> clone = new List<string>(aulas);
            Imprimir(clone);

            // remover faixa de valores
            clone.RemoveRange(clone.Count -2, 2);

        }

        private static void Imprimir(List<string> aulas)
        { 
            /* varrerá cada elemento das aulas
            foreach(var aula in aulas)          // para cada elemento aula irá varrer a colecao de aulas
            {
                System.Console.WriteLine(aula);
            }
            */

            /* LENGTH n faz parte do objeto List<string>
            for(var i=0; i < aulas.Count; i++)  // count tem o mesmo significado de length, mas serve p/ Lista
            {                                              // acessar atraves do indice i
                System.Console.WriteLine(aulas[i]);
            }
            */

            aulas.ForEach(aula => {           // "para cada aula vai executar X coisa" 
                System.Console.WriteLine(aula);
            });
        }
    }
}