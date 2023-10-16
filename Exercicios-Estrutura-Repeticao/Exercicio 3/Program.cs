Console.WriteLine($"Insira o numero da tabuada que deseja:");
int tabuada = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{tabuada} x {i} = {tabuada*i}");
    
}
