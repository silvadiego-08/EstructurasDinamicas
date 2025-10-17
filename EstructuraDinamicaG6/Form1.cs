namespace EstructuraDinamicaG6
{
    public partial class FrmPilaDS : Form
    {
        public FrmPilaDS()
        {
            InitializeComponent();
        }
        Stack<int> pila = new Stack<int>();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int edad = int.Parse(tbEdad.Text);
            pila.Push(edad);
            Mostrar();
        }
        private void Mostrar()
        {
            string msn = "";
            foreach (int edad in pila)
            {
                msn += edad + "|";
            }
            lblEdades.Text = msn;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (pila.Count > 0)
            {
                pila.Pop();
                Mostrar();
            }
            else
            {
                MessageBox.Show("La pila está vacía.");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (pila.Count > 0)
            {
                MessageBox.Show($"{pila.Peek()}");
            }
            else MessageBox.Show("La pila está vacía.");
        }
        private void ordenar()
        {
            Stack<int> pilaAux = new Stack<int>();
            while (pila.Count > 0)
            {
                int temp = pila.Pop();
                while (pilaAux.Count > 0 && pilaAux.Peek() > temp)
                {
                    pila.Push(pilaAux.Pop());
                }
                pilaAux.Push(temp);
            }
            pila = pilaAux;
        }
        

        private void btnMayor_Click(object sender, EventArgs e) // Ordenar
        {
            ordenar();
            Mostrar();

        }
    }
}
