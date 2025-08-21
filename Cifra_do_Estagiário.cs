using System;

class CifraEstagiario
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite uma frase: ");
        string cifra = Console.ReadLine().upper;

        string resultado = "";

        for (int i = 0; i < cifra.Length; i++)
        {
            switch (letra)
            {
                case 'A':
                    resultado += '@';
                    break;
                case 'E':
                    resultado += '#';
                    break;
                case 'I':
                    resultado += '!';
                    break;
                case 'O':
                    resultado += '$';
                    break;
                case 'U':
                    resultado += '%';
                    break;
                default:
                    resultado += letra;
                    break;
            }
        }
        Console.WriteLine("Texto cifrado: " + resultado);
    }
}