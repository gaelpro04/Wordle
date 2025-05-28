namespace Wordle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using(Form4 form4 = new Form4())
            {
                this.Hide();
                Form4 puntuacion = new Form4();
                puntuacion.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Form3 form3 = new Form3())
            {
                if (form3.ShowDialog() == DialogResult.OK)
                {
                    string dificultad = form3.dificultadSeleccionada;

                    this.Hide();
                    Form2 juego = new Form2(dificultad);
                    juego.Show();
                }
            }
                
        }
    }
}
