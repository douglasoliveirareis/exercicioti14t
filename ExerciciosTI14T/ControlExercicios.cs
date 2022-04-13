using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosTI14T
{
    class ControlExercicios
    {
        //Ligar as duas classes
        ModelExercicios model;
        private int opcao;
        public ControlExercicios()
        {
            model = new ModelExercicios();//Chamando o construtor da classe Model Exercicios
        }//fim do construtor

        public int ConsultarOpcao
        {
            get
            {
                return opcao;
            }
            set
            {
                this.opcao = value;
            }
        }
        public void Menu()
        {
            Console.WriteLine("---- Menu ----" +
                             "\n1. Exercício 01" +
                             "\n2. Exercício 02" +
                             "\n3. Exercício 03");
            Console.WriteLine("Escolha uma das opções acima: ");
            ConsultarOpcao = Convert.ToInt32(Console.ReadLine());
        }//fim do menu

        public void Executar()
        {
            Menu();
            //Executar a ação
            switch (ConsultarOpcao)
            {
                case 1:
                    Console.WriteLine(model.Exercicio01());
                    break;
                case 2:
                    do
                    {
                        Console.WriteLine("informe a base");
                        bas = Convert.ToDouble(Console.ReadLine());
                        if (bas <= 0)
                        {
                            Console.WriteLine("base digitada não é valida, digite novamente! ");
                        }
                    } while (bas <= 0);
                    do
                    {
                        Console.WriteLine("informe a altura: ");
                        altura = Convert.ToDouble(Console.ReadLine());
                        if (altura <= 0)
                        {
                            Console.WriteLine("altura digitada não é valida, digite novamente!");
                        }
                    } while (altura <= 0);
                    Console.WriteLine("A área do retângulo é: " + model.Exercício02(bas, altura));

                    break;

                
                    
                default:
                    Console.WriteLine("Código digitado não é valido!");
                    break;
            }//fim do switch
        }//fim do executar
    }//fim da classe
}//fim do projeto
