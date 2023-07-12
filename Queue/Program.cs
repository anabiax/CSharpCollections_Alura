namespace CSharpCollections
{
    class Program
    {
        // variável estática do escopo da classe
        static Queue<string> pedagio = new Queue<string>();

        public static void Main(string[] args)
        {
            Enfileirar("Van");
            Enfileirar("Kombi");
            Enfileirar("Guincho");
            Enfileirar("Picape");

            // carro liberado
            Desenfileirar();

            // saber o veiculo que está p/ sair da fila
            Desenfileirar();

        }

        public static void Enfileirar(string veiculo)
        {
            System.Console.WriteLine($"Entrou na fila: {veiculo}.");
            pedagio.Enqueue(veiculo); // p/ adicionar(enfileirar) os veiculos
            ImprimirFila();

        }

        private static void ImprimirFila()
        {
            System.Console.WriteLine($"Fila:");
            foreach(var item in pedagio)
            {
                System.Console.WriteLine(item);
            }
        }

        private static void Desenfileirar()
        {
            if(pedagio.Any())
            {
                if(pedagio.Peek() == "Guincho")  // permite pegar o elemento que está esperando - "dar uma espiada" no prox a sair da fila
                {
                    System.Console.WriteLine($"O proximo a sair da fila é o guincho");
                    System.Console.WriteLine($"Guincho encaminhado para realizar o pagamento.");
                }

                var veiculo = pedagio.Dequeue();  // o primeiro que entra é o primeiro que sai
                System.Console.WriteLine($"Saiu da fila: {veiculo}");
                ImprimirFila();
            }
        }
    }
}