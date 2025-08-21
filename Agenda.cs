using System;
using System.Collections.Generic;

//Parte 1
class Contato
{
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }

    public Contato(string nome, string telefone, string email)
    {
        Nome = nome;
        Telefone = telefone;
        Email = email;
    }

    public override string ToString()
    {
        return $"Nome: {Nome}, Telefone: {Telefone}, Email: {Email}";
    }
}

// Parte 2 e 3
class Agenda
{
    private List<Contato> contatos;

    public Agenda()
    {
        contatos = new List<Contato>();
    }

    public void AdicionarContato(Contato contato)
    {
        contatos.Add(contato);
        Console.WriteLine("Contato adicionado com sucesso!");
    }

    public void ListarTodos()
    {
        if (contatos.Count == 0)
        {
            Console.WriteLine("A agenda está vazia.");
            return;
        }

        Console.WriteLine("\n=== LISTA DE CONTATOS ===");
        for (int i = 0; i < contatos.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {contatos[i]}");
        }
    }

    public void BuscarPorNome(string nome)
    {
        List<Contato> contatosEncontrados = new List<Contato>();
        
        foreach (Contato contato in contatos)
        {
            if (contato.Nome.ToLower().Contains(nome.ToLower()))
            {
                contatosEncontrados.Add(contato);
            }
        }

        if (contatosEncontrados.Count == 0)
        {
            Console.WriteLine($"Nenhum contato encontrado com o nome '{nome}'.");
        }
        else
        {
            Console.WriteLine($"\n=== CONTATOS ENCONTRADOS COM '{nome}' ===");
            foreach (Contato contato in contatosEncontrados)
            {
                Console.WriteLine(contato);
            }
        }
    }
}
