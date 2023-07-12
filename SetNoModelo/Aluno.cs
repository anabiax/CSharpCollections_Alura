namespace CSharpCollections
{
    public class Aluno
    {
        public string Nome { get; set; }
        public int Matricula { get; set; }

        public Aluno(string nome, int matricula)
        {
            Nome = nome;
            Matricula = matricula;
        }

        public override string ToString()  // sobreescreve p/ aparecer no console os detalhes do Aluno
        {
            return $"[Nome: {Nome}, Matricula: {Matricula}]";
        }

        // aqui eu n quero comparar instâncias, mas os nomes. 
        public override bool Equals(object? obj)
        {
            Aluno outro = obj as Aluno;  // "obj convertido p/ Aluno (um tipo específico)"
            
            if(outro == null)
            {
                return false;
            }

            return this.Nome.Equals(outro.Nome);
        }

        // SEMPRE QUE O EQUALS FOR IMPLEMENTADO O GETHASHCODE DEVE ACOMPANHÁ-LO
        // importante: a rapidez da busca depende do CÓDIGO DE DISPERSAO -> isto é, do GetHashCode funcionar corretamente
        public override int GetHashCode() // esse cara retorna o mesmo numero de dispersao p/ objetos considerados iguais
        {
            return this.Nome.GetHashCode();  // por hora leia "hash" como valor
        }
    }
}