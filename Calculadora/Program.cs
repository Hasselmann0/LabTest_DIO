using Calculadora.Services;

CalculadoraImp c = new CalculadoraImp();

int num1 = 10;
int num2 = 20;

Console.WriteLine($"A soma de {num1} e {num2} é : {c.Somar(num1, num2)}");