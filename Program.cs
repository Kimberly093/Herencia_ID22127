using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HERENCIA
{
    static class Program
    {
        /*clase principal o clase papá que guardara los metodos de lectura 
        de valores y almacenado de valores en variables*/
        //nombre de la clase
        class operacion
        {
            //declaracion de variables que usa la clase
            //tipo de acceso    tipo de dato    nombre de dato
            protected           int             valor1;
            protected           int             valor2;
            protected           int             resultado;

        }
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
