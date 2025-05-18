using System.Runtime.InteropServices;

namespace Wordle
{
    internal static class Program
    {

        [DllImport("DllPro.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int suma(int a, int b);
        
        [DllImport("DllPro.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int resta(int a, int b);

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.


            int resultado = suma(4, 5);
            Console.WriteLine(resultado);

            resultado = resta(4, 5);
            Console.WriteLine(resultado);
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
        }
    }
}