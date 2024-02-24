using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTi20n
{
    class Model
    {
        //Área de variaveis

        private double num1;
        private double num2;



        //método Construtor = Instancia as variaveis = dar valor inicial
        public Model()
        {
            ConsultarNum1 = 0;
            num2 = 0;





        }//fim do contrutor

        //metodo get e set toda variavel tem ,mostra e altera

        public double ConsultarNum1
        {
            get { return num1; }
            set { num1 = value; }      
        }//fim do get e set

        public double ConsultarNum2
        {
            get { return num2; }
            set { num2 = value; }
        }//fim do get e set



        public double Somar() 
        {
            return ConsultarNum1 + ConsultarNum2;                          
        
        }//fim do somar


        public double Subtrair() 
        { 
        
            return ConsultarNum1 - ConsultarNum2;
        
        }//fim do subtrair


        public double Multiplicar()
        {

            return ConsultarNum1 * ConsultarNum2;

        }//fim do multiplicar

        public double Dividir()
        {
            if (ConsultarNum2 <= 0)
            {
                return -1;
            }
            else
            {
                return ConsultarNum1 / ConsultarNum2;
            }
        }//fim do dividir









    }//fim da classe
}//fim do projeto
