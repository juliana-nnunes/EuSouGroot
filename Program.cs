using System;
class Program
{
            static string pergunta = "";
            static string resposta = "";
            static string saída = "tchau";


            static void Main ()

    {
        Console.WriteLine("--- Groot Chatboot ---\n");


        while (true)
        {
            PerguntaUsuario();

            if (pergunta == saída)

            {
                 
                 resposta = "Eu sou o Groot!";
                 Console.WriteLine($"\nResposta: {resposta}");
                 break;

            }

            resposta = "Eu sou o Groot.";
            Console.WriteLine($"\nResposta: {resposta}\n");

        }
    }

    static void PerguntaUsuario()

    {
        Console.Write("Pergunta: ");
        pergunta = Console.ReadLine()!.ToLower().Trim();
    }
}
