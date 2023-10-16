
// Criando variáveis para armazenar as informações da pesquisa
    int sim = 0, nao = 0, mulheresSim = 0, homensNao = 0, totalHomens = 0;
    string sexo, resposta;

    // Loop para coletar as respostas dos entrevistados
    for (int i = 1; i <= 10; i++) {
        Console.WriteLine($"Entrevistado {i}:");
        Console.Write("Sexo (M/F): ");
        sexo = Console.ReadLine().ToUpper();
        Console.Write("Resposta (S/N): ");
        resposta = Console.ReadLine().ToUpper();

// Atualizando as variáveis de acordo com as respostas
     if (resposta == "S") {
    sim++;
    if (sexo == "F") {
     mulheresSim++;
    }
    } else if (resposta == "N") {
    nao++;
    if (sexo == "M") {
    homensNao++;
    }
    }

    if (sexo == "M") {
    totalHomens++;
    }

    Console.WriteLine();
    }

// Imprimindo os resultados
    Console.WriteLine("Resultados da pesquisa:");
    Console.WriteLine($"Total de respostas SIM: {sim}");
    Console.WriteLine($"Total de respostas NÃO: {nao}");
    Console.WriteLine($"Número de mulheres que responderam SIM: {mulheresSim}");
    Console.WriteLine($"Porcentagem de homens que responderam NÃO: {(homensNao * 100.0 / totalHomens):0.00}%");
    

