using System;

// Paso 2: Creamos una clase llamada ConsolePrinter que implementa la interfaz IPrinter para imprimir en la consola.
namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}