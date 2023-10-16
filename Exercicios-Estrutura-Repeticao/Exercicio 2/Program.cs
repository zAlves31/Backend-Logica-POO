Console.WriteLine($"Insira seu usuario");
string usuario = Console.ReadLine();

Console.WriteLine($"Insira sua senha");
string senha = Console.ReadLine();



while (senha==usuario)
{
    Console.WriteLine($"ERRO: o usuário não pode ser igual a senha, tente novamente");
    senha =  Console.ReadLine();
}

    Console.WriteLine($"Cadastro efetuado");
    