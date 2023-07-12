namespace CSharpCollections
{
    class Program
    {
        // lista de uma classe customizada
        public static void Main(string[] args)
        {
                                // instancias do objeto da classe Aula
            var aulaIntro = new Aula("Introducao às colecoes", 20);
            var aulaModelando = new Aula("Modelando a classe aula", 18);
            var aulaSets = new Aula("Trabalhando com conjuntos", 16);


            // lista de objetos do tipo Aula - instância da linguagem
            List<Aula> aulas = new List<Aula>();
            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);
            Imprimir(aulas);

            aulas.Sort();
            Imprimir(aulas);

            // ordenar pelo tempo de duracao via expressao lambda =>
                                // obj inicial e obj final
            aulas.Sort((esteObj, outroObj) => esteObj.Duracao.CompareTo(outroObj.Duracao));

        }

        private static void Imprimir(List<Aula> aulas)
        {
            Console.Clear();
            foreach(Aula aula in aulas)  // pegar cada uma das aulas e imprimir no console
            {
                System.Console.WriteLine(aula);
            }
       }
    }
}