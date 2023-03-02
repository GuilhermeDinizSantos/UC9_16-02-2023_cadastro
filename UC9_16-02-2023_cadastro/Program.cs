string[,] cadastro = new string[5,3];
string loop = "";
int linha, coluna, ano;
string busca = "";
int encontrou = 0;
linha = 0;
coluna = 0;
ano = 2023;
    for (linha = 0; linha < 5; linha++)
    {
        Console.Clear();
        Console.WriteLine("->Insira seu nome: ");
        cadastro[linha, coluna++] = Console.ReadLine();
        Console.WriteLine("->Insira seu sobrenome: ");
        cadastro[linha, coluna++] = Console.ReadLine();
        Console.WriteLine("->Insira seu ano de nascimento: ");
        cadastro[linha, coluna++] = Console.ReadLine();
    coluna = 0;
    }
while (loop != "N")
{
    encontrou = 0;
    Console.Clear();
    Console.WriteLine("Informe o nome que deseja buscar: ");
    busca = Console.ReadLine();
    linha = 0;
    for (linha = 0;linha < 5; linha++)
    {
        if (busca == cadastro[linha, 0])
        {
            Console.WriteLine("Você encontrou " + cadastro[linha, 0] + "\nEsta pessoa atende pelo sobrenome de " + cadastro[linha, 1] + " e tem "+ (ano - int.Parse(cadastro[linha, 2])) +" anos de idade");
            encontrou = 8;
        }
        if (encontrou != 8)
        {
            Console.WriteLine("Pessoa não encontrada");
            linha = 5;
        }
    Console.WriteLine("Deseja buscar outra pessoa? S / N");
    loop = Console.ReadLine();
}