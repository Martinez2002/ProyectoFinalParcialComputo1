using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ProyectoFinal
{
    class InicioSesion
    {
        //FALTA TERMINAR
        public static void Inicio()
        {
            
            int i = 0;
            //usuario nivel 1 ADMIN
            
            Console.WriteLine("1. Iniciar sesion ADMIN");
            Console.WriteLine("2. Iniciar sesion usuario");
            Console.WriteLine("3. Crear usuario");

            string IS = Console.ReadLine();

            if (IS == "1")
            {
                while (i < 3)
                {
                    Console.WriteLine("Ingrese el usuario");
                    string usuario = Console.ReadLine();
                    Console.WriteLine("Ingrese la contraseña");
                    string contraseña = Console.ReadLine();
                    i++;


                    if ((usuario == "admin") && (contraseña == "123"))
                    {
                        i = 4;
                        Console.WriteLine("Ha ingresado exitosamente");


                    }
                    else
                    {
                        Console.WriteLine("El nombre de usuario o contraseña son incorrctos");

                        if (i == 3)
                        {
                            Console.WriteLine("Has excedido el numero de intentos");
                            Environment.Exit(2);
                        }

                    }
                }
            } 
            if (IS == "2")
            {
                
                while (i < 3)
                {
                    Console.WriteLine("Ingrese el usuario");
                    string usuario = Console.ReadLine();
                    Console.WriteLine("Ingrese la contraseña");
                    string contraseña = Console.ReadLine();
                    i++;


                    if ((usuario == "user") && (contraseña == "contra"))
                    {
                        i = 4;
                        Console.WriteLine("Ha ingresado exitosamente");


                    }
                    else
                    {
                        Console.WriteLine("El nombre de usuario o contraseña son incorrctos");

                        if (i == 3)
                        {
                            Console.WriteLine("Has excedido el numero de intentos");
                            Environment.Exit(2);
                        }

                    }
                }
            }
            if (IS == "3")
            {
                Console.WriteLine("Ingrese el nombre de usuario a crear");
                string usuario = Console.ReadLine();
                Console.WriteLine("ingrese la contraseña");
                string contraseña = Console.ReadLine();
                
            }
         
           

            






            Console.ReadKey();
           
            

        }



    }
}
