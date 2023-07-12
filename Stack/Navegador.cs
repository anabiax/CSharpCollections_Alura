namespace CSharpCollections
{
    public class Navegador
    {
        private string paginaAtual = "vazia";
        private readonly Stack<string> historicoAnterior = new Stack<string>();
        private readonly Stack<string> historicoProximo = new Stack<string>();

        // "qnd o navegador for instanciado eu quero que seja impresso no console a pagina atual"
        public Navegador()
        {
            System.Console.WriteLine($"Página atual: {paginaAtual}");
        }

        public void NavegarPara(string url)   // ele deve definir a página atual como a url que está sendo recebida como parâmetro pelo método(no Program).
        {
                            // sempre adiciona o elemento no topo da pilha 
            historicoAnterior.Push(paginaAtual);  // salva a paginaAtual no historicoAnterior
            paginaAtual = url;              // trocar os valores de 'atual' para 'url'
            System.Console.WriteLine($"Página atual: {paginaAtual}");
        }


        // Esse método deve pegar o valor da última url navegada e defini-lo como url atual.
        public void NavegarPagAnterior()
        {
            // "tem algum elemento? Se sim, remove."
            if(historicoAnterior.Any())
            {
                historicoProximo.Push(paginaAtual);  
                paginaAtual = historicoAnterior.Pop();   // pega o prox elemento da fila
                System.Console.WriteLine($"Página atual: {paginaAtual}");
            }
        }

        public void NavegarParaProximaPagina()
        {
            if(historicoProximo.Any())
            {   
                historicoAnterior.Push(paginaAtual);
                paginaAtual = historicoProximo.Pop();   // retira e retorna o elemento do topo da pilha.
                System.Console.WriteLine($"Pagina atual: {paginaAtual}");
            }
        }
    }
}