using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wordle
{
    public partial class Form5 : Form
    {
        private string nombreUsuario = "";
        public Form5(String tiempo)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            label1.Text = "Has ganado!!.Tiempo: " + tiempo + "\n Deseas reiniciar el juego";
            button1.Enabled = false;
            button3.Enabled = false;
            button3.Click += button3_Click;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            button1.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0)
            {
                button3.Enabled = true;
                nombreUsuario = textBox1.Text;
            }
        }

        public string getNombreUsuario()
        {
            return nombreUsuario;
        }
    }
}
