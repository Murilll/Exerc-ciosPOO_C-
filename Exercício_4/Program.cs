List<Jogador> Time1 = new List<Jogador>();
for (int j = 0; j < 11; j++)
{
    Console.Clear();

    Console.Write($"Digite o ID do {j+1}° Jogador: ");
    int IDUser = int.Parse(Console.ReadLine() ?? "0");

    Console.Write($"Digite o Nome do Jogador: ");
    string NomeUser = Console.ReadLine() ?? "Desconhecido";

    Console.Write($"Digite a Posição do {NomeUser}: ");
    string PosicaoUser = Console.ReadLine() ?? "Desconhecido";

    Console.Write($"Digite o Apelido do {NomeUser}: ");
    string ApelidoUser = Console.ReadLine() ?? "Desconhecido";

    Console.Write($"Digite a Data de Nascimento do {NomeUser}: ");
    string DataUser = Console.ReadLine() ?? "Desconhecido";

    Console.Write($"Digite o Número do {NomeUser}: ");
    int NumUser = int.Parse(Console.ReadLine() ?? "0");

    Console.Write($"Digite a qualidade do {NomeUser}: ");
    double QualidadeUser = int.Parse(Console.ReadLine() ?? "0");

    Console.Write($"Digite a Quantidade de Cartões Amarelos o {NomeUser} recebeu: ");
    int AmareloUser = int.Parse(Console.ReadLine() ?? "0");

    Jogador Player = new Jogador(IDUser, NomeUser, PosicaoUser, ApelidoUser, DataUser, NumUser, QualidadeUser, AmareloUser);
    Time1.Add(Player);
}

for (int k = 0; k<Time1.Count(); k++)
    Time1[k].MostrarTudo();