Console.WriteLine(@$"
    ------------------------------------ 
   |   Cardapio                         |
   |                                    | 
   |   1 - whisky                       |
   |   2 - refrigerante                 |
   |   3 - suco                         |
   |   4 - vodka                        |
   |   5 - agua                         |
   |                                    |
    ------------------------------------
");

// entrada
Console.WriteLine($"Inofrme a bebida do cardapio");
string bebidas =(Console.ReadLine());

// processamento

switch (bebidas)
{
    case "1":
        Console.WriteLine($"Essa bebida necessita de gelo");
        break;

    case "2":
         Console.WriteLine($"Essa bebida necessita de gelo");
        break;

    case "3":
        Console.WriteLine($"Essa bebida necessita de gelo");
        break;

    case "4":
        Console.WriteLine($"Essa bebida necessita de gelo");
        break;

    case "5":
        Console.WriteLine($"Essa bebida nao necessita de gelo");
        break;

    default:
        Console.WriteLine($"Nao existe essa bebida em nosso cardapio");
        break;
}
