Árvores !!

As estruturas apresentadas até aqui são chamadas de lineares. A importância dessas estruturas é inegável, porém, elas não são adequadas para representar dados que devem ser dispostos de maneira hierárquica. A estrutura que preenche essa lacuna é a árvore.

Uma árvore é uma estrutura bidimensional, não linear (Figura 15), que possui propriedades especiais e admite muitas operações de conjuntos dinâmicos, tais como a consulta, insercão, remoção. entre outros.

Figura 15 - Representação de uma estrutura dedados árvore
Fonte: Adaptado de Ascencio (2010)

As características de árvores são (Figura 16):
*   nó raiz: nó no topo da árvore, do qual descendem o os demais nós; é o primeiro nó da árvore;

*   nó interior: nó do interior da árvore (que possui descendentes);

*   nó terminal: nó que não possui descendentes;

*   trajetória: número de nós que devem ser percorridos até o nó determinado;

*   grau do nó: número de nós descendentes do nó, ou seja, o número de subár-vores de um nó;

*   grau da árvore: número máximo de subárvores de um nó;

*   altura da árvore: número máximo de níveis dos seus nós.

Podemos utilizar árvores binárias para armazenamento temporário de conjunto de elementos e pode ser implementada com armazenamento dinâmico, através de listas duplamente encadedas. Com relação ao tipo, elas podem ser do tipo listas generalizadas ou binárias. Nas árvores binárias, cada nó possui, no máximo, dois filhos. Nesta Unidade, abordaremos apenas as árvores binárias.

Árvores binárias !!

Uma árvore binária pode ser nula, e assim como qualquer árvore possui um elemento denominado raiz, e os demais elementos são particionados em T, e T2, estruturas disjuntas de árvore binária. A subárvore da esquerda é denominada T, e a da direita Tz

Nesse tipo de árvore também existe a particularidade quanto à posição dos nós.
Os nós da direita sempre possuem valor superior aos do nó pai, e os da esquerda sempre possuem valor inferior ao do nó pai (veja a Figura 17).

Para a manipulação de árvore, existe uma grande similaridade com os nós criados para manipular listas, por isso utilizaremos os mesmos princípios, criaremos uma classe BTreeNo (Figura 18), a qual implementa o nó da árvore e contém os atributos item do tipo int, o que possibilita manipular números inteiros com o objetivo de facilitar o entendimento da lógica - mas vale lembrar que a árvore manipula qualquer tipo de dados e os atributos esq e dir do tipo TreeNo. A cada novo nó inserido na árvore, uma instância da classe BTreeNo será criada, ou seja, um novo objeto nó.


Inserir nó em uma árvore !!

Após definir a estrutura do nó da árvore, o próximo passo é criar a classe ár-vore, que será instanciada toda vez que uma nova árvore for criada, contendo os métodos que possibilitem operações de inserção e exclusão de nós. Os métodos de inserção são apresentados na Figura 19.


De acordo com a lógic acima apresentada, o objeto BTreeNo será instanciado toda vez que um novo nó for inserido na árvore. O método inserirNo é o responsável em receber o valor a ser inserido e, então, ele chama o método inserir, que recebe como parâmetro um valor do tipo BTreeNo (chamado no código de árvore) e um valor inteiro. Esse percorre recursivamente a árvore a partir da raiz, buscando uma posição de referência nula para inserir o novo elemento.

Quando a estrutura de dados está vazia, o método insere o novo elemento na raiz; quando a estrutura já tem elementos armazenados, o método verifica se o valor a ser inserido é maior ou menor que o nó. Caso seja menor, será inserido à es-querda; caso contrário, insere-se à direita. A recursividade é utilizada para percorrer os nós até encontrar um nó vazio (null) que possibilita a inserção de um novo nó.


Exibir nós de uma árvore !!


A partir da operação para exibir os valores, apresentaremos apenas o método correspondente, lembrando que esse e os demais foram desenvolvidos no escopo da classe BIree, apresentada na Figura 19.

