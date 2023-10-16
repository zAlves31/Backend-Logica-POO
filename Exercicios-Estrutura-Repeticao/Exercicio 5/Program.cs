
int totalHomens = 0;
int totalMulheres = 0;
int idadeHomens = 0;
int idadeMulheres = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Digite a idade da pessoa {i}:");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o peso da pessoa {i}:");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o sexo da pessoa {i} (M para masculino ou F para feminino):");
            char sexo = char.Parse(Console.ReadLine());

            if (sexo == 'M' || sexo == 'm')
            {
                totalHomens++;
                idadeHomens += idade;
            }
            else if (sexo == 'F' || sexo == 'f')
            {
                totalMulheres++;
                idadeMulheres += idade;
            }
        }

        double mediaIdadeHomens = (double)idadeHomens / totalHomens;
        double mediaIdadeMulheres = (double)idadeMulheres / totalMulheres;

        Console.WriteLine($"Total de Homens: {totalHomens}");
        Console.WriteLine($"Total de Mulheres: {totalMulheres}");
        Console.WriteLine($"Média de idade dos Homens: {mediaIdadeHomens}");
        Console.WriteLine($"Média de idade das Mulheres: {mediaIdadeMulheres}");

        Console.ReadKey();
        

