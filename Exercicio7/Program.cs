using Exercicio7;
using System;
using System.Globalization;

var C = new Cliente();

// Nome
while (true)
{
    try
    {
        Console.Write("Nome: ");
        C.Nome = Console.ReadLine();
        break;
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

// Cpf
while (true)
{
    try
    {
        Console.Write("CPF: ");
        C.CPF = Convert.ToInt64(Console.ReadLine());
        break;
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

// Nascimento
while (true)
{
    try
    {
        // https://learn.microsoft.com/en-us/dotnet/api/system.datetime.tryparseexact

        Console.Write("Data de nascimento: ");

        var DataString = Console.ReadLine();

        CultureInfo enUS = new CultureInfo("en-US");
        DateTime ValorData;

        DateTime.TryParseExact(DataString, "dd/MM/yyyy", enUS,
                                 DateTimeStyles.None, out ValorData);

        C.Nascimento = ValorData;

        break;
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

// Renda
while (true)
{
    try
    {
        Console.Write("Renda mensal: ");
        var RendaString = Console.ReadLine();
        var RendaValor = float.Parse(RendaString);

        C.Renda = (float) Math.Round(RendaValor, 2);

        break;
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

// Estado civil
while (true)
{
    try
    {
        Console.Write("Estado civil (C, S, V, D): ");
        var EstadoString = Console.ReadLine();

        C.EstadoCivil = EstadoString[0];

        break;
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

// Dependentes
while (true)
{
    try
    {
        Console.Write("Número de dependentes (0-10): ");
        var DependentesString = Console.ReadLine();

        C.Dependentes = Int32.Parse(DependentesString);

        break;
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

Console.WriteLine("## Dados ##");
Console.WriteLine(C.Nome);
Console.WriteLine(C.CPF);
Console.WriteLine(C.Nascimento);
Console.WriteLine(C.Renda);
Console.WriteLine(C.EstadoCivil);
Console.WriteLine(C.Dependentes);