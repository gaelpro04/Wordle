namespace Wordle
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

     
        /// <param name="disposing"
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Historic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LimeGreen;
            label1.Location = new Point(235, 45);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(232, 81);
            label1.TabIndex = 0;
            label1.Text = "Wordle";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuBar;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.CausesValidation = false;
            button1.Location = new Point(213, 196);
            button1.Name = "button1";
            button1.Size = new Size(254, 72);
            button1.TabIndex = 1;
            button1.Text = "Jugar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuBar;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.CausesValidation = false;
            button2.Location = new Point(213, 294);
            button2.Name = "button2";
            button2.Size = new Size(254, 72);
            button2.TabIndex = 2;
            button2.Text = "Puntuaciones";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(19F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(709, 609);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Font = new Font("Segoe UI Historic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(7);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
    }
}
