using ExercicioHeranca;
using static System.Runtime.InteropServices.JavaScript.JSType;
ContaBancaria[] contas = new ContaBancaria[3];
for(int i = 0; i < contas.Length; i++)
{
    contas[i] = new ContaVazia("0", "0", 0);
}
void CadastrarConta(int posicao) {
    while (true)
    {
        Console.WriteLine("Cadastre uma conta");
        Console.Write("Digite o numero da conta: ");
        string numero = Console.ReadLine();
        Console.WriteLine("Digite o tipo de conta (1 - Corrente | 2 - Poupança | 3 - Salario): ");
        int opcao = int.Parse(Console.ReadLine());
        switch (opcao)
        {
            case 1:
                ContaCorrente contaC = new(numero, "Corrente", 0);
                contas[posicao] = contaC;
                break;
            case 2:
                ContaPoupanca contaP = new(numero, "Poupanca", 0);
                contas[posicao] = contaP;
                break;
            case 3:
                ContaSalario contaS = new(numero, "Salario", 0);
                contas[posicao] = contaS;
                break;
            default:
                Console.WriteLine("Digite uma opção válida.");
                continue;
        }
        break;
    }
}

CadastrarConta(0);
int conta = 0;
while (true)
{
    int verificador = 3;
    for(int i = 0; i < contas.Length; i++)
    {
        Console.WriteLine(contas[i].ToString());
    }
    Console.Write("\n");
    Console.WriteLine("Digite 4 para criar uma nova conta");
    Console.WriteLine("Digite 5 para sair");
    Console.Write("Digite o numero de uma conta ou uma opção: ");
    string op = Console.ReadLine();
    for(int i = 0; i < contas.Length; i++)
    {
        if (contas[i].Numero == op)
        {
            conta = i;
            verificador = 2;
        }
    }
    bool verificador2 = false;
    if (op == "4")
    {
        verificador = 1;
        for (int i = 0; i < contas.Length; i++)
        {
            if (contas[i].ToString() == "Espaço para receber conta")
            {
                CadastrarConta(i);
                verificador2 = true;
                break;
            }
        }
        if (verificador2 == false)
        {
            Console.WriteLine("Lista de contas cheia, escolha uma para acessar");
        }
    }
    if (verificador == 3)
    {
        Console.WriteLine("Conta nao encontrada.");
        continue;
    }


    while (true)
    {
        bool verif = false;
        Console.Write("\n");
        Console.WriteLine("Banco 5by5 SA");
        Console.WriteLine("Digite uma opcao: ");
        Console.WriteLine("1 - Depositar");
        Console.WriteLine("2 - Sacar");
        Console.WriteLine("3 - Transferencia");
        Console.WriteLine("4 - Pagar");
        Console.WriteLine("5 - Ver saldo");
        Console.WriteLine("6 - Sair da conta");
        Console.Write("\n");
        Console.Write("Digite uma opcao: ");
        int opcao = int.Parse(Console.ReadLine());
        switch (opcao)
        {
            case 1:
                Console.Write("Digite o valor a ser depositado: ");
                decimal valor = decimal.Parse(Console.ReadLine());
                contas[conta].Depositar(valor);
                continue;

            case 2:
                Console.Write("Digite o valor a ser sacado: ");
                valor = decimal.Parse(Console.ReadLine());
                Console.WriteLine(contas[conta].Sacar(valor));
                continue;

            case 3:
                Console.Write("Digite o numero da conta a receber o valor: ");
                string numero = Console.ReadLine();
                Console.Write("Digite a quantia a ser transferida: ");
                valor = decimal.Parse(Console.ReadLine());
                for(int i = 0; i < contas.Length; i++)
                {
                    if (contas[i].Numero == numero)
                    {
                        contas[conta].Transferencia(valor);
                        contas[i].Saldo += valor;
                        verif = true;
                    }
                }
                if(verif == false)
                {
                    Console.WriteLine("Conta não encontrada, tente novamente.");
                    continue;
                }
                continue;

            case 4:
                Console.WriteLine("Digite o valor a ser pago: ");
                valor = decimal.Parse(Console.ReadLine());
                contas[conta].Pagar(valor);
                continue;
            case 5:
                Console.WriteLine($"Você tem: R$" + contas[conta].Saldo.ToString("F2"));
                continue;
            case 6:
                break;
        }
        break;
    }
    if(op == "5")
    {
        break;
    }
}



