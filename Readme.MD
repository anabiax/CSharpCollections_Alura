# ORDENACAO DAS AULAS

1- CSharpCollections (arrayzao p/ arquivos de baixo nivel(ler bytes, numeros int) e/ou trabalhar com colecoes de tamanho fixo); <br>
2- List (+ flexível de todas e a mais poderosa) -> permite inserir elementos em qqr posicao da colecao; <br>
    2.1 -> ListasDeObjetos; <br>
    2.2 -> ListaSomenteLeitura. <br>
3- OPoderDosSets -> HashSet -> verifica se um elemento está contido no conjunto; <br>
4- SetNoModelo -> Dictionary -> buscar valor através de uma chave(buscar cliente por CPF ou CNPJ);  <br>
5- LinkedList -> otimizada para adicionar e remover muitos elementos com bastante frequência(é + rapida). Nao é recomendado p/ buscas; <br>
6- Stack -> similar ao exemplo da vida real de uma pilha de pratos(os últimos pratos colocados na pilha são os primeiros a serem retirados dela); <br>
7- Queue -> é uma coleção protegida contra inserção e remoção aleatória de elementos: em vez disso, uma fila possui regra de prioridade, em que o primeiro que entre é o primeiro que sai. <br>


Pilha(stack) X Fila(queue) <br>
1- Pilha: o primeiro que entra é o último que sai; <br>
2- Fila: o primeiro que entra é o último que sai. E o último que entra é o primeiro que sai.


- Uma coleção List é ineficiente para inserir ou remover elementos no início da coleção, porque os elementos precisam ser reposicionados com frequência.

- Se quisermos adicionar ou remover elementos com muita frequência, podemos considerar um LinkedList. <br>
    Um LinkedList consegue armazenar elementos numa determinada ordem, porém, na memória, os elementos de um LinkedList não precisam ocupar uma posição sequencial.

- A coleção Dictionary não suporta chaves repetidas, e permite que os elementos sejam acessados pelo indexador.