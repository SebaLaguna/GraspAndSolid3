using System;
using System.IO;

// Paso 3: Creamos una clase llamada FilePrinter que implementa la interfaz IPrinter para imprimir en un archivo.
namespace Full_GRASP_And_SOLID.Library
{
    public class FilePrinter : IPrinter
    {
        private string filePath;

        // Constructor que recibe la ruta del archivo donde se imprimirá.
        public FilePrinter(string filePath)
        {
            this.filePath = filePath;
        }

        public void Print(string text)
        {
            // Escribe el texto en el archivo especificado.
            File.WriteAllText(filePath, text);
        }
    }
}

