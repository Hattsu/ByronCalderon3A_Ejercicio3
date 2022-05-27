using System;
namespace ByronCalderon3A_Ej3
{
    public class Num_mayor
    {
        private int numero_1
        {
            set; get;
        }
        private int numero_2
        {
            set; get;
        }
        private int numero_3
        {
            set; get;
        }
        public Num_mayor(int numero_1, int numero_2, int numero_3)
        {
            this.numero_1 = numero_1;
            this.numero_2 = numero_2;
            this.numero_3 = numero_3;
        }
        public void Elegir_mayor()
        {
            if(numero_1 > numero_2 && numero_1 > numero_3)
            {
                Console.WriteLine("El número ("+numero_1+") es mayor que ("+numero_2+"y "+numero_3+")");
            }
            else if(numero_2 > numero_1 && numero_2 > numero_3)
            {
                Console.WriteLine("El número ("+numero_2+") es mayor que ("+numero_1+"y "+numero_3+")");
            }
            else 
            {
                Console.WriteLine("El número ("+numero_3+") es mayor que ("+numero_1+"y "+numero_2+")");
            }
            Console.ReadKey();
        }
        
    }
}