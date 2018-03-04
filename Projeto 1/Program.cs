using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_1
{
    class Program
    {
        static void Main(string[] args)
        {

            bool exit = false;

            Text text = new Text();
            Validator validator = new Validator();

            do
            {

                text.Menu();

                validator.VerifyIsNumberInt(Console.ReadLine());

                if (validator.GetPass())
                {
                    switch ((int)validator.GetNumber())
                    {
                        case 1:

                            Exer1 exer = new Exer1();
                            exer.execute(text, validator);

                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                        case 6:
                            break;
                        default:

                            exit = true;
                            text.Exit();

                            break;
                    }
                }else
                {
                    text.ErrorNumber();
                }

            } while (exit == false);

        }
    }
}
