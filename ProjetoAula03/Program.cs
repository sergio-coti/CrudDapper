using ProjetoAula03.Controllers;

namespace ProjetoAula03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\nSISTEMA DE CONTROLE DE ESTOQUE E PRODUTOS:\n");

            Console.WriteLine("(1) CADASTRAR ESTOQUE");
            Console.WriteLine("(2) ATUALIZAR ESTOQUE");
            Console.WriteLine("(3) EXCLUIR ESTOQUE");
            Console.WriteLine("(4) CONSULTAR ESTOQUE");

            Console.Write("\nINFORME A OPÇÃO DESEJADA: ");
            var opcao = int.Parse(Console.ReadLine());

            var estoqueController = new EstoqueController();

            switch(opcao)
            {
                case 1:
                    estoqueController.CadastrarEstoque();
                    break;
                case 2:
                    estoqueController.AtualizarEstoque();
                    break;
                case 3:
                    estoqueController.ExcluirEstoque();
                    break;
                case 4:
                    estoqueController.ConsultarEstoques();
                    break;
                default:
                    Console.WriteLine("\nOPÇÃO INVÁLIDA!");
                    break;
            }

            Console.Write("\nDESEJA CONTINUAR (S,N): ");
            var continuar = Console.ReadLine();

            if(continuar.ToUpper().Equals("S"))
            {
                Console.Clear(); //limpar o console
                Main(args); //recursividade
            }
            else
            {
                Console.WriteLine("\nFIM DO PROGRAMA!");
                Console.ReadKey();
            }
        }
    }
}