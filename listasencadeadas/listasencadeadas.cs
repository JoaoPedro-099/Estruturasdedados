Lista Encadeada !!

Conforme já apresentado, uma lista encadeada (ou ligada) consta de um número indeterminado de elementos dispostos em uma organização física não linear, ou seja, espalhados na memória, denominados nós. Para organizar a lista de maneira que essa possa ser utilizada como um conjunto linear, cada nó tem dois componentes (campos), um valor, que pode ser de qualquer tipo, e um endereço (uma referência) para o nó seguinte da lista. O último nó é representado de maneira diferente para signiticar que esse nó não se liga a nenhum outro, contorme mostrado na Figura 2.

2
Cartão de crédito
1
Primeiro elemento
Prestação de carro
4
Condominio
3
Conta de luz
6
Último elemento
Casas Bahia
5
TV a cabo
Figura 2 - Exemplo de lista encadeada de pagamentos


As listas encadeadas podem ser divididas em quatro categorias:

*   Encadeada simples: cada nó contém um único endereço que o conecta ao nó seguinte ou sucessor, conforme mostrado na Figura 2;

*   Duplamente encadeadas: cada nó contém dois endereços, um ao seu nó antecessor e outro ao seu sucessor. Veja a Figura 3; 

* Ordenadas: a ordem linear da lista corresponde à ordem linear dos elementos.
Assim, quando um novo elemento é inserido, o mesmo deve ser posicionado de tal modo que garanta que a ordem da lista será mantida (veja a Figura 4).
Uma lista ordenada pode ter encadeamento simples ou duplo, porém, o princípio de ordenação é o mesmo;

Circulares: o último elemento se liga ao primeiro elemento, e vice-versa. Essa lista pode ser percorrida de modo circular, tanto da direita para esquerda quanto da esquerda para direita. Conforme mostra a Figura 5.

Sabendo que a alocação fixa de memória por meio de vetor é menos eficiente, então, adotaremos nesta Unidade a alocação de memória dinâmica e implementaremos a lista com ligações simples.

O gerenciamento dos elementos de uma lista é realizado por operações, que
terão as seguintes tarefas:

*   Inicialização ou criação, com declaração dos nós;
*   Inserir elementos em uma lista;
*   Eliminar elementos de uma lista;
*   Buscar elementos de uma lista.

Agora que você já sabe o que é uma lista encadeada simples, vamos implementar as operações; para isso, apresentamos a seguir em C# a lógica inerente de cada um deles.

Criação de um nó !!

Um nó será representado em C# por uma classe, denominada aqui de Node, a qual deve conter um valor (que nesta implementação será um objeto genérico denominado item) e a variável que referenciará o próximo elemento da lista (deno minado prox do tipo Node), conforme apresentado na Figura 6.

class Node
private Object item;
private Node prox;
Node (Object item)
this.item = item;
prox = null;
Figura 6 - Classe que cria a estrutura de nó simples
Fonte: Adaptaddo de Próprio Autor

Observe que, no construtor, o atributo prox recebe nulo, pois, quando um elemento é inserido na lista, ele pode vir a ser o último elemento e, sendo assim, não possui próximo elemento.

Trocando ideias...

Os programas escritos em C# podem ser reutilizados, então a classe Node poderá ser utilizada em vários programas que precisem de um nó de encadeamento simples, tais como pilhas e filas.

Inserir elementos em uma lista !!

Agora que você já conhece a estrutura do nó, podemos inserir novos elementos no início, no fim ou em uma posição específica da lista. Na lógica a seguir (Figura 7), temos, em uma classe chamada ListaSimples, os atributos do tipo Node primeiro e segundo, que referem-se ao primeiro e último nó da lista respectivamen-te, sendo que o último tem a referência para nulo (nulo), e três métodos de inserção de elemento na lista - um método que insere um nó no início da lista (inserelnicio), um que insere em uma posição específica (inserePosicao), veja Figura 8, e outro que insere no final (insereFim) - e ainda um método que retorna a quantidade de elementos da lista (contaNos).

Para que a operação possa ocorrer no início ou final da lista, você precisa saber qual é o primeiro nó e o último, ou seja, o nó cabeça, que conterá o primeiro elemento da lista, e o nó cauda, que contém o último elemento da lista.


Excluir elemento da lista !!

A partir da operação de exclusão, apresentaremos apenas o método correspon-dente, lembrando que esse e os demais foram desenvolvidos no escopo da classe ListaSimples, apresentada na Figura 7.

O método de exclusão de um elemento da lista (Figura 9) recebe como parâmetro o objeto genérico item que deverá ser excluído da lista. Quando esse é encon-trado, então é necessário que se deixe de fazer referência a ele e aponte para o próximo elemento do próximo.

