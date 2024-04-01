using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8Fichero.Servicios
{
    /// <summary>
    /// Interfaz de los menus de la aplicacion
    /// irodhan -> 01/04/2024 
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra y obtiene la opcion indicada por el usuario
        /// irodhan -> 01/014/2024
        /// </summary>
        /// <returns>Devuelve la opcion que desea utilizar el usuario</returns>
        public int mostrarMenuYSeleccion();
    }
}
