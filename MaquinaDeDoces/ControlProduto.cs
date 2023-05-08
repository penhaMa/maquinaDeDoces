using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    class ControlProduto
    {
        Produto prod;
        private int opcao;

        public ControlProduto()
        {
            prod = new Produto();
            ModificarOpcao = -1;
        }//Fim do construtor

        //Método Get e Set
        public int ModificarOpcao
        {
            get { return opcao; }
            set { opcao = value; }
        }

        //Método Menu
        public void Menu()
        {
            Console.Clear();//Limpa tela
            Console.WriteLine("\n\n\nEscolha uma das opções abaixo: \n" +
                "0 - Sair\n"                 +
                "1 - Cadastrar um Produto\n" +
                "2 - Consultar um Produto\n" +
                "3 - Atualizar Produto\n"    +
                "4 - Mudar Situação\n");
            ModificarOpcao = Convert.ToInt32(Console.ReadLine());
        }//Fim do método Menu Get e Set opcao

        //Realizar a operação
        public void Operacao()
        {
            do
            {
                Menu();//Monstrando o menu
                switch (ModificarOpcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        Console.Clear();//Limpa o Console
                        break;
                    case 1:
                        ColetarDados();
                        Console.Clear();//Limpa o Console
                        break;
                    case 2:
                        Consultar();
                        Console.Clear();//Limpa o Console
                        break;
                    case 3:
                        Atualizar();
                        Console.Clear();//Limpa o Console
                        break;
                    case 4:
                        AlterarSituacao();
                        Console.Clear();//Limpa o Console
                        break;
                    default:
                        Console.WriteLine("Opção escolhida não é válida!");
                        break;
                }//Fim do switch
            } while (ModificarOpcao != 0);
        }//Fim do método operação

        //Método de solicitação de dados 
        public void ColetarDados()
        {
            //Coletar Dados
            Console.WriteLine("Informe um código: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o nome do produto: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Faça uma breve descrição do produto: ");
            string descricao = Console.ReadLine();

            Console.WriteLine("Informe o preço do produto: ");
            double preco = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de produtos em estoque: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a data de validade do lote do produto: ");
            DateTime dtValidade = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Informe a situação: True - Ativo | False - Inativo ");
            Boolean situacao = Convert.ToBoolean(Console.ReadLine());

            //Cadastrar o produto
            prod.CadastrarProduto(codigo, nome, descricao, preco, quantidade, dtValidade, situacao);
            Console.WriteLine("Dado Cadastrado!");
        }//Fim do coletar dados

        //Consultar os dados do produto
        public void Consultar()
        {
            Console.WriteLine("\n\n\nInforme o código do produto que deseja consultar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            //Escrever o resultado na tela
            Console.WriteLine("Os dados do produto escolhido são: \n\n\n" + prod.ConsultarProduto(codigo));
        }//Fim do consultar dados

        //Atualizar produto
        public void Atualizar()
        {

            Console.WriteLine("\n\nInforme o código do produto que deseja atualizar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            short campo = 0;

            do
            {
                Console.WriteLine("\n\nInforme o código do produto que deseja atualizar de acordo com a regra abaixo: \n" +
                    "1 - Nome\n" +
                    "2 - Descrição\n" +
                    "3 - Preço\n" +
                    "4 - Quantidade\n" +
                    "5 - Data de Validade\n" +
                    "6 - Situação\n");
                campo = Convert.ToInt16(Console.ReadLine());
                //Avisar o usuário
                if ((campo < 1) || (campo > 6))
                {
                    Console.WriteLine("Erro, escolha um código entre 1 e 6");
                }
            } while ((campo < 1) || (campo > 6));

            Console.WriteLine("Informe o dado para a atualização: ");
            string novoDado = Console.ReadLine();

            //Chamar o método de atualização
            prod.AtualizarProduto(codigo, campo, novoDado);
        }//Fim do método Atualizar

        public void AlterarSituacao()
        {
            Console.WriteLine("Informe o código do produto que deseja alterar o status: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            //Chamar o método alterarSituação - Classe Produto
            prod.AlterarSituacao(codigo);
            Console.WriteLine("Alterado!");
        }//Fim do método Alterar Situação

    }//Fim da classe
}//Fim do projeto
