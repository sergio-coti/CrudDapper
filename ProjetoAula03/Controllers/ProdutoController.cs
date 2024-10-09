using ProjetoAula03.Entities;
using ProjetoAula03.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula03.Controllers
{
    /// <summary>
    /// Classe para executar os fluxos relacionados a produto.
    /// </summary>
    public class ProdutoController
    {
        /// <summary>
        /// Método para realizar o passo a passo de cadastro de produto.
        /// </summary>
        public void CadastrarProduto()
        {
            try
            {
                Console.WriteLine("\nCADASTRO DE PRODUTO:\n");

                var produto = new Produto
                {
                    Id = Guid.NewGuid()
                };

                Console.Write("INFORME O NOME DO PRODUTO....: ");
                produto.Nome = Console.ReadLine();

                Console.Write("INFORME O PREÇO..............: ");
                produto.Preco = decimal.Parse(Console.ReadLine());

                Console.Write("INFORME A QUANTIDADE.........: ");
                produto.Quantidade = int.Parse(Console.ReadLine());

                Console.Write("INFORME O ID DO ESTOQUE......: ");
                produto.EstoqueId = Guid.Parse(Console.ReadLine());

                var produtoRepository = new ProdutoRepository();
                produtoRepository.Add(produto);

                Console.WriteLine("\nPRODUTO CADASTRADO COM SUCESSO!");
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nFALHA AO CADASTRAR PRODUTO: {e.Message}");
            }
        }

        /// <summary>
        /// Método para realizar o passo a passo de edição de produto.
        /// </summary>
        public void AtualizarProduto()
        {
            try
            {
                Console.WriteLine("\nEDIÇÃO DE PRODUTO:\n");

                var produto = new Produto();

                Console.Write("INFORME O ID DO PRODUTO......: ");
                produto.Id = Guid.Parse(Console.ReadLine());

                Console.Write("INFORME O NOME DO PRODUTO....: ");
                produto.Nome = Console.ReadLine();

                Console.Write("INFORME O PREÇO..............: ");
                produto.Preco = decimal.Parse(Console.ReadLine());

                Console.Write("INFORME A QUANTIDADE.........: ");
                produto.Quantidade = int.Parse(Console.ReadLine());

                Console.Write("INFORME O ID DO ESTOQUE......: ");
                produto.EstoqueId = Guid.Parse(Console.ReadLine());

                var produtoRepository = new ProdutoRepository();
                produtoRepository.Update(produto);

                Console.WriteLine("\nPRODUTO ATUALIZADO COM SUCESSO!");
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nFALHA AO ATUALIZAR PRODUTO: {e.Message}");
            }
        }

        /// <summary>
        /// Método para realizar o passo a passo de exclusão de produto.
        /// </summary>
        public void ExcluirProduto()
        {
            try
            {
                Console.WriteLine("\nEXCLUSÃO DE PRODUTO:\n");

                Console.Write("INFORME O ID DO PRODUTO......: ");
                var id = Guid.Parse(Console.ReadLine());

                var produtoRepository = new ProdutoRepository();
                produtoRepository.Delete(id);

                Console.WriteLine("\nPRODUTO EXCLUÍDO COM SUCESSO!");
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nFALHA AO EXCLUIR PRODUTO: {e.Message}");
            }
        }

        /// <summary>
        /// Método para consultar e exibir todos os produtos
        /// </summary>
        public void ConsultarProdutos()
        {
            try
            {
                Console.WriteLine("\nCONSULTA DE PRODUTOS:\n");

                var produtoRepository = new ProdutoRepository();
                var lista = produtoRepository.GetAll();

                foreach (var item in lista)
                {
                    Console.WriteLine($"ID...............: {item.Id}");
                    Console.WriteLine($"NOME DO PRODUTO..: {item.Nome}");
                    Console.WriteLine($"PREÇO............: {item.Preco.ToString("c")}");
                    Console.WriteLine($"QUANTIDADE.......: {item.Quantidade}");
                    Console.WriteLine($"NOME DO ESTOQUE..: {item.Estoque.Nome}");
                    Console.WriteLine("...");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nFALHA AO CONSULTAR PRODUTOS: {e.Message}");
            }
        }

        public void GerarRelatorio()
        {
            try
            {
                Console.WriteLine("\nRELATÓRIO DE PRODUTOS:\n");

                var produtoRepository = new ProdutoRepository();
                var lista = produtoRepository.GroupByEstoque();

                foreach (var item in lista)
                {
                    Console.WriteLine($"ID DO ESTOQUE..........: {item.IdEstoque}");
                    Console.WriteLine($"NOME DO ESTOQUE........: {item.NomeEstoque}");
                    Console.WriteLine($"QTD TOTAL DE PRODUTOS..: {item.TotalQuantidade}");
                    Console.WriteLine("...");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nFALHA AO CONSULTAR PRODUTOS: {e.Message}");
            }
        }
    }
}