Assim como o método inserirNo, os métodos exibirNoEsq e exibirNoDir não recebem parâmetros e chamam os métodos exibirEsquerdo ou exibiDireito, e passa como parâmetro o nó denominado raiz. Os métodos exibirEsquerdo e exibir Direito recebem como parâmetro um objeto do tipo BIreeNo, que é passado pelo método exibirNoEsq ou exibir NoDir; e que, por meio de chamadas recur-sivas, buscam os nós à esquerda ou à direita da árvore, até que não encontrem um nó nulo. Esse percurso garante a impressão sempre na ordem ascendente de valor.


Excluir nó de uma árvore !!


A exclusão de um nó da árvore requer uma lógica mais complexa, uma vez que as referências ao nó excluído e seus filhos precisam ser devidamente ajustados.
A lógica a seguir, Figura 21, apresenta o método de exclusão, que recebe como parâmetro o valor do elemento a ser excluído.
Árvors binárias !!!


// Figura 18 - Classe que cria a estrutura de nó da árvore

public class BTreeNo
{
    private int valor;
    private BTreeNo esq;
    private BTreeNo dir;

    public BTreeNo(int valor)
    {
        this.valor = valor;
    }

    public int Valor
    {
        get { return valor; }
        set { valor = value; }
    }

    public BTreeNo Esq
    {
        get { return esq; }
        set { esq = value; }
    }

    public BTreeNo Dir
    {
        get { return dir; }
        set { dir = value; }
    }
}



Inserir nó em uma árvore !!


// Figura 19 - Classe que cria a estrutura de nó da árvore


public class BTree
{
    private BTreeNo raiz;

    private BTreeNo inserir(BTreeNo arvore, int novo)
    {
        BTreeNo aux = new BTreeNo(novo); // Cria um novo nó com o valor

        if (arvore == null)
        {
            return aux; // Se a árvore estiver vazia, retorna o novo nó como raiz
        }
        else if (novo < arvore.Valor)
        {
            arvore.Esq = inserir(arvore.Esq, novo); // Insere na subárvore esquerda
        }
        else
        {
            arvore.Dir = inserir(arvore.Dir, novo); // Insere na subárvore direita
        }

        return arvore; // Retorna a árvore modificada
    }

    public void inserirNo(int novo)
    {
        raiz = inserir(raiz, novo); // Chama o método recursivo para inserir o novo nó
    }
}




Exibir nós de uma árvore !!!


// Figura 20 - Métodos de exibição de nós na árvore binária


public void exibirEsquerdo(BTreeNo arv)
{
    if (arv != null)
    {
        exibirEsquerdo(arv.Esq); // Correção: arv.Esq em vez de arv.getEsq()
        Console.WriteLine(arv.Valor); // Correção: arv.Valor em vez de arv.getValor()
    }
}

public void exibirDireito(BTreeNo arv)
{
    if (arv != null)
    {
        exibirDireito(arv.Dir); // Correção: arv.Dir em vez de arv.getDir()
        Console.WriteLine(arv.Valor); // Correção: arv.Valor em vez de arv.getValor()
    }
}

public void ExibirRaiz()
{
    if (raiz != null)
    {
        Console.WriteLine("Raiz: " + raiz.Valor); // Correção: raiz.Valor em vez de raiz.getValor()
    }
    else
    {
        Console.WriteLine("Árvore vazia"); // Adicionado para lidar com árvore vazia
    }
}

public void exibirNoEsq()
{
    exibirEsquerdo(raiz);
}

public void exibirNoDir()
{
    exibirDireito(raiz);
}




Excluir nó de umq árvore !!


// Figura 21 - Métodos de exclusão de nó na árvore binária

