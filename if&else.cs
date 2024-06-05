using System.ComponentModel.Design;

int Idade;
string Nome;

{
    Console.WriteLine("Olá, qual seu nome? ");
    Nome = Console.ReadLine();
    Console.WriteLine("Olá " + Nome + ". Qual sua idade?: ");
    Idade = int.Parse(Console.ReadLine());

    if (Idade < 18)
    {
        Console.WriteLine("Desculpe, mas só pode entrar maiores de 18 anos.");
    }
    else if (Idade >= 18)
    { 
        Console.WriteLine("Você ja é maior de idade, pode entrar. Divirta-se e se cuide!"); 
    }
}