public class País
{
    public int Código { get; set; }
    public string Nome { get; set; }
    public int População { get; set; }
    public int Km2 { get; set; }

    public List<País> ListaFronteira{ get; set; } = new List<País>();

    public País (int Código, string Nome, int Km2, int População)
    {
        this.Código = Código;
        this.Nome = Nome;
        this.Km2 = Km2;
        this.População = População;
    }

    public bool Equals(País obj)
    {
        return this.Código == obj.Código;
    }

    public double Densidade() => this.População / this.Km2; 
}