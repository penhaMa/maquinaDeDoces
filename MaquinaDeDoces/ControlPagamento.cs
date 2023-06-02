using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    class ControlPagamento
    {
        Pagamento pgto;
        private short opcao;

        //Método construtor
        public ControlPagamento()
        {
            pgto = new Pagamento();
        }//Fim do construtor

        //Método Get e Set
        public short ModificarOpcao
        {
            get { return opcao; }
            set { opcao = value; }
        }
        //Fim do método get e set

        //Método Escolher forma de pagamento
        public void EscolherFormaDePagamento()
        {
            Console.WriteLine(pgto.MenuFormaDePagamento());//Mostrando o menu na tela
            short opcao = Convert.ToInt16(Console.ReadLine());//Coletando a resposta
        }
        //Fim do método Escolher forma de pagamento

        //Método Operação
        public void Operacao()
        {
            EscolherFormaDePagamento();

            switch (ModificarOpcao)
            { 
                case 1:
                    Console.WriteLine("Pgamento com Dinheiro: \n\n");
                    Console.WriteLine("Valor Inserido na máquina: ");
                    double valorInserido = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("\n\nValor do Produto: ");
                    double valorProduto = Convert.ToDouble(Console.ReadLine());

                    //Utilizar o método efetuar pagamento dinheiro
                    pgto.EfetuarPagamentoDinheiro(valorInserido, valorProduto);
                    Console.WriteLine(pgto.imprimir());
                    break;
                case 2:
                    Console.WriteLine("Pgamento com Cartão: \n\n");
                    Console.WriteLine("\n\nValor do Produto: ");
                    valorProduto = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("\n\nCódigo do Cartão: ");
                    int codCartao = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\n\nBandeira do Cartão: \n1- Visa\n2-Mastercard\n3-Elo");
                    short bandeiraCartao = Convert.ToInt16(Console.ReadLine());

                    //Utilizar o método efetuar pagamento dinheiro
                    pgto.EfetuarPagamentoCartao(valorProduto, codCartao, bandeiraCartao);
                    Console.WriteLine(pgto.imprimir());
                    break;
                default: 
                    Console.WriteLine("Impossivel realizar a operação, tente novamente!");
                    break;
            }//Fim do switch
        }//Fim do método operação

    }//Fim da classe
}//Fim do projeto
