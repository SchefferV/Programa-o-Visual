using System;

class Program {
  public static void Main (string[] args) {

    Console.Write("Informe seu nome: ");
    string nome = Console.ReadLine();

    Console.Write("Informe sua idade: ");
    int idade = Convert.ToInt16(Console.ReadLine());

    Console.Write("Você fuma? [S/N]: ");
    bool fumante = false;
    char fuma = Console.ReadLine()[0];

    if (fuma.Equals('S') || fuma.Equals('s')) {
      fumante = true;
    } 

    Console.Write("Qual seu saldo em conta: ");
    decimal saldoEmConta = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("Nome: " + nome); //concatenação
    Console.WriteLine($"Idade: {idade}"); //Interpolação
    Console.WriteLine($"Saldo em conta: R${saldoEmConta}");

    if (fumante) {
      Console.WriteLine($"Fuma? Sim");
    } else {
      Console.WriteLine($"Fuma? Não");
    }

    //outra forma de fazer este "if"
    Console.WriteLine("Fuma? " + (fumante ? "Sim" : "Não"));

    /*
    Desafio do TIO:
      Criar um programa que calcule o IMC de uma pessoa, dado o peso e a altura dela
    */   
  }
}