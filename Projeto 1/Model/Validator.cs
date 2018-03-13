using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_1.Model
{
    class Validator
    {

        float number;
        bool pass;
        /// <summary>
        /// Este é metodo contrudot do objeto Validar que define o atributo pass para false
        /// </summary>
        public Validator()
        {
            pass = false;
        }
        /// <summary>
        /// Este metodo retorna recebe uma string, valida a entrada e define o atributo number com o valor passado
        /// </summary>
        /// <param name="value"></param>
        public void VerifyIsNumberInt(String value)
        {

            try
            {
                number = Convert.ToInt32(value);
                pass = true;
            }
            catch (FormatException e)
            {
                this.pass = false;
            }
        }
        /// <summary>
        /// Este metodo retorna recebe uma Func<string>, valida a entrada e define o atributo number com o valor passado
        /// </summary>
        /// <param name="value"></param>
        public void VerifyIsNumberInt(Func<string> value)
        {

            try
            {
                number = Convert.ToInt32(value);
                pass = true;
            }
            catch (FormatException e)
            {
                this.pass = false;
            }
        }

        /// <summary>
        /// Este metodo retorna o atributo number do objeto Validator
        /// </summary>
        /// <returns></returns>
        public float GetNumber()
        {
            return this.number;
        }
        /// <summary>
        /// Este metodo retorna o atributo pass do objeto Validator
        /// </summary>
        /// <returns></returns>
        public bool GetPass()
        {
            return this.pass;
        }

    }
}
