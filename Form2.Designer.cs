namespace Wordle
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        protected void inicializarLabels()
        {
            int filas = 6;
            int columnas = 5;
            labels = new Label[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Label lbl = new Label();
                    lbl.Width = 50;
                    lbl.Height = 50;
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    lbl.Font = new Font("Arial", 20, FontStyle.Bold);
                    lbl.BorderStyle = BorderStyle.FixedSingle;
                    lbl.BackColor = Color.White;
                    lbl.Location = new Point(10 + j * 55, 10 + i * 55); // Espaciado de 5 px

                    labels[i, j] = lbl;
                    this.Controls.Add(lbl);  // Agrega al formulario
                }
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            textBox1 = new TextBox();
            label32 = new Label();
            label33 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI Historic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LimeGreen;
            label2.Location = new Point(273, 10);
            label2.Margin = new Padding(8, 0, 8, 0);
            label2.Name = "label2";
            label2.Size = new Size(258, 89);
            label2.TabIndex = 1;
            label2.Text = "Wordle";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(208, 788);
            textBox1.MaximumSize = new Size(364, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(364, 30);
            textBox1.TabIndex = 31;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label32.Location = new Point(273, 735);
            label32.Name = "label32";
            label32.Size = new Size(230, 36);
            label32.TabIndex = 32;
            label32.Text = "Ingrese la palabra";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label33.Location = new Point(14, 10);
            label33.Name = "label33";
            label33.Size = new Size(181, 36);
            label33.TabIndex = 33;
            label33.Text = "Tiempo 12:00";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 843);
            Controls.Add(label33);
            Controls.Add(label32);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label[,] labels;
        private Label label2;
        private TextBox textBox1;
        private Label label32;
        private Label label33;
    }
}