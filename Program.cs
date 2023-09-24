// See https://aka.ms/new-console-template for more information
double consumo, HorasUsoDia;
decimal Custo, estimativaMes;
Console.WriteLine("---Custo de Energia---\n");
Console.Write("Consumo do aparelho (em kWh/mês).:");
consumo = Convert.ToDouble(Console.ReadLine());
Console.Write("Horas de uso por dia.:");
HorasUsoDia = Convert.ToDouble(Console.ReadLine());
Console.Write("Custo da Energia (em R$/kWh).:");
Custo = Convert.ToDecimal(Console.ReadLine());
estimativaMes = Convert.ToDecimal(consumo * HorasUsoDia) * Custo;
Console.WriteLine($"\nCusto estimado: {estimativaMes:C}");