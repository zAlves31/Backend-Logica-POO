Console.WriteLine($"Insira a medida1");
float lado1 =float.Parse(Console.ReadLine());

Console.WriteLine($"Insira a medida2");
float lado2 =float.Parse(Console.ReadLine());

Console.WriteLine($"Insira a medida3");
float lado3 =float.Parse(Console.ReadLine());

if(lado1 == lado2 && lado2 == lado3)
{
    Console.WriteLine($" Triângulo Equilátero "); 
}

else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
{
    Console.WriteLine($" Triângulo Isoscele "); 
}

else if (lado1 != lado2 && lado2 != lado3)
{
    Console.WriteLine($" Triângulo Escaleno "); 
}
