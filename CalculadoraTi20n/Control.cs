using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTi20n
{
    class Control
    {
        //criei uma conexao com a classe model      
                
        Model mod;

        public Control() 
        {

            mod = new Model();//chamando o construtor da classe model
        
        }//fim do contrutor


        public string Menu()
        {
            string msg = "### Menu###\n\n" +
                         "0. Sair\n"+
                         "1. Somar\n" +
                         "2. Subtrair\n" +
                         "3. Multiplicar\n" +
                         "4. Dividir\n" +
                         "5. Tabuada\n" +
                         "6. Raiz\n"    +
                         "7. Potecia\n" +
                         "Escolha uma das opçoes acima:";

            return msg;

        }//fim do menu

        public void Operacao() 
        {
            int opcao;
            do
            {
                Console.WriteLine(Menu());// Mostrar as opçoes na tela
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {

                    case 0:
                        Console.WriteLine("Obrigado!!");
                        break;



                    case 1:
                        coletar();//Chamando o metodo coleta
                        Console.WriteLine("A soma dos valores digitados é: " + mod.Somar());
                        break;

                    case 2:
                        coletar();
                        Console.WriteLine("A subtração dos valores digitados é: " + mod.Subtrair());
                        break;

                    case 3:
                        coletar();//Chamando o metodo coleta
                        Console.WriteLine("A multiplicação dos valores digitador é: " + mod.Multiplicar());
                        break;

                    case 4:
                        coletar();
                        if (mod.Dividir() == -1)
                        {
                            Console.WriteLine("Impossivel dividir por zero!");

                        }
                        else
                        {
                            Console.WriteLine("A divisão dos valores digitados é: " + mod.Dividir());
                        }

                        Console.WriteLine("A divisão dos valores digitados é: " + mod.Dividir());
                        break;
                        case 5:
                            coletar();
                            Console.WriteLine("Tabuada: " + mod.Tabuada());
                            break;
                        case 6:
                            coletar();
                            Console.WriteLine(mod.Raiz());
                        break;
                        case 7: 
                            coletar();
                            Console.WriteLine("A Potencia é:" + mod.Potencia());
                        break;

                    default:
                        Console.WriteLine("Escolha uma opção válida!!");
                        break;
                }//fim do switch
            } while (opcao != 0);
        }//fim do Operacao

    public void coletar() 
    {
        //Coletando o primeiro número
        Console.WriteLine("Informe o primeiro numero");
        mod.ConsultarNum1 = Convert.ToDouble(Console.ReadLine());
        //coletando o segundo número
        Console.WriteLine("Informe o segundo numero");
        mod.ConsultarNum2 = Convert.ToDouble(Console.ReadLine());


        }//fim do metodo coletar



    }//fim da classe
}//fim do projeto
