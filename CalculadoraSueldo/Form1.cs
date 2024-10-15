namespace CalculadoraSueldo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int horasTrabajadas = int.Parse(textBox1.Text);
                int costeHora = int.Parse(textBox2.Text);

                float salario = horasTrabajadas * costeHora;
                label4.Text = salario.ToString("C2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

    
