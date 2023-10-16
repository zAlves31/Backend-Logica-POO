Console.WriteLine($"Insira sua nota");
int Nota = int.Parse(Console.ReadLine());

while (Nota >10 || Nota<0)
{
    Console.WriteLine($"Valor invalido");
    Nota =int.Parse(Console.ReadLine());
}
   
    Console.WriteLine($"Valor valido");
   

