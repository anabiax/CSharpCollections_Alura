using System.Collections.ObjectModel;

namespace ListaSomenteLeitura
{
    public class Curso
    {
        private IList<Aula> aulas;
        public IList<Aula> Aulas
        {
            get { return new ReadOnlyCollection<Aula>(aulas); }  // retorna somente leitura -> passa pelo construtor a propria lista
                                                                // codigo externo fica impedido de modificar diretamente o que ta aqui dentro -> principio de encapsulamento
        }

        private string nomeDoCurso;
        private string instrutor;

        public Curso(string nomeDoCurso, string instrutor)
        {
            this.nomeDoCurso = nomeDoCurso;
            this.instrutor = instrutor;
            this.aulas = new List<Aula>(); // instanciando a nova lista de aulas p/ acessá-la sem erros de referencia nula
        }

        public string NomeDoCurso
        {
            get { return nomeDoCurso; }
            set { nomeDoCurso = value; }
        }

        public string Instrutor
        {
            get { return instrutor; }
            set { instrutor = value; }
        }

        public void Adiciona(Aula aula)
        {
            this.aulas.Add(aula);  // acesso o proprio objeto (a lista de aulas) p/ fazer o processamento
        }

        public int TempoTotal
        {
            get
            {
                // LINQ - Language Integrated Query = Consulta Integrada à Linguagem
                return aulas.Sum(aula => aula.Duracao);
            }
        }

        public override string ToString()
        {
            return $"Curso: {nomeDoCurso}, tempo: {TempoTotal} e aulas: {string.Join(", ", aulas)}";  // une as strings e separa por virgulas
        }       
    }
}