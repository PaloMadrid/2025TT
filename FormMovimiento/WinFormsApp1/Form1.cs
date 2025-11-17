namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int PASO = 15;
        public Form1()
        {
            InitializeComponent();

            //esto sirve para usar WASD de controles pero no las flechas del teclado
            this.KeyPreview = true;
            this.ActiveControl = null;


            //a estas no les encontre utilidad
            //btnArriba.TabStop = false;
            //btnAbajo.TabStop = false;
            //btnIzquierda.TabStop = false;
            //btnDerecha.TabStop = false;
        }

        private void MoverPersonaje(string direccion)
        {
            // Obtener la ubicación actual
            Point nuevaUbicacion = pbPersonaje.Location;

            switch (direccion)
            {
                case "Arriba":
                    nuevaUbicacion.Y -= PASO;
                    break;
                case "Abajo":
                    nuevaUbicacion.Y += PASO;
                    break;
                case "Izquierda":
                    nuevaUbicacion.X -= PASO;
                    break;
                case "Derecha":
                    nuevaUbicacion.X += PASO;
                    break;
            }

            // Opcional: Implementación de límites para que el personaje no salga del formulario

            // X (Horizontal)
            if (nuevaUbicacion.X < 0) nuevaUbicacion.X = 0;
            if (nuevaUbicacion.X + pbPersonaje.Width > this.ClientSize.Width)
                nuevaUbicacion.X = this.ClientSize.Width - pbPersonaje.Width;

            // Y (Vertical)
            if (nuevaUbicacion.Y < 0) nuevaUbicacion.Y = 0;
            if (nuevaUbicacion.Y + pbPersonaje.Height > this.ClientSize.Height)
                nuevaUbicacion.Y = this.ClientSize.Height - pbPersonaje.Height;

            // Aplicar la nueva ubicación
            pbPersonaje.Location = nuevaUbicacion;
        }

        private void btnArriba_Click(object sender, EventArgs e)
        {
            MoverPersonaje("Arriba");
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            MoverPersonaje("Derecha");
        }

        private void btnAbajo_Click(object sender, EventArgs e)
        {
            MoverPersonaje("Abajo");
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            MoverPersonaje("Izquierda");
        }


        //ProcessCmdKey es un metodo para interceptar y manejar mensajes de teclado antes de que lleguen a los controles individuales. debemos aplicar polimorfismo para darle otra funcion a las teclas de direccion
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Up:
                    MoverPersonaje("Arriba");
                    return true;
                case Keys.Down:
                    MoverPersonaje("Abajo");
                    return true;
                case Keys.Left:
                    MoverPersonaje("Izquierda");
                    return true;
                case Keys.Right:
                    MoverPersonaje("Derecha");
                    return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        //para que se cree este evento tenes que seleccionar el formulario e ir al panel de eventos. ahi haces doble clic en el de nombre KeyDown
        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:

                    MoverPersonaje("Arriba");
                    break;

                case Keys.S:
                    MoverPersonaje("Abajo");
                    //e.Handled = true;
                    break;

                case Keys.A:
                    MoverPersonaje("Izquierda");
                    //e.Handled = true;
                    break;

                case Keys.D:
                    MoverPersonaje("Derecha");
                    //e.Handled = true;
                    break;
            }
            e.Handled = true;
            e.SuppressKeyPress = true;
        }
    }
}
