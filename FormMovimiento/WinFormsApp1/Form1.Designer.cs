namespace WinFormsApp1
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
            btnArriba = new Button();
            btnIzquierda = new Button();
            btnDerecha = new Button();
            btnAbajo = new Button();
            pbPersonaje = new Label();
            SuspendLayout();
            // 
            // btnArriba
            // 
            btnArriba.Location = new Point(637, 301);
            btnArriba.Name = "btnArriba";
            btnArriba.Size = new Size(75, 23);
            btnArriba.TabIndex = 0;
            btnArriba.Text = "arriba";
            btnArriba.UseVisualStyleBackColor = true;
            btnArriba.Click += btnArriba_Click;
            // 
            // btnIzquierda
            // 
            btnIzquierda.Location = new Point(569, 347);
            btnIzquierda.Name = "btnIzquierda";
            btnIzquierda.Size = new Size(75, 23);
            btnIzquierda.TabIndex = 0;
            btnIzquierda.Text = "izquierda";
            btnIzquierda.UseVisualStyleBackColor = true;
            btnIzquierda.Click += btnIzquierda_Click;
            // 
            // btnDerecha
            // 
            btnDerecha.Location = new Point(701, 347);
            btnDerecha.Name = "btnDerecha";
            btnDerecha.Size = new Size(75, 23);
            btnDerecha.TabIndex = 0;
            btnDerecha.Text = "derecha";
            btnDerecha.UseVisualStyleBackColor = true;
            btnDerecha.Click += btnDerecha_Click;
            // 
            // btnAbajo
            // 
            btnAbajo.Location = new Point(637, 387);
            btnAbajo.Name = "btnAbajo";
            btnAbajo.Size = new Size(75, 23);
            btnAbajo.TabIndex = 0;
            btnAbajo.Text = "abajo";
            btnAbajo.UseVisualStyleBackColor = true;
            btnAbajo.Click += btnAbajo_Click;
            // 
            // pbPersonaje
            // 
            pbPersonaje.AutoSize = true;
            pbPersonaje.Location = new Point(57, 36);
            pbPersonaje.Name = "pbPersonaje";
            pbPersonaje.Size = new Size(58, 15);
            pbPersonaje.TabIndex = 1;
            pbPersonaje.Text = "personaje";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pbPersonaje);
            Controls.Add(btnAbajo);
            Controls.Add(btnDerecha);
            Controls.Add(btnIzquierda);
            Controls.Add(btnArriba);
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnArriba;
        private Button btnIzquierda;
        private Button btnDerecha;
        private Button btnAbajo;
        private Label pbPersonaje;
    }
}
