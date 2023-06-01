using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    class Pagamento
    {
        //Definição de variáveis
        private int codigo;
        private double valorTotal;
        private short formaDePagamento;
        private DateTime dataHora;
        private int codCartao;
        private short bandeiraCartao;
        private double trocoMaquina;
        private double troco;

        //Método construtor
        public Pagamento()
        {
            ModificarCodigo = 0;
            ModificarValorTotal = 0;
            ModificarFormaDePagamento = 0;
            ModificarDataHora = new DateTime();//0000/00/00 00:00:00
            ModificarCodCartao = 0;
            ModificarBandeiraCartao = 0;
            ModificarTrocoMaquina = 100;
            ModificarTroco = 0;
        }//Fim do método construtor

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

        public short ModificarFormaDePagamento
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

        public int ModificarCodCartao
        {
            get
            {
                return this.codCartao;
            }//Fim do get - retornar o código

            set
            {
                this.codCartao = value;
            }//Fim do set - modificar o código
        }//Fim do ModificarCodigo

        public short ModificarBandeiraCartao
        {
            get
            {
                return this.bandeiraCartao;
            }//Fim do get - retornar o código

            set
            {
                this.bandeiraCartao = value;
            }//Fim do set - modificar o código
        }//Fim do ModificarCodigo

        public double ModificarTrocoMaquina
        {
            get
            {
                return this.trocoMaquina;
            }//Fim do get - retornar o código

            set
            {
                this.trocoMaquina = value;
            }//Fim do set - modificar o código
        }//Fim do ModificarCodigo

        public double ModificarTroco
        {
            get
            {
                return this.troco;
            }//Fim do get - retornar o código

            set
            {
                this.troco = value;
            }//Fim do set - modificar o código
        }//Fim do ModificarTroco

        //Método Verificar Notas
        public string VerificarNotas(double entradaDinheiro, double valorProduto)
        {
            if (entradaDinheiro >= valorProduto)
            {
                return "OK";
            }
            else
            {
                return "NOK";
            }//Fim do se e senão

        }//Fim do Verificar Notas

        //Método Existe Troco
        public Boolean ExisteTroco(double entradaDinheiro, double valorProduto)
        {
                if (entradaDinheiro > valorProduto)
                {
                    return true;
                }//Fim do se e senão

                return false;
            
        }//Fim do ExisteTroco

        //Método verificar troco
        public void VerificarTroco(double entradaDinheiro, double valorProduto)
        {
            Boolean respTroco = false;
            respTroco = ExisteTroco(entradaDinheiro, valorProduto);
            if (respTroco == true)
            { 
                ModificarTroco = entradaDinheiro - valorProduto;
            }
            else
            {
                ModificarTroco = 0;
            }
        }//Fim do método verificar troco

        //Método Menu forma de pagamento
        public string MenuFormadePagamento()
        {
            return "Escolher uma das opções abaixo:" + "\n1. Dinheiro \n2. Cartão";
        }//Fim do método Menu forma de pagamento

        //Método efetuar pagamento
        public void EfetuarPagamentoDinheiro(double entradaPagamento, double valorProduto)
        {
            string resp = "";
            resp = VerificarNotas(entradaPagamento, valorProduto);
           
            if (resp == "OK")
            {
                ModificarCodigo++;
                ModificarValorTotal = valorProduto;
                ModificarFormaDePagamento = 1;
                ModificarDataHora = DateTime.Now;//Pegar a data é hora da transação
                ModificarTrocoMaquina += valorProduto;
                VerificarTroco(entradaPagamento, valorProduto);
                imprimir();
            }
        }//Fim do Método efetuar pagamento

        //Método Efetuar pagamento cartao
        public void EfetuarPagamentoCartao(double entradaPagamento, double valorProduto, int codCartao, short bandeiraCartao)
        {
            ModificarCodigo++;
            ModificarValorTotal = valorProduto;
            ModificarFormaDePagamento = 1;
            ModificarDataHora = DateTime.Now;//Pegar a data é hora da transação
            ModificarBandeiraCartao = bandeiraCartao;
            ModificarCodCartao = codCartao;
            imprimir();
        }//Fim do método efetuar pagamento cartao

        //Método imprimir
        public string imprimir()
        {
            return "Código: "               + ModificarCodigo           +
                   "\nValor Total: "        + ModificarValorTotal       +
                   "\nTroco: "              + ModificarTroco            +
                   "\nForma de Pagamento: " + ModificarFormaDePagamento +
                   "\nData e Hora: "        + ModificarDataHora;
        }//Fim do método imprimir

    }//Fim da classe
}//Fim do Projeto