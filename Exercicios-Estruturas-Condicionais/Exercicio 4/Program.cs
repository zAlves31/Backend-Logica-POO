Console.WriteLine($"Insira sua senha");
float senha = float.Parse(Console.ReadLine());

if (senha == 1234)
{
    Console.WriteLine($"ACESSO PERMITIDO!");    
}
else if (senha !=1234 )
{
    Console.WriteLine($"ACESSO NEGADO");    
}
