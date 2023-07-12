using System.Collections.ObjectModel;

namespace CSharpCollections
{
    public class Curso
    {
        private IList<Aula> aulas;
        public IList<Aula> Aulas
        {
            get { return new ReadOnlyCollection<Aula>(aulas); }
        }
        
        private ISet<Aluno> alunos = new HashSet<Aluno>();
        public IList<Aluno> Alunos
        {
            get { return new ReadOnlyCollection<Aluno>(alunos.ToList()); }
        }


        // tipo da chave e do valor
        private IDictionary<int, Aluno> dicionarioAlunos = new Dictionary<int, Aluno>();

        private string nomeDoCurso;
        private string instrutor;

        public Curso(string nomeDoCurso, string instrutor)
        {
            this.nomeDoCurso = nomeDoCurso;
            this.instrutor = instrutor;
            this.aulas = new List<Aula>();
        }

        public string NomeDoCurso
        {
            get { return nomeDoCurso;}
            set { nomeDoCurso = value; }
        }

        public string Instrutor
        {
            get { return instrutor;}
            set { instrutor = value; }
        }

        public void Adiciona(Aula aula)
        {
            this.aulas.Add(aula); // acesso o próprio (a lista de aulas) p/ fazer o processamento
        }

        public int TempoTotal
        {
            get
            {
                // LINQ - Language Integrated Query = Consulta Integrada à Linguagem
                return aulas.Sum(aula => aula.Duracao);

                // "retorne p/ a minha colecao de aulas a soma dos tempos de cada aula"
                // para cada aula retorne aula.Tempo (duracao)
            }
        }

        public override string ToString()
        {
            return $"Curso: {nomeDoCurso}, tempo: {TempoTotal} e aulas: {string.Join(", ", aulas)}"; // une as strings e separa por meio de virgulas
        }

        public void Matricula(Aluno aluno)
        {
            alunos.Add(aluno);
            dicionarioAlunos.Add(aluno.Matricula, aluno); // o valor é o proprio aluno. Relaciona o numero de matricula com o aluno no HashSet
        }


        public bool EstaMatriculado(Aluno aluno)
        {
            return alunos.Contains(aluno);
        }

        public Aluno BuscaMatriculado(int numeroMatricula) // o intuito de fato é buscar pelo numero de matricula
        {
            /*
            foreach(var alunoEncontrado in alunos)
            {
                if(alunoEncontrado.Matricula == numeroMatriculado)
                {
                    return alunoEncontrado;
                }
            }

            throw new KeyNotFoundException($"Matricula nao encontrada {numeroMatriculado}.");
            */

            Aluno aluno = null;
            dicionarioAlunos.TryGetValue(numeroMatricula, out aluno); // out significa q é um parametro de saida -> se n encontrar retorna nulo
            return aluno; // esse cara pode ter sido encontrado ou nao, mas p/ n estourar excecao deve passar isso
        }

        public void SubstituiAluno(Aluno aluno)
        {
            dicionarioAlunos[aluno.Matricula] = aluno;  // substitui numa certa posicao por meio das chaves, assim como no array
        }
    }
}