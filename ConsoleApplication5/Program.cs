using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n\n - - Cuadro de basquet - - \n\n");
            
            int alturacm;
            bool alturaok = true;

            string vigencia = "si";
            string vigenciaok;
            bool ingreso;
        


           

            // Validacion de altura minima
            Console.WriteLine("Ingrese su altura en cm: ");

            alturacm = Convert.ToInt32(Console.ReadLine());

            alturaok = alturacm > 180;
           


            
            //Validacion de carnet vigente
            
            Console.WriteLine("Usted tiene su carnet de salud vigente si/no: ");
            vigenciaok = Console.ReadLine();

           

            ingreso = (vigenciaok == vigencia) && (alturaok); 
        
            // validacion final
            Console.WriteLine("Puede Ingresar"+ ingreso);
            Console.ReadLine(); 



          
        
        }
    }
}
