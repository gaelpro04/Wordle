using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wordle
{
    public partial class Form4 : Form
    {
        [DllImport("DllPro.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern IntPtr leerArchivo(string nombreArchivo);
        public Form4()
        {
            InitializeComponent();
            LeerPuntuaciones();
        }

        private void LeerPuntuaciones()
        {
            try
            {
                // Llamar a la función de ensamblador
                IntPtr ptr = leerArchivo("puntuaciones.txt");

                if (ptr != IntPtr.Zero)
                {
                    // Convertir el puntero a string
                    string contenidoArchivo = Marshal.PtrToStringAnsi(ptr);

                    // Mostrar el contenido completo del archivo
                    Console.WriteLine("Contenido del archivo puntuaciones.txt:");
                    Console.WriteLine(contenidoArchivo);

                    // También puedes mostrarlo en un MessageBox
                    MessageBox.Show(contenidoArchivo, "Puntuaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Procesar línea por línea si necesitas
                    ProcesarPuntuaciones(contenidoArchivo);

                }
                else
                {
                    MessageBox.Show("Error al leer el archivo puntuaciones.txt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProcesarPuntuaciones(string contenido)
        {
            string[] lineas = contenido.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("\nPuntuaciones procesadas:");
            foreach (string linea in lineas)
            {
                if (!string.IsNullOrWhiteSpace(linea))
                {
                    string[] datos = linea.Split(',');
                    if (datos.Length == 2)
                    {
                        string nombre = datos[0].Trim();
                        string puntuacion = datos[1].Trim();
                        Console.WriteLine($"Jugador: {nombre}, Puntuación: {puntuacion}");
                    }
                }
            }
        }

        private void agregarPuntuaciones()
        {
            //que lea de un archivo las puntuaciones
        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