void excluiNo (Object item)
{
Node
aux = primeiro;
while (aux != null && aux.getItem()!=item)
aux = aux.getProx);
}
aux.setProx(aux.getProx().getProx());
if (ultimo == aux-getProx).
ultimo = aux;
}
Figura 9 - Método excluiNo da classe ListaSimples
Fonte: Próprio Autor

Buscar elemento em uma lista !!

O método de buscar de um elemento da lista (Figura 10) recebe como parâmetro o objeto genérico item que deverá ser pesquisado na lista. Para isso, é feita a varredura de todos os nós da lista por meio da estrutura de repetição while. Nessa, é comparado o campo item do nó da lista com o item passado como parâmetro - quando são iguais, retorna o nó; caso não encontre, retorna nulo.

Com esses métodos, você é capaz de utilizar a estrutura de dados lista para resolver problemas na área de jogos que sejam possíveis de serem aplicados à lógica aqui apresentada. Observe que, após você entender a da lista encadeada simples, os outros tipos de listas podem ser implementados.
Códigs apostila

Criação de nó !!

// Figura 6 - Classe que cria a estrutura de nó simples

public class Node
{
    private object item;
    private Node prox;

    public Node(object item)
    {
        this.item = item;
        prox = null;
    }

    // Getters e setters opcionais, se necessário

    public object Item
    {
        get { return item; }
        set { item = value; }
    }

    public Node Prox
    {
        get { return prox; }
        set { prox = value; }
    }
}




Inserir elementos em uma lista !!! 

// Figura 7 - Lista Simples, com os métodos insereInicio, insereFim, inserePosicao e contaNos

public class ListaSimples
{
    public object primeiro { get; private set; }
    public object ultimo { get; private set; }

    private Node primeiro, ultimo;
    private int qtdeNos;

    public ListaSimples()
    {
        primeiro.Prox = null;
        ultimo.Prox = null;
    }

    public void insereFim(Node novo)
    {
        novo.Prox = null;
        if (this.primeiro == null)
        {
            this.primeiro = novo;
        }
        if (this.ultimo != null)
        {
            this.ultimo.Prox = novo;
        }
        this.ultimo = novo;
    }

    public void insereInicio(Node novo)
    {
        if (this.primeiro != null)
        {
            novo.Prox = primeiro;
        }
        else
        {
            if (this.primeiro == null)
            {
                this.primeiro = novo;
            }
            this.ultimo = novo;
        }
        this.primeiro = novo;
    }

    public void inserePosicao(Node novo, int pos)
    {
        Node aux = primeiro;
        int qtde = contaNos();
        int pos_aux;

        if (pos == 0)
        {
            novo.Prox = primeiro;
            if (primeiro == ultimo)
            {
                ultimo = novo;
            }
            primeiro = novo;
        }
        else if (pos <= qtde)
        {
            pos_aux = 1;
            while (aux != null && pos > pos_aux)
            {
                aux = aux.Prox;
                pos_aux++;
            }
            novo.Prox = aux.Prox;
            aux.Prox = novo;
        }
        else if (pos > qtde)
        {
            ultimo.Prox = novo;
            ultimo = novo;
        }
    }

    public int contaNos()
    {
        int tam = 0;
        Node aux = primeiro;
        while (aux != null)
        {
            tam++;
            aux = aux.Prox;
        }
        return tam;
    }
}




Excluir elementos da lista !!

// Figura 9 - Método excluiNo da classe ListaSimples

public void excluiNo(object item)
{
    Node aux = primeiro;
    Node anterior = null;

    while (aux != null && aux.Item != item)
    {
        anterior = aux;
        aux = aux.Prox;
    }

    if (aux != null) // Verifica se o nó foi encontrado
    {
        if (anterior == null) // Se o nó a ser excluído é o primeiro
        {
            primeiro = aux.Prox;
            if (primeiro == null) // Se a lista ficou vazia
            {
                ultimo = null;
            }
        }
        else
        {
            anterior.Prox = aux.Prox;
            if (ultimo == aux) // Se o nó a ser excluído é o último
            {
                ultimo = anterior;
            }
        }
    }
}


Buscar elementos em uma lista !!!

// Figura 10 - Método buscaNo da classe ListaSimples

public Node buscaNo(object item)
{
    int i = 0;
    Node aux = primeiro;

    while (aux != null)
    {
        if (aux.Item.Equals(item)) // Usar Equals() para comparar objetos
        {
            return aux;
        }
        i++;
        aux = aux.Prox;
    }

    return null;
}
