using System;

class Program {
  public static void Main (string[] args) {

    //Operadores Aritméticos:
    // São: +, -, /, *, %, ++ e --
    int x = 5;
    int y = 8;

    int soma = x + y;
    int sub = x - y;
    int div = x / y;
    int mult = x * y;
    int mod = x % y;

    Console.WriteLine($"Dados, X = {x} e Y = {y}, temos:");

    Console.WriteLine($"A soma é: {soma}");
    Console.WriteLine($"A subtração é: {sub}");
    Console.WriteLine($"A divisão é: {div}");
    Console.WriteLine($"A multiplicação é: {mult}");
    Console.WriteLine($"O módulo é: {mod}");
    
    x++; // x = x + 1
    y--; //y = y - 1;
    
    Console.WriteLine($"O x++ é: {x}");
    Console.WriteLine($"O y-- é: {y}");
    
    //Operadores de Atribuição
    // São: =, +=, -=, *=, /=, %=, &=, |=, ^=, >>= e <<=
    int z = 5;
    Console.WriteLine($"\nAgora, dado Z = {z}, temos:");
    Console.WriteLine($"z += 3 -> resulta em {z += 3}"); //é o mesmo que z = z + 3 (8)
    Console.WriteLine($"z -= 4 -> resulta em {z -= 4}"); //é o mesmo que z = z - 4 (4)
    Console.WriteLine($"z *= 5 -> resulta em {z *= 5}"); //é o mesmo que z = z * 5 (20)
    Console.WriteLine($"z /= 2 -> resulta em {z /= 2}"); //é o mesmo que z = z / 2 (10)
    Console.WriteLine($"z %= 3 -> resulta em {z %= 3}"); //é o mesmo que z = z % 3 (1)

    bool a = true;
    bool b = true;
    
    Console.WriteLine($"\nAgora temos A = {a} e B = {b}");
    
    Console.WriteLine($"a &= b -> resulta em {a &= b}"); //é o mesmo que a = a & b (true)
    Console.WriteLine($"a |= b -> resulta em {a |= b}"); //é o mesmo que a = a | b (true)
    Console.WriteLine($"a ˆ= b -> resulta em {a ^= b}"); //é o mesmo que a = a ˆ b (falso)

    //Para os operadores >>= e <<= vide https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/bitwise-and-shift-operators
    
    //Operadores de Comparação
    //São: <, >, <=, >=, ==. !=  --> resultados SEMPRE booleanos!
    Console.WriteLine($"\nUsando novamente as variáveis x = {x} e y = {y}, temos que: ");
    Console.WriteLine($"X < Y  -> {x < y}");
    Console.WriteLine($"X > Y  -> {x > y}");
    Console.WriteLine($"X == Y  -> {x == y}");
    Console.WriteLine($"X >= Y  -> {x >= y}"); //maior OU igual
    Console.WriteLine($"X <= Y  -> {x <= y}"); //menor OU igual
    Console.WriteLine($"X != Y  -> {x != y}"); //diferente
    
    
    //Operadores Lógicos
    //São: &&, || e !
    //Sempre sobre valores booleano
    bool c = true;
    Console.WriteLine($"\nDados A = {a} e C = {c}, temos que:");
    Console.WriteLine($"A && B -> {a && c}"); //E
    Console.WriteLine($"A || B -> {a || c}"); //OU
    Console.WriteLine($"A || B -> {a ^ c}"); //XOR
    Console.WriteLine($"!a -> {!a}"); //NOT
  }
}