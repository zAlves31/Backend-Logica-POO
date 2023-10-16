Console.WriteLine($" informe o salário recebido ");
int salario =int.Parse(Console.ReadLine());

Console.WriteLine($" informe o total gasto");
int totalGasto =int.Parse(Console.ReadLine());

if(salario > totalGasto )
{
    Console.WriteLine($" Gastos dentro do orçamento "); 
}
else if(totalGasto > salario)
{
   Console.WriteLine($" Orçamento estourado ");    
}
