using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    class ControlMaquina
    {
        Maquina maqui;
        private int opcao;

        public ControlMaquina()
        {
            maqui = new Maquina();
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
            Console.WriteLine("\n\n\nEscolha uma das opções abaixo: \n" +
                "0 - Sair\n" +
                "1 - Registrar Manutenção\n" +
                "2 - Efetuar Saque\n");
            ModificarOpcao = Convert.ToInt32(Console.ReadLine());
            Console.Clear();//Limpa tela
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
                        break;
                    case 1:
                        RegistrarManutencao();
                        break;
                    case 2:
                        EfetuarSaque();
                        break;
                    default:
                        Console.WriteLine("Opção escolhida não é válida!");
                        break;
                }//Fim do switch
            } while (ModificarOpcao != 0);
        }//Fim do método operação

        //Método informar saque 
        public void InformarSaque()
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
        }//Fim do informar saque

        //Método bloquear pagamento de dinheiro
        public void Consultar()
        {
            Console.WriteLine("\n\n\nInforme o código do produto que deseja consultar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            //Escrever o resultado na tela
            Console.WriteLine("Os dados do produto escolhido são: \n\n\n" + prod.ConsultarProduto(codigo));
        }//Fim do método bloquear pagamento de dinheiro

        //Método bloquear pagamento de cartão
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
        }//Fim do método bloquear pagamento de cartão

        //Método registrar manutenção
        public void RegistrarManutencao()
        {
            Console.WriteLine("Informe o Usuario: ");
            string usuario = Console.ReadLine();

            Console.WriteLine("\nInforme a Senha: ");
            int senha = Convert.ToInt32(Console.ReadLine());

            //Chamar o método alterarSituação - Classe Produto
            prod.AlterarSituacao(codigo);
            Console.WriteLine("Alterado!");
        }//Fim do método registrar manutenção

        //Método efetuar saque
        public void EfetuarSaque()
        {
            Console.WriteLine("Informe o Usuario: ");
            string usuario = Console.ReadLine();

            Console.WriteLine("\nInforme a Senha: ");
            int senha = Convert.ToInt32(Console.ReadLine());

            //Chamar o método alterarSituação - Classe Produto
            prod.AlterarSituacao(codigo);
            Console.WriteLine("Alterado!");
        }//Fim do método efetuar saque

    }//Fim da classe
}//Fim do projeto