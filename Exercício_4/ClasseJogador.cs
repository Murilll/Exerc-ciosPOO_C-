public class Jogador
{
    private int Id { get; set; }
    private string Nome { get; set; }
    private string Posicao { get; set; }
    private string Apelido { get; set; }
    private string DataNascimento { get; set; }
    private int Numero { get; set; }
    private int Qualidade { get; set; }
    private int CartaoAmarelo { get; set; }
    private int CartaoVermelho { get; set; }
  
    public Jogador(int ID, string NOME, string POSICAO, string APELIDO, string DATANASCIMENTO, int NUMERO, int QUALIDADE, int CARTAOAMARELO, int CARTAOVERMELHO)
    {
        this.Id = ID;
        this.Nome = NOME;
        this.Posicao = POSICAO;
        this.Apelido = APELIDO;
        this.DataNascimento = DATANASCIMENTO;
        this.Numero = NUMERO;
        this.Qualidade = QUALIDADE;
        this.CartaoAmarelo = CARTAOAMARELO;
        this.CartaoVermelho = CARTAOAMARELO;
    }


    public string Condicao()
    {
        if (this.CartaoAmarelo >=3 || this.CartaoVermelho>=1)
            return "Suspenso";
        else    
            return "Tá Pra Jogo";
    }

    public void Mostrar(){
        Console.WriteLine($"{this.Posicao}: {this.Numero} - {this.Nome} ({this.Apelido}) - {this.DataNascimento} Condição: {this.Condicao}");
    }
}
