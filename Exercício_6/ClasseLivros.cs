public class Livros
{
    private string Titulo { get; set; }
    private int qtdPaginas { get; set; } // daria para puxar a quantidade de pg direto se ela não fosse publica
    private int paginasLidas { get; set; }

    public Livros (string TITULO, int QTDPAGINAS, int PAGINASLIDAS)
    {
        this.Titulo = TITULO;
        this.qtdPaginas = QTDPAGINAS;
        this.paginasLidas = PAGINASLIDAS;
    }

    public double VerificarProgresso()
    {
        double porcentagem = this.paginasLidas * 100.0 / this.qtdPaginas;
        return porcentagem;
    }

    public string TituloDoLivro()
    { 
        return this.Titulo;
    }

    public int Paginas()
    {
        return this.qtdPaginas;
    }
}
