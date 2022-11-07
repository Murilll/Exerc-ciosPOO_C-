public class DespesasMes
{
    private int mes { get; set; }
    private float valor { get; set; }
    public int cpf { get; set; }

    public Pessoa(int cpf, int mes, float valor)
    {
        this.cpf = cpf;
        this.mes = mes;
        this.valor = valor;
    }

    public int getCPF()
    {
        return cpf;
    }

    public DespesasMes(int mes, float valor)
    {
        this.mes = mes;
        this.valor = valor;
    }

    public int getMes()
    {
        return mes;
    }

    public float getvalor()
    {
        return valor;
    }

    public class DespesaDia
    {
            private int dia;

        public DespesaDia(int dia, int mes, float valor)
        {
            super(mes, valor);
            this.dia = dia;
        }

        public int getDia()
        {
            return dia;
        }
    }
}