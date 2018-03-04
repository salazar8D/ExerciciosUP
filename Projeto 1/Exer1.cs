using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_1
{
    class Exer1
    {
        /// <summary>
        /// Este metodo executa o codigo para o Exercicio 1 recebendo os objetos Text e Validator
        /// </summary>
        /// <param name="text"></param>
        /// <param name="validator"></param>
        public void execute(Text text, Validator validator)
        {

            do
            {

                text.Exer1_1();
                validator.VerifyIsNumberInt(Console.ReadLine());
                if (!validator.GetPass())
                {
                    text.ErrorNumber();
                }

            } while (!validator.GetPass());

            if ((int) validator.GetNumber() % 2 == 0)
            {
                text.Exer1_2();
            }else
            {
                text.Exer1_3();
            }

        }

    }
}
