using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ProyectoFinal;

namespace ProyectoFinal
{
    class Trabajo
    {

        static void Main()
        {

            InicioSesion.Inicio();
            bool showMenu = true;

            while (showMenu)
            {
                showMenu = Menu(); //llamado al metodo Menu()
            }
            Console.ReadKey();
        }




        private static bool Menu()
        {

            
            Console.WriteLine("Seleccion la operación a realizar: ");
            Console.WriteLine("1. Registrar nuevo usuario");
            Console.WriteLine("2. borrar archivo");
            Console.WriteLine("3. Mostrar archivo");
            Console.WriteLine("4. Salir");
            Console.Write("\nOpcion: ");

            switch (Console.ReadLine())
            {
                case "1":
                    register(); //llamado al metodo registrar
                    return true;
               
                case "2":
                   Delete();//lamado al metodo eliminar
                    Console.ReadKey();
                    return true;
                case "3":
                    //mostrar el contenido del archivo
                    Mostrar();
                    Console.WriteLine("alumnos");
                  
                    Console.ReadKey();
                    return true;
                case "4":
                    return false;
                default:
                    return false;
                    
            }
        }



        //metodo para obtener la ruta del archivo
        private static string getPath()
        {
            string path = @"D:\ejemplo\trabajo.txt";
            return path;
        }

        //metodo para registrar al usuario
        private static void register()
        {
           

            
        }

        //David Fernandez

        //leer archivo
        private static void Mostrar()
        {

            //comentario del aprendizaje de primer computo
         
            string codigo = "SMIS031521";
            string aprendi = "Bryan Josue Quintanilla Martinez: aprendi de manera confiable sobre los elementos basicos de c# , puse mas o mnenos en practica el aprendizaje adquirido y espero que todo me salga bien. Hay que seguir aprendiendo poco a poco";
            //crear el archivo, uso de StreamWriter para escribir el archivo
            using (StreamWriter sw = File.AppendText(getPath()))
            {

                sw.WriteLine("{0}; {1}", codigo,aprendi);

                sw.Close();
            }
            string[] lines;
            lines = File.ReadAllLines(getPath());
            Console.WriteLine("CONTENIDO UTILIZANDO ReadAllLines");
            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine(lines[i]);
            }
        }

        //Borrar archivo
        private static void Delete()
        {

            string archivo = getPath();
            try
            {
                File.Delete(archivo);
                if (File.Exists(archivo))
                {
                    Console.WriteLine("El archivo sigue existiendo.");
                }
                else
                {
                    Console.WriteLine("El archivo ya no existe.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al borrar archivo: {0}", e.ToString());
            }
            Console.WriteLine("Presiona Enter para terminar.");
            var name = Console.ReadLine();
        }





    }
}
