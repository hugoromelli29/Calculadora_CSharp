using Calculadora;

Begin: Console.WriteLine("Que operação deseja fazer? [a]-adição / [s]-subtração / [m]-multiplicação / [d]-divisão");
char letra = char.Parse(Console.ReadLine());
if (letra == 'a')
{
    Soma operacao = new();
    operacao.EntradaDosValores();
    operacao.ImprimeResutlado();
}
else if (letra == 's')
{
    Subtracao operacao = new();
    operacao.EntradaDosValores();
    operacao.ImprimeResutlado();
}
else if (letra == 'm')
{
    Multiplicacao operacao = new();
    operacao.EntradaDosValores();
    operacao.ImprimeResutlado();
}
else if (letra == 'd')
{
    try
    {
        Divisao operacao = new();
        operacao.EntradaDosValores();
        operacao.ImprimeResutlado();
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Impossível dividir por 0");
    }
}
else Console.WriteLine("Opção inválida.");
Console.ReadKey();
Console.Clear();
goto Begin;