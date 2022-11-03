public class Livros
{
    public string Titulo { get; set; }
    public int qtdPaginas { get; set; }
    public int paginasLidas { get; set; }

    public Livros (string TITULO, int QTDPAGINAS, int PAGINASLIDAS)
    {
        this.Titulo = TITULO;
        this.qtdPaginas = QTDPAGINAS;
        this.paginasLidas = PAGINASLIDAS;
    }

    public double VerificarProgresso()
    {
        int porcentagem = this.paginasLidas * 100 / this.qtdPaginas;
        return porcentagem;
    }
}