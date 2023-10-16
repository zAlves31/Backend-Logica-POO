Console.WriteLine($"Insira quantidade de maçãs");
float maçãs = float.Parse(Console.ReadLine());

if (maçãs <= 11)
{ 
     Console.WriteLine(maçãs * 0.30);
}
else if (maçãs >= 12)
{
    Console.WriteLine(maçãs * 0.25);   
}