public void exluirNo(int item)
{
    BTreeNo aux = raiz, pai = null, filho = raiz, temp;


    // Busca o nó a ser excluído e seu pai

    while (aux != null && aux.Valor != item) // Correção: aux.Valor em vez de aux.getValor()
    {
        pai = aux;
        if (item < aux.Valor) // Correção: aux.Valor em vez de aux.getValor()
        {
            aux = aux.Esq; // Correção: aux.Esq em vez de aux.getEsq()
        }
        else
        {
            aux = aux.Dir; // Correção: aux.Dir em vez de aux.getDir()
        }
    }

    if (aux == null)
    {
        Console.WriteLine("Valor não encontrado");
        return;
    }


    // Caso 1: Nó a ser excluído não tem filhos ou tem apenas um filho


    if (aux.Dir == null) // Correção: aux.Dir em vez de aux.getDir()
    {
        if (pai == null) // Nó a ser excluído é a raiz
        {
            raiz = aux.Esq; // Correção: aux.Esq em vez de aux.getEsq()
        }
        else if (pai.Esq == aux) // Correção: pai.Esq em vez de pai.getEsq()
        {
            pai.Esq = aux.Esq; // Correção: pai.Esq em vez de pai.getEsq() e aux.Esq em vez de aux.getEsq()
        }
        else
        {
            pai.Dir = aux.Esq; // Correção: pai.Dir em vez de pai.getDir() e aux.Esq em vez de aux.getEsq()
        }
    }
    else if (aux.Esq == null) // Correção: aux.Esq em vez de aux.getEsq()
    {
        if (pai == null) // Nó a ser excluído é a raiz
        {
            raiz = aux.Dir; // Correção: aux.Dir em vez de aux.getDir()
        }
        else if (pai.Esq == aux) // Correção: pai.Esq em vez de pai.getEsq()
        {
            pai.Esq = aux.Dir; // Correção: pai.Esq em vez de pai.getEsq() e aux.Dir em vez de aux.getDir()
        }
        else
        {
            pai.Dir = aux.Dir; // Correção: pai.Dir em vez de pai.getDir() e aux.Dir em vez de aux.getDir()
        }
    }


    // Caso 2: Nó a ser excluído tem dois filhos

    else
    {
        temp = aux;
        filho = aux.Esq; // Correção: aux.Esq em vez de aux.getEsq()

        while (filho.Dir != null) // Correção: filho.Dir em vez de filho.getDir()
        {
            temp = filho;
            filho = filho.Dir; // Correção: filho.Dir em vez de filho.getDir()
        }

        if (filho != aux.Esq) // Correção: aux.Esq em vez de aux.getEsq()
        {
            temp.Dir = filho.Esq; // Correção: temp.Dir em vez de temp.getDir() e filho.Esq em vez de filho.getEsq()
            filho.Esq = aux.Esq; // Correção: filho.Esq em vez de aux.getEsq()
        }

        filho.Dir = aux.Dir; // Correção: aux.Dir em vez de aux.getDir()

        if (pai == null) // Nó a ser excluído é a raiz
        {
            raiz = filho;
        }
        else if (pai.Esq == aux) // Correção: pai.Esq em vez de pai.getEsq()
        {
            pai.Esq = filho; // Correção: pai.Esq em vez de pai.getEsq()
        }
        else
        {
            pai.Dir = filho; // Correção: pai.Dir em vez de pai.getDir()
        }
    }
}
Primeiramente, é feita uma busca nos diversos nós da árvore, comparando o valor passado como parâmetro com o valor do nó e, após isso, são tratados os diversos cenários que podem acontecer - tais como percorrer totalmente a árvore e não encontrar o valor; o nó pesquisado ser o nó raiz; nós sem filhos a direita ou a esquerda. Já para os nós com filhos à esquerda e à direita, é feita uma busca pelo elemento mais à direita do ramo esquerdo da árvore (maior valor em relação à raiz que será excluída) e esse elemento é trocado pela raiz e as referências atualizadas.
conforme a Figura 22.

Caso o elemento pai não seja nulo, isso significa que o nó a ser excluído não é o nó raiz; e se o nó a ser excluído não possuir filho à direita, a referência do nó pai será trocada pela do nó a ser excluído (a mesma lógica é aplicada caso o nó não possuir filhos à esquerda). No cenário do nó a ser excluído possuir filhos à esquerda e à direita, é aplicada a mesma lógica de exclusão do nó raiz, porém, devem ser ajustas as referências do pai do nó a ser excluído.
