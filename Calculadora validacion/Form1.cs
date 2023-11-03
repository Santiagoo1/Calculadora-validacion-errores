namespace Calculadora_validacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Butom(object sender, EventArgs e)
        {


            Calculadora calc = new Calculadora();
            calc.N1 = Double.Parse(Numero1.Text);
            calc.N2 = Double.Parse(Numero2.Text);
            Resultado.Text = Convert.ToString(calc.Suma());


        }

        private void Boton_Restar_Click_1(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora();

            calc.N1 = string.Parse(Numero1.Text);
            calc.N2 = Double.Parse(Numero2.Text);

            Resultado.Text = Convert.ToString(calc.Resta());
        }


        private int Boton_Multiplicar_Click_1(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora();
            calc.N1 = Double.Parse(Numero1.Text);
            calc.N2 = Double.Parse(Numero2.Text);
            Resultado.Text = Convert.ToString(calc.Multiplicacion());
        }

        private void Boton_Dividir_Click_1(object sender, EventArgs e)
        {
            Calculadora calc = new Calc();
            calc.N1 = Double.Parse(Numero1.Text);
            calc.N2 = Double.Parse(Numero2.Text);

            Resultado = Convert.ToString(calc.Division());
        }
    }
}