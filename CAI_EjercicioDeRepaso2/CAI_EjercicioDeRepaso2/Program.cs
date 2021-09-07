using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_EjercicioDeRepaso2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int nro_registro = 976;
            string contador = "";
            int i;
            

            do
            {
                bool primo = false;
                numero = numero + 1;
                for (i = 2;i < numero; i++)
                {
                    if (numero % i == 0)
                    {
                        primo = true;
                        break;
                    }
                }

                if(primo==true)
                {
                    if(numero%3==0)
                    {
                        contador = contador + numero + " - es divisible por 3 " + "\n";
                    }
                    else
                    {
                        contador = contador + numero + "\n";
                    }
                }
                    else
                    {
                        contador = contador + numero + " - es primo " + "\n";
                    }
             
            } while (numero < nro_registro);

            Console.WriteLine(contador);
            Console.ReadKey();
        }
    }
}
