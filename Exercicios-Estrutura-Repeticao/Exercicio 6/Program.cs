Console.WriteLine($"imprima a tabuada (de 1 a 10)");
int tabuada = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++) {
    Console.WriteLine("Tabuada do " + i + ":");
for (int j = 1; j <= 10; j++) {
     Console.WriteLine(i + " x " + j + " = " + i*j);
}
Console.WriteLine(); 
}
