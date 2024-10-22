class Carro
{
    public string fabricante;
    public string modelo;
    public int ano;

    public string DescricaoResumida =>
        $"O carro {fabricante}, modelo {modelo} ano {ano}";

public void FichaTecnica()
{
    Console.WriteLine(DescricaoResumida);
}

}



