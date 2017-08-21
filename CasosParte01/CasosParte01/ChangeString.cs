using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CasosParte01
{
    public class ChangeString
    {
        string ABC = "abcdefghijklmnñopqrstuvwxyz";

        public string build(string parametro)
        {
            string caracter = "";
            string cod1 = "";
            char[] cod2 = parametro.ToCharArray();

            foreach(char variable in cod2)
            {
                caracter = variable.ToString();

                if (char.IsLetter(variable))//verifica si es una letra
                {

                    for (int j = 0; j < ABC.Length; j++)
                    {
                        if (caracter.Equals(ABC.Substring(j, 1)))
                        {
                            if (caracter.Equals("Z"))
                            {
                                cod1 = cod1 + "A";
                            }
                            else
                            {
                                cod1 = cod1 + ABC.Substring(j + 1, 1);
                            }
                        }

                    }
                }
                else
                {
                    cod1 = cod1 + caracter;
                }
            }

            return cod1;
        }
    }
}