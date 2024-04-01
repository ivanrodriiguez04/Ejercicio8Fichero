using Ejercicio8Fichero.Servicios;

namespace Ejercicio8Fichero.Controladores
{
    /// <summary>
    /// Clase principal de la aplicacion
    /// irodhan -> 22/03/2024
    /// </summary>
    class Program
    {
        //Atributos
        static string rutaFichero = "C:\\Users\\csi22-irodhan\\Desktop\\Programacion\\Ficheros\\";
        static int numeroLinea = 0;
        static int numeroPosicion = 0;
        static string nuevoTexto = "aaaaa";
        static string nombreFichero = "aaaaa";
        static string rutaFicheroCompleta = "aaaaa";

        /// <summary>
        /// Metodo principal de la aplicacion
        /// irodhan -> 01/04/2024
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                //Objetos
                MenuInterfaz mI = new MenuImplementacion();

                //Atributos
                int opcionSeleccionada = 0;
                bool cerrarMenu = false;

                //Bucle while
                while (!cerrarMenu)
                {
                    opcionSeleccionada = mI.mostrarMenuYSeleccion();
                    switch (opcionSeleccionada)
                    {
                        case 0:
                            Console.WriteLine("[INFO] -  Ha seleccionado la opcion 0");
                            Console.WriteLine("[INFO] -  La aplicacion va ha cerrarse");
                            cerrarMenu = true;
                            break;
                        case 1:
                            Console.WriteLine("[INFO] -  Ha seleccionado la opcion 1");
                            //Pedimos el nombre del fichero
                            Console.WriteLine("Introduzca el nombre del fichero que desea usar:");
                            nombreFichero = Console.ReadLine() + ".txt";
                            rutaFicheroCompleta = rutaFichero + nombreFichero;
                            //Comprobamos que el fichero exista
                            if (File.Exists(rutaFicheroCompleta))
                            {
                                //Mostramos la informacion del fichero
                                mostrarFichero();
                            }
                            else
                            {
                                Console.WriteLine("[INFO] - El fichero indicado no existe");
                            }
                            break;
                        case 2:
                            Console.WriteLine("[INFO] -  Ha seleccionado la opcion 2");
                            //Pedimos el nombre del fichero
                            Console.WriteLine("Introduzca el nombre del fichero que desea usar:");
                            nombreFichero = Console.ReadLine() + ".txt";
                            rutaFicheroCompleta = rutaFichero + nombreFichero;
                            //Comprobamos que el fichero exista
                            if (File.Exists(rutaFicheroCompleta))
                            {
                                //Modificamos la lista del fichero
                                modificarLinea();
                            }
                            else
                            {
                                Console.WriteLine("[INFO] - El fichero indicado no existe");
                            }
                            break;
                        case 3:
                            Console.WriteLine("[INFO] -  Ha seleccionado la opcion 3");
                            //Pedimos el nombre del fichero
                            Console.WriteLine("Introduzca el nombre del fichero que desea usar:");
                            nombreFichero = Console.ReadLine() + ".txt";
                            rutaFicheroCompleta = rutaFichero + nombreFichero;
                            //Comprobamos que el fichero exista
                            if (File.Exists(rutaFicheroCompleta))
                            {
                                //Insertamos informacion en el fichero
                                insertarLinea();
                            }
                            else
                            {
                                Console.WriteLine("[INFO] - El fichero indicado no existe");
                            }
                            break;
                        default:
                            Console.WriteLine("[INFO] -  La opcion seleccionada no coincide con ninguna opcion mostrada anteriormente");
                            break;
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error al leer o escribir en el archivo: " + e.Message);
            }

        }
        static void mostrarFichero()
        {
            string[] lineas = File.ReadAllLines(rutaFicheroCompleta);
            foreach (string linea in lineas)
            {
                Console.WriteLine(linea);
            }
        }

        /// <summary>
        /// Metodo que modifica la linea indicada por el usuario
        /// irodhan -> 22/03/2024
        /// </summary>
        static void modificarLinea()
        {
            //Pedimos al usuario en que linea desea escribir
            Console.WriteLine("En que linea deseas escribir: ");
            numeroLinea = Convert.ToInt32(Console.ReadLine());

            //Guardamos la informacion de la lista en un array
            string[] lineas = File.ReadAllLines(rutaFicheroCompleta);

            //Comprobamos que la linea  indicada este dentro del tamaño del array
            if (numeroLinea >= 1 && numeroLinea <= lineas.Length)
            {
                Console.WriteLine("Que desea escribir: ");
                nuevoTexto = Console.ReadLine();

                lineas[numeroLinea - 1] = nuevoTexto;

                File.WriteAllLines(rutaFicheroCompleta, lineas);
            }
            else
            {
                Console.WriteLine("La linea en la que desea escribir esta fuera de rango");
            }
        }

        /// <summary>
        /// Metodo que inserta nueva informacion en la linea y posicion indicada por el usuario
        /// irodhan -> 22/03/2024
        /// </summary>
        static void insertarLinea()
        {
            //Pedimos al usuario en que linea desea escribir
            Console.WriteLine("Indica la linea deseas escribir: ");
            numeroLinea = Convert.ToInt32(Console.ReadLine());

            //Guardamos la informacion de la lista en un array
            string[] lineas = File.ReadAllLines(rutaFicheroCompleta);

            //Comprobamos que la linea  indicada este dentro del tamaño del array
            if (numeroLinea >= 1 && numeroLinea < lineas.Length)
            {
                //Guardamos la linea indicada en un string
                string linea = lineas[numeroLinea - 1];

                //Pedimos al usuario la posicion de la linea donde desea escribir
                Console.WriteLine("Indica la posicion en la que desea añadir texto: ");
                numeroPosicion = Convert.ToInt32(Console.ReadLine());

                //Comprobamos que la posicion entre dentro del rango
                if (numeroPosicion >= 1 && numeroPosicion <= linea.Length)
                {
                    //Le pedimos al usuario lo que desea escribir en el fichero
                    Console.WriteLine("Que desea escribir: ");
                    nuevoTexto = Console.ReadLine();

                    //Añadimos le texto indicado a la posicion
                    string nuevaLinea = linea.Insert(numeroPosicion, nuevoTexto);

                    //Modificamos la linea con el texto nuevo incluido
                    lineas[numeroLinea - 1] = nuevaLinea;

                    //Sobreescribimos el archivo con la nueva informacion
                    File.WriteAllLines(rutaFicheroCompleta, lineas);

                }
                else
                {
                    Console.WriteLine("La posicion indicada esta fuera del rango de la linea");
                }
            }
            else
            {
                Console.WriteLine("La linea indicada no cioncide con el tamaño del fichero");
            }
        }
    }
}
