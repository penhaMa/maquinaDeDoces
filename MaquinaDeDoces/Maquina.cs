using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    internal class Maquina
    {
        //Definição de variáveis
        private int codigo;
        private string descricao;
        private string usuario;
        private int senha;
        private string local;
        private double valorReal;

        //Método construtor
        public Maquina()
        {
            ModificarCodigo = 0;
            ModificarDescricao = "";
            ModificarUsuario = "";
            ModificarSenha = 0;
            ModificarLocal = "";
            ModificarValorReal = 0;
        }//Fim do método construtor

        //Método construtor com parâmetros
        public Maquina(int codigo, string descricao, string usuario, int senha, string local, double valorReal)
        {
            ModificarCodigo = codigo;
            ModificarDescricao = descricao;
            ModificarUsuario = usuario;
            ModificarSenha = senha;
            ModificarLocal = local;
            ModificarValorReal = valorReal;
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
        }//Fim do ModificarDescricao

        public string ModificarUsuario
        {
            get
            {
                return this.usuario;
            }//Fim do get - retornar o usuario

            set
            {
                this.usuario = value;
            }//Fim do set - modificar o usuario
        }//Fim do ModificarUsuario

        public int ModificarSenha   
        {
            get
            {
                return this.senha;
            }//Fim do get - retornar a senha

            set
            {
                this.senha = value;
            }//Fim do set - modificar a senha
        }//Fim do ModificarSenha

        public string ModificarLocal
        {
            get
            {
                return this.local;
            }//Fim do get - retornar o local

            set
            {
                this.local = value;
            }//Fim do set - modificar o local
        }//Fim do ModificarLocal

        public double ModificarValorReal
        {
            get
            {
                return this.valorReal;
            }//Fim do get - retornar o valor real

            set
            {
                this.valorReal = value;
            }//Fim do set - modificar o valor real
        }//Fim do ModificarValorReal


    }//Fim da classe
}//Fim do Projeto
