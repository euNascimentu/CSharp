int Idade;
string nome;
double num1;
double num2;

{
    Console.WriteLine("Olá, por favor digite o seu nome: ");
    nome = Console.ReadLine();

    Console.WriteLine("Olá " + nome + ", qual sua idade?");
    Idade = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite um numero de 1 a 10: ");
    num1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Legal! Agora digite outro numero de 1 a 10: ");
    num2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Legal a soma de " + num1 + " + " + num2 + " é igual á: " + (num1 + num2));
    Console.WriteLine("Legal a multiplicação de " + num1 + " * " + num2 + " é igual á: " + (num1 * num2));
    Console.WriteLine("Legal a divisão de " + num1 + " ÷ " + num2 + " é igual á: " + (num1 / num2));
    Console.WriteLine("Legal a subtração de " + num1 + " - " + num2 + " é igual á: " + (num1 - num2));
}
    