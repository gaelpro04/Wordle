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

        private string[] bancoFacil = {"comer", "subir", "beber", " sacar", "decir", "mirar", "poner", "abrir", "tomar", "pagar"};
        private string[] bancoNormal = {"colina", "esfera", "rodaje", "luchar", "tomate", "granos", "grieta", "cerrar", "sender", "salida"};
        private string[] bancoDificil = { "ventana", "maestro", "zapatos", "archivo", "cuerpo", "empresa", "hombre", "letras", "relojes", "carrera" };
        private string palabraSeleccionada;
        private string palabraUsuario;
        private string dificultad;
        public Form2(string dificultadSeleccionada)
        {
            InitializeComponent();
            this.dificultad = dificultadSeleccionada;
            

            //Crear los cuadritos de forma automatica y dependiendo de la dificultad hacer mas o menos cuadritos

        }

        //Metodo para asignar la palabra seleccionada Random
        private void asignarPalabraDificultad()
        {
            int numeroRandomGenerado = generadorNumeroRandom();
            Console.WriteLine("Numero generado: " + numeroRandomGenerado);

            int numeroDificultad = verificarDificultad(dificultad);
            IntPtr[] bancoConversion;

            if (numeroDificultad == 1)
            {
                bancoConversion = StringArToIntPtrAr(bancoFacil);
                palabraSeleccionada = Marshal.PtrToStringAnsi(obtenerPalabra(bancoConversion, numeroRandomGenerado));

            } else if (numeroDificultad == 2) {

            } else if (numeroDificultad == 3) {

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

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {
            
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
