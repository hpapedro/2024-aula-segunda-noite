//1 - Criar uma variável ou um vetor
//2 - Criar um laço para percorrer o vetor 
//3 - Para cada posição gerar um valor aleatório 
//4 - Ordenar o vetor

int tamanho = 10;
int[] vetor = new int[tamanho];

//Gerando um vetor com valores aleatórios
Random random = new Random();
for (int i = 0; i < vetor.Length; i++)
{
    vetor[i] = random.Next(1000);

}

//Imprimir o vetor com valores sem ordenação 
for (int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}

//Ordenação do vetor com Bubble Sort
bool troca = false;
do
{
    troca = false;
for (int i = 0; i < vetor.Length - 1; i++)
{
    if (vetor[i] > vetor[i + 1])
    {
        int aux = vetor[i];
        vetor[i] = vetor[i + 1];
        vetor[i + 1] = aux;
        troca = true;
    }
}
    
} while (troca);

Console.WriteLine(" ");
//Imprimir o vetor com valores ordenados
for (int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}


//O gabriel ta doente