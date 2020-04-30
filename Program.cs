using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Verificar_Cpf
{
  
 
    class Program
    {

        public static bool Cpf(string cpf)
        {
            if (cpf.Length != 11) return false;

            // Veriricar o Primeiro digito;

            int k = 0;
            int soma = 0, r, t;

            for (int cont = 10; cont >= 2; cont--)
            {
                soma += cont * (int)Char.GetNumericValue(cpf[k]);

                k++;
            }

            int rest = soma % 11;

            t = 11 - rest;



            r = (int)Char.GetNumericValue(cpf[9]);
            if (rest == 0 || rest == 1)
            {
                if (r != 1 || r != 0)
                {
                    
                    Console.WriteLine("cpf incorreto parte 1 0");

                    return false;

                }
            }
            else
            {
                t = 11 - rest;



                if (t != r)
                {
                   

                    return false;
                }
            }        

    // Verificar o segundo digito      
            soma = 0; rest = 0; k = 0;
            for (int cont = 11; cont > 2; cont--)
            {

                soma += cont * (int)Char.GetNumericValue(cpf[k]);

                k++;
            }
            soma += t * 2;

            rest = soma % 11;
            t = 11 - rest;


            r = (int)Char.GetNumericValue(cpf[10]);
            if (rest == 0 || rest == 1)
            {
                if (r != 1 || r != 0)
                {
                   
                    return false;

                }


            }
            else
            {
                if (t != r)
                {                    
                    return false;
                }
            }


            return true;

        }

        static void Main(string[] args)
        {
            Console.Write("Digite seu CPF:  ");
            Console.Write(Cpf(Console.ReadLine()));



        }
    }
}
