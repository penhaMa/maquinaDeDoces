using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    class Produto
    {
        //Definição de variáveis
        private int codigo;
        private string nome;
        private string descricao;
        private double preco;
        private int quantidade;
        private DateTime dtValidade;
        private Boolean situacao;

        //Método construtor
        public Produto()
        {
            ModificarCodigo     = 0;
            ModificarNome       = "";
            ModificarDescricao  = "";
            ModificarPreco      = 0;
            ModificarQuantidade = 0;
            ModificarDtValidade = new DateTime();//0000/00/00 00:00:00
            ModificarSituacao   = false;
        }//Fim do método construtor

        //Método construtor com parâmetros
        public Produto(int codigo, string nome, string descricao, double preco, int quantidade, DateTime dtValidade, Boolean situacao)
        {
            ModificarCodigo     = codigo;
            ModificarNome       = nome;
            ModificarDescricao  = descricao;
            ModificarPreco      = preco;
            ModificarQuantidade = quantidade;
            ModificarDtValidade = dtValidade;
            ModificarSituacao   = situacao;
        }//Fim do método construtor com parâmetros

        //Métodos Get e Set
        //Métodos de acesso e modificação
        public int ModificarCodigo
        {
            get{
                return this.codigo;
            }//Fim do get - retornar o código

            set{
                this.codigo = value;
            }//Fim do set - modificar o código
        }//Fim do ModificarCodigo

        public string ModificarNome
        {
            get
            {
                return this.nome;
            }//Fim do get - retornar o nome

            set
            {
                this.nome = value;
            }//Fim do set - modificar o nome
        }//Fim do ModificarNome

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

        public double ModificarPreco
        {
            get
            {
                return this.preco;
            }//Fim do get - retornar o preço

            set
            {
                this.preco = value;
            }//Fim do set - modificar o preço
        }//Fim do ModificarPreco

        public int ModificarQuantidade
        {
            get
            {
                return this.quantidade;
            }//Fim do get - retornar a quantidade

            set
            {
                this.quantidade = value;
            }//Fim do set - modificar a quantidade
        }//Fim do ModificarQuantidade

        public DateTime ModificarDtValidade
        {
            get
            {
                return this.dtValidade;
            }//Fim do get - retornar a DtValidade

            set
            {
                this.dtValidade = value;
            }//Fim do set - modificar a DtValidade
        }//Fim do ModificarDtValidade

        public Boolean ModificarSituacao
        {
            get
            {
                return this.situacao;
            }//Fim do get - retornar a situação

            set
            {
                this.situacao = value;
            }//Fim do set - modificar a situação
        }//Fim do ModificarSituação

        //Método cadastrar produto
        public void CadastrarProduto(int codigo, string nome, string descricao, double preco, int quantidade, DateTime dtValidade, Boolean situacao)
        {
            ModificarCodigo     = codigo;
            ModificarNome       = nome;
            ModificarDescricao  = descricao;
            ModificarPreco      = preco;
            ModificarQuantidade = quantidade;
            ModificarDtValidade = dtValidade;
            ModificarSituacao   = situacao;
        }//Fim do método cadastrar produto

        //Método consultar produto
        public string ConsultarProduto(int codigo) 
        {
            string msg = "";//Criando uma variável local
            if (ModificarCodigo == codigo)
            {
                msg = "Código:"              + ModificarCodigo     +
                      "\nNome: "             + ModificarNome       +
                      "\nDescrição: "        + ModificarDescricao  +
                      "\nPreço: "            + ModificarPreco      +
                      "\nQuantidade: "       + ModificarQuantidade +
                      "\nData de Validade: " + ModificarDtValidade +
                      "\nSituação: "         + ModificarSituacao;
            }
            else 
            {
                msg = "O código digitado não existe!";
            }//Fim do se e senão

            return msg;
        }//Fim do método consultar produto

        //Método atualizar produto
        public Boolean AtualizarProduto(int codigo, int campo, string novoDado) 
        {
            Boolean flag = false;
            if (ModificarCodigo == codigo)
            {
                switch (campo) 
                {
                    case 1:
                        ModificarNome = novoDado;
                        flag = true;
                        break;
                    case 2:
                        ModificarDescricao = novoDado;
                        flag = true;
                        break;
                    case 3:
                        ModificarPreco = Convert.ToDouble(novoDado);
                        flag = true;
                        break;
                    case 4:
                        ModificarQuantidade = Convert.ToInt32(novoDado);
                        flag = true;
                        break;
                    case 5:
                        ModificarDtValidade = Convert.ToDateTime(novoDado);
                        flag = true;
                        break;
                    case 6:
                        ModificarSituacao = Convert.ToBoolean(novoDado);
                        flag = true;
                        break;
                    default:
                        break;
                }//Fim da escolha
                return flag;
            }//Fim do if
            return flag;
        }//Fim do método atualizar produto

        //Método alterar situacao
        public Boolean AlterarSituacao(int codigo) 
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
                flag= true;
            }//Fim do se  senão
            return flag;
        }//Fim do Método AlterarSituacao

        //Método solicitar produto
        public Boolean SolicitarProduto() 
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
}//Fim do projeto
