using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Conecta com a classe Control Produto
            ControlProduto controlProd = new ControlProduto();

            //Chamar o método principal daquela classe
            controlProd.Operacao();

            Console.ReadLine();//Manter a janela aberta
        }//Fim do método main
    }//Fim da classe
}//Fim do projeto
