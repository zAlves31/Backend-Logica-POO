
string nome;
int idade;
double salario;
char estadoCivil;

    Console.Write("Digite o nome: ");
    nome = Console.ReadLine();

    while (string.IsNullOrEmpty(nome)) {
        Console.Write("Nome inválido. Digite novamente: ");
        nome = Console.ReadLine();
    }

    Console.Write("Digite a idade: ");
    idade = int.Parse(Console.ReadLine());

    while (idade < 0 || idade > 100) {
        Console.Write("Idade inválida. Digite novamente: ");
        idade = int.Parse(Console.ReadLine());
    }

    Console.Write("Digite o salário: ");
    salario = double.Parse(Console.ReadLine());

    while (salario <= 0) {
        Console.Write("Salário inválido. Digite novamente: ");
        salario = double.Parse(Console.ReadLine());
    }

    Console.Write("Digite o estado civil ('s' para solteiro(a), 'c' para casado(a), 'v' para viúvo(a) ou 'd' para divorciado(a)): ");
    estadoCivil = char.Parse(Console.ReadLine());

    while (estadoCivil != 's' && estadoCivil != 'c' && estadoCivil != 'v' && estadoCivil != 'd') {
        Console.Write("Estado civil inválido. Digite novamente: ");
        estadoCivil = char.Parse(Console.ReadLine());
    }

    Console.WriteLine("Informações válidas.");
    Console.ReadKey();
    


