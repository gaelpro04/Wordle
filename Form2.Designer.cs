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
            labels = new List<Label[]>(6);

            for (int i = 0; i < 6; ++i) {
                labels.Add(new Label[6]);

                for (int j = 0; j < 5; ++j) {
                    labels[i][j] = new Label();
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            label28 = new Label();
            label29 = new Label();
            label30 = new Label();
            label31 = new Label();
            textBox1 = new TextBox();
            label32 = new Label();
            label33 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlLight;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(179, 104);
            label1.Name = "label1";
            label1.Size = new Size(60, 60);
            label1.TabIndex = 0;
            label1.Text = "L";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI Historic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LimeGreen;
            label2.Location = new Point(233, 9);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(232, 81);
            label2.TabIndex = 1;
            label2.Text = "Wordle";
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ControlLight;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(245, 104);
            label3.Name = "label3";
            label3.Size = new Size(60, 60);
            label3.TabIndex = 2;
            label3.Text = "L";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ControlLight;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(311, 104);
            label4.Name = "label4";
            label4.Size = new Size(60, 60);
            label4.TabIndex = 3;
            label4.Text = "L";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ControlLight;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(377, 104);
            label5.Name = "label5";
            label5.Size = new Size(60, 60);
            label5.TabIndex = 4;
            label5.Text = "L";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = SystemColors.ControlLight;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(443, 104);
            label6.Name = "label6";
            label6.Size = new Size(60, 60);
            label6.TabIndex = 5;
            label6.Text = "L";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.BackColor = SystemColors.ControlLight;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(443, 174);
            label7.Name = "label7";
            label7.Size = new Size(60, 60);
            label7.TabIndex = 10;
            label7.Text = "L";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.BackColor = SystemColors.ControlLight;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(377, 174);
            label8.Name = "label8";
            label8.Size = new Size(60, 60);
            label8.TabIndex = 9;
            label8.Text = "L";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.BackColor = SystemColors.ControlLight;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(311, 174);
            label9.Name = "label9";
            label9.Size = new Size(60, 60);
            label9.TabIndex = 8;
            label9.Text = "L";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.BackColor = SystemColors.ControlLight;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(245, 174);
            label10.Name = "label10";
            label10.Size = new Size(60, 60);
            label10.TabIndex = 7;
            label10.Text = "L";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.BackColor = SystemColors.ControlLight;
            label11.BorderStyle = BorderStyle.FixedSingle;
            label11.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(179, 174);
            label11.Name = "label11";
            label11.Size = new Size(60, 60);
            label11.TabIndex = 6;
            label11.Text = "L";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.BackColor = SystemColors.ControlLight;
            label12.BorderStyle = BorderStyle.FixedSingle;
            label12.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(443, 244);
            label12.Name = "label12";
            label12.Size = new Size(60, 60);
            label12.TabIndex = 15;
            label12.Text = "L";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.BackColor = SystemColors.ControlLight;
            label13.BorderStyle = BorderStyle.FixedSingle;
            label13.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(377, 244);
            label13.Name = "label13";
            label13.Size = new Size(60, 60);
            label13.TabIndex = 14;
            label13.Text = "L";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.BackColor = SystemColors.ControlLight;
            label14.BorderStyle = BorderStyle.FixedSingle;
            label14.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(311, 244);
            label14.Name = "label14";
            label14.Size = new Size(60, 60);
            label14.TabIndex = 13;
            label14.Text = "L";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.BackColor = SystemColors.ControlLight;
            label15.BorderStyle = BorderStyle.FixedSingle;
            label15.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(245, 244);
            label15.Name = "label15";
            label15.Size = new Size(60, 60);
            label15.TabIndex = 12;
            label15.Text = "L";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.BackColor = SystemColors.ControlLight;
            label16.BorderStyle = BorderStyle.FixedSingle;
            label16.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(179, 244);
            label16.Name = "label16";
            label16.Size = new Size(60, 60);
            label16.TabIndex = 11;
            label16.Text = "L";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.BackColor = SystemColors.ControlLight;
            label17.BorderStyle = BorderStyle.FixedSingle;
            label17.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(443, 315);
            label17.Name = "label17";
            label17.Size = new Size(60, 60);
            label17.TabIndex = 20;
            label17.Text = "L";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            label18.BackColor = SystemColors.ControlLight;
            label18.BorderStyle = BorderStyle.FixedSingle;
            label18.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(377, 315);
            label18.Name = "label18";
            label18.Size = new Size(60, 60);
            label18.TabIndex = 19;
            label18.Text = "L";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            label19.BackColor = SystemColors.ControlLight;
            label19.BorderStyle = BorderStyle.FixedSingle;
            label19.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.Location = new Point(311, 315);
            label19.Name = "label19";
            label19.Size = new Size(60, 60);
            label19.TabIndex = 18;
            label19.Text = "L";
            label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            label20.BackColor = SystemColors.ControlLight;
            label20.BorderStyle = BorderStyle.FixedSingle;
            label20.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.Location = new Point(245, 315);
            label20.Name = "label20";
            label20.Size = new Size(60, 60);
            label20.TabIndex = 17;
            label20.Text = "L";
            label20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            label21.BackColor = SystemColors.ControlLight;
            label21.BorderStyle = BorderStyle.FixedSingle;
            label21.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.Location = new Point(179, 315);
            label21.Name = "label21";
            label21.Size = new Size(60, 60);
            label21.TabIndex = 16;
            label21.Text = "L";
            label21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            label22.BackColor = SystemColors.ControlLight;
            label22.BorderStyle = BorderStyle.FixedSingle;
            label22.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.Location = new Point(443, 385);
            label22.Name = "label22";
            label22.Size = new Size(60, 60);
            label22.TabIndex = 25;
            label22.Text = "L";
            label22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            label23.BackColor = SystemColors.ControlLight;
            label23.BorderStyle = BorderStyle.FixedSingle;
            label23.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label23.Location = new Point(377, 385);
            label23.Name = "label23";
            label23.Size = new Size(60, 60);
            label23.TabIndex = 24;
            label23.Text = "L";
            label23.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            label24.BackColor = SystemColors.ControlLight;
            label24.BorderStyle = BorderStyle.FixedSingle;
            label24.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label24.Location = new Point(311, 385);
            label24.Name = "label24";
            label24.Size = new Size(60, 60);
            label24.TabIndex = 23;
            label24.Text = "L";
            label24.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            label25.BackColor = SystemColors.ControlLight;
            label25.BorderStyle = BorderStyle.FixedSingle;
            label25.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label25.Location = new Point(245, 385);
            label25.Name = "label25";
            label25.Size = new Size(60, 60);
            label25.TabIndex = 22;
            label25.Text = "L";
            label25.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            label26.BackColor = SystemColors.ControlLight;
            label26.BorderStyle = BorderStyle.FixedSingle;
            label26.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label26.Location = new Point(179, 385);
            label26.Name = "label26";
            label26.Size = new Size(60, 60);
            label26.TabIndex = 21;
            label26.Text = "L";
            label26.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            label27.BackColor = SystemColors.ControlLight;
            label27.BorderStyle = BorderStyle.FixedSingle;
            label27.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label27.Location = new Point(443, 456);
            label27.Name = "label27";
            label27.Size = new Size(60, 60);
            label27.TabIndex = 30;
            label27.Text = "L";
            label27.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            label28.BackColor = SystemColors.ControlLight;
            label28.BorderStyle = BorderStyle.FixedSingle;
            label28.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label28.Location = new Point(377, 456);
            label28.Name = "label28";
            label28.Size = new Size(60, 60);
            label28.TabIndex = 29;
            label28.Text = "L";
            label28.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            label29.BackColor = SystemColors.ControlLight;
            label29.BorderStyle = BorderStyle.FixedSingle;
            label29.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label29.Location = new Point(311, 456);
            label29.Name = "label29";
            label29.Size = new Size(60, 60);
            label29.TabIndex = 28;
            label29.Text = "L";
            label29.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            label30.BackColor = SystemColors.ControlLight;
            label30.BorderStyle = BorderStyle.FixedSingle;
            label30.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label30.Location = new Point(245, 456);
            label30.Name = "label30";
            label30.Size = new Size(60, 60);
            label30.TabIndex = 27;
            label30.Text = "L";
            label30.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            label31.BackColor = SystemColors.ControlLight;
            label31.BorderStyle = BorderStyle.FixedSingle;
            label31.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label31.Location = new Point(179, 456);
            label31.Name = "label31";
            label31.Size = new Size(60, 60);
            label31.TabIndex = 26;
            label31.Text = "L";
            label31.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(179, 570);
            textBox1.MaximumSize = new Size(324, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(324, 27);
            textBox1.TabIndex = 31;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label32.Location = new Point(245, 526);
            label32.Name = "label32";
            label32.Size = new Size(203, 31);
            label32.TabIndex = 32;
            label32.Text = "Ingrese la palabra";
            label32.Click += label32_Click;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(0, 0);
            label33.Name = "label33";
            label33.Size = new Size(58, 20);
            label33.TabIndex = 33;
            label33.Text = "label33";
            label33.Click += label33_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 609);
            Controls.Add(label33);
            Controls.Add(label32);
            Controls.Add(textBox1);
            Controls.Add(label27);
            Controls.Add(label28);
            Controls.Add(label29);
            Controls.Add(label30);
            Controls.Add(label31);
            Controls.Add(label22);
            Controls.Add(label23);
            Controls.Add(label24);
            Controls.Add(label25);
            Controls.Add(label26);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(label20);
            Controls.Add(label21);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private List<Label[]> labels;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label28;
        private Label label29;
        private Label label30;
        private Label label31;
        private TextBox textBox1;
        private Label label32;
        private Label label33;
    }
}