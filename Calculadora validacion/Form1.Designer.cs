namespace Calculadora_validacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Resultado = new TextBox();
            Numero1 = new TextBox();
            Numero2 = new TextBox();
            Boton_Dividir = new Button();
            Boton_Multiplicar = new Button();
            Boton_Restar = new Button();
            Boton_Sumar = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(169, 75);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 29;
            label3.Text = "Resultado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(247, 9);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 28;
            label2.Text = "Ingrese numero 2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 27;
            label1.Text = "Ingrese numero 1";
            // 
            // Resultado
            // 
            Resultado.Location = new Point(43, 103);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(304, 23);
            Resultado.TabIndex = 26;
            // 
            // Numero1
            // 
            Numero1.Location = new Point(43, 38);
            Numero1.Name = "Numero1";
            Numero1.Size = new Size(100, 23);
            Numero1.TabIndex = 24;
            // 
            // Numero2
            // 
            Numero2.Location = new Point(247, 38);
            Numero2.Name = "Numero2";
            Numero2.Size = new Size(100, 23);
            Numero2.TabIndex = 25;
            // 
            // Boton_Dividir
            // 
            Boton_Dividir.Location = new Point(301, 148);
            Boton_Dividir.Name = "Boton_Dividir";
            Boton_Dividir.Size = new Size(75, 23);
            Boton_Dividir.TabIndex = 23;
            Boton_Dividir.Text = "/";
            Boton_Dividir.UseVisualStyleBackColor = true;
            Boton_Dividir.Click += Boton_Dividir_Click_1;
            // 
            // Boton_Multiplicar
            // 
            Boton_Multiplicar.Location = new Point(209, 148);
            Boton_Multiplicar.Name = "Boton_Multiplicar";
            Boton_Multiplicar.Size = new Size(75, 23);
            Boton_Multiplicar.TabIndex = 22;
            Boton_Multiplicar.Text = "*";
            Boton_Multiplicar.UseVisualStyleBackColor = true;
            Boton_Multiplicar.Click += Boton_Multiplicar_Click_1;
            // 
            // Boton_Restar
            // 
            Boton_Restar.Location = new Point(116, 148);
            Boton_Restar.Name = "Boton_Restar";
            Boton_Restar.Size = new Size(75, 23);
            Boton_Restar.TabIndex = 21;
            Boton_Restar.Text = "-";
            Boton_Restar.UseVisualStyleBackColor = true;
            Boton_Restar.Click += Boton_Restar_Click_1;
            // 
            // Boton_Sumar
            // 
            Boton_Sumar.Location = new Point(18, 148);
            Boton_Sumar.Name = "Boton_Sumar";
            Boton_Sumar.Size = new Size(75, 23);
            Boton_Sumar.TabIndex = 20;
            Boton_Sumar.Text = "+";
            Boton_Sumar.UseVisualStyleBackColor = true;
            Boton_Sumar.Click += Boton_Sumar_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 177);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Resultado);
            Controls.Add(Numero1);
            Controls.Add(Numero2);
            Controls.Add(Boton_Dividir);
            Controls.Add(Boton_Multiplicar);
            Controls.Add(Boton_Restar);
            Controls.Add(Boton_Sumar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox Resultado;
        private TextBox Numero1;
        private TextBox Numero2;
        private Button Boton_Dividir;
        private Button Boton_Multiplicar;
        private Button Boton_Restar;
        private Button Boton_Sumar;
    }
}