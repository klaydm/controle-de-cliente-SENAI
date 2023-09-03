using System;
namespace ControleDeClientes
{
    class Program
    {
        static void Main(string[] args)
        {
            float val_pag;
            Console.WriteLine("Por favor, informe seu nome: ");
            string var_nome = Console.ReadLine();
            Console.WriteLine("Por favor, informe seu endereço: ");
            string var_endereco = Console.ReadLine();
            Console.WriteLine("Indique se você é Pessoa Física (F) ou Pessoa Jurídica(J) ou (S) para sair");
            string var_tipo = Console.ReadLine();

            if (var_tipo == "F")
            {
                Pessoa_Fisica PF = new Pessoa_Fisica();

                PF.Nome = var_nome;
                PF.Endereco = var_endereco;

                Console.WriteLine("Por favor, informe seu CPF");
                PF.CPF = Console.ReadLine();

                Console.WriteLine("Por favor, informe seu RG");
                PF.RG = Console.ReadLine();

                Console.WriteLine("Informe o valor da compra: ");
                val_pag = float.Parse(Console.ReadLine());
                PF.Pagar_Imposto(val_pag);

                Console.WriteLine("-------- Pessoa Física --------");
                Console.WriteLine($"Nome............: {PF.Nome}");
                Console.WriteLine($"Endereço........: {PF.Endereco}");
                Console.WriteLine($"CPF.............: {PF.CPF}");
                Console.WriteLine($"RG..............: {PF.RG}");
                Console.WriteLine($"Valor da Compra.:{PF.Valor.ToString("C")}");
                Console.WriteLine($"Imposto.........: {PF.Imposto.ToString("C")}");
                Console.WriteLine($"Total a pagar...: {PF.Total.ToString("C")}");
                Console.WriteLine("Obrigado por comprar na nossa loja, volte sempre!");
            }
            if (var_tipo == "J")
            {
                Pessoa_Juridica PJ = new Pessoa_Juridica();

                PJ.Nome = var_nome;
                PJ.Endereco = var_endereco;

                Console.WriteLine("Por favor, informe seu CNPJ");
                PJ.CNPJ = Console.ReadLine();

                Console.WriteLine("Por favor, informe sua Inscrição Estadual");
                PJ.IE = Console.ReadLine();

                Console.WriteLine("Informe o valor da compra: ");
                val_pag = float.Parse(Console.ReadLine());
                PJ.Pagar_Imposto(val_pag);

                Console.WriteLine("-------- Pessoa Jurídica --------");
                Console.WriteLine($"Nome............: {PJ.Nome}");
                Console.WriteLine($"Endereço........: {PJ.Endereco}");
                Console.WriteLine($"CPF.............: {PJ.CNPJ}");
                Console.WriteLine($"RG..............: {PJ.IE}");
                Console.WriteLine($"Valor da Compra.:{PJ.Valor.ToString("C")}");
                Console.WriteLine($"Imposto.........: {PJ.Imposto.ToString("C")}");
                Console.WriteLine($"Total a pagar...: {PJ.Total.ToString("C")}");
                Console.WriteLine("Obrigado por comprar na nossa loja, volte sempre!");
            }
        }
    }
}