using System;

class Animal
{
    public virtual string EmitirSom()
    {
        return "Som";
    }
}

class Leao : Animal
{
    public override string EmitirSom()
    {
        return "Rooooar!";
    }
}

class Macaco : Animal
{
    public override string EmitirSom()
    {
        return "Uh uh ah ah!";
    }
}


class Elefante : Animal
{
    public override string EmitirSom()
    {
        return "Fuuuuuum!";
    }
}


class Zoologico
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Animais Escolhidos: ");
        string escolha = Console.ReadLine();
        string[] animaisEscolhidos = escolha.Split(',');

    foreach (string nome in animaisEscolhidos)
        {
            switch (nome.Trim())
            {
                case "Leao":
                    Leao leao = new Leao();
                    Console.WriteLine($"Leão: {leao.EmitirSom()}");
                    break;
                case "Macaco":
                    Macaco macaco = new Macaco();
                    Console.WriteLine($"Macaco: {macaco.EmitirSom()}");
                    break;
                case "Elefante":
                    Elefante elefante = new Elefante();
                    Console.WriteLine($"Elefante: {elefante.EmitirSom()}");
                    break;
                default:
                    Console.WriteLine($"Opção inválida: {opcao}");
                    break;
            }
        }


    }
}