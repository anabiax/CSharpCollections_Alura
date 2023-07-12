namespace CSharpCollections
{
    class Program
    {
        public static void Main(string[] args)
        {
            // COLECAO PILHA    
            var navegador = new Navegador();
            navegador.NavegarPara("google.com");
            navegador.NavegarPara("caelum.com.br");
            navegador.NavegarPara("alura.com.br");

            // Essa funcionalidade: anterior e proximo
            // é implementada internamente como duas pilhas de urls: a primeira pilha permite acessar as páginas anteriores e a segunda as próximas páginas.
            navegador.NavegarPagAnterior();
            navegador.NavegarPagAnterior();
            navegador.NavegarPagAnterior();

            navegador.NavegarParaProximaPagina();

        }
    }
}
