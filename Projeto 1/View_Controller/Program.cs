using Projeto_1.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_1.View_Controller
{
    class Program
    {
        static void Main(string[] args)
        {

            int aux1, aux2;
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

                            do
                            {

                                text.Exer1_1();
                                validator.VerifyIsNumberInt(Console.ReadLine());
                                if (!validator.GetPass())
                                {
                                    text.ErrorNumber();
                                }

                            } while (!validator.GetPass());

                            if ((int)validator.GetNumber() % 2 == 0)
                            {
                                text.Exer1_2();
                            }
                            else
                            {
                                text.Exer1_3();
                            }

                            break;
                        case 2:

                            do
                            {
                                text.Exer2_1();
                                validator.VerifyIsNumberInt(Console.ReadLine());
                                if (!validator.GetPass())
                                {
                                    text.ErrorNumber();
                                }
                            } while (!validator.GetPass());

                            aux1 = (int)validator.GetNumber();

                            do
                            {
                                text.Exer2_2();
                                validator.VerifyIsNumberInt(Console.ReadLine());
                                if (!validator.GetPass())
                                {
                                    text.ErrorNumber();
                                }
                            } while (!validator.GetPass());

                            if(aux1 == (int)validator.GetNumber())
                            {

                            }else
                            {
                                if (aux1 < (int)validator.GetNumber())
                                {

                                    text.Exer2_3(aux1, (int)validator.GetNumber());

                                    Console.Write(aux1 + ", ");

                                    for (aux2 = aux1 + 1; aux2 < (int)validator.GetNumber(); aux2++)
                                    {
                                        Console.Write(aux2 + ", ");
                                    }

                                    Console.Write((int)validator.GetNumber());

                                }
                                else
                                {

                                    text.Exer2_3((int)validator.GetNumber(), aux1);

                                    Console.Write((int)validator.GetNumber() + ", ");

                                    for (aux2 = (int)validator.GetNumber() + 1; aux2 < aux1; aux2++)
                                    {
                                        Console.Write(aux2 + ", ");
                                    }

                                    Console.Write(aux1);
                                    text.waiting(3000);
                                }
                            }

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
