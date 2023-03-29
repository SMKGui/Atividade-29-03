// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Programa para calcular idade

Console.WriteLine($"Digite sua idade");

int idade = int.Parse(Console.ReadLine());

int idadeEmMeses = idade * 12;
Console.WriteLine($"Sua idade em meses: {idadeEmMeses} ");

int IdadeEmSemanas = idade * 52;
Console.WriteLine($"Sua idade em semanas: {IdadeEmSemanas}");

int IdadeEmDias = idade * 365;
Console.WriteLine($"Sua idade em dias: {IdadeEmDias}");

int IdadeEmHoras = idade * 8760;
Console.WriteLine($"Sua idade em horas: {IdadeEmHoras}");

int IdadeEmMinutos = idade * 525600;
Console.WriteLine($"Sua idade em minutos: {IdadeEmMinutos}");

