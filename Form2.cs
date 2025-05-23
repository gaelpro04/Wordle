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
        private string[] bancoNormal = {"pedir", "medir", "nacer", "rogar", "venir", "soñar", "jugar", "andar", "tirar", "parir"};
        private string[] bancoDificil = { "pulir", "yacer", "ceñir", "tañer", "urdir", "ceder", "coser", "zumar", "toser", "teñir" };
        private string palabraSeleccionada;
        private string palabraUsuario;
        private string dificultad;
        public Form2(string dificultadSeleccionada)
        {
            InitializeComponent();
            this.dificultad = dificultadSeleccionada;
            Console.WriteLine(dificultad);

            int numeroDificultad = verificarDificultad(dificultad);
            Console.WriteLine(numeroDificultad);

            int numero = generadorNumeroRandom();
            Console.WriteLine(numero);

            IntPtr[] bancoPtr = new IntPtr[bancoFacil.Length];
            //for (int i = 0; i < bancoFacil.Length)

            //string palabraObtenida = Marshal.PtrToStringAnsi(obtenerPalabra(bancoNormal, numero));
            //Console.WriteLine(palabraObtenida);


        }

        private void asignarPalabraDificultad()
        {
            
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

        //private IntPtr[] StringArToIntPtrAr(String[] banco)
        //{
        //    IntPtr[] bancoPtr = new IntPtr[banco.Length];

        //    for (int i = 0; )
        //}
    }
}
