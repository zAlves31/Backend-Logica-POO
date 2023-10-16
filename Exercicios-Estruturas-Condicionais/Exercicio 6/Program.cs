Console.WriteLine($"Insira a media do aluno");
int media = int.Parse(Console.ReadLine());

Console.WriteLine($"Insira a frequencia do aluno");
int frequencia = int.Parse(Console.ReadLine());

if (media >= 7.0 && frequencia >= 75)
{
    Console.WriteLine($"o aluno esta aprovado");    
}

else if (media < 7.0 && frequencia < 75)
{
    Console.WriteLine($"o aluno esta reprovado");    
}

else if (media >=3 && frequencia >= 75)
{
    Console.WriteLine($"o aluno tem chance de uma prova de recuperacao");    
}






