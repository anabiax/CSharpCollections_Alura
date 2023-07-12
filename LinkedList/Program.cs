namespace CSharpCollections
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> frutas = new List<string>
            {
                "abacate", "banana", "mexerica", "laranja", "caqui"
            };

            foreach(var item in frutas)
            {
                System.Console.WriteLine(item);
            }

            // LISTA LIGADA (LINKED LIST)
            // elementos n precisam estar em sequência na memória p/ representar a ordem que eu quero
            // cada elemento é um 'nó' que contem um valor
            LinkedList<string> diasDaSemana = new LinkedList<string>();
            var d4 = diasDaSemana.AddFirst("quarta-feira");
            System.Console.WriteLine($"d4.Value: {d4.Value}");  // acessar o valor do nó(da variável)


            // adiciona segunda antes de quarta(antes de um nó conhecido)
            var d2 = diasDaSemana.AddBefore(d4, "segunda-feira");
            // agr os nós d4 e d2 estao ligados

            // acessar um nó atraves do outro
            var d3 = diasDaSemana.AddAfter(d2, "terca-feira"); // ponteiros foram redirecionados -> agr esse cara está no meio das duas referencias

            var d6 = diasDaSemana.AddAfter(d4, "sexta-feira");

            var d7 = diasDaSemana.AddAfter(d6, "sabado");

            var d5 = diasDaSemana.AddBefore(d6, "quinta-feira");

            var d1 = diasDaSemana.AddBefore(d2, "domingo");

            foreach(var item in diasDaSemana)
            {
                System.Console.WriteLine(item);
            }

            // LinkedList NAO DA suporte ao acesso de indice: diasDaSemana[0] -> NAO USAR O LACO *FOR* aqui

            // p/ fazer muitas buscas o linked list nao é eficiente

            // p/ remover um elemento podemos tanto: remover pelo valor qnt pela referencia do LinkedList
            //diasDaSemana.Remove(d4);

            diasDaSemana.Remove("quarta-feira");
            foreach(var item in diasDaSemana)
            {
                System.Console.WriteLine(item);
            }

        }
    }
}