Console.WriteLine($" informe quantidade de gols do Santos ");
int Santos =int.Parse(Console.ReadLine());

Console.WriteLine($" informe quantidade de gols do Botafogo ");
int Botafogo =int.Parse(Console.ReadLine());

if(Santos > Botafogo )
{
    Console.WriteLine($" Vitoria do Santos "); 
}

else if(Santos < Botafogo )
{
    Console.WriteLine($" Vitoria do Botafogo "); 
}

else if(Santos == Botafogo )
{
    Console.WriteLine($" Empate "); 
}


