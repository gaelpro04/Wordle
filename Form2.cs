using Microsoft.VisualBasic;
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

        [DllImport("DllPro.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern IntPtr verificarVerdes(string palabraU, string palabraAdivinar, int cantidadLetras);

        [DllImport("DllPro.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern IntPtr verificarAmarillos(string palabraU, string palabraAdivinar, int cantidadLetras);

        [DllImport("DllPro.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int verificarVictoria(IntPtr arregloVerdes, int cantidadLetras);

        [DllImport("DllPro.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int obtenerTiempo();

        [DllImport("DllPro.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int verificarDerrota(int intentos);

        [DllImport("DllPro.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int verificarTamanioArc(int tiempoActual);

        [DllImport("DllPro.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void ordenamientoPuntuaciones(IntPtr tiempos, IntPtr nombres, int n);

        [DllImport("DllPro.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int calculoTiempo(int tiempoInicio, int tiempoFinal);



        private string[] bancoFacil = { "comer", "subir", "beber", "sacar", "decir", "mirar", "poner", "abrir", "tomar", "pagar" };
        private string[] bancoNormal = { "colina", "esfera", "rodaje", "luchar", "tomate", "granos", "grieta", "cerrar", "sender", "salida" };
        private string[] bancoDificil = { "ventana", "maestro", "zapatos", "archivo", "cuerpos", "empresa", "hombres", "brindar", "relojes", "carrera" };
        private string palabraSeleccionada;
        private string palabraUsuario;
        private int numeroDificultad;
        private int fila;
        private int tiempoAbsoluto, tiempoInicio, tiempoMili;
        private int minutos;
        private string tiempo;
        private int intentos;
        private string[] nombres;
        private int[] tiempos;
        private GCHandle tiemposHandle;

        private List<Label[]> labelsLetras;
        public Form2(string dificultadSeleccionada)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            string dificultad = dificultadSeleccionada;
            labelsLetras = new List<Label[]>();


            //Asignar tamanio a los arreglos de los datos
            string ruta = "C:\\Users\\sgsg_\\source\\repos\\Wordle\\puntuaciones.txt";

            string[] actTamanio = File.ReadAllLines(ruta);
            int tamanioActual = int.Parse(actTamanio[0]);

            nombres = new string[tamanioActual+1];
            tiempos = new int[tamanioActual+1];
            intentos = 0;

            minutos = 0;
            tiempo = "0";
            tiempoInicio = obtenerTiempo();
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;
            timer1.Tick += tiempo_Tick;
            timer1.Start(); 

            asignarPalabraDificultad(dificultad);
            textBox1.KeyDown += TextBox1_KeyDown;
            fila = 0;
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

            }
            else if (numeroDificultad == 2)
            {
                bancoConversion = StringArToIntPtrAr(bancoNormal);

                //Construccion del juego relacionado con la palabra
                palabraSeleccionada = Marshal.PtrToStringAnsi(obtenerPalabra(bancoConversion, numeroRandomGenerado));
                int cantidadLetras = cantidadLetrasPalabra(palabraSeleccionada);

                Console.WriteLine(palabraSeleccionada);
                Console.WriteLine(cantidadLetras);

                generarLabels(numeroDificultad, cantidadLetras);
            }
            else if (numeroDificultad == 3)
            {
                bancoConversion = StringArToIntPtrAr(bancoDificil);

                //Construccion del juego relacionado con la palabra
                palabraSeleccionada = Marshal.PtrToStringAnsi(obtenerPalabra(bancoConversion, numeroRandomGenerado));
                int cantidadLetras = cantidadLetrasPalabra(palabraSeleccionada);

                Console.WriteLine(palabraSeleccionada);
                Console.WriteLine(cantidadLetras);

                generarLabels(numeroDificultad, cantidadLetras);
            }
            else
            {
                //Aun no se
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
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

            }
            else if (dificultad == 2)
            {
                posicionBaseX = 120;
                posicionBaseY = 80;
                distanciaX = 63;
                distanciaY = 63;

            }
            else if (dificultad == 3)
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

        //Metodo para ingresar la palabra del usuario
        //tambien verifica el tamaño de la cadena para que no se pase o le falte letras y agrega la palabra a los labels
        //se hace la verificacion de la posicion de la letras, si esta en su lugar es verde
        //si no amarilla y si no esta en la palabra no hace nada
        private void TextBox1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                palabraUsuario = textBox1.Text;
                int numLetrasPalabraUsuario = cantidadLetrasPalabra(palabraUsuario);
                int longitudEsperada = numeroDificultad + 4;

                if (numLetrasPalabraUsuario != longitudEsperada)
                {
                    MessageBox.Show($"La palabra debe tener {longitudEsperada} letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                e.SuppressKeyPress = true;
                textBox1.Text = "";

                char[] letrasPalabraUsuario = palabraUsuario.ToCharArray();
                int columna = 0;
                foreach (char i in letrasPalabraUsuario)
                {
                    labelsLetras[fila][columna].Text = i.ToString();
                    columna++;
                }
                fila++;

                IntPtr ptrVerdes = verificarVerdes(palabraUsuario, palabraSeleccionada, longitudEsperada);
                int[] verdes = new int[longitudEsperada];
                Marshal.Copy(ptrVerdes, verdes, 0, longitudEsperada);

                for (int i = 0; i < longitudEsperada; i++)
                {
                    if (verdes[i] == 1)
                    {
                        labelsLetras[fila - 1][i].BackColor = Color.Green;
                    }
                    Console.WriteLine($"Posición {i}: {verdes[i]}");
                }

                IntPtr ptrAmarillos = verificarAmarillos(palabraUsuario, palabraSeleccionada, longitudEsperada);
                int[] amarillos = new int[longitudEsperada];
                Marshal.Copy(ptrAmarillos, amarillos, 0, longitudEsperada);

                //pasar esto a esamblador
                for (int i = 0; i < longitudEsperada; i++)
                {
                    if (amarillos[i] == 1 && verdes[i] == 0)
                    {
                        char letraActual = letrasPalabraUsuario[i];
                        bool yaVerde = false;
                        for (int j = 0; j < longitudEsperada; j++)
                        {
                            if (letraActual == palabraSeleccionada[j] && verdes[j] == 1)
                            {
                                yaVerde = true;
                                break;
                            }
                        }
                        if (!yaVerde)
                        {
                            labelsLetras[fila - 1][i].BackColor = Color.Yellow;
                        }
                    }

                }
                ++intentos;

                Console.WriteLine($"Tiempo: {tiempoMili}");

                //Seccion para verificar victoria......
                int verificadorVictoria = verificarVictoria(ptrVerdes, longitudEsperada);
                int verificadorDerrota = verificarDerrota(intentos);
                if (verificadorVictoria == 1)
                {
                    textBox1.Enabled = false;

                    DialogResult resultado = 0;
                    timer1.Stop();
                    //resultado = MessageBox.Show($"Has ganado!!. Tiempo: {tiempo} \n Deseas reiniciar el juego?", "Victoria", MessageBoxButtons.YesNo);
                    Form5 form5 = new Form5(tiempoAbsoluto); 
                    resultado = form5.ShowDialog();
                    string nombreUsuario = form5.getNombreUsuario();

                    int nombreValida = cantidadLetrasPalabra(nombreUsuario);
                    int verificador = verificarTamanioArc(nombreValida);
                    if (verificador == 1)
                    {
                        lecturaArchivo(nombreUsuario, tiempoAbsoluto);
                    }
                    
                    

                    if (resultado == DialogResult.Yes)
                    {
                        this.Hide();

                        Form1 form1 = new Form1();
                        form1.FormClosed += (s, args) => this.Close();

                        form1.Show();
                    } else
                    {
                        this.Close();
                     
                    }
                } else if (verificadorDerrota == 1) 
                {
                    textBox1.Enabled = false;
                    DialogResult resultado = 0;
                    timer1.Stop();
                    resultado = MessageBox.Show("Has perdido, has agotado todos tus intentos \n Deseas reiniciar el juego?", "Derrota", MessageBoxButtons.YesNo);

                    if (resultado == DialogResult.Yes)
                    {
                        this.Hide();

                        Form1 form1 = new Form1();
                        form1.FormClosed += (s, args) => this.Close();

                        form1.Show();
                    }
                    else
                    {
                        this.Close();

                    }
                }
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

        private IntPtr intArToIntPtrAr(int[] banco)
        {
           tiemposHandle = GCHandle.Alloc(banco, GCHandleType.Pinned);

           return tiemposHandle.AddrOfPinnedObject();
        }

        private void LiberarStringArray(IntPtr arregloPtr, int cantidad)
        {
            // Liberar cada string individual
            for (int i = 0; i < cantidad; i++)
            {
                IntPtr ptr = Marshal.ReadIntPtr(arregloPtr, i * IntPtr.Size);
                if (ptr != IntPtr.Zero)
                {
                    Marshal.FreeHGlobal(ptr);
                }
            }

            // Liberar el array de punteros
            Marshal.FreeHGlobal(arregloPtr);
        }

        private IntPtr StringArrayToIntPtr(string[] arreglo)
        {
            int longitud = arreglo.Length;
            IntPtr[] punteros = new IntPtr[longitud];

            // Crear punteros para cada string
            for (int i = 0; i < longitud; i++)
            {
                punteros[i] = Marshal.StringToHGlobalAnsi(arreglo[i]);
            }

            // Crear array de punteros
            IntPtr arregloPtr = Marshal.AllocHGlobal(IntPtr.Size * longitud);
            for (int i = 0; i < longitud; i++)
            {
                Marshal.WriteIntPtr(arregloPtr, i * IntPtr.Size, punteros[i]);
            }

            return arregloPtr;
        }


        //Metodo para obtener el tiempo actual en string y en formato de tiempo
        private void tiempo_Tick(object sender, EventArgs e)
        {
            int tiempoFinal = obtenerTiempo();
            int tiempoSeg = calculoTiempo(tiempoInicio, tiempoFinal) / 1000;
            tiempoAbsoluto = tiempoSeg;

            if (tiempoSeg > 59)
            {
                ++minutos;
                tiempoSeg = 0;
                tiempoInicio = obtenerTiempo();

                label33.Text = tiempo;
            } else
            {
                label33.Text = tiempo;
            }

            if (minutos > 0)
            {
                if (tiempoSeg < 10)
                {
                    tiempo = minutos + ":0" + tiempoSeg + " min";
                } else
                {
                    tiempo = minutos + ":" + tiempoSeg + " min";
                }

                    
            } else
            {
                tiempo = tiempoSeg + " s";
            }

        }

        //Metodo encargado de la lectura y escritua de archivos puntuaciones
        //Ruta gael: C:\Users\sgsg_\source\repos\Wordle\puntuaciones.txt
        //Ruta Diego: 
        private void lecturaArchivo(string nombre, int tiempo)
        {
            string ruta = "C:\\Users\\sgsg_\\source\\repos\\Wordle\\puntuaciones.txt";
            string[] actTamanio = File.ReadAllLines(ruta);
            int tamanioActual = int.Parse(actTamanio[0]);
            tamanioActual++;
            actTamanio[0] = tamanioActual.ToString();
            File.WriteAllLines(ruta, actTamanio);

            int verificador = verificarTamanioArc(tamanioActual);
            if (verificador == 1)
            {
                int[] tiemposTemp = new int[tamanioActual];
                string[] nombresTemp = new string[tamanioActual];

                int contador = 0;
                for (int i = 1; i < actTamanio.Length; ++i)
                {
                    string[] lineas = actTamanio[i].Split(',');
                    if (lineas.Length == 2)
                    {
                        nombresTemp[contador] = lineas[0];
                        tiemposTemp[contador] = int.Parse(lineas[1].Trim()) * 1000;
                        ++contador;
                    }
                }

                nombresTemp[contador] = nombre;
                tiemposTemp[contador] = tiempo * 1000;

                Console.WriteLine("=== ANTES DEL ORDENAMIENTO ===");
                for (int i = 0; i < tamanioActual; i++)
                {
                    Console.WriteLine($"{nombresTemp[i]}, {tiemposTemp[i]}");
                }

                IntPtr tiemposPtr = intArToIntPtrAr(tiemposTemp);
                IntPtr nombresPtr = StringArrayToIntPtr(nombresTemp);

                ordenamientoPuntuaciones(tiemposPtr, nombresPtr, tamanioActual);

                int[] tiemposOrdenados = new int[tamanioActual];
                Marshal.Copy(tiemposPtr, tiemposOrdenados, 0, tamanioActual);

                string[] nombresOrdenados = new string[tamanioActual];
                for (int i = 0; i < tamanioActual; ++i)
                {
                    IntPtr actual = Marshal.ReadIntPtr(nombresPtr, i * IntPtr.Size);
                    nombresOrdenados[i] = Marshal.PtrToStringAnsi(actual);
                }

                Console.WriteLine("=== DESPUÉS DEL ORDENAMIENTO ===");
                for (int i = 0; i < tamanioActual; i++)
                {
                    Console.WriteLine($"{nombresOrdenados[i]}, {tiemposOrdenados[i]}");
                }

                LiberarStringArray(nombresPtr, tamanioActual);

                if (tiemposHandle.IsAllocated)
                {
                    tiemposHandle.Free();
                }

                string[] nuevaEscritura = new string[tamanioActual + 1];
                nuevaEscritura[0] = tamanioActual.ToString();

                int contadorArchivos = 1;
                for(int i = tamanioActual - 1;i >= 0; i--)
                {
                    nuevaEscritura[contadorArchivos] = nombresOrdenados[i] + "," + (tiemposOrdenados[i] / 1000);
                    ++contadorArchivos;
                }

                File.WriteAllLines(ruta, nuevaEscritura);

            }
            else
            {
                string nuevoDato = nombre + "," + tiempo;
                File.AppendAllText(ruta, nuevoDato + Environment.NewLine);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }
    }
}
