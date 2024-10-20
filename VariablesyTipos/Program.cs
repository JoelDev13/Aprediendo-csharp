using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesyTipos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaración de variables de diferentes tipos de datos
            int numeroEntero = 100; 
            long numeroGrande = 123456789; 
            float numeroFlotante = 5.75F;
            double numeroDecimal = 3.14159; 
            decimal numeroPreciso = 19.99M;
            string texto = "Hola, Gente"; 
            char caracter = 'J'; 
            bool esVerdad = true; 

            // Concatenación de cadenas con variables
            Console.WriteLine("Número Entero: " + numeroEntero);
            Console.WriteLine("Número Grande: " + numeroGrande);
            Console.WriteLine("Número Flotante: " + numeroFlotante);
            Console.WriteLine("Número Decimal: " + numeroDecimal);
            Console.WriteLine("Número Decimal Preciso: " + numeroPreciso);
            Console.WriteLine("Texto: " + texto);
            Console.WriteLine("Caracter: " + caracter);
            Console.WriteLine("Booleano: " + esVerdad);

            // Variables nulas (Nullable) permiten que un tipo de valor tenga un valor nulo
            int? posibleNulo = null; 
            Console.WriteLine("Valor nullable: " + posibleNulo);

            // Conversión de tipos (Casting) 
            // De 'int' a 'long
            long numeroConvertido = numeroEntero;
            Console.WriteLine("Número convertido de int a long: " + numeroConvertido);

            // Conversión explícita (Casting): debes hacerla manualmente porque puede haber pérdida de datos
            // De 'double' a 'int' (pierde los decimales)
            int numeroCortado = (int)numeroDecimal;
            Console.WriteLine("Número convertido de double a int (sin decimales): " + numeroCortado);

            //Usando métodos de conversión
            // Convertir 'string' a 'int'
            string numeroTexto = "123";
            int numeroConvertidoDesdeTexto = Convert.ToInt32(numeroTexto);
            Console.WriteLine("Convertir string a int: " + numeroConvertidoDesdeTexto);

            // Convertir 'bool' a 'string'
            string booleanoTexto = esVerdad.ToString();
            Console.WriteLine("Convertir bool a string: " + booleanoTexto);

            // Convertir 'decimal' a 'double'
            double numeroConvertidoDecimal = Convert.ToDouble(numeroPreciso);
            Console.WriteLine("Convertir decimal a double: " + numeroConvertidoDecimal);
        }
    }
}
