using Microsoft.VisualBasic.ApplicationServices;
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
        [DllImport("DllPro.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int lineasDisponibles(int tamanioActual);

        private Panel panelPuntuaciones;
        private Label tituloPuntuaciones;
        private Button botonRegresar;
        public Form4()
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            botonRegresar = new Button();
            botonRegresar.Text = "Regresar";
            botonRegresar.Size = new Size(114, 33);
            botonRegresar.Location = new Point(284, 640);
            botonRegresar.Click += button1_Click;
            this.Controls.Add(botonRegresar);

            panelPuntuaciones = new Panel();
            panelPuntuaciones.AutoScroll = true;
            panelPuntuaciones.Size = new Size(716, 620);
            panelPuntuaciones.Location = new Point(10, 10);
            this.Controls.Add(panelPuntuaciones);

            tituloPuntuaciones = new Label();
            tituloPuntuaciones.Text = "Puntuaciones";
            tituloPuntuaciones.Font = new Font("Segoe UI", 26, FontStyle.Bold);
            tituloPuntuaciones.ForeColor = Color.LimeGreen;
            tituloPuntuaciones.TextAlign = ContentAlignment.MiddleCenter;
            tituloPuntuaciones.Size = new Size(369, 61);
            tituloPuntuaciones.Location = new Point(165, 38);
            panelPuntuaciones.Controls.Add(tituloPuntuaciones);
            
            InitializeComponent();
            agregarPuntuaciones();
        }

        private void agregarPuntuaciones()
        {
            //ruta gael
            //string ruta = "C:\\Users\\sgsg_\\source\\repos\\Wordle\\puntuaciones.txt";

            //ruta diego
            string ruta = "C:\\Users\\bombo\\OneDrive\\Desktop\\Arqui\\ProyectoFinal\\Wordle\\puntuaciones.txt";

            string[] actTamanio = File.ReadAllLines(ruta);
            int tamanioActual = int.Parse(actTamanio[0]);
            int verificador = lineasDisponibles(tamanioActual);
            if (verificador == 1)
            {
                int posicionBaseX = 100;
                int posicionBaseY = 90;
                int distanciaX = 172;
                int distanciaY = 50;
                int j = 0;

                for (int i = tamanioActual; i >= 1; i--)
                {
                    string[] linea = actTamanio[i].Split(",");
                    if (linea.Length < 3 || string.IsNullOrWhiteSpace(linea[0]))
                        continue;
                    Label label = new Label();
                    label.Name = "label" + i;
                    label.Text = linea[0];
                    label.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                    label.Size = new Size(166, 40);
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.BorderStyle = BorderStyle.FixedSingle;
                    label.BackColor = Color.LightGray;
                    label.Location = new Point(posicionBaseX, posicionBaseY + distanciaY * j);
                    panelPuntuaciones.Controls.Add(label);
                    j++;
                }
                j = 0;
                for (int i = tamanioActual; i >= 1; i--)
                {
                    string[] linea = actTamanio[i].Split(",");
                    if (linea.Length < 3 || string.IsNullOrWhiteSpace(linea[0]))
                        continue;
                    Label label = new Label();
                    label.Name = "label" + i;
                    if (int.Parse(linea[2]) > 9)
                    {
                        label.Text = linea[1] + ":" + linea[2];
                    }
                    else
                    {
                        label.Text = linea[1] + ":0" + linea[2];
                    }
                    label.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                    label.Size = new Size(166, 40);
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.BorderStyle = BorderStyle.FixedSingle;
                    label.BackColor = Color.LightGray;
                    label.Location = new Point(posicionBaseX + distanciaX, posicionBaseY + distanciaY * j);
                    panelPuntuaciones.Controls.Add(label);
                    j++;
                }
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            using (Form1 form1 = new Form1())
            {
                this.Hide();
                Form1 menu = new Form1();
                menu.Show();
            }
        }
    }
}
