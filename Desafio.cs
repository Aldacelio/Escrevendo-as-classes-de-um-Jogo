using System;

class Heroi
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Tipo { get; set; }

    public Heroi(string nome, int idade, string tipo)
    {
        Nome = nome;
        Idade = idade;
        Tipo = tipo;
    }

    public void Atacar()
    {
        string ataque = "";

        switch (Tipo)
        {
            case "mago":
                ataque = "usou magia";
                break;
            case "guerreiro":
                ataque = "usou espada";
                break;
            case "monge":
                ataque = "usou artes marciais";
                break;
            case "ninja":
                ataque = "usou shuriken";
                break;
            default:
                ataque = "realizou um ataque";
                break;
        }

        Console.WriteLine($"O {Tipo} atacou usando {ataque}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criar uma instância da classe Heroi
        Heroi heroi = new Heroi("Alice", 25, "mago");

        // Chamar o método Atacar
        heroi.Atacar(); // Isso imprime "O mago atacou usando magia"
    }
}
