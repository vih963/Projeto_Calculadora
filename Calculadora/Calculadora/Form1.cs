namespace Calculadora
{
    public partial class Form1 : Form
    {
        int valor1;
        int valor2;
        string operacao;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtvalor.Text += "1";

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtvalor.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtvalor.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtvalor.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtvalor.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtvalor.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtvalor.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtvalor.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtvalor.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtvalor.Text += "0";
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            //apaga tudo
            //txtvalor.Text += "";
            int tamanho = txtvalor.Text.Length;
            if (tamanho > 0)
            {
                string texto = txtvalor.Text.Remove(tamanho - 1);
                txtvalor.Text = texto;
            }
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            int numero;
            int.TryParse(txtvalor.Text, out numero);

            if (numero <= 0)
            {
                MessageBox.Show("Informe um numero valido");
            }
            else
            {
                valor1 = numero;
                txtvalor.Text = "";
                operacao = "+";
            }
        }
    }
}
