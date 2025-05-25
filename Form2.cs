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

    public partial class Form2 : Form
    {
        [DllImport("DllPro.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int generadorNumeroRandom();

        [DllImport("DllPro.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern int verificarDificultad(string dificultad);

        [DllImport("DllPro.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        //Se usa IntPtr porque directamente no se puede usar char** en Csharp por lo tanto string[] != char**
        //por eso mismo es necesario usar IntPtr que manualmente convierte cada String en puntero usando una funcion adicional
        public static extern IntPtr obtenerPalabra(IntPtr[] banco, int index);

        [DllImport("DllPro.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern int cantidadLetrasPalabra(string palabra);

        [DllImport("DllPro.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr verificarAmarillos(string palabra, int cantidadLetras);

        private string[] bancoFacil = {"comer", "subir", "beber", " sacar", "decir", "mirar", "poner", "abrir", "tomar", "pagar"};
        private string[] bancoNormal = {"colina", "esfera", "rodaje", "luchar", "tomate", "granos", "grieta", "cerrar", "sender", "salida"};
        private string[] bancoDificil = { "ventana", "maestro", "zapatos", "archivo", "cuerpo", "empresa", "hombre", "letras", "relojes", "carrera" };
        private string palabraSeleccionada;
        private string palabraUsuario;
        private int numeroDificultad;

        private List<Label[]> labelsLetras;
        public Form2(string dificultadSeleccionada)
        {
            InitializeComponent();
            string dificultad = dificultadSeleccionada;
            labelsLetras = new List<Label[]>();
            asignarPalabraDificultad(dificultad);
        }

        //Metodo para asignar la palabra seleccionada Random
        private void asignarPalabraDificultad(string dificultad)
        {
            int numeroRandomGenerado = generadorNumeroRandom();
            Console.WriteLine("Numero generado: " + numeroRandomGenerado);

            numeroDificultad = verificarDificultad(dificultad);
            IntPtr[] bancoConversion;

            if (numeroDificultad == 1)
            {
                bancoConversion = StringArToIntPtrAr(bancoFacil);

                //Construccion del juego relacionado con la palabra
                palabraSeleccionada = Marshal.PtrToStringAnsi(obtenerPalabra(bancoConversion, numeroRandomGenerado));
                int cantidadLetras = cantidadLetrasPalabra(palabraSeleccionada);

                Console.WriteLine(palabraSeleccionada);
                Console.WriteLine(cantidadLetras);

                generarLabels(numeroDificultad, cantidadLetras);

            } else if (numeroDificultad == 2) 
            {
                bancoConversion = StringArToIntPtrAr(bancoNormal);

                //Construccion del juego relacionado con la palabra
                palabraSeleccionada = Marshal.PtrToStringAnsi(obtenerPalabra(bancoConversion, numeroRandomGenerado));
                int cantidadLetras = cantidadLetrasPalabra(palabraSeleccionada);

                Console.WriteLine(palabraSeleccionada);
                Console.WriteLine(cantidadLetras);

                generarLabels(numeroDificultad, cantidadLetras);
            } else if (numeroDificultad == 3) 
            {
                bancoConversion = StringArToIntPtrAr(bancoDificil);

                //Construccion del juego relacionado con la palabra
                palabraSeleccionada = Marshal.PtrToStringAnsi(obtenerPalabra(bancoConversion, numeroRandomGenerado));
                int cantidadLetras = cantidadLetrasPalabra(palabraSeleccionada);

                Console.WriteLine(palabraSeleccionada);
                Console.WriteLine(cantidadLetras);

                generarLabels(numeroDificultad, cantidadLetras);
            } else { 
                //Aun no se
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Funcion que genera dinamicamente los labels dependiendo de la dificultad
        private void generarLabels(int dificultad, int cantidadLetras)
        {
            int posicionBaseX = 0;
            int posicionBaseY = 0;
            int distanciaX = 0;
            int distanciaY = 0;

            if (dificultad == 1)
            {
                posicionBaseX = 145;
                posicionBaseY = 80;
                distanciaX = 63;
                distanciaY = 63;
                
                
            } else if (dificultad == 2)
            {
                posicionBaseX = 120;
                posicionBaseY = 80;
                distanciaX = 63;
                distanciaY = 63;

            } else if (dificultad == 3) 
            {
                posicionBaseX = 90;
                posicionBaseY = 80;
                distanciaX = 63;
                distanciaY = 63;

            }

            for (int j = 0; j < 6; ++j)
            {
                Label[] labelsFila = new Label[cantidadLetras];
                for (int i = 0; i < cantidadLetras; ++i)
                {
                    Label label = new Label();
                    label.Name = "labeLetra" + i;
                    label.Text = " ";
                    label.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                    label.Size = new Size(57, 57);
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.BorderStyle = BorderStyle.FixedSingle;
                    label.BackColor = Color.LightGray;
                    label.Location = new Point(posicionBaseX + distanciaX * i, posicionBaseY + distanciaY * j);

                    this.Controls.Add(label);
                    labelsFila[i] = label;
                }
                labelsLetras.Add(labelsFila);
            }
        }

        private IntPtr[] StringArToIntPtrAr(String[] banco)
        {
            IntPtr[] bancoPtr = new IntPtr[banco.Length];

            for (int i = 0; i < banco.Length; ++i)
            {
                bancoPtr[i] = Marshal.StringToHGlobalAnsi(banco[i]);
            }

            return bancoPtr;
        }
    }
}
