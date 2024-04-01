using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8Fichero.Servicios
{
    /// <summary>
    /// Clase que implementa a las interfaces de los menus
    /// irodhan -> 22/03/2024
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz        
    {
        public int mostrarMenuYSeleccion()
        {
            Console.WriteLine("|-------------------------|");
            Console.WriteLine("|          Menú           |");
            Console.WriteLine("|_________________________|");
            Console.WriteLine("| 0. Cerrar aplicacion    |");
            Console.WriteLine("| 1. Mostrar informacion  |");
            Console.WriteLine("| 2. Modificar linea      |");
            Console.WriteLine("| 3. Insertar texto       |");
            Console.WriteLine("|_________________________|");
            Console.WriteLine("Los nombres de los ficheros son: \n1. Fichero1\n2. Fichero2\n3. Fichero3");
            Console.WriteLine("\nIntroduzca la opcion deseada:");
            int opcion = Console.ReadKey(true).KeyChar - ('0');
            return opcion;
        }        
    }
 }
