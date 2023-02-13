using System;
using System.IO;
namespace VirtualGift.Programacion.Helper
{
    public class ArchivoHelper
    {
        private static string extension = ".VGSave";
        public static void CrearArchivoGuardado(string nombre, String contenido)
        {
            StreamWriter miEscritura = File.CreateText(nombre + extension);

            //string[] strings = Split(contenido as String, vbLf);
            // Escribimos en el archivo. El tipo de objeto Streamwritter
            // tiene una clase llamada Write y otra llamada WriteLine.
            // Para escribir en el archivo solo tenemos que hacer uso
            // del objeto creado anteriormente llamado miEscritura

            miEscritura.WriteLine(contenido);
            
            // Cerramos el archivo. Al cerrarlo, se guardará en la carpeta
            // debug del directorio bin.
            miEscritura.Close();
        }

        public static string LeerArchivoGuardado(string nombre)
        {
            string lineaLeida = "Error en lectura";
            string leida = string.Empty;
            try
            {
                // Creamos un objeto para leer el archivo.
                StreamReader miLectura = File.OpenText(nombre + extension);

                lineaLeida = miLectura.ReadLine();
                
                // Cerramos el archivo
                miLectura.Close();

            }
            catch (Exception msg) // Si no se puede leer mostramos el error
            {
                throw msg;

               // return "Ha habido un error";
            }

            return lineaLeida;
        }


    }
}
