using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    class Pagamento
    {
        //Definição de variáveis
        private int codigo;
        private string descricao;
        private double valorTotal;
        private int formaDePagamento;
        private DateTime dataHora;

        //Método construtor
        public Pagamento()
        {
            ModificarCodigo = 0;
            ModificarDescricao = "";
            ModificarValorTotal = 0;
            ModificarFormaDePagamento = 0;
            ModificarDataHora = new DateTime();//0000/00/00 00:00:00
        }//Fim do método construtor

        //Método construtor com parâmetros
        public Pagamento(int codigo, string descricao, double valorTotal, int formaDePagamento, DateTime dataHora)
        {
            ModificarCodigo = codigo;
            ModificarDescricao = descricao;
            ModificarValorTotal = valorTotal;
            ModificarFormaDePagamento = formaDePagamento;
            ModificarDataHora = dataHora;
        }//Fim do método construtor com parâmetros

        //Métodos Get e Set
        //Métodos de acesso e modificação
        public int ModificarCodigo
        {
            get
            {
                return this.codigo;
            }//Fim do get - retornar o código

            set
            {
                this.codigo = value;
            }//Fim do set - modificar o código
        }//Fim do ModificarCodigo

        public string ModificarDescricao
        {
            get
            {
                return this.descricao;
            }//Fim do get - retornar a descrição

            set
            {
                this.descricao = value;
            }//Fim do set - modificar a descrição
        }//Fim do ModificarDescrição

        public double ModificarValorTotal
        {
            get
            {
                return this.valorTotal;
            }//Fim do get - retornar o valor total

            set
            {
                this.valorTotal = value;
            }//Fim do set - modificar o valor total
        }//Fim do ModificarPreco

        public int ModificarFormaDePagamento
        {
            get
            {
                return this.formaDePagamento;
            }//Fim do get - retornar a forma de pagamento

            set
            {
                this.formaDePagamento = value;
            }//Fim do set - modificar a forma de pagamento
        }//Fim do ModificarQuantidade

        public DateTime ModificarDataHora
        {
            get
            {
                return this.dataHora;
            }//Fim do get - retornar a data e a hora

            set
            {
                this.dataHora = value;
            }//Fim do set - modificar a data e a hora
        }//Fim do ModificarDtValidade

        //Método verificar notas
        public Boolean VerificarNotas(int codigo, Boolean validacao)
        {
            string msg = "";//Criando uma variável local
            if (ModificarCodigo == codigo)
            {
                msg = "Código:" + ModificarCodigo + "Essa nota é:" + validacao;
            }
            else
            {
                msg = "O código digitado não existe!";
            }//Fim do se e senão

            return msg;
        }//Fim do método verificar notas

        //Método verificar troco
        public Boolean VerificarTroco(int codigo, double validacao)
        {
            double valorEntrada = 0;//Criando uma variável local
            string msg = "";//Criando uma variável local
            if (ModificarCodigo == codigo)
            {
                validacao = ModificarValorTotal - valorEntrada;
                msg = "O valor do Troco é :" + validacao;
            }
            else
            {
                msg = "O código digitado não existe!";
            }//Fim do se e senão

            return msg;
        }//Fim do método verificar troco

        //Método verificar troco
        public string ValidarCartao(int codigo, string cartao, string validacao)
        {
            int cartaoCredito = 0;
            int cartaoDebito = 0;
            int dinheiro = 0;
            if (ModificarCodigo == codigo)
            {
                switch (validacao)
                {
                    case 1:
                        Console.WriteLine("Insira o cartão de crédito: ");
                        int cartaoCredito = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Insira o cartão de débito: ");
                        int cartaoDebito = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Insira o dinheiro: ");
                        int dinheiro = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Digite um número válido: ");
                        Console.ReadLine();
                        break;
                }//Fim da escolha
            }//Fim do if
        }//Fim do método atualizar produto

        //Método efetuar pagamento
        public double EfetuarPagamento(int codigo)
        {
            Boolean flag = false;
            if (ModificarCodigo == codigo)
            {
                if (ModificarSituacao == true)
                {
                    ModificarSituacao = false;
                }
                else
                {
                    ModificarSituacao = true;
                }//Fim do AlterarSituacao
                flag = true;
            }//Fim do se  senão
            return flag;
        }//Fim do Método efetuar pagamento

        //Método consultar pagamento
        public Boolean ConsultarPagamento()
        {
            if (ModificarCodigo == codigo)
            {
                if (ModificarQuantidade <= 3)
                {
                    return true;
                }
            }//Fim do se senao
            return false;
        }//Fim do método solicitar produto

    }//Fim da classe
}//Fim do Projeto