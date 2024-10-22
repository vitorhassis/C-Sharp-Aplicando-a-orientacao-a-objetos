class Carro
{
    public string fabricante { get; set; }
    public string modelo { get; set; }
    public int anoCarro
    {
        get => anoCarro;
        set
        {
            if (value>=1960 && value<=2023)
            {
                anoCarro = value;
            } else
            {
                Console.WriteLine("O ano deve estar entre 1960 e 2023");
            }
        }
    }

    public string FichaTecnica => $"O carro {fabricante} modelo {modelo} do ano {anoCarro}";
}