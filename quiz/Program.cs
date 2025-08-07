class Program
{
    public static void Main()
    {
        Console.WriteLine("Qual a sua missão? ");
        Console.WriteLine("a Encontrar o calice Sagrado  /  b Ganhar dinheiro   /  c Criar Chaves   /  d Ser Rei");
        Console.WriteLine("");
        String question1 = Console.ReadLine();

        if (question1 == "a")
        {
            Console.WriteLine("Correto");
        }
        else
        {
            Console.WriteLine("Errado");
            Console.WriteLine("Voce Morreu");
            return;
        }

        Console.WriteLine("");
        Console.WriteLine("Quem o Seu Nome? ");
        Console.WriteLine("a  Rei Arthur  /  b Pedro Álvaréz   /  c Carlos   /  d Chaves");
        Console.WriteLine("");
        String question2 = Console.ReadLine();


        if (question2 == "a")
        {
            Console.WriteLine("Correto");
        }
        else
        {
            Console.WriteLine("Errado");
            Console.WriteLine("Voce Morreu");
            return;

        }

        Console.WriteLine("");
        Console.WriteLine("Qual, a velocidade de uma andaroinha viajando no ar? ");
        Console.WriteLine("a Acima da Luz  /  b 25 Metros por Hora   /  c Qual tipo de andorinha? Uma africana ou Europeia?   /  d Muito");
        Console.WriteLine("");
        String question3 = Console.ReadLine();


        if (question3 == "c")
        {
            Console.WriteLine("Eu... Eu não sei");
            Console.WriteLine("*o quiz morreu*");

        }
        else
        {
            Console.WriteLine("Errado");
            Console.WriteLine("Voce Morreu");
            return;
        }

    }
}






