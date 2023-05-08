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

    }
}
