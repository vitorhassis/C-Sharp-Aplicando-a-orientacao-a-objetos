class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    public bool disponivel;

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duracao: {duracao}");
        Console.WriteLine($"Disponivel: {disponivel}");
        if (disponivel)
        {
            Console.WriteLine("Disponivel no plano");
        } else
        {
            Console.WriteLine("Adquita o plano Plus+");
        }
    }
}
 