using System;

namespace Tarea_Franko_Mejia
{
    class Program
    {
        public static void Main(string[] args) // Franko Mejía C.I: 30.077.625
        {
            int edad = 0;
            string datos = "";
            string nombre1 = "";
            double tamaño = 0.00;
          
            Console.WriteLine("Hola, Bienvenido a Jurassic World!, el único parque jurásico con dinosaurios reales en todo el mundo!!");
            Console.WriteLine("Por motivos de seguridad ingresa tu Nombre y Apellido para guardarte en nuestros servidores:");
            nombre1= Console.ReadLine();
            Console.WriteLine("Perfecto {0}!, ahora necesitamos guardar tus datos", nombre1);
            
            Console.WriteLine("Bienvenido a la sala de registros, debemos conocer tu edad para darte acceso a la zona Safari");
            Console.WriteLine("¿Cúal es tu edad?");
            datos = Console.ReadLine();
            edad = Convert.ToInt32(datos);

            if(edad >= 0) 
            {
                if(edad > 17)
                     { 
                         if(edad >= 18 && edad <= 70) 
                         {
                             Console.WriteLine("Eres mayor de edad, perfecto!");
                             Console.WriteLine("Ahora necesitamos tu altura en metros para saber a que atracciones tienes permitido entrar");
                             Console.WriteLine("¿Cuánto mides?");
                             tamaño = Convert.ToDouble(Console.ReadLine());
                             
                             if(tamaño > 0) 
                             {
                                if(tamaño < 1.50) // SI ES VERDADERO EJECUTA ESTA CONDICIÓN, SINO EJECUTA LA CONDICIÓN CONTRARIA (ELSE) 
                                {
                                    Console.WriteLine("No cumples los requisitos de seguridad para entrar a la zona de riesgo del parque");
                                }    
                                else if (tamaño >= 1.50)
                                {
                                    if(tamaño <= 2.10) // SI LA PERSONA TIENE UNA MEDIDA ENTRE ESTOS VALORES, PODRÁ ENTRAR
                                    {
                                        Console.WriteLine("Excelente {0}, puedes disfutar de todas las atracciones del parque... Disfruta!", nombre1);
                                    }      
                                    else if(tamaño > 2.10 ) // DE LO CONTRARIO, SUPERARÁ LAS MEDIDAS DE ALTURA
                                    {
                                        Console.WriteLine("Excediste los parámetros de altura requeridos");
                                    }           
                                }                                                        
                             }       
                          }                                                 
                         else if(edad > 70)
                         {
                             Console.WriteLine("Disculpa, superas los parámetros de edad para entrar a las atracciones del parque jurásico");
                         }
                }
                else
                {
                    Console.WriteLine("Disculpa, eres menor de edad para entrar a las atracciones de riesgo del parque jurásico");
                }
            }
             else 
             {
                Console.WriteLine("ERROR, no se puede colocar un número negativo");
             }
             Console.Write("Presiona cualquier tecla para continuar. . . .");
              Console.ReadKey(true);
        }
    }
} 
