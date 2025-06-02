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
        public Form4()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            agregarPuntuaciones();
        }

        private void agregarPuntuaciones()
        {
            string ruta = "C:\\Users\\sgsg_\\source\\repos\\Wordle\\puntuaciones.txt";

            string[] actTamanio = File.ReadAllLines(ruta);
            int tamanioActual = int.Parse(actTamanio[0]);

            int verificador = lineasDisponibles(tamanioActual);
            if (verificador == 1)
            {
                int posicionBaseX = 100;
                int posicionBaseY = 90;
                int distanciaX = 172;
                int distanciaY = 50;

                for (int i = 1; i < actTamanio.Length; i++)
                {
                    string[] linea = actTamanio[i].Split(",");
                    Label label = new Label();
                    label.Name = "label" + i;
                    label.Text = linea[0];
                    label.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                    label.Size = new Size(166, 40);
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.BorderStyle = BorderStyle.FixedSingle;
                    label.BackColor = Color.LightGray;
                    label.Location = new Point(posicionBaseX, posicionBaseY + distanciaY * (i - 1));
                    this.Controls.Add(label);
                }

                for (int i = 1; i < actTamanio.Length; i++)
                {
                    string[] linea = actTamanio[i].Split(",");
                    Label label = new Label();
                    label.Name = "label" + i;
                    label.Text = linea[1];
                    label.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                    label.Size = new Size(166, 40);
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.BorderStyle = BorderStyle.FixedSingle;
                    label.BackColor = Color.LightGray;
                    label.Location = new Point(posicionBaseX + distanciaX, posicionBaseY + distanciaY * (i - 1));
                    this.Controls.Add(label);
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
